namespace OpenGrade
{
    partial class FormSurveyStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSurveyStart));
            this.lblMessage = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblStepCnt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSurveyHeight = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblMessage
            // 
            resources.ApplyResources(this.lblMessage, "lblMessage");
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Click += new System.EventHandler(this.lblMessage_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblStepCnt
            // 
            resources.ApplyResources(this.lblStepCnt, "lblStepCnt");
            this.lblStepCnt.ForeColor = System.Drawing.Color.Yellow;
            this.lblStepCnt.Name = "lblStepCnt";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // lblSurveyHeight
            // 
            this.lblSurveyHeight.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lblSurveyHeight, "lblSurveyHeight");
            this.lblSurveyHeight.Name = "lblSurveyHeight";
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Lime;
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.ForeColor = System.Drawing.Color.Black;
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // FormSurveyStart
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ControlBox = false;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblSurveyHeight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblStepCnt);
            this.Controls.Add(this.lblMessage);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSurveyStart";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblStepCnt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSurveyHeight;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Timer timer2;
    }
}