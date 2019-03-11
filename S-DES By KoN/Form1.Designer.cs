namespace S_DES_By_KoN
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.TXT_sourceText = new System.Windows.Forms.TextBox();
            this.TXT_cipheredText = new System.Windows.Forms.TextBox();
            this.BGW_Encryption = new System.ComponentModel.BackgroundWorker();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_status = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TXT_key = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TXT_plainBits = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.TXT_cipherBits = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TXT_sourceBits = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TXT_numRounds = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.TXT_keySize = new System.Windows.Forms.TextBox();
            this.TXT_blockSize = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TXT_type = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TXT_decryptedText = new System.Windows.Forms.TextBox();
            this.TIM_Operation = new System.Windows.Forms.Timer(this.components);
            this.label14 = new System.Windows.Forms.Label();
            this.LBL_elapsedTime = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.BTN_decrypt = new System.Windows.Forms.Button();
            this.BTN_encrypt = new System.Windows.Forms.Button();
            this.BGW_Decryption = new System.ComponentModel.BackgroundWorker();
            this.label10 = new System.Windows.Forms.Label();
            this.TXT_sourceBytes = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TXT_cipherBytes = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TXT_plainBytes = new System.Windows.Forms.TextBox();
            this.BTN_plainToText = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // TXT_sourceText
            // 
            this.TXT_sourceText.AcceptsReturn = true;
            this.TXT_sourceText.AcceptsTab = true;
            this.TXT_sourceText.AllowDrop = true;
            this.TXT_sourceText.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_sourceText.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_sourceText.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_sourceText.Location = new System.Drawing.Point(5, 29);
            this.TXT_sourceText.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TXT_sourceText.Multiline = true;
            this.TXT_sourceText.Name = "TXT_sourceText";
            this.TXT_sourceText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_sourceText.Size = new System.Drawing.Size(329, 225);
            this.TXT_sourceText.TabIndex = 0;
            // 
            // TXT_cipheredText
            // 
            this.TXT_cipheredText.AcceptsTab = true;
            this.TXT_cipheredText.AllowDrop = true;
            this.TXT_cipheredText.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_cipheredText.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_cipheredText.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_cipheredText.Location = new System.Drawing.Point(5, 29);
            this.TXT_cipheredText.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TXT_cipheredText.Multiline = true;
            this.TXT_cipheredText.Name = "TXT_cipheredText";
            this.TXT_cipheredText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_cipheredText.Size = new System.Drawing.Size(328, 167);
            this.TXT_cipheredText.TabIndex = 4;
            // 
            // BGW_Encryption
            // 
            this.BGW_Encryption.WorkerReportsProgress = true;
            this.BGW_Encryption.WorkerSupportsCancellation = true;
            this.BGW_Encryption.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_Encryption_DoWork);
            this.BGW_Encryption.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGW_Encryption_ProgressChanged);
            this.BGW_Encryption.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_Encryption_RunWorkerCompleted);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(57, 602);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(633, 27);
            this.progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(11, 577);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Status:";
            // 
            // LBL_status
            // 
            this.LBL_status.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_status.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_status.Location = new System.Drawing.Point(57, 574);
            this.LBL_status.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_status.Name = "LBL_status";
            this.LBL_status.Size = new System.Drawing.Size(450, 23);
            this.LBL_status.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(6, 609);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Progress";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TXT_sourceText);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(10, 40);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox1.Size = new System.Drawing.Size(338, 262);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Source";
            // 
            // TXT_key
            // 
            this.TXT_key.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.TXT_key.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_key.Location = new System.Drawing.Point(5, 25);
            this.TXT_key.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TXT_key.Name = "TXT_key";
            this.TXT_key.Size = new System.Drawing.Size(125, 26);
            this.TXT_key.TabIndex = 12;
            this.TXT_key.TextChanged += new System.EventHandler(this.TXT_key_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TXT_key);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Location = new System.Drawing.Point(11, 302);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox2.Size = new System.Drawing.Size(137, 65);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Key";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TXT_cipheredText);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Location = new System.Drawing.Point(11, 369);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox3.Size = new System.Drawing.Size(337, 200);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Ciphertext";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.menuStrip1.Font = new System.Drawing.Font("Agency FB", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(697, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(41, 22);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(91, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(38, 22);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TXT_plainBytes);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.TXT_plainBits);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.TXT_cipherBytes);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.TXT_cipherBits);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.TXT_sourceBytes);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.TXT_sourceBits);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.TXT_numRounds);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.TXT_keySize);
            this.groupBox4.Controls.Add(this.TXT_blockSize);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.TXT_type);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox4.Location = new System.Drawing.Point(353, 40);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(333, 262);
            this.groupBox4.TabIndex = 16;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Information";
            // 
            // TXT_plainBits
            // 
            this.TXT_plainBits.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_plainBits.ForeColor = System.Drawing.Color.Lime;
            this.TXT_plainBits.Location = new System.Drawing.Point(54, 228);
            this.TXT_plainBits.Name = "TXT_plainBits";
            this.TXT_plainBits.ReadOnly = true;
            this.TXT_plainBits.Size = new System.Drawing.Size(100, 26);
            this.TXT_plainBits.TabIndex = 22;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(6, 231);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(33, 20);
            this.label16.TabIndex = 21;
            this.label16.Text = "#Bits";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label17.Location = new System.Drawing.Point(6, 205);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(66, 20);
            this.label17.TabIndex = 20;
            this.label17.Text = "PlainText Info";
            // 
            // TXT_cipherBits
            // 
            this.TXT_cipherBits.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_cipherBits.ForeColor = System.Drawing.Color.Lime;
            this.TXT_cipherBits.Location = new System.Drawing.Point(54, 176);
            this.TXT_cipherBits.Name = "TXT_cipherBits";
            this.TXT_cipherBits.ReadOnly = true;
            this.TXT_cipherBits.Size = new System.Drawing.Size(100, 26);
            this.TXT_cipherBits.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(6, 179);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(33, 20);
            this.label12.TabIndex = 16;
            this.label12.Text = "#Bits";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label13.Location = new System.Drawing.Point(6, 153);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 20);
            this.label13.TabIndex = 15;
            this.label13.Text = "ChipherText Info";
            // 
            // TXT_sourceBits
            // 
            this.TXT_sourceBits.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_sourceBits.ForeColor = System.Drawing.Color.Lime;
            this.TXT_sourceBits.Location = new System.Drawing.Point(54, 127);
            this.TXT_sourceBits.Name = "TXT_sourceBits";
            this.TXT_sourceBits.ReadOnly = true;
            this.TXT_sourceBits.Size = new System.Drawing.Size(100, 26);
            this.TXT_sourceBits.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(6, 130);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(33, 20);
            this.label9.TabIndex = 11;
            this.label9.Text = "#Bits";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label8.Location = new System.Drawing.Point(6, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 20);
            this.label8.TabIndex = 10;
            this.label8.Text = "Source Info";
            // 
            // TXT_numRounds
            // 
            this.TXT_numRounds.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_numRounds.ForeColor = System.Drawing.Color.Lime;
            this.TXT_numRounds.Location = new System.Drawing.Point(54, 75);
            this.TXT_numRounds.Name = "TXT_numRounds";
            this.TXT_numRounds.ReadOnly = true;
            this.TXT_numRounds.Size = new System.Drawing.Size(100, 26);
            this.TXT_numRounds.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(6, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "#Rounds";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(159, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Key Size";
            // 
            // TXT_keySize
            // 
            this.TXT_keySize.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_keySize.ForeColor = System.Drawing.Color.Lime;
            this.TXT_keySize.Location = new System.Drawing.Point(218, 75);
            this.TXT_keySize.Name = "TXT_keySize";
            this.TXT_keySize.ReadOnly = true;
            this.TXT_keySize.Size = new System.Drawing.Size(100, 26);
            this.TXT_keySize.TabIndex = 6;
            // 
            // TXT_blockSize
            // 
            this.TXT_blockSize.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_blockSize.ForeColor = System.Drawing.Color.Lime;
            this.TXT_blockSize.Location = new System.Drawing.Point(218, 43);
            this.TXT_blockSize.Name = "TXT_blockSize";
            this.TXT_blockSize.ReadOnly = true;
            this.TXT_blockSize.Size = new System.Drawing.Size(100, 26);
            this.TXT_blockSize.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(159, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Block Size";
            // 
            // TXT_type
            // 
            this.TXT_type.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_type.ForeColor = System.Drawing.Color.Lime;
            this.TXT_type.Location = new System.Drawing.Point(54, 43);
            this.TXT_type.Name = "TXT_type";
            this.TXT_type.ReadOnly = true;
            this.TXT_type.Size = new System.Drawing.Size(100, 26);
            this.TXT_type.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(6, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Algorithm Parameters";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.BTN_plainToText);
            this.groupBox5.Controls.Add(this.TXT_decryptedText);
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Location = new System.Drawing.Point(353, 369);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox5.Size = new System.Drawing.Size(337, 200);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Plaintext";
            // 
            // TXT_decryptedText
            // 
            this.TXT_decryptedText.AcceptsTab = true;
            this.TXT_decryptedText.AllowDrop = true;
            this.TXT_decryptedText.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_decryptedText.Font = new System.Drawing.Font("Agency FB", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TXT_decryptedText.ForeColor = System.Drawing.Color.Yellow;
            this.TXT_decryptedText.Location = new System.Drawing.Point(5, 29);
            this.TXT_decryptedText.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.TXT_decryptedText.Multiline = true;
            this.TXT_decryptedText.Name = "TXT_decryptedText";
            this.TXT_decryptedText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TXT_decryptedText.Size = new System.Drawing.Size(328, 132);
            this.TXT_decryptedText.TabIndex = 4;
            // 
            // TIM_Operation
            // 
            this.TIM_Operation.Interval = 1000;
            this.TIM_Operation.Tick += new System.EventHandler(this.TIM_Operation_Tick);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.Control;
            this.label14.Location = new System.Drawing.Point(515, 575);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 20);
            this.label14.TabIndex = 18;
            this.label14.Text = "Elapsed Time:";
            // 
            // LBL_elapsedTime
            // 
            this.LBL_elapsedTime.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.LBL_elapsedTime.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LBL_elapsedTime.Location = new System.Drawing.Point(586, 574);
            this.LBL_elapsedTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LBL_elapsedTime.Name = "LBL_elapsedTime";
            this.LBL_elapsedTime.Size = new System.Drawing.Size(104, 23);
            this.LBL_elapsedTime.TabIndex = 19;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.BTN_decrypt);
            this.groupBox6.Controls.Add(this.BTN_encrypt);
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Location = new System.Drawing.Point(152, 302);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.groupBox6.Size = new System.Drawing.Size(534, 65);
            this.groupBox6.TabIndex = 14;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // BTN_decrypt
            // 
            this.BTN_decrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_decrypt.Location = new System.Drawing.Point(297, 19);
            this.BTN_decrypt.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.BTN_decrypt.Name = "BTN_decrypt";
            this.BTN_decrypt.Size = new System.Drawing.Size(180, 35);
            this.BTN_decrypt.TabIndex = 23;
            this.BTN_decrypt.Text = "Decrypt Text";
            this.BTN_decrypt.UseVisualStyleBackColor = true;
            this.BTN_decrypt.Click += new System.EventHandler(this.BTN_decrypt_Click);
            // 
            // BTN_encrypt
            // 
            this.BTN_encrypt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_encrypt.Location = new System.Drawing.Point(57, 20);
            this.BTN_encrypt.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.BTN_encrypt.Name = "BTN_encrypt";
            this.BTN_encrypt.Size = new System.Drawing.Size(180, 35);
            this.BTN_encrypt.TabIndex = 22;
            this.BTN_encrypt.Text = "Encrypt Text";
            this.BTN_encrypt.UseVisualStyleBackColor = true;
            this.BTN_encrypt.Click += new System.EventHandler(this.BTN_encrypt_Click);
            // 
            // BGW_Decryption
            // 
            this.BGW_Decryption.WorkerReportsProgress = true;
            this.BGW_Decryption.WorkerSupportsCancellation = true;
            this.BGW_Decryption.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGW_Decryption_DoWork);
            this.BGW_Decryption.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.BGW_Decryption_ProgressChanged);
            this.BGW_Decryption.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.BGW_Decryption_RunWorkerCompleted);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(159, 130);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 20);
            this.label10.TabIndex = 13;
            this.label10.Text = "#Bytes";
            // 
            // TXT_sourceBytes
            // 
            this.TXT_sourceBytes.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_sourceBytes.ForeColor = System.Drawing.Color.Lime;
            this.TXT_sourceBytes.Location = new System.Drawing.Point(218, 127);
            this.TXT_sourceBytes.Name = "TXT_sourceBytes";
            this.TXT_sourceBytes.ReadOnly = true;
            this.TXT_sourceBytes.Size = new System.Drawing.Size(100, 26);
            this.TXT_sourceBytes.TabIndex = 14;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(159, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 18;
            this.label11.Text = "#Bytes";
            // 
            // TXT_cipherBytes
            // 
            this.TXT_cipherBytes.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_cipherBytes.ForeColor = System.Drawing.Color.Lime;
            this.TXT_cipherBytes.Location = new System.Drawing.Point(218, 176);
            this.TXT_cipherBytes.Name = "TXT_cipherBytes";
            this.TXT_cipherBytes.ReadOnly = true;
            this.TXT_cipherBytes.Size = new System.Drawing.Size(100, 26);
            this.TXT_cipherBytes.TabIndex = 19;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(159, 231);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(42, 20);
            this.label15.TabIndex = 23;
            this.label15.Text = "#Bytes";
            // 
            // TXT_plainBytes
            // 
            this.TXT_plainBytes.BackColor = System.Drawing.SystemColors.InfoText;
            this.TXT_plainBytes.ForeColor = System.Drawing.Color.Lime;
            this.TXT_plainBytes.Location = new System.Drawing.Point(218, 228);
            this.TXT_plainBytes.Name = "TXT_plainBytes";
            this.TXT_plainBytes.ReadOnly = true;
            this.TXT_plainBytes.Size = new System.Drawing.Size(100, 26);
            this.TXT_plainBytes.TabIndex = 24;
            // 
            // BTN_plainToText
            // 
            this.BTN_plainToText.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BTN_plainToText.Location = new System.Drawing.Point(5, 163);
            this.BTN_plainToText.Name = "BTN_plainToText";
            this.BTN_plainToText.Size = new System.Drawing.Size(328, 33);
            this.BTN_plainToText.TabIndex = 5;
            this.BTN_plainToText.Text = "Convert To Text";
            this.BTN_plainToText.UseVisualStyleBackColor = true;
            this.BTN_plainToText.Click += new System.EventHandler(this.BTN_plainToText_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(697, 635);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.LBL_elapsedTime);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBL_status);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Agency FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 5, 2, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "S-DES By KoN";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TXT_sourceText;
        private System.Windows.Forms.TextBox TXT_cipheredText;
        private System.ComponentModel.BackgroundWorker BGW_Encryption;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_status;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TXT_key;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TXT_decryptedText;
        private System.Windows.Forms.TextBox TXT_cipherBits;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TXT_sourceBits;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TXT_numRounds;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TXT_keySize;
        private System.Windows.Forms.TextBox TXT_blockSize;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TXT_type;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer TIM_Operation;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LBL_elapsedTime;
        private System.Windows.Forms.TextBox TXT_plainBits;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button BTN_decrypt;
        private System.Windows.Forms.Button BTN_encrypt;
        private System.ComponentModel.BackgroundWorker BGW_Decryption;
        private System.Windows.Forms.TextBox TXT_plainBytes;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TXT_cipherBytes;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TXT_sourceBytes;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BTN_plainToText;
    }
}

