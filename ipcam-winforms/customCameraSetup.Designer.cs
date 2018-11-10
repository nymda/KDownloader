namespace ipcam_winforms
{
    partial class customCameraSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(customCameraSetup));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.pathlbl = new System.Windows.Forms.Label();
            this.userlbl = new System.Windows.Forms.Label();
            this.passlbl = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.testbttn = new System.Windows.Forms.Button();
            this.savebttn = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.testlbl = new System.Windows.Forms.Label();
            this.helpbttn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(85, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(85, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // pathlbl
            // 
            this.pathlbl.AutoSize = true;
            this.pathlbl.Location = new System.Drawing.Point(37, 9);
            this.pathlbl.Name = "pathlbl";
            this.pathlbl.Size = new System.Drawing.Size(42, 13);
            this.pathlbl.TabIndex = 3;
            this.pathlbl.Text = "PATH: ";
            // 
            // userlbl
            // 
            this.userlbl.AutoSize = true;
            this.userlbl.Location = new System.Drawing.Point(12, 37);
            this.userlbl.Name = "userlbl";
            this.userlbl.Size = new System.Drawing.Size(67, 13);
            this.userlbl.TabIndex = 4;
            this.userlbl.Text = "DEF. USER:";
            // 
            // passlbl
            // 
            this.passlbl.AutoSize = true;
            this.passlbl.Location = new System.Drawing.Point(12, 63);
            this.passlbl.Name = "passlbl";
            this.passlbl.Size = new System.Drawing.Size(65, 13);
            this.passlbl.TabIndex = 5;
            this.passlbl.Text = "DEF. PASS:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(302, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(354, 169);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // testbttn
            // 
            this.testbttn.Location = new System.Drawing.Point(581, 181);
            this.testbttn.Name = "testbttn";
            this.testbttn.Size = new System.Drawing.Size(75, 23);
            this.testbttn.TabIndex = 7;
            this.testbttn.Text = "TEST";
            this.testbttn.UseVisualStyleBackColor = true;
            this.testbttn.Click += new System.EventHandler(this.testbttn_Click);
            // 
            // savebttn
            // 
            this.savebttn.Location = new System.Drawing.Point(12, 86);
            this.savebttn.Name = "savebttn";
            this.savebttn.Size = new System.Drawing.Size(284, 23);
            this.savebttn.TabIndex = 8;
            this.savebttn.Text = "SAVE";
            this.savebttn.UseVisualStyleBackColor = true;
            this.savebttn.Click += new System.EventHandler(this.savebttn_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(445, 183);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(130, 20);
            this.textBox4.TabIndex = 9;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // testlbl
            // 
            this.testlbl.AutoSize = true;
            this.testlbl.Location = new System.Drawing.Point(388, 186);
            this.testlbl.Name = "testlbl";
            this.testlbl.Size = new System.Drawing.Size(51, 13);
            this.testlbl.TabIndex = 10;
            this.testlbl.Text = "TEST IP:";
            // 
            // helpbttn
            // 
            this.helpbttn.Location = new System.Drawing.Point(12, 113);
            this.helpbttn.Name = "helpbttn";
            this.helpbttn.Size = new System.Drawing.Size(24, 23);
            this.helpbttn.TabIndex = 11;
            this.helpbttn.Text = "?";
            this.helpbttn.UseVisualStyleBackColor = true;
            this.helpbttn.Click += new System.EventHandler(this.helpbttn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 14;
            // 
            // customCameraSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 212);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.helpbttn);
            this.Controls.Add(this.testlbl);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.savebttn);
            this.Controls.Add(this.testbttn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.passlbl);
            this.Controls.Add(this.userlbl);
            this.Controls.Add(this.pathlbl);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "customCameraSetup";
            this.Text = "Custom camera setup";
            this.Load += new System.EventHandler(this.customCameraSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label pathlbl;
        private System.Windows.Forms.Label userlbl;
        private System.Windows.Forms.Label passlbl;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button testbttn;
        private System.Windows.Forms.Button savebttn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label testlbl;
        private System.Windows.Forms.Button helpbttn;
        private System.Windows.Forms.Label label2;
    }
}