namespace OpenGrade
{
    partial class FormRemote
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

        /// <summary>
        ///  Everything the class will use. 
        /// </summary>
        public bool isAuto = true, isResume = true, isOpen = true, isCut = true;

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        /// 

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRemote));
            this.btnCancelChanges = new System.Windows.Forms.Button();
            this.btnRemoteSaveSettings = new System.Windows.Forms.Button();
            this.lblRemote = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.listA = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.listB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listX = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listY = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.listUp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.listDown = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.listLeft = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.listRight = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listStart = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelChanges
            // 
            this.btnCancelChanges.BackColor = System.Drawing.Color.Black;
            this.btnCancelChanges.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancelChanges.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelChanges.Image = global::OpenGrade.Properties.Resources.Cancel64;
            this.btnCancelChanges.Location = new System.Drawing.Point(438, 399);
            this.btnCancelChanges.Name = "btnCancelChanges";
            this.btnCancelChanges.Size = new System.Drawing.Size(98, 95);
            this.btnCancelChanges.TabIndex = 0;
            this.btnCancelChanges.UseVisualStyleBackColor = false;
            this.btnCancelChanges.Click += new System.EventHandler(this.btnCancelChanges_Click);
            // 
            // btnRemoteSaveSettings
            // 
            this.btnRemoteSaveSettings.BackColor = System.Drawing.Color.Black;
            this.btnRemoteSaveSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRemoteSaveSettings.Image = global::OpenGrade.Properties.Resources.FileSave;
            this.btnRemoteSaveSettings.Location = new System.Drawing.Point(230, 399);
            this.btnRemoteSaveSettings.Name = "btnRemoteSaveSettings";
            this.btnRemoteSaveSettings.Size = new System.Drawing.Size(98, 95);
            this.btnRemoteSaveSettings.TabIndex = 1;
            this.btnRemoteSaveSettings.UseVisualStyleBackColor = false;
            this.btnRemoteSaveSettings.Click += new System.EventHandler(this.btnRemoteSaveSettings_Click);
            // 
            // lblRemote
            // 
            this.lblRemote.BackColor = System.Drawing.Color.Transparent;
            this.lblRemote.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRemote.Image = global::OpenGrade.Properties.Resources.BTRemote;
            this.lblRemote.Location = new System.Drawing.Point(282, 20);
            this.lblRemote.Name = "lblRemote";
            this.lblRemote.Size = new System.Drawing.Size(187, 376);
            this.lblRemote.TabIndex = 2;
            this.lblRemote.Text = "BT REMOTE";
            this.lblRemote.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnReturn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnReturn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnReturn.Image = global::OpenGrade.Properties.Resources.back_button;
            this.btnReturn.Location = new System.Drawing.Point(334, 399);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(98, 95);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // listA
            // 
            this.listA.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listA.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listA.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listA.FormattingEnabled = true;
            this.listA.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listA.Location = new System.Drawing.Point(503, 106);
            this.listA.Name = "listA";
            this.listA.Size = new System.Drawing.Size(207, 32);
            this.listA.TabIndex = 5;
            this.listA.SelectedIndexChanged += new System.EventHandler(this.listA_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(477, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(477, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "B";
            // 
            // listB
            // 
            this.listB.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listB.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listB.FormattingEnabled = true;
            this.listB.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listB.Location = new System.Drawing.Point(503, 156);
            this.listB.Name = "listB";
            this.listB.Size = new System.Drawing.Size(207, 32);
            this.listB.TabIndex = 7;
            this.listB.SelectedIndexChanged += new System.EventHandler(this.listB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(477, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "X";
            // 
            // listX
            // 
            this.listX.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listX.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listX.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listX.FormattingEnabled = true;
            this.listX.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listX.Location = new System.Drawing.Point(503, 208);
            this.listX.Name = "listX";
            this.listX.Size = new System.Drawing.Size(207, 32);
            this.listX.TabIndex = 9;
            this.listX.SelectedIndexChanged += new System.EventHandler(this.listX_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(477, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Y";
            // 
            // listY
            // 
            this.listY.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listY.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listY.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listY.FormattingEnabled = true;
            this.listY.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listY.Location = new System.Drawing.Point(503, 263);
            this.listY.Name = "listY";
            this.listY.Size = new System.Drawing.Size(207, 32);
            this.listY.TabIndex = 11;
            this.listY.SelectedIndexChanged += new System.EventHandler(this.listY_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(45, 112);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "UP";
            // 
            // listUp
            // 
            this.listUp.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listUp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listUp.FormattingEnabled = true;
            this.listUp.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listUp.Location = new System.Drawing.Point(81, 106);
            this.listUp.Name = "listUp";
            this.listUp.Size = new System.Drawing.Size(207, 32);
            this.listUp.TabIndex = 13;
            this.listUp.SelectedIndexChanged += new System.EventHandler(this.listUp_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(17, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "DOWN";
            // 
            // listDown
            // 
            this.listDown.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listDown.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listDown.FormattingEnabled = true;
            this.listDown.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listDown.Location = new System.Drawing.Point(81, 156);
            this.listDown.Name = "listDown";
            this.listDown.Size = new System.Drawing.Size(207, 32);
            this.listDown.TabIndex = 15;
            this.listDown.SelectedIndexChanged += new System.EventHandler(this.ListDown_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(28, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "LEFT";
            // 
            // listLeft
            // 
            this.listLeft.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLeft.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listLeft.FormattingEnabled = true;
            this.listLeft.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listLeft.Location = new System.Drawing.Point(81, 208);
            this.listLeft.Name = "listLeft";
            this.listLeft.Size = new System.Drawing.Size(207, 32);
            this.listLeft.TabIndex = 17;
            this.listLeft.SelectedIndexChanged += new System.EventHandler(this.listLeft_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(16, 269);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "RIGHT";
            // 
            // listRight
            // 
            this.listRight.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listRight.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listRight.FormattingEnabled = true;
            this.listRight.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listRight.Location = new System.Drawing.Point(81, 263);
            this.listRight.Name = "listRight";
            this.listRight.Size = new System.Drawing.Size(207, 32);
            this.listRight.TabIndex = 19;
            this.listRight.SelectedIndexChanged += new System.EventHandler(this.listRight_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(362, 297);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(23, 24);
            this.label10.TabIndex = 21;
            this.label10.Text = "A";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(330, 264);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 24);
            this.label11.TabIndex = 22;
            this.label11.Text = "X";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(397, 264);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 24);
            this.label12.TabIndex = 23;
            this.label12.Text = "Y";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(365, 232);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(22, 24);
            this.label13.TabIndex = 24;
            this.label13.Text = "B";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(15, 322);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 26;
            this.label1.Text = "START";
            // 
            // listStart
            // 
            this.listStart.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.listStart.FormattingEnabled = true;
            this.listStart.Items.AddRange(new object[] {
            "Toggle Auto Cut",
            "Toggle Survey",
            "Open GPS Data",
            "Increase Blade Offset",
            "Decrease Blade Offset",
            "Reset Blade Offset",
            "Open Job",
            "Save Cut"});
            this.listStart.Location = new System.Drawing.Point(81, 316);
            this.listStart.Name = "listStart";
            this.listStart.Size = new System.Drawing.Size(207, 32);
            this.listStart.TabIndex = 25;
            this.listStart.SelectedIndexChanged += new System.EventHandler(this.listStart_SelectedIndexChanged);
            // 
            // FormRemote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(742, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listStart);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listRight);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.listLeft);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.listDown);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.listUp);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listA);
            this.Controls.Add(this.btnCancelChanges);
            this.Controls.Add(this.btnRemoteSaveSettings);
            this.Controls.Add(this.lblRemote);
            this.Controls.Add(this.btnReturn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormRemote";
            this.ShowIcon = false;
            this.Text = "Configure Remote";
            this.Load += new System.EventHandler(this.FormRemote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblRemote;
        private System.Windows.Forms.Button btnRemoteSaveSettings;
        private System.Windows.Forms.Button btnCancelChanges;
        private System.Windows.Forms.ComboBox listA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox listB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox listUp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox listDown;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox listLeft;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox listRight;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox listStart;
    }

}





