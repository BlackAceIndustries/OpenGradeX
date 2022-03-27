namespace OpenGrade.Forms
{
    partial class FormNtripLog
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
            this.tBoxNtripLog = new System.Windows.Forms.RichTextBox();
            this.btnClearNtripLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxNtripLog
            // 
            this.tBoxNtripLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.tBoxNtripLog.Location = new System.Drawing.Point(1, 1);
            this.tBoxNtripLog.Name = "tBoxNtripLog";
            this.tBoxNtripLog.Size = new System.Drawing.Size(799, 399);
            this.tBoxNtripLog.TabIndex = 0;
            this.tBoxNtripLog.Text = "";
            // 
            // btnClearNtripLog
            // 
            this.btnClearNtripLog.Location = new System.Drawing.Point(25, 406);
            this.btnClearNtripLog.Name = "btnClearNtripLog";
            this.btnClearNtripLog.Size = new System.Drawing.Size(739, 37);
            this.btnClearNtripLog.TabIndex = 1;
            this.btnClearNtripLog.Text = "Clear Log";
            this.btnClearNtripLog.UseVisualStyleBackColor = true;
            // 
            // FormNtripLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearNtripLog);
            this.Controls.Add(this.tBoxNtripLog);
            this.Name = "FormNtripLog";
            this.Text = "NTRIP LOG";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox tBoxNtripLog;
        private System.Windows.Forms.Button btnClearNtripLog;
    }
}