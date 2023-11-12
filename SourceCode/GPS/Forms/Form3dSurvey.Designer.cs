namespace OpenGrade
{
    partial class Form3dSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3dSurvey));
            this.button1 = new System.Windows.Forms.Button();
            this.btnFixQuality = new System.Windows.Forms.Button();
            this.btnBoundarySide = new System.Windows.Forms.Button();
            this.btnStartPause = new System.Windows.Forms.Button();
            this.btnManualOffOn = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddPoint = new System.Windows.Forms.Button();
            this.btnPointDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Image = global::OpenGrade.Properties.Resources.OK64;
            this.button1.Location = new System.Drawing.Point(335, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnFixQuality
            // 
            this.btnFixQuality.Location = new System.Drawing.Point(134, 31);
            this.btnFixQuality.Name = "btnFixQuality";
            this.btnFixQuality.Size = new System.Drawing.Size(69, 58);
            this.btnFixQuality.TabIndex = 263;
            this.btnFixQuality.Text = "RTK ONLY";
            this.btnFixQuality.UseVisualStyleBackColor = true;
            this.btnFixQuality.Click += new System.EventHandler(this.btnFixQuality_Click);
            // 
            // btnBoundarySide
            // 
            this.btnBoundarySide.Image = global::OpenGrade.Properties.Resources.BoundaryLeft;
            this.btnBoundarySide.Location = new System.Drawing.Point(13, 10);
            this.btnBoundarySide.Name = "btnBoundarySide";
            this.btnBoundarySide.Size = new System.Drawing.Size(100, 100);
            this.btnBoundarySide.TabIndex = 262;
            this.btnBoundarySide.UseVisualStyleBackColor = true;
            this.btnBoundarySide.Click += new System.EventHandler(this.btnBoundarySide_Click);
            // 
            // btnStartPause
            // 
            this.btnStartPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnStartPause.Font = new System.Drawing.Font("Tahoma", 22F, System.Drawing.FontStyle.Bold);
            this.btnStartPause.Image = global::OpenGrade.Properties.Resources.BoundaryRecord;
            this.btnStartPause.Location = new System.Drawing.Point(229, 114);
            this.btnStartPause.Name = "btnStartPause";
            this.btnStartPause.Size = new System.Drawing.Size(100, 100);
            this.btnStartPause.TabIndex = 261;
            this.btnStartPause.UseVisualStyleBackColor = true;
            this.btnStartPause.Visible = false;
            this.btnStartPause.Click += new System.EventHandler(this.btnStartPause_Click);
            // 
            // btnManualOffOn
            // 
            this.btnManualOffOn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnManualOffOn.BackColor = System.Drawing.Color.LightGray;
            this.btnManualOffOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManualOffOn.Enabled = false;
            this.btnManualOffOn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnManualOffOn.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnManualOffOn.Image = ((System.Drawing.Image)(resources.GetObject("btnManualOffOn.Image")));
            this.btnManualOffOn.Location = new System.Drawing.Point(-922, -72);
            this.btnManualOffOn.Name = "btnManualOffOn";
            this.btnManualOffOn.Size = new System.Drawing.Size(90, 90);
            this.btnManualOffOn.TabIndex = 260;
            this.btnManualOffOn.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(13, 114);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 265;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddPoint
            // 
            this.btnAddPoint.Image = global::OpenGrade.Properties.Resources.PointAdd;
            this.btnAddPoint.Location = new System.Drawing.Point(335, 10);
            this.btnAddPoint.Name = "btnAddPoint";
            this.btnAddPoint.Size = new System.Drawing.Size(100, 100);
            this.btnAddPoint.TabIndex = 266;
            this.btnAddPoint.UseVisualStyleBackColor = true;
            this.btnAddPoint.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPointDelete
            // 
            this.btnPointDelete.Image = global::OpenGrade.Properties.Resources.PointDelete;
            this.btnPointDelete.Location = new System.Drawing.Point(229, 10);
            this.btnPointDelete.Name = "btnPointDelete";
            this.btnPointDelete.Size = new System.Drawing.Size(100, 100);
            this.btnPointDelete.TabIndex = 267;
            this.btnPointDelete.UseVisualStyleBackColor = true;
            this.btnPointDelete.Click += new System.EventHandler(this.btnPointDelete_Click);
            // 
            // Form3dSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(450, 226);
            this.Controls.Add(this.btnPointDelete);
            this.Controls.Add(this.btnAddPoint);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnFixQuality);
            this.Controls.Add(this.btnBoundarySide);
            this.Controls.Add(this.btnStartPause);
            this.Controls.Add(this.btnManualOffOn);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form3dSurvey";
            this.Text = "3D Survey";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_About_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnFixQuality;
        private System.Windows.Forms.Button btnBoundarySide;
        private System.Windows.Forms.Button btnStartPause;
        public System.Windows.Forms.Button btnManualOffOn;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddPoint;
        private System.Windows.Forms.Button btnPointDelete;
    }
}