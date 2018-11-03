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
    public partial class JPG_REQUEST : Form
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
                    }
                }
                catch
                {

                }
            }
        }

        public void MoveThread(Uri uri)
        {
            using (MyWebClient client = new MyWebClient())
            {
                try
                {
                    client.Credentials = new NetworkCredential(user, pass);
                    client.DownloadData(uri);
                }
                catch
                {

                }

            }
        }

        public JPG_REQUEST(string ip1, string u1, string p1, string l1)
        {
            InitializeComponent();
            ip = ip1;
            user = u1;
            pass = p1;
            location = l1;
        }

        private void JPG_REQUEST_Load(object sender, EventArgs e)
        {
            Thread a = new Thread(() => NewThread());
            a.IsBackground = true;
            a.Start();
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {//up
            Thread up = new Thread(() => MoveThread(new Uri("http://" + ip + "/cgi-bin/hi3510/ytup.cgi")));
            up.IsBackground = true;
            up.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {//left
            Thread up = new Thread(() => MoveThread(new Uri("http://" + ip + "/cgi-bin/hi3510/ytleft.cgi")));
            up.IsBackground = true;
            up.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {//right
            Thread up = new Thread(() => MoveThread(new Uri("http://" + ip + "/cgi-bin/hi3510/ytright.cgi")));
            up.IsBackground = true;
            up.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {//down
            Thread up = new Thread(() => MoveThread(new Uri("http://" + ip + "/cgi-bin/hi3510/ytdown.cgi")));
            up.IsBackground = true;
            up.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = "FPS: " + fps;
            fps = 0;
        }
    }
}
