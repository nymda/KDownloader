using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ipcam_winforms
{
    public partial class messageBox : Form
    {
        public string title;
        public string text;

        public messageBox(string ti, string te)
        {
            InitializeComponent();
            title = ti;
            text = te;
        }

        private void messageBox_Load(object sender, EventArgs e)
        {
            label1.Text = text;
            this.Text = title;
        }
    }
}
