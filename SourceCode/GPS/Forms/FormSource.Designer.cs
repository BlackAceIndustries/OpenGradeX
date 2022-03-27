﻿namespace OpenGrade
{
    partial class FormSource
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing && (components != null))
        //    {
        //        components.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lvLines = new System.Windows.Forms.ListView();
            this.chDistance = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chLon = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chFormat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.chNetwork = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tboxMount = new System.Windows.Forms.TextBox();
            this.lblCurrentAutoSteerPort = new System.Windows.Forms.Label();
            this.btnSite = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvLines
            // 
            this.lvLines.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lvLines.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lvLines.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.chDistance,
            this.chName,
            this.chLat,
            this.chLon,
            this.chFormat,
            this.chNetwork});
            this.lvLines.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvLines.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lvLines.GridLines = true;
            this.lvLines.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.lvLines.HideSelection = false;
            this.lvLines.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.lvLines.LabelWrap = false;
            this.lvLines.Location = new System.Drawing.Point(24, 4);
            this.lvLines.Margin = new System.Windows.Forms.Padding(6);
            this.lvLines.MultiSelect = false;
            this.lvLines.Name = "lvLines";
            this.lvLines.Size = new System.Drawing.Size(989, 521);
            this.lvLines.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.lvLines.TabIndex = 97;
            this.lvLines.UseCompatibleStateImageBehavior = false;
            this.lvLines.View = System.Windows.Forms.View.Details;
            this.lvLines.SelectedIndexChanged += new System.EventHandler(this.lvLines_SelectedIndexChanged);
            // 
            // chDistance
            // 
            this.chDistance.Text = "Distance";
            this.chDistance.Width = 150;
            // 
            // chName
            // 
            this.chName.Text = "Mount Point";
            this.chName.Width = 250;
            // 
            // chLat
            // 
            this.chLat.Text = "Lat";
            this.chLat.Width = 100;
            // 
            // chLon
            // 
            this.chLon.Text = "Lon";
            this.chLon.Width = 100;
            // 
            // chFormat
            // 
            this.chFormat.Text = "Format";
            this.chFormat.Width = 150;
            // 
            // chNetwork
            // 
            this.chNetwork.Text = "Network";
            this.chNetwork.Width = 220;
            // 
            // tboxMount
            // 
            this.tboxMount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tboxMount.BackColor = System.Drawing.SystemColors.InfoText;
            this.tboxMount.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxMount.ForeColor = System.Drawing.Color.Yellow;
            this.tboxMount.Location = new System.Drawing.Point(167, 532);
            this.tboxMount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tboxMount.Name = "tboxMount";
            this.tboxMount.ReadOnly = true;
            this.tboxMount.Size = new System.Drawing.Size(244, 33);
            this.tboxMount.TabIndex = 98;
            this.tboxMount.Text = "N/A";
            this.tboxMount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblCurrentAutoSteerPort
            // 
            this.lblCurrentAutoSteerPort.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblCurrentAutoSteerPort.AutoSize = true;
            this.lblCurrentAutoSteerPort.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentAutoSteerPort.Location = new System.Drawing.Point(42, 538);
            this.lblCurrentAutoSteerPort.Name = "lblCurrentAutoSteerPort";
            this.lblCurrentAutoSteerPort.Size = new System.Drawing.Size(118, 18);
            this.lblCurrentAutoSteerPort.TabIndex = 99;
            this.lblCurrentAutoSteerPort.Text = "Closest Mount:";
            // 
            // btnSite
            // 
            this.btnSite.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSite.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSite.Location = new System.Drawing.Point(630, 534);
            this.btnSite.Name = "btnSite";
            this.btnSite.Size = new System.Drawing.Size(157, 31);
            this.btnSite.TabIndex = 100;
            this.btnSite.Text = "Go To Site";
            this.btnSite.UseVisualStyleBackColor = true;
            this.btnSite.Click += new System.EventHandler(this.btnSite_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(839, 534);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 31);
            this.button1.TabIndex = 101;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1039, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSite);
            this.Controls.Add(this.lblCurrentAutoSteerPort);
            this.Controls.Add(this.tboxMount);
            this.Controls.Add(this.lvLines);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormSource";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Available NTRIP Base stations";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FormSource_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListView lvLines;
        private System.Windows.Forms.ColumnHeader chName;
        private System.Windows.Forms.ColumnHeader chLat;
        private System.Windows.Forms.ColumnHeader chLon;
        private System.Windows.Forms.TextBox tboxMount;
        private System.Windows.Forms.ColumnHeader chDistance;
        private System.Windows.Forms.Label lblCurrentAutoSteerPort;
        private System.Windows.Forms.Button btnSite;
        private System.Windows.Forms.ColumnHeader chFormat;
        private System.Windows.Forms.ColumnHeader chNetwork;
        private System.Windows.Forms.Button button1;
    }
}