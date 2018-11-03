using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipcam_winforms
{
    public partial class JPG_REQUEST_FOSCAM : Form
    {
        public string ip;
        public string user;
        public string pass;
        public string location;
        public int fps;

        public class MyWebClient : WebClient
        {
            protected override WebRequest GetWebRequest(Uri address)
            {
                var req = base.GetWebRequest(address);
                req.Timeout = 5000;
                return req;
            }
        }

        public Uri Uribuilder(string function)
        {
            Console.WriteLine("uri builder started");

            //UP = 0
            //UP STOP = 1
            //DOWN = 2
            //DOWN STOP = 3
            //LEFT = 4
            //LEFT STOP = 5
            //RIGHT = 6
            //RIGHT STOP = 7

            Uri deaduri = new Uri("http://knedit.pw");

            if(function == "up")
            {
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=0");
                return uri;
            }
            if (function == "down")
            {
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=2");
                return uri;
            }
            if (function == "left")
            {
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=4");
                return uri;
            }
            if (function == "right")
            {
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=6");
                return uri;
            }

            return deaduri;
        }

        public Uri StopUribuilder(string function)
        {
            Console.WriteLine("stop uri builder started");
            Console.WriteLine("func: " + function);

            //UP = 0
            //UP STOP = 1
            //DOWN = 2
            //DOWN STOP = 3
            //LEFT = 4
            //LEFT STOP = 5
            //RIGHT = 6
            //RIGHT STOP = 7

            Uri deaduri = new Uri("http://knedit.pw");

            if (function == "up")
            {
                Console.WriteLine("up");
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=1");
                return uri;
            }
            if (function == "down")
            {
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=3");
                return uri;
            }
            if (function == "left")
            {
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=5");
                return uri;
            }
            if (function == "right")
            {
                Uri uri = new Uri("http://" + ip + "/decoder_control.cgi?user=" + user + "&pwd=" + pass + "&command=7");
                return uri;
            }

            return deaduri;
        }

        public void NewThread()
        {
            using (MyWebClient client = new MyWebClient())
            {
                try
                {
                    client.Credentials = new NetworkCredential(user, pass);
                    for (; ; )
                    {
                        byte[] imageBytes = client.DownloadData((new Uri("http://" + ip + "/snapshot.cgi")));
                        Bitmap bmp;
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            bmp = new Bitmap(ms);

                            try
                            {
                                this.Invoke(new MethodInvoker(delegate ()
                                {
                                    pictureBox1.Image = bmp;
                                    fps++;
                                }));
                            }
                            catch
                            {

                            }
                        }
                        //Thread.Sleep(10);
                    }
                }
                catch
                {

                }
            }
        }

        public void MoveThread(string func)
        {
            using (MyWebClient client = new MyWebClient())
            {
                try
                {
                    Console.WriteLine("movethread started");
                    client.Credentials = new NetworkCredential(user, pass);
                    client.DownloadData(Uribuilder(func));
                    Console.WriteLine(Uribuilder(func));
                    Thread.Sleep(200);
                    client.DownloadData(StopUribuilder(func));
                    Console.WriteLine(StopUribuilder(func));
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                }

            }
        }

        public JPG_REQUEST_FOSCAM(string ip1, string u1, string p1, string l1)
        {
            InitializeComponent();
            ip = ip1;
            user = "admin";
            pass = "";
            location = l1;
        }

        private void JPG_REQUEST_FOSCAM_Load(object sender, EventArgs e)
        {
            Thread a = new Thread(() => NewThread());
            a.IsBackground = true;
            a.Start();
            timer1.Start();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Thread up = new Thread(() => MoveThread("up"));
            up.IsBackground = true;
            up.Start();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Thread up = new Thread(() => MoveThread("left"));
            up.IsBackground = true;
            up.Start();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Thread up = new Thread(() => MoveThread("right"));
            up.IsBackground = true;
            up.Start();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Thread up = new Thread(() => MoveThread("down"));
            up.IsBackground = true;
            up.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label1.Text = "FPS: " + fps;
            fps = 0;
        }
    }
}
