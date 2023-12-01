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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2dSurvey));
            this.btnAutoDrain = new System.Windows.Forms.Button();
            this.openGLControlBack = new SharpGL.OpenGLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStripToDesign = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStriptoSurvey = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStripSlopeAuto = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStripShoreAuto = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStripAltitude = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStrip2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tStrip3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel12 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel11 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel10 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.vrbSave = new System.Windows.Forms.Button();
            this.btnSerialCancel = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDoneDraw = new System.Windows.Forms.Button();
            this.btnDeleteLastPoint = new System.Windows.Forms.Button();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlBack)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAutoDrain
            // 
            this.btnAutoDrain.BackColor = System.Drawing.Color.Lime;
            this.btnAutoDrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAutoDrain.Enabled = false;
            this.btnAutoDrain.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoDrain.Location = new System.Drawing.Point(4, 5);
            this.btnAutoDrain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAutoDrain.Name = "btnAutoDrain";
            this.btnAutoDrain.Size = new System.Drawing.Size(100, 100);
            this.btnAutoDrain.TabIndex = 242;
            this.btnAutoDrain.Text = "Auto Drain";
            this.btnAutoDrain.UseVisualStyleBackColor = false;
            this.btnAutoDrain.Click += new System.EventHandler(this.btnAutoDrain_Click);
            // 
            // openGLControlBack
            // 
            this.openGLControlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControlBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openGLControlBack.Cursor = System.Windows.Forms.Cursors.Cross;
            this.openGLControlBack.DrawFPS = false;
            this.openGLControlBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControlBack.Location = new System.Drawing.Point(112, 4);
            this.openGLControlBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.openGLControlBack.Name = "openGLControlBack";
            this.openGLControlBack.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControlBack.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControlBack.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControlBack.Size = new System.Drawing.Size(920, 400);
            this.openGLControlBack.TabIndex = 269;
            this.openGLControlBack.OpenGLInitialized += new System.EventHandler(this.openGLControlBack_OpenGLInitialized);
            this.openGLControlBack.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControlBack_OpenGLDraw);
            this.openGLControlBack.Resized += new System.EventHandler(this.openGLControlBack_Resized);
            this.openGLControlBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openGLControlBack_MouseClick);
            this.openGLControlBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControlBack_MouseMove);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel9,
            this.tStripToDesign,
            this.tStriptoSurvey,
            this.tStripSlopeAuto,
            this.tStripShoreAuto,
            this.tStripAltitude,
            this.tStrip2,
            this.tStrip3});
            this.statusStrip1.Location = new System.Drawing.Point(0, 408);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1139, 50);
            this.statusStrip1.TabIndex = 489;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.AutoSize = false;
            this.toolStripStatusLabel9.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel9.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel9.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(10, 50);
            // 
            // tStripToDesign
            // 
            this.tStripToDesign.AutoSize = false;
            this.tStripToDesign.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripToDesign.ForeColor = System.Drawing.Color.Aqua;
            this.tStripToDesign.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.tStripToDesign.Name = "tStripToDesign";
            this.tStripToDesign.Size = new System.Drawing.Size(150, 50);
            this.tStripToDesign.Text = "0.00";
            this.tStripToDesign.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tStriptoSurvey
            // 
            this.tStriptoSurvey.AutoSize = false;
            this.tStriptoSurvey.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStriptoSurvey.ForeColor = System.Drawing.Color.Yellow;
            this.tStriptoSurvey.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.tStriptoSurvey.Name = "tStriptoSurvey";
            this.tStriptoSurvey.Size = new System.Drawing.Size(150, 50);
            this.tStriptoSurvey.Text = "0.00";
            this.tStriptoSurvey.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tStripSlopeAuto
            // 
            this.tStripSlopeAuto.AutoSize = false;
            this.tStripSlopeAuto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripSlopeAuto.ForeColor = System.Drawing.Color.White;
            this.tStripSlopeAuto.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.tStripSlopeAuto.Name = "tStripSlopeAuto";
            this.tStripSlopeAuto.Size = new System.Drawing.Size(150, 50);
            this.tStripSlopeAuto.Text = "0.00";
            this.tStripSlopeAuto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tStripShoreAuto
            // 
            this.tStripShoreAuto.AutoSize = false;
            this.tStripShoreAuto.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripShoreAuto.ForeColor = System.Drawing.Color.White;
            this.tStripShoreAuto.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.tStripShoreAuto.Name = "tStripShoreAuto";
            this.tStripShoreAuto.Size = new System.Drawing.Size(150, 50);
            this.tStripShoreAuto.Text = "0.00";
            this.tStripShoreAuto.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tStripAltitude
            // 
            this.tStripAltitude.AutoSize = false;
            this.tStripAltitude.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripAltitude.ForeColor = System.Drawing.Color.White;
            this.tStripAltitude.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.tStripAltitude.Name = "tStripAltitude";
            this.tStripAltitude.Size = new System.Drawing.Size(150, 50);
            this.tStripAltitude.Text = "0.00";
            this.tStripAltitude.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tStrip2
            // 
            this.tStrip2.AutoSize = false;
            this.tStrip2.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStrip2.ForeColor = System.Drawing.Color.White;
            this.tStrip2.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.tStrip2.Name = "tStrip2";
            this.tStrip2.Size = new System.Drawing.Size(150, 50);
            this.tStrip2.Text = "0.00";
            this.tStrip2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tStrip3
            // 
            this.tStrip3.AutoSize = false;
            this.tStrip3.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStrip3.ForeColor = System.Drawing.Color.White;
            this.tStrip3.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.tStrip3.Name = "tStrip3";
            this.tStrip3.Size = new System.Drawing.Size(150, 50);
            this.tStrip3.Text = "0.00";
            this.tStrip3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // statusStrip2
            // 
            this.statusStrip2.AutoSize = false;
            this.statusStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel12,
            this.toolStripStatusLabel11,
            this.toolStripStatusLabel10,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel2});
            this.statusStrip2.Location = new System.Drawing.Point(0, 458);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip2.Size = new System.Drawing.Size(1139, 20);
            this.statusStrip2.TabIndex = 488;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.AutoSize = false;
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.Aqua;
            this.toolStripStatusLabel7.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel7.Text = "Distance to Cursor";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.AutoSize = false;
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.Yellow;
            this.toolStripStatusLabel8.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel8.Text = "Dist to Design";
            // 
            // toolStripStatusLabel12
            // 
            this.toolStripStatusLabel12.AutoSize = false;
            this.toolStripStatusLabel12.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel12.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel12.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel12.Name = "toolStripStatusLabel12";
            this.toolStripStatusLabel12.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel12.Text = "Auto Slope";
            // 
            // toolStripStatusLabel11
            // 
            this.toolStripStatusLabel11.AutoSize = false;
            this.toolStripStatusLabel11.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel11.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel11.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel11.Name = "toolStripStatusLabel11";
            this.toolStripStatusLabel11.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel11.Text = "Auto Shore";
            // 
            // toolStripStatusLabel10
            // 
            this.toolStripStatusLabel10.AutoSize = false;
            this.toolStripStatusLabel10.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel10.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel10.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel10.Name = "toolStripStatusLabel10";
            this.toolStripStatusLabel10.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel10.Text = "Altitude";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.AutoSize = false;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel5.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel5.Text = "T2";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.AutoSize = false;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Tahoma", 10F);
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(150, 20);
            this.toolStripStatusLabel2.Text = "Max Cut";
            // 
            // vrbSave
            // 
            this.vrbSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vrbSave.BackColor = System.Drawing.Color.DimGray;
            this.vrbSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.vrbSave.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.vrbSave.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.vrbSave.Image = global::OpenGrade.Properties.Resources.VehFileSave;
            this.vrbSave.Location = new System.Drawing.Point(1037, 104);
            this.vrbSave.Name = "vrbSave";
            this.vrbSave.Size = new System.Drawing.Size(100, 100);
            this.vrbSave.TabIndex = 268;
            this.vrbSave.Text = "SAVE";
            this.vrbSave.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.vrbSave.UseVisualStyleBackColor = false;
            this.vrbSave.Click += new System.EventHandler(this.vrbSave_Click);
            // 
            // btnSerialCancel
            // 
            this.btnSerialCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSerialCancel.BackColor = System.Drawing.Color.Black;
            this.btnSerialCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSerialCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnSerialCancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSerialCancel.ForeColor = System.Drawing.Color.Black;
            this.btnSerialCancel.Image = global::OpenGrade.Properties.Resources.Cancel64;
            this.btnSerialCancel.Location = new System.Drawing.Point(1037, 204);
            this.btnSerialCancel.Name = "btnSerialCancel";
            this.btnSerialCancel.Size = new System.Drawing.Size(100, 100);
            this.btnSerialCancel.TabIndex = 267;
            this.btnSerialCancel.UseVisualStyleBackColor = false;
            this.btnSerialCancel.Click += new System.EventHandler(this.btnSerialCancel_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button2.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(1037, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 100);
            this.button2.TabIndex = 266;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnDoneDraw
            // 
            this.btnDoneDraw.BackColor = System.Drawing.Color.DimGray;
            this.btnDoneDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoneDraw.Enabled = false;
            this.btnDoneDraw.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneDraw.Image = ((System.Drawing.Image)(resources.GetObject("btnDoneDraw.Image")));
            this.btnDoneDraw.Location = new System.Drawing.Point(4, 205);
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
            this.btnDeleteLastPoint.Location = new System.Drawing.Point(4, 305);
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
            this.btnStartDraw.Location = new System.Drawing.Point(4, 105);
            this.btnStartDraw.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(100, 100);
            this.btnStartDraw.TabIndex = 239;
            this.btnStartDraw.UseVisualStyleBackColor = false;
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Image = global::OpenGrade.Properties.Resources.OK64;
            this.button1.Location = new System.Drawing.Point(1037, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 100);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button3.Location = new System.Drawing.Point(417, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(229, 48);
            this.button3.TabIndex = 490;
            this.button3.Text = "SMOOTH LINE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(652, 98);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(229, 48);
            this.button4.TabIndex = 491;
            this.button4.Text = "ACCEPT SMOOTHING";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2dSurvey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.ClientSize = new System.Drawing.Size(1139, 478);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.openGLControlBack);
            this.Controls.Add(this.vrbSave);
            this.Controls.Add(this.btnSerialCancel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAutoDrain);
            this.Controls.Add(this.btnDoneDraw);
            this.Controls.Add(this.btnDeleteLastPoint);
            this.Controls.Add(this.btnStartDraw);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.HelpButton = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2dSurvey";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "2D Survey";
            this.Load += new System.EventHandler(this.Form2dSurvey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlBack)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
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
        private SharpGL.OpenGLControl openGLControlBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        private System.Windows.Forms.ToolStripStatusLabel tStripToDesign;
        private System.Windows.Forms.ToolStripStatusLabel tStriptoSurvey;
        public System.Windows.Forms.ToolStripStatusLabel tStrip3;
        private System.Windows.Forms.StatusStrip statusStrip2;
        public System.Windows.Forms.ToolStripStatusLabel tStripSlopeAuto;
        public System.Windows.Forms.ToolStripStatusLabel tStripShoreAuto;
        public System.Windows.Forms.ToolStripStatusLabel tStripAltitude;
        public System.Windows.Forms.ToolStripStatusLabel tStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel12;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel11;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel10;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}