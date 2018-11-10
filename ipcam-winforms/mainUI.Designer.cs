namespace ipcam_winforms
{
    partial class mainUI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainUI));
            this.inputBttn = new System.Windows.Forms.Button();
            this.outputBttn = new System.Windows.Forms.Button();
            this.startBttn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.aboutBttn = new System.Windows.Forms.Button();
            this.foscamRadioBttn = new System.Windows.Forms.RadioButton();
            this.aztechRadioBttn = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.folderBttn = new System.Windows.Forms.Button();
            this.randomIpOrdCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.threadSelector = new System.Windows.Forms.DomainUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.updatelbl = new System.Windows.Forms.Label();
            this.updatebttn = new System.Windows.Forms.Button();
            this.discardOutputCheck = new System.Windows.Forms.CheckBox();
            this.defewayRadioBttn = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.customRadioBttn = new System.Windows.Forms.RadioButton();
            this.loadCustomBttn = new System.Windows.Forms.Button();
            this.createCustomBttn = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // inputBttn
            // 
            this.inputBttn.Location = new System.Drawing.Point(39, 34);
            this.inputBttn.Name = "inputBttn";
            this.inputBttn.Size = new System.Drawing.Size(75, 23);
            this.inputBttn.TabIndex = 0;
            this.inputBttn.Text = "INPUT";
            this.inputBttn.UseVisualStyleBackColor = true;
            this.inputBttn.Click += new System.EventHandler(this.button1_Click);
            // 
            // outputBttn
            // 
            this.outputBttn.Location = new System.Drawing.Point(39, 63);
            this.outputBttn.Name = "outputBttn";
            this.outputBttn.Size = new System.Drawing.Size(75, 23);
            this.outputBttn.TabIndex = 1;
            this.outputBttn.Text = "OUTPUT";
            this.outputBttn.UseVisualStyleBackColor = true;
            this.outputBttn.Click += new System.EventHandler(this.button2_Click);
            // 
            // startBttn
            // 
            this.startBttn.Location = new System.Drawing.Point(38, 319);
            this.startBttn.Name = "startBttn";
            this.startBttn.Size = new System.Drawing.Size(177, 23);
            this.startBttn.TabIndex = 3;
            this.startBttn.Text = "START";
            this.startBttn.UseVisualStyleBackColor = true;
            this.startBttn.Click += new System.EventHandler(this.button3_Click);
            // 
            // aboutBttn
            // 
            this.aboutBttn.Location = new System.Drawing.Point(38, 348);
            this.aboutBttn.Name = "aboutBttn";
            this.aboutBttn.Size = new System.Drawing.Size(177, 23);
            this.aboutBttn.TabIndex = 14;
            this.aboutBttn.Text = "ABOUT";
            this.aboutBttn.UseVisualStyleBackColor = true;
            this.aboutBttn.Click += new System.EventHandler(this.button4_Click);
            // 
            // foscamRadioBttn
            // 
            this.foscamRadioBttn.AutoSize = true;
            this.foscamRadioBttn.Location = new System.Drawing.Point(39, 223);
            this.foscamRadioBttn.Name = "foscamRadioBttn";
            this.foscamRadioBttn.Size = new System.Drawing.Size(105, 17);
            this.foscamRadioBttn.TabIndex = 15;
            this.foscamRadioBttn.Text = "Foscam / Clones";
            this.foscamRadioBttn.UseVisualStyleBackColor = true;
            // 
            // aztechRadioBttn
            // 
            this.aztechRadioBttn.AutoSize = true;
            this.aztechRadioBttn.Checked = true;
            this.aztechRadioBttn.Location = new System.Drawing.Point(39, 200);
            this.aztechRadioBttn.Name = "aztechRadioBttn";
            this.aztechRadioBttn.Size = new System.Drawing.Size(100, 17);
            this.aztechRadioBttn.TabIndex = 16;
            this.aztechRadioBttn.TabStop = true;
            this.aztechRadioBttn.Text = "Aztech / Sineoji";
            this.aztechRadioBttn.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // folderBttn
            // 
            this.folderBttn.Location = new System.Drawing.Point(39, 92);
            this.folderBttn.Name = "folderBttn";
            this.folderBttn.Size = new System.Drawing.Size(75, 23);
            this.folderBttn.TabIndex = 18;
            this.folderBttn.Text = "FOLDER";
            this.folderBttn.UseVisualStyleBackColor = true;
            this.folderBttn.Click += new System.EventHandler(this.button5_Click);
            // 
            // randomIpOrdCheckbox
            // 
            this.randomIpOrdCheckbox.AutoSize = true;
            this.randomIpOrdCheckbox.Location = new System.Drawing.Point(39, 121);
            this.randomIpOrdCheckbox.Name = "randomIpOrdCheckbox";
            this.randomIpOrdCheckbox.Size = new System.Drawing.Size(114, 17);
            this.randomIpOrdCheckbox.TabIndex = 23;
            this.randomIpOrdCheckbox.Text = "randomise IP order";
            this.randomIpOrdCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Threads:";
            // 
            // threadSelector
            // 
            this.threadSelector.Items.Add("4");
            this.threadSelector.Items.Add("2");
            this.threadSelector.Items.Add("1");
            this.threadSelector.Location = new System.Drawing.Point(93, 293);
            this.threadSelector.Name = "threadSelector";
            this.threadSelector.Size = new System.Drawing.Size(42, 20);
            this.threadSelector.TabIndex = 24;
            this.threadSelector.Text = "4";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(35, 399);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "SELECT OUTPUT";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(39, 144);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(104, 50);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "file info";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "users: 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "IPs: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(35, 375);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 29;
            this.label8.Text = "SELECT INPUT";
            // 
            // timer2
            // 
            this.timer2.Interval = 1;
            // 
            // tabs
            // 
            this.tabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabs.Controls.Add(this.tabPage1);
            this.tabs.Controls.Add(this.tabPage2);
            this.tabs.Location = new System.Drawing.Point(3, 3);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(1430, 633);
            this.tabs.TabIndex = 32;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.createCustomBttn);
            this.tabPage1.Controls.Add(this.loadCustomBttn);
            this.tabPage1.Controls.Add(this.customRadioBttn);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.discardOutputCheck);
            this.tabPage1.Controls.Add(this.defewayRadioBttn);
            this.tabPage1.Controls.Add(this.inputBttn);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.startBttn);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.aboutBttn);
            this.tabPage1.Controls.Add(this.outputBttn);
            this.tabPage1.Controls.Add(this.threadSelector);
            this.tabPage1.Controls.Add(this.foscamRadioBttn);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.folderBttn);
            this.tabPage1.Controls.Add(this.aztechRadioBttn);
            this.tabPage1.Controls.Add(this.randomIpOrdCheckbox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1422, 607);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "settings";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.updatelbl);
            this.groupBox1.Controls.Add(this.updatebttn);
            this.groupBox1.Location = new System.Drawing.Point(38, 377);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(133, 72);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "update";
            // 
            // updatelbl
            // 
            this.updatelbl.AutoSize = true;
            this.updatelbl.Location = new System.Drawing.Point(12, 22);
            this.updatelbl.Name = "updatelbl";
            this.updatelbl.Size = new System.Drawing.Size(100, 13);
            this.updatelbl.TabIndex = 35;
            this.updatelbl.Text = "no update available";
            // 
            // updatebttn
            // 
            this.updatebttn.Enabled = false;
            this.updatebttn.Location = new System.Drawing.Point(6, 38);
            this.updatebttn.Name = "updatebttn";
            this.updatebttn.Size = new System.Drawing.Size(118, 23);
            this.updatebttn.TabIndex = 34;
            this.updatebttn.Text = "download";
            this.updatebttn.UseVisualStyleBackColor = true;
            this.updatebttn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // discardOutputCheck
            // 
            this.discardOutputCheck.AutoSize = true;
            this.discardOutputCheck.Location = new System.Drawing.Point(120, 67);
            this.discardOutputCheck.Name = "discardOutputCheck";
            this.discardOutputCheck.Size = new System.Drawing.Size(95, 17);
            this.discardOutputCheck.TabIndex = 33;
            this.discardOutputCheck.Text = "Discard output";
            this.discardOutputCheck.UseVisualStyleBackColor = true;
            this.discardOutputCheck.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // defewayRadioBttn
            // 
            this.defewayRadioBttn.AutoSize = true;
            this.defewayRadioBttn.Location = new System.Drawing.Point(39, 246);
            this.defewayRadioBttn.Name = "defewayRadioBttn";
            this.defewayRadioBttn.Size = new System.Drawing.Size(96, 17);
            this.defewayRadioBttn.TabIndex = 31;
            this.defewayRadioBttn.TabStop = true;
            this.defewayRadioBttn.Text = "defeway DVRs";
            this.defewayRadioBttn.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Controls.Add(this.pictureBox6);
            this.tabPage2.Controls.Add(this.pictureBox5);
            this.tabPage2.Controls.Add(this.pictureBox1);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.pictureBox4);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Controls.Add(this.listBox1);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.pictureBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1422, 607);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "view";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(1054, 581);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(178, 19);
            this.button8.TabIndex = 44;
            this.button8.Text = "JPG control";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox6.Location = new System.Drawing.Point(1238, 466);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(178, 109);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 43;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox5.Location = new System.Drawing.Point(1238, 351);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(178, 109);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 42;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(195, 6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1037, 570);
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(192, 582);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "IP: RESPONSE: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tested: ";
            // 
            // button6
            // 
            this.button6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(1238, 581);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(178, 19);
            this.button6.TabIndex = 37;
            this.button6.Text = "PAUSE";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click_1);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 582);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Elapsed: ";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Location = new System.Drawing.Point(1238, 236);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(178, 109);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 36;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Location = new System.Drawing.Point(1238, 6);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(178, 109);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // listBox1
            // 
            this.listBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.IntegralHeight = false;
            this.listBox1.Location = new System.Drawing.Point(9, 37);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(180, 539);
            this.listBox1.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 39;
            this.label1.Text = "Working IPs:";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Location = new System.Drawing.Point(1238, 121);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(178, 109);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 35;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // customRadioBttn
            // 
            this.customRadioBttn.AutoSize = true;
            this.customRadioBttn.Location = new System.Drawing.Point(39, 269);
            this.customRadioBttn.Name = "customRadioBttn";
            this.customRadioBttn.Size = new System.Drawing.Size(59, 17);
            this.customRadioBttn.TabIndex = 34;
            this.customRadioBttn.TabStop = true;
            this.customRadioBttn.Text = "custom";
            this.customRadioBttn.UseVisualStyleBackColor = true;
            this.customRadioBttn.CheckedChanged += new System.EventHandler(this.customRadioBttn_CheckedChanged);
            // 
            // loadCustomBttn
            // 
            this.loadCustomBttn.Location = new System.Drawing.Point(101, 266);
            this.loadCustomBttn.Name = "loadCustomBttn";
            this.loadCustomBttn.Size = new System.Drawing.Size(49, 23);
            this.loadCustomBttn.TabIndex = 35;
            this.loadCustomBttn.Text = "LOAD";
            this.loadCustomBttn.UseVisualStyleBackColor = true;
            this.loadCustomBttn.Click += new System.EventHandler(this.loadCustomBttn_Click);
            // 
            // createCustomBttn
            // 
            this.createCustomBttn.Location = new System.Drawing.Point(156, 266);
            this.createCustomBttn.Name = "createCustomBttn";
            this.createCustomBttn.Size = new System.Drawing.Size(94, 23);
            this.createCustomBttn.TabIndex = 36;
            this.createCustomBttn.Text = "CREATE CFG";
            this.createCustomBttn.UseVisualStyleBackColor = true;
            this.createCustomBttn.Click += new System.EventHandler(this.createCustomBttn_Click);
            // 
            // mainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1436, 637);
            this.Controls.Add(this.tabs);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainUI";
            this.Text = "KDownloader | Public release";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button inputBttn;
        private System.Windows.Forms.Button outputBttn;
        private System.Windows.Forms.Button startBttn;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button aboutBttn;
        private System.Windows.Forms.RadioButton foscamRadioBttn;
        private System.Windows.Forms.RadioButton aztechRadioBttn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button folderBttn;
        private System.Windows.Forms.CheckBox randomIpOrdCheckbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DomainUpDown threadSelector;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TabControl tabs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        public System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.RadioButton defewayRadioBttn;
        private System.Windows.Forms.CheckBox discardOutputCheck;
        private System.Windows.Forms.Button updatebttn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label updatelbl;
        private System.Windows.Forms.Button createCustomBttn;
        private System.Windows.Forms.Button loadCustomBttn;
        private System.Windows.Forms.RadioButton customRadioBttn;
    }
}

