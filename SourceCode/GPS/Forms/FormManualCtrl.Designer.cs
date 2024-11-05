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
            this.lblCurrentPitch = new System.Windows.Forms.Label();
            this.lblPitchSlope = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnValveAUp = new System.Windows.Forms.Button();
            this.btnValveADown = new System.Windows.Forms.Button();
            this.btnValveBDown = new System.Windows.Forms.Button();
            this.btnValveBUp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblTargetPitch = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkRed;
            this.button1.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(8, 329);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 80);
            this.button1.TabIndex = 73;
            this.button1.Text = "DISABLED";
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
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button2.Location = new System.Drawing.Point(419, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 93);
            this.button2.TabIndex = 77;
            this.button2.Text = "Increase Delta 1";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DimGray;
            this.button3.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button3.Location = new System.Drawing.Point(419, 102);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(131, 93);
            this.button3.TabIndex = 78;
            this.button3.Text = "Decrease Delta 1";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DimGray;
            this.button4.Enabled = false;
            this.button4.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Image = global::OpenGrade.Properties.Resources.DnArrow32;
            this.button4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button4.Location = new System.Drawing.Point(282, 102);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(131, 93);
            this.button4.TabIndex = 79;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DimGray;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Image = global::OpenGrade.Properties.Resources.UpArrow32;
            this.button5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button5.Location = new System.Drawing.Point(282, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 93);
            this.button5.TabIndex = 80;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(419, 279);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 31);
            this.label1.TabIndex = 84;
            this.label1.Text = "0.0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.AliceBlue;
            this.label3.Location = new System.Drawing.Point(282, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 31);
            this.label3.TabIndex = 83;
            this.label3.Text = "Target ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.AliceBlue;
            this.label4.Location = new System.Drawing.Point(282, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 31);
            this.label4.TabIndex = 82;
            this.label4.Text = "Setpoint";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.ForeColor = System.Drawing.Color.Yellow;
            this.label5.Location = new System.Drawing.Point(419, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 31);
            this.label5.TabIndex = 81;
            this.label5.Text = "----";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Transparent;
            this.button6.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button6.Location = new System.Drawing.Point(145, 331);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 80);
            this.button6.TabIndex = 85;
            this.button6.Text = "Settings";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Black;
            this.button7.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.button7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Image = global::OpenGrade.Properties.Resources.Cancel64;
            this.button7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button7.Location = new System.Drawing.Point(419, 329);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(131, 80);
            this.button7.TabIndex = 86;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(419, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 31);
            this.label6.TabIndex = 88;
            this.label6.Text = "0.0";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.AliceBlue;
            this.label7.Location = new System.Drawing.Point(282, 240);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 31);
            this.label7.TabIndex = 87;
            this.label7.Text = "PWM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // FormManualCtrl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(558, 423);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblTargetPitch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnValveBUp);
            this.Controls.Add(this.btnValveBDown);
            this.Controls.Add(this.btnValveADown);
            this.Controls.Add(this.btnValveAUp);
            this.Controls.Add(this.lblPitchSlope);
            this.Controls.Add(this.lblCurrentPitch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(574, 462);
            this.MinimumSize = new System.Drawing.Size(297, 462);
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
        private System.Windows.Forms.Label lblCurrentPitch;
        private System.Windows.Forms.Label lblPitchSlope;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnValveAUp;
        private System.Windows.Forms.Button btnValveADown;
        private System.Windows.Forms.Button btnValveBDown;
        private System.Windows.Forms.Button btnValveBUp;
        private Button button1;
        private Timer timer2;
        private Timer timer3;
        private Label label2;
        private Label lblTargetPitch;
        private CheckBox checkBox1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button6;
        private Button button7;
        private Label label6;
        private Label label7;
    }
}