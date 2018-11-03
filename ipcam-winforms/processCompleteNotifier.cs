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
    public partial class processCompleteNotifier : Form
    {

        public string timestr;
        public string fileloc;
        public bool discardWorkingOutput;

        public processCompleteNotifier(string time, string wipfile, bool discard)
        {
            InitializeComponent();
            timestr = time;
            fileloc = wipfile;
            discardWorkingOutput = discard;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            label1.Text = "processing complete\ntime elapsed: " + timestr;
            if (discardWorkingOutput)
            {
                button1.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(fileloc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
