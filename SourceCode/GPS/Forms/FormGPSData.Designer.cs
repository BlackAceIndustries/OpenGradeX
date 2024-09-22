namespace OpenGrade
{
    partial class FormGPSData
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblFixQuality = new System.Windows.Forms.Label();
            this.lblSatsTracked = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblEasting = new System.Windows.Forms.Label();
            this.lblNorthing = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblHDOP = new System.Windows.Forms.Label();
            this.tboxNMEASerial = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.tboxRTCM = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.lblGyro = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.lblPDOP = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.lblVDOP = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblRtcmTrip = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblRTKAge = new System.Windows.Forms.Label();
            this.tboxA1 = new System.Windows.Forms.TextBox();
            this.tboxGC = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(292, 56);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Northing";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(304, 82);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 6;
            this.label5.Text = "Easting";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(298, 108);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 23);
            this.label6.TabIndex = 5;
            this.label6.Text = "Latitude";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(59, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Heading";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(25, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Fix Quality";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(18, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 23);
            this.label3.TabIndex = 9;
            this.label3.Text = "# Satellites";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Lime;
            this.lblStatus.Location = new System.Drawing.Point(136, 90);
            this.lblStatus.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(61, 19);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblFixQuality
            // 
            this.lblFixQuality.AutoSize = true;
            this.lblFixQuality.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFixQuality.ForeColor = System.Drawing.Color.Lime;
            this.lblFixQuality.Location = new System.Drawing.Point(136, 116);
            this.lblFixQuality.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblFixQuality.Name = "lblFixQuality";
            this.lblFixQuality.Size = new System.Drawing.Size(70, 19);
            this.lblFixQuality.TabIndex = 2;
            this.lblFixQuality.Text = "FixQual";
            this.lblFixQuality.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSatsTracked
            // 
            this.lblSatsTracked.AutoSize = true;
            this.lblSatsTracked.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSatsTracked.ForeColor = System.Drawing.Color.Lime;
            this.lblSatsTracked.Location = new System.Drawing.Point(136, 142);
            this.lblSatsTracked.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSatsTracked.Name = "lblSatsTracked";
            this.lblSatsTracked.Size = new System.Drawing.Size(44, 19);
            this.lblSatsTracked.TabIndex = 4;
            this.lblSatsTracked.Text = "Sats";
            this.lblSatsTracked.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLatitude.ForeColor = System.Drawing.Color.Lime;
            this.lblLatitude.Location = new System.Drawing.Point(386, 111);
            this.lblLatitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(77, 19);
            this.lblLatitude.TabIndex = 12;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblEasting
            // 
            this.lblEasting.AutoSize = true;
            this.lblEasting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEasting.ForeColor = System.Drawing.Color.Lime;
            this.lblEasting.Location = new System.Drawing.Point(386, 85);
            this.lblEasting.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblEasting.Name = "lblEasting";
            this.lblEasting.Size = new System.Drawing.Size(69, 19);
            this.lblEasting.TabIndex = 11;
            this.lblEasting.Text = "Easting";
            // 
            // lblNorthing
            // 
            this.lblNorthing.AutoSize = true;
            this.lblNorthing.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNorthing.ForeColor = System.Drawing.Color.Lime;
            this.lblNorthing.Location = new System.Drawing.Point(386, 59);
            this.lblNorthing.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNorthing.Name = "lblNorthing";
            this.lblNorthing.Size = new System.Drawing.Size(80, 19);
            this.lblNorthing.TabIndex = 10;
            this.lblNorthing.Text = "Northing";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLongitude.ForeColor = System.Drawing.Color.Lime;
            this.lblLongitude.Location = new System.Drawing.Point(386, 137);
            this.lblLongitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(90, 19);
            this.lblLongitude.TabIndex = 13;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblAltitude
            // 
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.ForeColor = System.Drawing.Color.Lime;
            this.lblAltitude.Location = new System.Drawing.Point(386, 163);
            this.lblAltitude.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(75, 19);
            this.lblAltitude.TabIndex = 14;
            this.lblAltitude.Text = "Altitude";
            this.lblAltitude.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(278, 134);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 15;
            this.label7.Text = "Longitiude";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Location = new System.Drawing.Point(302, 160);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 23);
            this.label8.TabIndex = 16;
            this.label8.Text = "Altitude";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(62, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 23);
            this.label9.TabIndex = 18;
            this.label9.Text = "HDOP";
            // 
            // lblHDOP
            // 
            this.lblHDOP.AutoSize = true;
            this.lblHDOP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHDOP.ForeColor = System.Drawing.Color.Lime;
            this.lblHDOP.Location = new System.Drawing.Point(136, 189);
            this.lblHDOP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblHDOP.Name = "lblHDOP";
            this.lblHDOP.Size = new System.Drawing.Size(56, 19);
            this.lblHDOP.TabIndex = 17;
            this.lblHDOP.Text = "HDOP";
            this.lblHDOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxNMEASerial
            // 
            this.tboxNMEASerial.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxNMEASerial.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxNMEASerial.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxNMEASerial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxNMEASerial.Location = new System.Drawing.Point(14, 268);
            this.tboxNMEASerial.Multiline = true;
            this.tboxNMEASerial.Name = "tboxNMEASerial";
            this.tboxNMEASerial.ReadOnly = true;
            this.tboxNMEASerial.Size = new System.Drawing.Size(371, 114);
            this.tboxNMEASerial.TabIndex = 107;
            this.tboxNMEASerial.TextChanged += new System.EventHandler(this.tboxNMEASerial_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Location = new System.Drawing.Point(14, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 23);
            this.label10.TabIndex = 110;
            this.label10.Text = "NMEA";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(323, 30);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(52, 23);
            this.label11.TabIndex = 114;
            this.label11.Text = "Zone";
            // 
            // lblZone
            // 
            this.lblZone.AutoSize = true;
            this.lblZone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblZone.ForeColor = System.Drawing.Color.Lime;
            this.lblZone.Location = new System.Drawing.Point(386, 33);
            this.lblZone.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(49, 19);
            this.lblZone.TabIndex = 113;
            this.lblZone.Text = "Zone";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label18.Location = new System.Drawing.Point(15, 386);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(59, 23);
            this.label18.TabIndex = 124;
            this.label18.Text = "RTCM";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // tboxRTCM
            // 
            this.tboxRTCM.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxRTCM.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxRTCM.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxRTCM.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxRTCM.Location = new System.Drawing.Point(14, 411);
            this.tboxRTCM.Multiline = true;
            this.tboxRTCM.Name = "tboxRTCM";
            this.tboxRTCM.ReadOnly = true;
            this.tboxRTCM.Size = new System.Drawing.Size(371, 114);
            this.tboxRTCM.TabIndex = 123;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label19.Location = new System.Drawing.Point(81, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(40, 23);
            this.label19.TabIndex = 126;
            this.label19.Text = "Roll";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRoll.ForeColor = System.Drawing.Color.Lime;
            this.lblRoll.Location = new System.Drawing.Point(139, 21);
            this.lblRoll.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(41, 19);
            this.lblRoll.TabIndex = 125;
            this.lblRoll.Text = "Roll";
            this.lblRoll.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblRoll.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label21.Location = new System.Drawing.Point(71, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 23);
            this.label21.TabIndex = 127;
            this.label21.Text = "Pitch";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label22.Location = new System.Drawing.Point(66, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(0, 23);
            this.label22.TabIndex = 128;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label23.Location = new System.Drawing.Point(72, 64);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(49, 23);
            this.label23.TabIndex = 129;
            this.label23.Text = "Gyro";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitch.ForeColor = System.Drawing.Color.Lime;
            this.lblPitch.Location = new System.Drawing.Point(139, 44);
            this.lblPitch.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(50, 19);
            this.lblPitch.TabIndex = 130;
            this.lblPitch.Text = "Pitch";
            this.lblPitch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblGyro
            // 
            this.lblGyro.AutoSize = true;
            this.lblGyro.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGyro.ForeColor = System.Drawing.Color.Lime;
            this.lblGyro.Location = new System.Drawing.Point(139, 67);
            this.lblGyro.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblGyro.Name = "lblGyro";
            this.lblGyro.Size = new System.Drawing.Size(47, 19);
            this.lblGyro.TabIndex = 131;
            this.lblGyro.Text = "Gyro";
            this.lblGyro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label20.Location = new System.Drawing.Point(311, 184);
            this.label20.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(63, 23);
            this.label20.TabIndex = 133;
            this.label20.Text = "Speed";
            this.label20.Click += new System.EventHandler(this.label20_Click_1);
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed.ForeColor = System.Drawing.Color.Lime;
            this.lblSpeed.Location = new System.Drawing.Point(386, 189);
            this.lblSpeed.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(59, 19);
            this.lblSpeed.TabIndex = 132;
            this.lblSpeed.Text = "Speed";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblSpeed.Click += new System.EventHandler(this.label24_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label24.Location = new System.Drawing.Point(62, 162);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(56, 23);
            this.label24.TabIndex = 135;
            this.label24.Text = "PDOP";
            this.label24.Click += new System.EventHandler(this.label24_Click_1);
            // 
            // lblPDOP
            // 
            this.lblPDOP.AutoSize = true;
            this.lblPDOP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPDOP.ForeColor = System.Drawing.Color.Lime;
            this.lblPDOP.Location = new System.Drawing.Point(136, 165);
            this.lblPDOP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblPDOP.Name = "lblPDOP";
            this.lblPDOP.Size = new System.Drawing.Size(55, 19);
            this.lblPDOP.TabIndex = 134;
            this.lblPDOP.Text = "PDOP";
            this.lblPDOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPDOP.Click += new System.EventHandler(this.label25_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label26.Location = new System.Drawing.Point(62, 211);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(57, 23);
            this.label26.TabIndex = 137;
            this.label26.Text = "VDOP";
            // 
            // lblVDOP
            // 
            this.lblVDOP.AutoSize = true;
            this.lblVDOP.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVDOP.ForeColor = System.Drawing.Color.Lime;
            this.lblVDOP.Location = new System.Drawing.Point(136, 214);
            this.lblVDOP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblVDOP.Name = "lblVDOP";
            this.lblVDOP.Size = new System.Drawing.Size(55, 19);
            this.lblVDOP.TabIndex = 136;
            this.lblVDOP.Text = "VDOP";
            this.lblVDOP.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Tahoma", 10.25F);
            this.label25.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label25.Location = new System.Drawing.Point(301, 528);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(42, 17);
            this.label25.TabIndex = 139;
            this.label25.Text = "Bytes";
            // 
            // lblRtcmTrip
            // 
            this.lblRtcmTrip.AutoSize = true;
            this.lblRtcmTrip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRtcmTrip.ForeColor = System.Drawing.Color.Lime;
            this.lblRtcmTrip.Location = new System.Drawing.Point(366, 528);
            this.lblRtcmTrip.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRtcmTrip.Name = "lblRtcmTrip";
            this.lblRtcmTrip.Size = new System.Drawing.Size(19, 19);
            this.lblRtcmTrip.TabIndex = 138;
            this.lblRtcmTrip.Text = "0";
            this.lblRtcmTrip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label27.Location = new System.Drawing.Point(292, 207);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(82, 23);
            this.label27.TabIndex = 141;
            this.label27.Text = "RTK Age";
            // 
            // lblRTKAge
            // 
            this.lblRTKAge.AutoSize = true;
            this.lblRTKAge.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTKAge.ForeColor = System.Drawing.Color.Lime;
            this.lblRTKAge.Location = new System.Drawing.Point(386, 212);
            this.lblRTKAge.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblRTKAge.Name = "lblRTKAge";
            this.lblRTKAge.Size = new System.Drawing.Size(41, 19);
            this.lblRTKAge.TabIndex = 140;
            this.lblRTKAge.Text = "Age";
            this.lblRTKAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tboxA1
            // 
            this.tboxA1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxA1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxA1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxA1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxA1.Location = new System.Drawing.Point(431, 268);
            this.tboxA1.Multiline = true;
            this.tboxA1.Name = "tboxA1";
            this.tboxA1.ReadOnly = true;
            this.tboxA1.Size = new System.Drawing.Size(371, 114);
            this.tboxA1.TabIndex = 142;
            // 
            // tboxGC
            // 
            this.tboxGC.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxGC.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxGC.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGC.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tboxGC.Location = new System.Drawing.Point(431, 411);
            this.tboxGC.Multiline = true;
            this.tboxGC.Name = "tboxGC";
            this.tboxGC.ReadOnly = true;
            this.tboxGC.Size = new System.Drawing.Size(371, 114);
            this.tboxGC.TabIndex = 143;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label28.Location = new System.Drawing.Point(427, 242);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(96, 23);
            this.label28.TabIndex = 144;
            this.label28.Text = "Antenna 1";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.Location = new System.Drawing.Point(427, 386);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(126, 23);
            this.label29.TabIndex = 145;
            this.label29.Text = "Grade Control";
            // 
            // FormGPSData
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(814, 556);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.tboxGC);
            this.Controls.Add(this.tboxA1);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lblRTKAge);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.lblRtcmTrip);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.lblVDOP);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.lblPDOP);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.lblGyro);
            this.Controls.Add(this.lblPitch);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lblRoll);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.tboxRTCM);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblZone);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tboxNMEASerial);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lblHDOP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblAltitude);
            this.Controls.Add(this.lblLongitude);
            this.Controls.Add(this.lblLatitude);
            this.Controls.Add(this.lblEasting);
            this.Controls.Add(this.lblNorthing);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblSatsTracked);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblFixQuality);
            this.Controls.Add(this.lblStatus);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormGPSData";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Diagnostics";
            this.Load += new System.EventHandler(this.FormGPSData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblFixQuality;
        private System.Windows.Forms.Label lblSatsTracked;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblEasting;
        private System.Windows.Forms.Label lblNorthing;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblHDOP;
        private System.Windows.Forms.TextBox tboxNMEASerial;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tboxRTCM;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label lblGyro;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label lblPDOP;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label lblVDOP;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label lblRtcmTrip;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblRTKAge;
        private System.Windows.Forms.TextBox tboxA1;
        private System.Windows.Forms.TextBox tboxGC;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
    }
}