namespace OpenGrade
{
    partial class Form2dSurvey
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2dSurvey));
            this.button1 = new System.Windows.Forms.Button();
            this.btnAutoDrain = new System.Windows.Forms.Button();
            this.btnDoneDraw = new System.Windows.Forms.Button();
            this.btnDeleteLastPoint = new System.Windows.Forms.Button();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.vrbSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Image = global::OpenGrade.Properties.Resources.OK64;
            this.button1.Location = new System.Drawing.Point(131, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 70);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAutoDrain
            // 
            this.btnAutoDrain.BackColor = System.Drawing.Color.Lime;
            this.btnAutoDrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAutoDrain.Enabled = false;
            this.btnAutoDrain.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoDrain.Location = new System.Drawing.Point(137, 134);
            this.btnAutoDrain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAutoDrain.Name = "btnAutoDrain";
            this.btnAutoDrain.Size = new System.Drawing.Size(100, 100);
            this.btnAutoDrain.TabIndex = 242;
            this.btnAutoDrain.Text = "Auto Drain";
            this.btnAutoDrain.UseVisualStyleBackColor = false;
            this.btnAutoDrain.Click += new System.EventHandler(this.btnAutoDrain_Click);
            // 
            // btnDoneDraw
            // 
            this.btnDoneDraw.BackColor = System.Drawing.Color.DimGray;
            this.btnDoneDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoneDraw.Enabled = false;
            this.btnDoneDraw.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneDraw.Image = ((System.Drawing.Image)(resources.GetObject("btnDoneDraw.Image")));
            this.btnDoneDraw.Location = new System.Drawing.Point(25, 24);
            this.btnDoneDraw.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDoneDraw.Name = "btnDoneDraw";
            this.btnDoneDraw.Size = new System.Drawing.Size(100, 100);
            this.btnDoneDraw.TabIndex = 241;
            this.btnDoneDraw.UseVisualStyleBackColor = false;
            this.btnDoneDraw.Click += new System.EventHandler(this.btnDoneDraw_Click);
            // 
            // btnDeleteLastPoint
            // 
            this.btnDeleteLastPoint.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteLastPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteLastPoint.Enabled = false;
            this.btnDeleteLastPoint.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLastPoint.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteLastPoint.Image")));
            this.btnDeleteLastPoint.Location = new System.Drawing.Point(25, 134);
            this.btnDeleteLastPoint.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDeleteLastPoint.Name = "btnDeleteLastPoint";
            this.btnDeleteLastPoint.Size = new System.Drawing.Size(100, 100);
            this.btnDeleteLastPoint.TabIndex = 240;
            this.btnDeleteLastPoint.UseVisualStyleBackColor = false;
            this.btnDeleteLastPoint.Click += new System.EventHandler(this.btnDeleteLastPoint_Click);
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.BackColor = System.Drawing.Color.DimGray;
            this.btnStartDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartDraw.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDraw.Image = ((System.Drawing.Image)(resources.GetObject("btnStartDraw.Image")));
            this.btnStartDraw.Location = new System.Drawing.Point(137, 24);
            this.btnStartDraw.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(100, 100);
            this.btnStartDraw.TabIndex = 239;
            this.btnStartDraw.UseVisualStyleBackColor = false;
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.BackColor = System.Drawing.Color.LightGray;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(25, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 266;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSerialCancel
            // 
            this.btnSerialCancel.BackColor = System.Drawing.Color.Black;
            this.btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialCancel.ForeColor = System.Drawing.Color.Black;
            this.btnSerialCancel.Image = global::OpenGrade.Properties.Resources.Cancel64;
            this.btnSerialCancel.Location = new System.Drawing.Point(33, 378);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(88, 71);
            this.btnSerialCancel.TabIndex = 267;
            this.btnSerialCancel.UseVisualStyleBackColor = false;
            this.btnSerialCancel.Click += new System.EventHandler(this.btnSerialCancel_Click);
            // 
            // vrbSave
            // 
            this.vrbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.vrbSave.BackColor = System.Drawing.Color.LightGray;
            this.vrbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vrbSave.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.vrbSave.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.vrbSave.Image = global::OpenGrade.Properties.Resources.VehFileSave;
            this.vrbSave.Location = new System.Drawing.Point(137, 242);
            this.vrbSave.Name = "vrbSave";
            this.vrbSave.Size = new System.Drawing.Size(100, 100);
            this.vrbSave.TabIndex = 268;
            this.vrbSave.UseVisualStyleBackColor = false;
            this.vrbSave.Click += new System.EventHandler(this.vrbSave_Click);
            // 
            // Form2dSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(255, 463);
            this.Controls.Add(this.vrbSave);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAutoDrain);
            this.Controls.Add(this.btnDoneDraw);
            this.Controls.Add(this.btnDeleteLastPoint);
            this.Controls.Add(this.btnStartDraw);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2dSurvey";
            this.ShowInTaskbar = false;
            this.Text = "2D Survey";
            this.Load += new System.EventHandler(this.Form_About_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAutoDrain;
        private System.Windows.Forms.Button btnDoneDraw;
        private System.Windows.Forms.Button btnDeleteLastPoint;
        private System.Windows.Forms.Button btnStartDraw;
        public System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnSerialCancel;
        public System.Windows.Forms.Button vrbSave;
    }
}