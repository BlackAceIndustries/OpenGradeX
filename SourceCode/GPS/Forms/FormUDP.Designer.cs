namespace OpenGrade
{
    partial class FormUDP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUDP));
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tboxHostName = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tboxThisIP = new System.Windows.Forms.TextBox();
            this.nudThisPort = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.nudAutoSteerPort = new System.Windows.Forms.NumericUpDown();
            this.tboxAutoSteerIP = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nudGradeControlPort = new System.Windows.Forms.NumericUpDown();
            this.tboxGradeControlIP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.choiceWiFi = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lblGCVersion = new System.Windows.Forms.TextBox();
            this.lblAntennaVersion = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnRefreshWifi = new System.Windows.Forms.Button();
            this.btnHotSpotConnect = new System.Windows.Forms.Button();
            this.choicePassword = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblProgramName = new System.Windows.Forms.Label();
            this.lblOGXVersion = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThisPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSteerPort)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeControlPort)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tboxHostName);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.tboxThisIP);
            this.groupBox4.Controls.Add(this.nudThisPort);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox4.Location = new System.Drawing.Point(23, 42);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(248, 232);
            this.groupBox4.TabIndex = 72;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "OpenGradeX Server";
            // 
            // tboxHostName
            // 
            this.tboxHostName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxHostName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxHostName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxHostName.Location = new System.Drawing.Point(65, 79);
            this.tboxHostName.Name = "tboxHostName";
            this.tboxHostName.ReadOnly = true;
            this.tboxHostName.Size = new System.Drawing.Size(157, 30);
            this.tboxHostName.TabIndex = 86;
            this.tboxHostName.Text = "192.168.1.255";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(2, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 23);
            this.label14.TabIndex = 85;
            this.label14.Text = "Host";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 23);
            this.label1.TabIndex = 84;
            this.label1.Text = "This Computer";
            // 
            // tboxThisIP
            // 
            this.tboxThisIP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxThisIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxThisIP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxThisIP.Location = new System.Drawing.Point(62, 120);
            this.tboxThisIP.Name = "tboxThisIP";
            this.tboxThisIP.ReadOnly = true;
            this.tboxThisIP.Size = new System.Drawing.Size(157, 30);
            this.tboxThisIP.TabIndex = 73;
            this.tboxThisIP.Text = "192.168.1.255";
            // 
            // nudThisPort
            // 
            this.nudThisPort.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudThisPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudThisPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nudThisPort.Location = new System.Drawing.Point(62, 162);
            this.nudThisPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudThisPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudThisPort.Name = "nudThisPort";
            this.nudThisPort.Size = new System.Drawing.Size(96, 30);
            this.nudThisPort.TabIndex = 74;
            this.nudThisPort.Value = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(7, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 23);
            this.label9.TabIndex = 75;
            this.label9.Text = "Port";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(22, 124);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 23);
            this.label10.TabIndex = 76;
            this.label10.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "9999";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(5, 8);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(565, 23);
            this.label7.TabIndex = 70;
            this.label7.Text = "** You must RESTART OpenGrade for any changes to take effect!\r\n";
            // 
            // btnSerialCancel
            // 
            this.btnSerialCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialCancel.BackColor = System.Drawing.Color.Black;
            this.btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialCancel.Image = global::OpenGrade.Properties.Resources.Cancel64;
            this.btnSerialCancel.Location = new System.Drawing.Point(299, 469);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(88, 76);
            this.btnSerialCancel.TabIndex = 71;
            this.btnSerialCancel.UseVisualStyleBackColor = false;
            // 
            // btnSerialOK
            // 
            this.btnSerialOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialOK.BackColor = System.Drawing.Color.Black;
            this.btnSerialOK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialOK.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSerialOK.Image = ((System.Drawing.Image)(resources.GetObject("btnSerialOK.Image")));
            this.btnSerialOK.Location = new System.Drawing.Point(419, 469);
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.Size = new System.Drawing.Size(156, 76);
            this.btnSerialOK.TabIndex = 70;
            this.btnSerialOK.Text = "Save";
            this.btnSerialOK.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnSerialOK.UseVisualStyleBackColor = false;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(179, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 19);
            this.label3.TabIndex = 84;
            this.label3.Text = "8888";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(8, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 83;
            this.label4.Text = "Antenna/IMU";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(30, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 23);
            this.label5.TabIndex = 82;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(15, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 23);
            this.label6.TabIndex = 81;
            this.label6.Text = "Port";
            // 
            // nudAutoSteerPort
            // 
            this.nudAutoSteerPort.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudAutoSteerPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudAutoSteerPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nudAutoSteerPort.Location = new System.Drawing.Point(70, 116);
            this.nudAutoSteerPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudAutoSteerPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudAutoSteerPort.Name = "nudAutoSteerPort";
            this.nudAutoSteerPort.Size = new System.Drawing.Size(96, 30);
            this.nudAutoSteerPort.TabIndex = 80;
            this.nudAutoSteerPort.Value = new decimal(new int[] {
            8888,
            0,
            0,
            0});
            // 
            // tboxAutoSteerIP
            // 
            this.tboxAutoSteerIP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxAutoSteerIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxAutoSteerIP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxAutoSteerIP.Location = new System.Drawing.Point(70, 74);
            this.tboxAutoSteerIP.Name = "tboxAutoSteerIP";
            this.tboxAutoSteerIP.Size = new System.Drawing.Size(167, 30);
            this.tboxAutoSteerIP.TabIndex = 79;
            this.tboxAutoSteerIP.Text = "192.168.1.155";
            this.tboxAutoSteerIP.Validating += new System.ComponentModel.CancelEventHandler(this.tboxAutoSteerIP_Validating);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(179, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 19);
            this.label8.TabIndex = 90;
            this.label8.Text = "7777";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(8, 201);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 23);
            this.label11.TabIndex = 89;
            this.label11.Text = "Grade Control";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(30, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(27, 23);
            this.label12.TabIndex = 88;
            this.label12.Text = "IP";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(15, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(43, 23);
            this.label13.TabIndex = 87;
            this.label13.Text = "Port";
            // 
            // nudGradeControlPort
            // 
            this.nudGradeControlPort.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nudGradeControlPort.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudGradeControlPort.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.nudGradeControlPort.Location = new System.Drawing.Point(70, 276);
            this.nudGradeControlPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nudGradeControlPort.Minimum = new decimal(new int[] {
            1025,
            0,
            0,
            0});
            this.nudGradeControlPort.Name = "nudGradeControlPort";
            this.nudGradeControlPort.Size = new System.Drawing.Size(96, 30);
            this.nudGradeControlPort.TabIndex = 86;
            this.nudGradeControlPort.Value = new decimal(new int[] {
            7777,
            0,
            0,
            0});
            // 
            // tboxGradeControlIP
            // 
            this.tboxGradeControlIP.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxGradeControlIP.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGradeControlIP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxGradeControlIP.Location = new System.Drawing.Point(70, 234);
            this.tboxGradeControlIP.Name = "tboxGradeControlIP";
            this.tboxGradeControlIP.Size = new System.Drawing.Size(167, 30);
            this.tboxGradeControlIP.TabIndex = 85;
            this.tboxGradeControlIP.Text = "192.168.1.255";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxGradeControlIP);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.tboxAutoSteerIP);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.nudAutoSteerPort);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudGradeControlPort);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(299, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(276, 319);
            this.groupBox1.TabIndex = 91;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Module Address and Ports";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // choiceWiFi
            // 
            this.choiceWiFi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choiceWiFi.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.choiceWiFi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choiceWiFi.FormattingEnabled = true;
            this.choiceWiFi.ItemHeight = 19;
            this.choiceWiFi.Location = new System.Drawing.Point(11, 34);
            this.choiceWiFi.Name = "choiceWiFi";
            this.choiceWiFi.Size = new System.Drawing.Size(226, 27);
            this.choiceWiFi.TabIndex = 92;
            this.choiceWiFi.Text = "Wifi Network";
            this.choiceWiFi.Visible = false;
            this.choiceWiFi.SelectedIndexChanged += new System.EventHandler(this.choiceWiFi_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.Yellow;
            this.textBox1.Location = new System.Drawing.Point(2, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(163, 16);
            this.textBox1.TabIndex = 93;
            this.textBox1.Text = "GradeControl ";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.ForeColor = System.Drawing.Color.Yellow;
            this.textBox2.Location = new System.Drawing.Point(2, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(163, 16);
            this.textBox2.TabIndex = 94;
            this.textBox2.Text = "Antenna";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lblGCVersion
            // 
            this.lblGCVersion.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblGCVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblGCVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGCVersion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblGCVersion.Location = new System.Drawing.Point(181, 40);
            this.lblGCVersion.Name = "lblGCVersion";
            this.lblGCVersion.Size = new System.Drawing.Size(57, 17);
            this.lblGCVersion.TabIndex = 95;
            this.lblGCVersion.Text = "-------";
            this.lblGCVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAntennaVersion
            // 
            this.lblAntennaVersion.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblAntennaVersion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblAntennaVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntennaVersion.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.lblAntennaVersion.Location = new System.Drawing.Point(181, 64);
            this.lblAntennaVersion.Name = "lblAntennaVersion";
            this.lblAntennaVersion.Size = new System.Drawing.Size(57, 17);
            this.lblAntennaVersion.TabIndex = 96;
            this.lblAntennaVersion.Text = "-------";
            this.lblAntennaVersion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnRefreshWifi);
            this.groupBox2.Controls.Add(this.btnHotSpotConnect);
            this.groupBox2.Controls.Add(this.choicePassword);
            this.groupBox2.Controls.Add(this.choiceWiFi);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Location = new System.Drawing.Point(21, 286);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 251);
            this.groupBox2.TabIndex = 97;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "HotSpot Connection";
            // 
            // btnRefreshWifi
            // 
            this.btnRefreshWifi.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRefreshWifi.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshWifi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRefreshWifi.Location = new System.Drawing.Point(12, 147);
            this.btnRefreshWifi.Name = "btnRefreshWifi";
            this.btnRefreshWifi.Size = new System.Drawing.Size(225, 25);
            this.btnRefreshWifi.TabIndex = 99;
            this.btnRefreshWifi.Text = "Find  Available Wifi Networks";
            this.btnRefreshWifi.UseVisualStyleBackColor = false;
            this.btnRefreshWifi.Visible = false;
            this.btnRefreshWifi.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnHotSpotConnect
            // 
            this.btnHotSpotConnect.BackColor = System.Drawing.Color.LimeGreen;
            this.btnHotSpotConnect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotSpotConnect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnHotSpotConnect.Location = new System.Drawing.Point(12, 178);
            this.btnHotSpotConnect.Name = "btnHotSpotConnect";
            this.btnHotSpotConnect.Size = new System.Drawing.Size(225, 56);
            this.btnHotSpotConnect.TabIndex = 98;
            this.btnHotSpotConnect.Text = "Connect To WiFi";
            this.btnHotSpotConnect.UseVisualStyleBackColor = false;
            this.btnHotSpotConnect.Visible = false;
            this.btnHotSpotConnect.Click += new System.EventHandler(this.btnHotSpotConnect_Click);
            // 
            // choicePassword
            // 
            this.choicePassword.AllowDrop = true;
            this.choicePassword.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.choicePassword.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.choicePassword.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.choicePassword.FormattingEnabled = true;
            this.choicePassword.ItemHeight = 19;
            this.choicePassword.Location = new System.Drawing.Point(11, 67);
            this.choicePassword.Name = "choicePassword";
            this.choicePassword.Size = new System.Drawing.Size(226, 27);
            this.choicePassword.TabIndex = 97;
            this.choicePassword.Text = "Wifi Password";
            this.choicePassword.Visible = false;
            this.choicePassword.SelectedIndexChanged += new System.EventHandler(this.choicePassword_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblProgramName);
            this.groupBox3.Controls.Add(this.lblOGXVersion);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.textBox1);
            this.groupBox3.Controls.Add(this.lblAntennaVersion);
            this.groupBox3.Controls.Add(this.lblGCVersion);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(299, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(276, 91);
            this.groupBox3.TabIndex = 98;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "OpenGradeX Version";
            // 
            // lblProgramName
            // 
            this.lblProgramName.ForeColor = System.Drawing.Color.Yellow;
            this.lblProgramName.Location = new System.Drawing.Point(2, 17);
            this.lblProgramName.Name = "lblProgramName";
            this.lblProgramName.Size = new System.Drawing.Size(163, 20);
            this.lblProgramName.TabIndex = 1;
            this.lblProgramName.Text = "OpenGradeX";
            this.lblProgramName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOGXVersion
            // 
            this.lblOGXVersion.BackColor = System.Drawing.Color.Black;
            this.lblOGXVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOGXVersion.Location = new System.Drawing.Point(180, 19);
            this.lblOGXVersion.Name = "lblOGXVersion";
            this.lblOGXVersion.Size = new System.Drawing.Size(58, 16);
            this.lblOGXVersion.TabIndex = 0;
            this.lblOGXVersion.Text = "-------";
            this.lblOGXVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormUDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(603, 578);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.btnSerialOK);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormUDP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UDP Configuration";
            this.Load += new System.EventHandler(this.FormUDp_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudThisPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudAutoSteerPort)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudGradeControlPort)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSerialCancel;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown nudAutoSteerPort;
        private System.Windows.Forms.TextBox tboxAutoSteerIP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nudGradeControlPort;
        private System.Windows.Forms.TextBox tboxGradeControlIP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tboxThisIP;
        private System.Windows.Forms.NumericUpDown nudThisPort;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tboxHostName;
        private System.Windows.Forms.Label label14;
        public System.Windows.Forms.ComboBox choiceWiFi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox lblGCVersion;
        private System.Windows.Forms.TextBox lblAntennaVersion;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.ComboBox choicePassword;
        private System.Windows.Forms.Button btnHotSpotConnect;
        private System.Windows.Forms.Button btnRefreshWifi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblOGXVersion;
        private System.Windows.Forms.Label lblProgramName;
    }
}