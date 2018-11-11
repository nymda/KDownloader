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
    public partial class JPG_REQUEST_NOPTZ : Form
    {
        public string ip;
        public string user;
        public string pass;
        public string location;
        public int fps;

        public JPG_REQUEST_NOPTZ(string ip1, string u1, string p1, string l1)
        {
            InitializeComponent();
            ip = ip1;
            user = u1;
            pass = p1;
            location = l1;
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

        public void NewThread()
        {
            using (MyWebClient client = new MyWebClient())
            {
                try
                {
                    client.Credentials = new NetworkCredential(user, pass);
                    for (; ; )
                    {
                        byte[] imageBytes = client.DownloadData((new Uri("http://" + ip + location)));
                        Console.WriteLine("http://" + ip + location);
                        Console.WriteLine(imageBytes.Length);
                        Bitmap bmp;
                        using (var ms = new MemoryStream(imageBytes))
                        {
                            bmp = new Bitmap(ms);

                            try
                            {
                                this.Invoke(new MethodInvoker(delegate ()
                                {
                                    Console.WriteLine("invoked");
                                    pbox.Image = new Bitmap(bmp);
                                    fps++;
                                }));
                            }
                            catch
                            {
                                this.Close();
                            }
                        }
                    }
                }
                catch
                {

                }
            }
        }

        private void JPG_REQUEST_NOPTZ_Load(object sender, EventArgs e)
        {
            Thread a = new Thread(() => NewThread());
            a.IsBackground = true;
            a.Start();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "FPS: " + fps;
            fps = 0;
        }
    }
}
