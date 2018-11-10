using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipcam_winforms
{
    public partial class customCameraSetup : Form
    {
        public customCameraSetup()
        {
            InitializeComponent();
        }

        public string myLocation = Application.StartupPath;

        private void helpbttn_Click(object sender, EventArgs e)
        {
            Form customCameraHelp = new customCameraHelp();
            customCameraHelp.Show();
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

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        private void savebttn_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog dlg = new SaveFileDialog())
            {
                dlg.Title = "Save Custom Camera File";
                dlg.Filter = "camera files | *.cdat";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    string newName = dlg.FileName;
                    File.WriteAllText(newName, Base64Encode(textBox1.Text + "," + textBox2.Text + "," + textBox3.Text));
                    label2.Text = "saved successfully.";
                }
            }
        }

        private void testbttn_Click(object sender, EventArgs e)
        {
            using (MyWebClient client = new MyWebClient())
            {
                try
                {
                    NetworkCredential c = new NetworkCredential(textBox2.Text, textBox3.Text);
                    client.Credentials = c;
                    byte[] gdata = client.DownloadData("http://" + textBox4.Text + "/" + textBox1.Text);
                    using (var ms = new MemoryStream(gdata))
                    {
                        Bitmap b = new Bitmap(ms);
                        pictureBox1.Image = b;
                    }
                }
                catch
                {

                }
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Text = textBox4.Text.Replace("http://", "");
        }

        private void customCameraSetup_Load(object sender, EventArgs e)
        {

        }
    }
}
