using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipcam_winforms
{
    public partial class INT_BROWSER : Form
    {
        public string IP;
        public Uri uri;
        public string user;
        public string pass;

        public INT_BROWSER(string ip1, string[] creds)
        {
            InitializeComponent();
            user = creds[0];
            pass = creds[1];
            IP = ip1;

        }

        public static Uri addCredsToUri(Uri u, string user, string pass)
        {
            UriBuilder uriSite = new UriBuilder(u);
            uriSite.UserName = user;
            uriSite.Password = pass;
            return uriSite.Uri;
        }

        private void INT_BROWSER_Load(object sender, EventArgs e)
        {
            IP = IP.Replace(" ", "");
            this.Text = "Internal browser | " + IP;
            uri = new Uri("http://" + IP);

            if(IP != "")
            {
                uri = addCredsToUri(uri, user, pass);
                webBrowser1.Navigate(uri);
            }
        }
    }
}
