namespace OpenGrade
{
    partial class FormNtrip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNtrip));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnNtripOnOff = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxCasterIP = new System.Windows.Forms.TextBox();
            this.nudCasterPort = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.tboxUserName = new System.Windows.Forms.TextBox();
            this.tboxUserPassword = new System.Windows.Forms.TextBox();
            this.tboxMount = new System.Windows.Forms.TextBox();
            this.nudGGAInterval = new System.Windows.Forms.NumericUpDown();
            this.tboxEnterURL = new System.Windows.Forms.TextBox();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnGetSourceTable = new System.Windows.Forms.Button();
            this.cboxGGAManual = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.btnPassPassword = new System.Windows.Forms.Button();
            this.cboxHTTP = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cBoxManPos = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblMnt = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnStartNtrip = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCasterPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGGAInterval)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnNtripOnOff);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 524);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(191, 103);
            this.groupBox2.TabIndex = 98;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "On / Off";
            // 
            // btnNtripOnOff
            // 
            this.btnNtripOnOff.BackColor = System.Drawing.Color.Red;
            this.btnNtripOnOff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNtripOnOff.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNtripOnOff.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNtripOnOff.Location = new System.Drawing.Point(17, 25);
            this.btnNtripOnOff.Name = "btnNtripOnOff";
            this.btnNtripOnOff.Size = new System.Drawing.Size(157, 49);
            this.btnNtripOnOff.TabIndex = 130;
            this.btnNtripOnOff.Text = "OFF";
            this.btnNtripOnOff.UseVisualStyleBackColor = false;
            this.btnNtripOnOff.Click += new System.EventHandler(this.btnNtripOnOff_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(46, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 129;
            this.label1.Text = "*Restart Required";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tboxCasterIP
            // 
            this.tboxCasterIP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxCasterIP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxCasterIP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tboxCasterIP.Location = new System.Drawing.Point(136, 51);
            this.tboxCasterIP.Name = "tboxCasterIP";
            this.tboxCasterIP.Size = new System.Drawing.Size(168, 33);
            this.tboxCasterIP.TabIndex = 79;
            this.tboxCasterIP.Text = "192.168.188.255";
            this.tboxCasterIP.Validating += new System.ComponentModel.CancelEventHandler(this.tboxCasterIP_Validating);
            // 
            // nudCasterPort
            // 
            this.nudCasterPort.AutoSize = true;
            this.nudCasterPort.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudCasterPort.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudCasterPort.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nudCasterPort.Location = new System.Drawing.Point(369, 51);
            this.nudCasterPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudCasterPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudCasterPort.Name = "nudCasterPort";
            this.nudCasterPort.Size = new System.Drawing.Size(122, 33);
            this.nudCasterPort.TabIndex = 2101;
            this.nudCasterPort.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudCasterPort.Value = new decimal(new int[] {
            80,
            0,
            0,
            0});
            this.nudCasterPort.Enter += new System.EventHandler(this.NudCasterPort_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(28, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 24);
            this.label5.TabIndex = 82;
            this.label5.Text = "Caster IP:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnSerialCancel
            // 
            this.btnSerialCancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSerialCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialCancel.ForeColor = System.Drawing.Color.Black;
            this.btnSerialCancel.Image = global::OpenGrade.Properties.Resources.Cancel64;
            this.btnSerialCancel.Location = new System.Drawing.Point(266, 541);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(88, 76);
            this.btnSerialCancel.TabIndex = 95;
            this.btnSerialCancel.UseVisualStyleBackColor = false;
            // 
            // btnSerialOK
            // 
            this.btnSerialOK.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSerialOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSerialOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialOK.Image = global::OpenGrade.Properties.Resources.OK64;
            this.btnSerialOK.Location = new System.Drawing.Point(365, 541);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(138, 76);
            this.btnSerialOK.TabIndex = 94;
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = false;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // tboxUserName
            // 
            this.tboxUserName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxUserName.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUserName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tboxUserName.Location = new System.Drawing.Point(136, 171);
            this.tboxUserName.Name = "tboxUserName";
            this.tboxUserName.Size = new System.Drawing.Size(168, 33);
            this.tboxUserName.TabIndex = 100;
            this.tboxUserName.Click += new System.EventHandler(this.tboxUserName_Click);
            // 
            // tboxUserPassword
            // 
            this.tboxUserPassword.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxUserPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxUserPassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tboxUserPassword.Location = new System.Drawing.Point(136, 231);
            this.tboxUserPassword.Name = "tboxUserPassword";
            this.tboxUserPassword.PasswordChar = '*';
            this.tboxUserPassword.Size = new System.Drawing.Size(168, 33);
            this.tboxUserPassword.TabIndex = 101;
            this.tboxUserPassword.Click += new System.EventHandler(this.tboxUserPassword_Click);
            // 
            // tboxMount
            // 
            this.tboxMount.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxMount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMount.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tboxMount.Location = new System.Drawing.Point(212, 69);
            this.tboxMount.Name = "tboxMount";
            this.tboxMount.Size = new System.Drawing.Size(253, 33);
            this.tboxMount.TabIndex = 104;
            this.tboxMount.Click += new System.EventHandler(this.tboxMount_Click);
            this.tboxMount.TextChanged += new System.EventHandler(this.tboxMount_TextChanged);
            // 
            // nudGGAInterval
            // 
            this.nudGGAInterval.AutoSize = true;
            this.nudGGAInterval.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudGGAInterval.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGGAInterval.ForeColor = System.Drawing.Color.Yellow;
            this.nudGGAInterval.Location = new System.Drawing.Point(330, 28);
            this.nudGGAInterval.Maximum = new decimal(new int[] {
            600,
            0,
            0,
            0});
            this.nudGGAInterval.Name = "nudGGAInterval";
            this.nudGGAInterval.Size = new System.Drawing.Size(133, 33);
            this.nudGGAInterval.TabIndex = 106;
            this.nudGGAInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudGGAInterval.Value = new decimal(new int[] {
            333,
            0,
            0,
            0});
            this.nudGGAInterval.ValueChanged += new System.EventHandler(this.nudGGAInterval_ValueChanged);
            this.nudGGAInterval.Enter += new System.EventHandler(this.NudGGAInterval_Enter);
            // 
            // tboxEnterURL
            // 
            this.tboxEnterURL.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxEnterURL.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxEnterURL.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tboxEnterURL.Location = new System.Drawing.Point(137, 111);
            this.tboxEnterURL.Name = "tboxEnterURL";
            this.tboxEnterURL.Size = new System.Drawing.Size(169, 33);
            this.tboxEnterURL.TabIndex = 108;
            this.tboxEnterURL.Text = "RTK2Go.com";
            this.tboxEnterURL.Click += new System.EventHandler(this.tboxEnterURL_Click);
            // 
            // nudLatitude
            // 
            this.nudLatitude.BackColor = System.Drawing.Color.Black;
            this.nudLatitude.DecimalPlaces = 7;
            this.nudLatitude.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLatitude.ForeColor = System.Drawing.Color.Yellow;
            this.nudLatitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLatitude.Location = new System.Drawing.Point(88, 112);
            this.nudLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudLatitude.Name = "nudLatitude";
            this.nudLatitude.Size = new System.Drawing.Size(224, 33);
            this.nudLatitude.TabIndex = 118;
            this.nudLatitude.Value = new decimal(new int[] {
            881234567,
            0,
            0,
            -2147024896});
            this.nudLatitude.ValueChanged += new System.EventHandler(this.nudLatitude_ValueChanged);
            this.nudLatitude.Enter += new System.EventHandler(this.NudLatitude_Enter);
            // 
            // nudLongitude
            // 
            this.nudLongitude.BackColor = System.Drawing.Color.Black;
            this.nudLongitude.DecimalPlaces = 7;
            this.nudLongitude.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLongitude.ForeColor = System.Drawing.Color.Yellow;
            this.nudLongitude.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudLongitude.Location = new System.Drawing.Point(88, 155);
            this.nudLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudLongitude.Name = "nudLongitude";
            this.nudLongitude.Size = new System.Drawing.Size(224, 33);
            this.nudLongitude.TabIndex = 117;
            this.nudLongitude.Value = new decimal(new int[] {
            1781234567,
            0,
            0,
            -2147024896});
            this.nudLongitude.ValueChanged += new System.EventHandler(this.nudLongitude_ValueChanged);
            this.nudLongitude.Enter += new System.EventHandler(this.NudLongitude_Enter);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnGetSourceTable
            // 
            this.btnGetSourceTable.BackColor = System.Drawing.Color.DodgerBlue;
            this.btnGetSourceTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGetSourceTable.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGetSourceTable.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGetSourceTable.Location = new System.Drawing.Point(33, 25);
            this.btnGetSourceTable.Name = "btnGetSourceTable";
            this.btnGetSourceTable.Size = new System.Drawing.Size(161, 45);
            this.btnGetSourceTable.TabIndex = 127;
            this.btnGetSourceTable.Text = "Find Base";
            this.btnGetSourceTable.UseVisualStyleBackColor = false;
            this.btnGetSourceTable.Click += new System.EventHandler(this.btnGetSourceTable_Click);
            // 
            // cboxGGAManual
            // 
            this.cboxGGAManual.BackColor = System.Drawing.Color.Black;
            this.cboxGGAManual.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxGGAManual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxGGAManual.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxGGAManual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboxGGAManual.FormattingEnabled = true;
            this.cboxGGAManual.Items.AddRange(new object[] {
            "Use Manual Fix",
            "Use GPS Fix"});
            this.cboxGGAManual.Location = new System.Drawing.Point(329, 155);
            this.cboxGGAManual.Name = "cboxGGAManual";
            this.cboxGGAManual.Size = new System.Drawing.Size(136, 24);
            this.cboxGGAManual.TabIndex = 128;
            this.cboxGGAManual.SelectedIndexChanged += new System.EventHandler(this.cboxGGAManual_SelectedIndexChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label19.Location = new System.Drawing.Point(244, 53);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(43, 13);
            this.label19.TabIndex = 131;
            this.label19.Text = "0 = Off";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // btnPassPassword
            // 
            this.btnPassPassword.BackColor = System.Drawing.Color.Lime;
            this.btnPassPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassPassword.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassPassword.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPassPassword.Location = new System.Drawing.Point(349, 171);
            this.btnPassPassword.Name = "btnPassPassword";
            this.btnPassPassword.Size = new System.Drawing.Size(121, 33);
            this.btnPassPassword.TabIndex = 134;
            this.btnPassPassword.Text = "VERIFY";
            this.btnPassPassword.UseVisualStyleBackColor = false;
            this.btnPassPassword.Click += new System.EventHandler(this.btnPassPassword_Click);
            // 
            // cboxHTTP
            // 
            this.cboxHTTP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxHTTP.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxHTTP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxHTTP.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxHTTP.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cboxHTTP.FormattingEnabled = true;
            this.cboxHTTP.Items.AddRange(new object[] {
            "1.0",
            "1.1"});
            this.cboxHTTP.Location = new System.Drawing.Point(385, 112);
            this.cboxHTTP.Name = "cboxHTTP";
            this.cboxHTTP.Size = new System.Drawing.Size(80, 33);
            this.cboxHTTP.TabIndex = 135;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboxGGAManual);
            this.groupBox1.Controls.Add(this.cBoxManPos);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.nudLongitude);
            this.groupBox1.Controls.Add(this.lblMnt);
            this.groupBox1.Controls.Add(this.nudLatitude);
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.nudGGAInterval);
            this.groupBox1.Controls.Add(this.btnGetSourceTable);
            this.groupBox1.Controls.Add(this.tboxMount);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(508, 204);
            this.groupBox1.TabIndex = 137;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "NTRIP Stream";
            // 
            // cBoxManPos
            // 
            this.cBoxManPos.AutoSize = true;
            this.cBoxManPos.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cBoxManPos.Location = new System.Drawing.Point(329, 121);
            this.cBoxManPos.Name = "cBoxManPos";
            this.cBoxManPos.Size = new System.Drawing.Size(141, 20);
            this.cBoxManPos.TabIndex = 141;
            this.cBoxManPos.Text = "Use manual Position";
            this.cBoxManPos.UseVisualStyleBackColor = true;
            this.cBoxManPos.CheckedChanged += new System.EventHandler(this.cBoxManPos_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(29, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 29);
            this.label2.TabIndex = 135;
            this.label2.Text = "Lon:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label15.Location = new System.Drawing.Point(34, 113);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 29);
            this.label15.TabIndex = 134;
            this.label15.Text = "Lat:";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lblMnt
            // 
            this.lblMnt.AutoSize = true;
            this.lblMnt.BackColor = System.Drawing.Color.Transparent;
            this.lblMnt.Font = new System.Drawing.Font("Tahoma", 15F);
            this.lblMnt.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMnt.Location = new System.Drawing.Point(29, 73);
            this.lblMnt.Name = "lblMnt";
            this.lblMnt.Size = new System.Drawing.Size(177, 24);
            this.lblMnt.TabIndex = 138;
            this.lblMnt.Text = "NTRIP Mount point";
            this.lblMnt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMnt.Click += new System.EventHandler(this.lblMnt_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F);
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(200, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 19);
            this.label9.TabIndex = 132;
            this.label9.Text = "Request Interval";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label7.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(11, 116);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 24);
            this.label7.TabIndex = 137;
            this.label7.Text = "Caster URL:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label17.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label17.Location = new System.Drawing.Point(32, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(94, 24);
            this.label17.TabIndex = 139;
            this.label17.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(310, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 141;
            this.label6.Text = "Port:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label20.Location = new System.Drawing.Point(317, 117);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(62, 23);
            this.label20.TabIndex = 142;
            this.label20.Text = "HTTP:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 15F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 143;
            this.label3.Text = "Username";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnStartNtrip);
            this.groupBox6.Controls.Add(this.tboxUserPassword);
            this.groupBox6.Controls.Add(this.label20);
            this.groupBox6.Controls.Add(this.label3);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.btnPassPassword);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.tboxUserName);
            this.groupBox6.Controls.Add(this.label17);
            this.groupBox6.Controls.Add(this.nudCasterPort);
            this.groupBox6.Controls.Add(this.cboxHTTP);
            this.groupBox6.Controls.Add(this.tboxEnterURL);
            this.groupBox6.Controls.Add(this.tboxCasterIP);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox6.Location = new System.Drawing.Point(12, 222);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(508, 296);
            this.groupBox6.TabIndex = 144;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "NTRIP Caster Settings";
            // 
            // btnStartNtrip
            // 
            this.btnStartNtrip.BackColor = System.Drawing.Color.Lime;
            this.btnStartNtrip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartNtrip.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartNtrip.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnStartNtrip.Location = new System.Drawing.Point(349, 231);
            this.btnStartNtrip.Name = "btnStartNtrip";
            this.btnStartNtrip.Size = new System.Drawing.Size(121, 33);
            this.btnStartNtrip.TabIndex = 2102;
            this.btnStartNtrip.Text = "RESTART";
            this.btnStartNtrip.UseVisualStyleBackColor = false;
            this.btnStartNtrip.Click += new System.EventHandler(this.btnStartNtrip_Click);
            // 
            // FormNtrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(534, 639);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.btnSerialOK);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNtrip";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "NTRIP Client Settings";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormNtrip_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCasterPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGGAInterval)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tboxCasterIP;
        private System.Windows.Forms.NumericUpDown nudCasterPort;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.TextBox tboxUserName;
        private System.Windows.Forms.TextBox tboxUserPassword;
        private System.Windows.Forms.NumericUpDown nudGGAInterval;
        private System.Windows.Forms.TextBox tboxEnterURL;
        private System.Windows.Forms.NumericUpDown nudLatitude;
        private System.Windows.Forms.NumericUpDown nudLongitude;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnGetSourceTable;
        private System.Windows.Forms.ComboBox cboxGGAManual;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label19;
        public System.Windows.Forms.TextBox tboxMount;
        private System.Windows.Forms.Button btnPassPassword;
        private System.Windows.Forms.ComboBox cboxHTTP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label lblMnt;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.CheckBox cBoxManPos;
        private System.Windows.Forms.Button btnNtripOnOff;
        private System.Windows.Forms.Button btnStartNtrip;
    }
}