namespace OpenGrade
{
    partial class FormCommSet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCommSet));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnRescan = new System.Windows.Forms.Button();
            this.btnSerialOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboxPort = new System.Windows.Forms.ComboBox();
            this.cboxBaud = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.lblCurrentPort = new System.Windows.Forms.Label();
            this.lblCurrentBaud = new System.Windows.Forms.Label();
            this.btnCloseSerial = new System.Windows.Forms.Button();
            this.textBoxRcv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOpenSerial = new System.Windows.Forms.Button();
            this.btnCloseSerialArduino = new System.Windows.Forms.Button();
            this.btnOpenSerialArduino = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCurrentGradeControlPort = new System.Windows.Forms.Label();
            this.cboxArdPort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBoxSendGradeControl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRecvGradeControl = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxSendAutoSteer = new System.Windows.Forms.TextBox();
            this.cboxASPort = new System.Windows.Forms.ComboBox();
            this.txtBoxRecvAutoSteer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentAutoSteerPort = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenSerialAutoSteer = new System.Windows.Forms.Button();
            this.btnCloseSerialAutoSteer = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnRescan
            // 
            this.btnRescan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.btnRescan, "btnRescan");
            this.btnRescan.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRescan.Name = "btnRescan";
            this.btnRescan.UseVisualStyleBackColor = false;
            this.btnRescan.Click += new System.EventHandler(this.btnRescan_Click);
            // 
            // btnSerialOK
            // 
            resources.ApplyResources(this.btnSerialOK, "btnSerialOK");
            this.btnSerialOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.btnSerialOK.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSerialOK.Name = "btnSerialOK";
            this.btnSerialOK.UseVisualStyleBackColor = false;
            this.btnSerialOK.Click += new System.EventHandler(this.btnSerialOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboxPort);
            this.groupBox1.Controls.Add(this.cboxBaud);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.lblCurrentPort);
            this.groupBox1.Controls.Add(this.lblCurrentBaud);
            this.groupBox1.Controls.Add(this.btnCloseSerial);
            this.groupBox1.Controls.Add(this.textBoxRcv);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnOpenSerial);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // cboxPort
            // 
            this.cboxPort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboxPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboxPort, "cboxPort");
            this.cboxPort.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxPort.FormattingEnabled = true;
            this.cboxPort.Items.AddRange(new object[] {
            resources.GetString("cboxPort.Items"),
            resources.GetString("cboxPort.Items1"),
            resources.GetString("cboxPort.Items2"),
            resources.GetString("cboxPort.Items3"),
            resources.GetString("cboxPort.Items4"),
            resources.GetString("cboxPort.Items5")});
            this.cboxPort.Name = "cboxPort";
            this.cboxPort.SelectedIndexChanged += new System.EventHandler(this.cboxPort_SelectedIndexChanged_1);
            // 
            // cboxBaud
            // 
            this.cboxBaud.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboxBaud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboxBaud, "cboxBaud");
            this.cboxBaud.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cboxBaud.FormattingEnabled = true;
            this.cboxBaud.Items.AddRange(new object[] {
            resources.GetString("cboxBaud.Items"),
            resources.GetString("cboxBaud.Items1"),
            resources.GetString("cboxBaud.Items2"),
            resources.GetString("cboxBaud.Items3"),
            resources.GetString("cboxBaud.Items4"),
            resources.GetString("cboxBaud.Items5")});
            this.cboxBaud.Name = "cboxBaud";
            this.cboxBaud.SelectedIndexChanged += new System.EventHandler(this.cboxBaud_SelectedIndexChanged_1);
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.Name = "label16";
            // 
            // lblCurrentPort
            // 
            resources.ApplyResources(this.lblCurrentPort, "lblCurrentPort");
            this.lblCurrentPort.Name = "lblCurrentPort";
            // 
            // lblCurrentBaud
            // 
            resources.ApplyResources(this.lblCurrentBaud, "lblCurrentBaud");
            this.lblCurrentBaud.Name = "lblCurrentBaud";
            this.lblCurrentBaud.Click += new System.EventHandler(this.lblCurrentBaud_Click);
            // 
            // btnCloseSerial
            // 
            this.btnCloseSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.btnCloseSerial, "btnCloseSerial");
            this.btnCloseSerial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloseSerial.Name = "btnCloseSerial";
            this.btnCloseSerial.UseVisualStyleBackColor = false;
            this.btnCloseSerial.Click += new System.EventHandler(this.btnCloseSerial_Click);
            // 
            // textBoxRcv
            // 
            resources.ApplyResources(this.textBoxRcv, "textBoxRcv");
            this.textBoxRcv.BackColor = System.Drawing.SystemColors.InfoText;
            this.textBoxRcv.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBoxRcv.Name = "textBoxRcv";
            this.textBoxRcv.ReadOnly = true;
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // btnOpenSerial
            // 
            this.btnOpenSerial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.btnOpenSerial, "btnOpenSerial");
            this.btnOpenSerial.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenSerial.Name = "btnOpenSerial";
            this.btnOpenSerial.UseVisualStyleBackColor = false;
            this.btnOpenSerial.Click += new System.EventHandler(this.btnOpenSerial_Click);
            // 
            // btnCloseSerialArduino
            // 
            this.btnCloseSerialArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.btnCloseSerialArduino, "btnCloseSerialArduino");
            this.btnCloseSerialArduino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCloseSerialArduino.Name = "btnCloseSerialArduino";
            this.btnCloseSerialArduino.UseVisualStyleBackColor = false;
            this.btnCloseSerialArduino.Click += new System.EventHandler(this.btnCloseSerialArduino_Click);
            // 
            // btnOpenSerialArduino
            // 
            this.btnOpenSerialArduino.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            resources.ApplyResources(this.btnOpenSerialArduino, "btnOpenSerialArduino");
            this.btnOpenSerialArduino.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnOpenSerialArduino.Name = "btnOpenSerialArduino";
            this.btnOpenSerialArduino.UseVisualStyleBackColor = false;
            this.btnOpenSerialArduino.Click += new System.EventHandler(this.btnOpenSerialArduino_Click);
            // 
            // label15
            // 
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // lblCurrentGradeControlPort
            // 
            resources.ApplyResources(this.lblCurrentGradeControlPort, "lblCurrentGradeControlPort");
            this.lblCurrentGradeControlPort.Name = "lblCurrentGradeControlPort";
            this.lblCurrentGradeControlPort.Click += new System.EventHandler(this.lblCurrentGradeControlPort_Click);
            // 
            // cboxArdPort
            // 
            this.cboxArdPort.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.cboxArdPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboxArdPort, "cboxArdPort");
            this.cboxArdPort.FormattingEnabled = true;
            this.cboxArdPort.Name = "cboxArdPort";
            this.cboxArdPort.SelectedIndexChanged += new System.EventHandler(this.cboxArdPort_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.txtBoxSendGradeControl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cboxArdPort);
            this.groupBox2.Controls.Add(this.txtBoxRecvGradeControl);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.lblCurrentGradeControlPort);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnOpenSerialArduino);
            this.groupBox2.Controls.Add(this.btnCloseSerialArduino);
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // txtBoxSendGradeControl
            // 
            this.txtBoxSendGradeControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.txtBoxSendGradeControl, "txtBoxSendGradeControl");
            this.txtBoxSendGradeControl.ForeColor = System.Drawing.Color.Yellow;
            this.txtBoxSendGradeControl.Name = "txtBoxSendGradeControl";
            this.txtBoxSendGradeControl.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxRecvGradeControl
            // 
            this.txtBoxRecvGradeControl.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.txtBoxRecvGradeControl, "txtBoxRecvGradeControl");
            this.txtBoxRecvGradeControl.ForeColor = System.Drawing.Color.Yellow;
            this.txtBoxRecvGradeControl.Name = "txtBoxRecvGradeControl";
            this.txtBoxRecvGradeControl.ReadOnly = true;
            this.txtBoxRecvGradeControl.TextChanged += new System.EventHandler(this.txtBoxSendGradeControl_TextChanged);
            // 
            // label17
            // 
            resources.ApplyResources(this.label17, "label17");
            this.label17.Name = "label17";
            // 
            // groupBox3
            // 
            resources.ApplyResources(this.groupBox3, "groupBox3");
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // txtBoxSendAutoSteer
            // 
            this.txtBoxSendAutoSteer.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtBoxSendAutoSteer, "txtBoxSendAutoSteer");
            this.txtBoxSendAutoSteer.Name = "txtBoxSendAutoSteer";
            this.txtBoxSendAutoSteer.ReadOnly = true;
            // 
            // cboxASPort
            // 
            this.cboxASPort.Cursor = System.Windows.Forms.Cursors.Default;
            this.cboxASPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cboxASPort, "cboxASPort");
            this.cboxASPort.FormattingEnabled = true;
            this.cboxASPort.Name = "cboxASPort";
            this.cboxASPort.SelectedIndexChanged += new System.EventHandler(this.cboxASPort_SelectedIndexChanged);
            // 
            // txtBoxRecvAutoSteer
            // 
            this.txtBoxRecvAutoSteer.BackColor = System.Drawing.SystemColors.Window;
            resources.ApplyResources(this.txtBoxRecvAutoSteer, "txtBoxRecvAutoSteer");
            this.txtBoxRecvAutoSteer.Name = "txtBoxRecvAutoSteer";
            this.txtBoxRecvAutoSteer.ReadOnly = true;
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // lblCurrentAutoSteerPort
            // 
            resources.ApplyResources(this.lblCurrentAutoSteerPort, "lblCurrentAutoSteerPort");
            this.lblCurrentAutoSteerPort.Name = "lblCurrentAutoSteerPort";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // btnOpenSerialAutoSteer
            // 
            this.btnOpenSerialAutoSteer.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.btnOpenSerialAutoSteer, "btnOpenSerialAutoSteer");
            this.btnOpenSerialAutoSteer.Name = "btnOpenSerialAutoSteer";
            this.btnOpenSerialAutoSteer.UseVisualStyleBackColor = false;
            this.btnOpenSerialAutoSteer.Click += new System.EventHandler(this.btnOpenSerialAutoSteer_Click);
            // 
            // btnCloseSerialAutoSteer
            // 
            this.btnCloseSerialAutoSteer.BackColor = System.Drawing.SystemColors.ControlLight;
            resources.ApplyResources(this.btnCloseSerialAutoSteer, "btnCloseSerialAutoSteer");
            this.btnCloseSerialAutoSteer.Name = "btnCloseSerialAutoSteer";
            this.btnCloseSerialAutoSteer.UseVisualStyleBackColor = false;
            this.btnCloseSerialAutoSteer.Click += new System.EventHandler(this.btnCloseSerialAutoSteer_Click);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // FormCommSet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ControlBox = false;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnRescan);
            this.Controls.Add(this.btnSerialOK);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormCommSet";
            this.Load += new System.EventHandler(this.FormCommSet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnRescan;
        private System.Windows.Forms.Button btnSerialOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label lblCurrentPort;
        private System.Windows.Forms.Label lblCurrentBaud;
        private System.Windows.Forms.Button btnCloseSerial;
        private System.Windows.Forms.TextBox textBoxRcv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOpenSerial;
        private System.Windows.Forms.ComboBox cboxBaud;
        private System.Windows.Forms.ComboBox cboxPort;
        private System.Windows.Forms.Button btnCloseSerialArduino;
        private System.Windows.Forms.Button btnOpenSerialArduino;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCurrentGradeControlPort;
        private System.Windows.Forms.TextBox txtBoxRecvGradeControl;
        private System.Windows.Forms.ComboBox cboxArdPort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxSendAutoSteer;
        private System.Windows.Forms.ComboBox cboxASPort;
        private System.Windows.Forms.TextBox txtBoxRecvAutoSteer;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentAutoSteerPort;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnOpenSerialAutoSteer;
        private System.Windows.Forms.Button btnCloseSerialAutoSteer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxSendGradeControl;
    }
}