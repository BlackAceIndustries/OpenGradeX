using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using System.Windows.Forms;

namespace OpenGrade
{
    partial class FormManualCtrl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManualCtrl));
            this.lblValve = new System.Windows.Forms.Label();
            this.lblCurrentPitch = new System.Windows.Forms.Label();
            this.lblPitchSlope = new System.Windows.Forms.Label();
            this.lblUserFour = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnValveAUp = new System.Windows.Forms.Button();
            this.btnValveADown = new System.Windows.Forms.Button();
            this.btnValveBDown = new System.Windows.Forms.Button();
            this.btnValveBUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTargetPitch = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblValve
            // 
            this.lblValve.BackColor = System.Drawing.Color.Gray;
            this.lblValve.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblValve.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblValve.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblValve.Location = new System.Drawing.Point(375, 10);
            this.lblValve.Name = "lblValve";
            this.lblValve.Size = new System.Drawing.Size(131, 75);
            this.lblValve.TabIndex = 0;
            this.lblValve.Text = "ENABLE";
            this.lblValve.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblValve.Click += new System.EventHandler(this.lblUserOne_Click);
            // 
            // lblCurrentPitch
            // 
            this.lblCurrentPitch.BackColor = System.Drawing.Color.Black;
            this.lblCurrentPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblCurrentPitch.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentPitch.Location = new System.Drawing.Point(145, 204);
            this.lblCurrentPitch.Name = "lblCurrentPitch";
            this.lblCurrentPitch.Size = new System.Drawing.Size(131, 31);
            this.lblCurrentPitch.TabIndex = 1;
            this.lblCurrentPitch.Text = "----";
            this.lblCurrentPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCurrentPitch.Click += new System.EventHandler(this.lblUserThree_Click);
            // 
            // lblPitchSlope
            // 
            this.lblPitchSlope.BackColor = System.Drawing.Color.Transparent;
            this.lblPitchSlope.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPitchSlope.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPitchSlope.ForeColor = System.Drawing.Color.AliceBlue;
            this.lblPitchSlope.Location = new System.Drawing.Point(8, 204);
            this.lblPitchSlope.Name = "lblPitchSlope";
            this.lblPitchSlope.Size = new System.Drawing.Size(131, 31);
            this.lblPitchSlope.TabIndex = 2;
            this.lblPitchSlope.Text = "Current Pitch:";
            this.lblPitchSlope.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPitchSlope.Click += new System.EventHandler(this.lblUserTwo_Click);
            // 
            // lblUserFour
            // 
            this.lblUserFour.BackColor = System.Drawing.Color.Gray;
            this.lblUserFour.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblUserFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserFour.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUserFour.Location = new System.Drawing.Point(336, 294);
            this.lblUserFour.Name = "lblUserFour";
            this.lblUserFour.Size = new System.Drawing.Size(275, 93);
            this.lblUserFour.TabIndex = 3;
            this.lblUserFour.Text = "800.250";
            this.lblUserFour.Click += new System.EventHandler(this.lblUserFour_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btnValveAUp
            // 
            this.btnValveAUp.BackColor = System.Drawing.Color.DimGray;
            this.btnValveAUp.Enabled = false;
            this.btnValveAUp.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnValveAUp.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValveAUp.Image = global::OpenGrade.Properties.Resources.UpArrow32;
            this.btnValveAUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnValveAUp.Location = new System.Drawing.Point(8, 6);
            this.btnValveAUp.Name = "btnValveAUp";
            this.btnValveAUp.Size = new System.Drawing.Size(131, 93);
            this.btnValveAUp.TabIndex = 71;
            this.btnValveAUp.UseVisualStyleBackColor = false;
            this.btnValveAUp.Click += new System.EventHandler(this.btnValveAUp_Click);
            this.btnValveAUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnValveAUp_MouseDown);
            this.btnValveAUp.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnValveAUp_MouseUp);
            // 
            // btnValveADown
            // 
            this.btnValveADown.BackColor = System.Drawing.Color.DimGray;
            this.btnValveADown.Enabled = false;
            this.btnValveADown.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnValveADown.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnValveADown.Image = global::OpenGrade.Properties.Resources.DnArrow32;
            this.btnValveADown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnValveADown.Location = new System.Drawing.Point(8, 102);
            this.btnValveADown.Name = "btnValveADown";
            this.btnValveADown.Size = new System.Drawing.Size(131, 93);
            this.btnValveADown.TabIndex = 71;
            this.btnValveADown.UseVisualStyleBackColor = false;
            this.btnValveADown.Click += new System.EventHandler(this.btnValveADown_Click_1);
            this.btnValveADown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnValveADown_MouseDown);
            this.btnValveADown.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnValveADown_MouseUp);
            // 
            // btnValveBDown
            // 
            this.btnValveBDown.BackColor = System.Drawing.Color.DimGray;
            this.btnValveBDown.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnValveBDown.ForeColor = System.Drawing.Color.White;
            this.btnValveBDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnValveBDown.Location = new System.Drawing.Point(145, 102);
            this.btnValveBDown.Name = "btnValveBDown";
            this.btnValveBDown.Size = new System.Drawing.Size(131, 93);
            this.btnValveBDown.TabIndex = 71;
            this.btnValveBDown.Text = "Decrease Pitch 1%";
            this.btnValveBDown.UseVisualStyleBackColor = false;
            this.btnValveBDown.Click += new System.EventHandler(this.btnValveBDown_Click);
            // 
            // btnValveBUp
            // 
            this.btnValveBUp.BackColor = System.Drawing.Color.DimGray;
            this.btnValveBUp.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnValveBUp.ForeColor = System.Drawing.Color.White;
            this.btnValveBUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnValveBUp.Location = new System.Drawing.Point(145, 6);
            this.btnValveBUp.Name = "btnValveBUp";
            this.btnValveBUp.Size = new System.Drawing.Size(131, 93);
            this.btnValveBUp.TabIndex = 71;
            this.btnValveBUp.Text = "Increase Pitch 1%";
            this.btnValveBUp.UseVisualStyleBackColor = false;
            this.btnValveBUp.Click += new System.EventHandler(this.btnValveBUp_Click_1);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(375, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 50);
            this.label1.TabIndex = 72;
            this.label1.Text = "VALVE B";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Image = global::OpenGrade.Properties.Resources.Cancel64;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(76, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 80);
            this.button1.TabIndex = 73;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.AliceBlue;
            this.label2.Location = new System.Drawing.Point(8, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 74;
            this.label2.Text = "Target Pitch:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblTargetPitch
            // 
            this.lblTargetPitch.BackColor = System.Drawing.Color.Black;
            this.lblTargetPitch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblTargetPitch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblTargetPitch.ForeColor = System.Drawing.Color.Yellow;
            this.lblTargetPitch.Location = new System.Drawing.Point(145, 242);
            this.lblTargetPitch.Name = "lblTargetPitch";
            this.lblTargetPitch.Size = new System.Drawing.Size(131, 31);
            this.lblTargetPitch.TabIndex = 75;
            this.lblTargetPitch.Text = "0.0";
            this.lblTargetPitch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.checkBox1.ForeColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(76, 288);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(150, 35);
            this.checkBox1.TabIndex = 76;
            this.checkBox1.Text = "AutoPitch";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FormManualCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(287, 423);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblTargetPitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnValveBUp);
            this.Controls.Add(this.btnValveBDown);
            this.Controls.Add(this.btnValveADown);
            this.Controls.Add(this.btnValveAUp);
            this.Controls.Add(this.lblUserFour);
            this.Controls.Add(this.lblPitchSlope);
            this.Controls.Add(this.lblCurrentPitch);
            this.Controls.Add(this.lblValve);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormManualCtrl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manual Valve Control";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAltSet_FormClosing);
            this.Load += new System.EventHandler(this.FormAltSet_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblValve;
        private System.Windows.Forms.Label lblCurrentPitch;
        private System.Windows.Forms.Label lblPitchSlope;
        private System.Windows.Forms.Label lblUserFour;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnValveAUp;
        private System.Windows.Forms.Button btnValveADown;
        private System.Windows.Forms.Button btnValveBDown;
        private System.Windows.Forms.Button btnValveBUp;
        private System.Windows.Forms.Label label1;
        private Button button1;
        private Timer timer2;
        private Timer timer3;
        private Label label2;
        private Label lblTargetPitch;
        private CheckBox checkBox1;
    }
}