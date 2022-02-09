namespace OpenGrade
{
    partial class FormGPS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGPS));
            ProgBar.cBlendItems cBlendItems1 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints1 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems2 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints2 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems3 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints3 = new ProgBar.cFocalPoints();
            ProgBar.cBlendItems cBlendItems4 = new ProgBar.cBlendItems();
            ProgBar.cFocalPoints cFocalPoints4 = new ProgBar.cFocalPoints();
            this.openGLControl = new SharpGL.OpenGLControl();
            this.contextMenuStripOpenGL = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteFlagToolOpenGLContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.googleEarthOpenGLContextMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.txtDistanceOffABLine = new System.Windows.Forms.TextBox();
            this.openGLControlBack = new SharpGL.OpenGLControl();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.setWorkingDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.loadVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.fieldToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.resetALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.colorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripUnitsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.metricToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.imperialToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.gridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightbarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polygonsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logNMEAMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pursuitLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skyToolStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.simulatorOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.remoteConfigurationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.explorerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webCamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fieldViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleEarthToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gPSDataToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuHelpHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.resetModulesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAntennaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetGradeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zeroIMUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrWatchdog = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripMinMax = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownBtnFuncs = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstripField = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripResetTrip = new System.Windows.Forms.ToolStripMenuItem();
            this.stripDistance = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripEqWidth = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolstripUDPConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripVehicleConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.stripTopoLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripOnlineGPS = new System.Windows.Forms.ToolStripProgressBar();
            this.stripOnlineAutoSteer = new System.Windows.Forms.ToolStripProgressBar();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.contextMenuStripFlag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemFlagRed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFlagGrn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFlagYel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuFlagDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuFlagDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSpeedUnits = new System.Windows.Forms.Label();
            this.lblHeading = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lblDrawSlope = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCutFillRatio = new System.Windows.Forms.Label();
            this.lblFill = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.lblCut = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.lblAltitude = new System.Windows.Forms.Label();
            this.panelSimControls = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetSteerAngle = new System.Windows.Forms.Button();
            this.btnResetSim = new System.Windows.Forms.Button();
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbarSteerAngle = new System.Windows.Forms.TrackBar();
            this.tbarStepDistance = new System.Windows.Forms.TrackBar();
            this.nudElevation = new System.Windows.Forms.NumericUpDown();
            this.sqrCutLine = new System.Windows.Forms.Label();
            this.timerSim = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.pbarCutBelow = new ProgBar.ProgBarPlus();
            this.pbarCutAbove = new ProgBar.ProgBarPlus();
            this.lblBarGraphMax = new System.Windows.Forms.Label();
            this.OpenGradePage = new System.Windows.Forms.TabPage();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCurrentCutDepth = new System.Windows.Forms.Label();
            this.lblDistToTarget = new System.Windows.Forms.Label();
            this.btnSaveCut = new System.Windows.Forms.Button();
            this.btnAutoDrain = new System.Windows.Forms.Button();
            this.lblDistanceToCut = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCutDelta = new System.Windows.Forms.Label();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnSurface = new System.Windows.Forms.Button();
            this.btnDoneDraw = new System.Windows.Forms.Button();
            this.btnDeleteLastPoint = new System.Windows.Forms.Button();
            this.btnStartDraw = new System.Windows.Forms.Button();
            this.btnClearLastPass = new System.Windows.Forms.Button();
            this.SettingsPage = new System.Windows.Forms.TabPage();
            this.connectionGroupBox = new System.Windows.Forms.GroupBox();
            this.ledGradeControl = new System.Windows.Forms.Button();
            this.ledAntenna = new System.Windows.Forms.Button();
            this.lblUdpConnected = new System.Windows.Forms.Label();
            this.lblAntennaConnected = new System.Windows.Forms.Label();
            this.btnFileExplorer = new System.Windows.Forms.Button();
            this.btnABLine = new System.Windows.Forms.Button();
            this.btnUnits = new System.Windows.Forms.Button();
            this.btnGPSData = new System.Windows.Forms.Button();
            this.btnFlag = new System.Windows.Forms.Button();
            this.btnSnap = new System.Windows.Forms.Button();
            this.btnGoogleEarth = new System.Windows.Forms.Button();
            this.GPSPage = new System.Windows.Forms.TabPage();
            this.alt = new System.Windows.Forms.Label();
            this.lblAltitude2 = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.lblSats = new System.Windows.Forms.Label();
            this.lblFixQuality = new System.Windows.Forms.Label();
            this.lblGPSHeading = new System.Windows.Forms.Label();
            this.lblZone = new System.Windows.Forms.Label();
            this.lblEasting = new System.Windows.Forms.Label();
            this.lblNorthing = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblGyroHeading = new System.Windows.Forms.Label();
            this.tboxSentence = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tabGradeControl = new System.Windows.Forms.TabControl();
            this.lblDiagnostics = new System.Windows.Forms.TextBox();
            this.lblMaxDepth = new System.Windows.Forms.Label();
            this.lblMinCover = new System.Windows.Forms.Label();
            this.sqrMinCover = new System.Windows.Forms.Button();
            this.sqrMaxDepth = new System.Windows.Forms.Button();
            this.sqrCutLine1 = new System.Windows.Forms.Button();
            this.lblCutLine = new System.Windows.Forms.Label();
            this.sqrDitchCutLine = new System.Windows.Forms.Button();
            this.lblDitchCutLine = new System.Windows.Forms.Label();
            this.btnContour = new System.Windows.Forms.Button();
            this.btnGradeControl = new System.Windows.Forms.Button();
            this.btnZoomIn = new ProXoft.WinForms.RepeatButton();
            this.btnTiltDown = new ProXoft.WinForms.RepeatButton();
            this.btnZoomOut = new ProXoft.WinForms.RepeatButton();
            this.btnTiltUp = new ProXoft.WinForms.RepeatButton();
            this.btnManualOffOn = new System.Windows.Forms.Button();
            this.voltageBar = new ProgBar.ProgBarPlus();
            this.lblMaxVoltage = new System.Windows.Forms.Label();
            this.lblMinVoltage = new System.Windows.Forms.Label();
            this.lblFloatVoltage = new System.Windows.Forms.Label();
            this.lblBladeOffset = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAutoCut = new System.Windows.Forms.Button();
            this.btnIncCut = new System.Windows.Forms.Button();
            this.btnDecCut = new System.Windows.Forms.Button();
            this.lblAutoCutDepth = new System.Windows.Forms.Label();
            this.lblPassDepth = new System.Windows.Forms.Label();
            this.voltageBar2 = new ProgBar.ProgBarPlus();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnAutoShore = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.contextMenuStripOpenGL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlBack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripFlag.SuspendLayout();
            this.panelSimControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElevation)).BeginInit();
            this.OpenGradePage.SuspendLayout();
            this.SettingsPage.SuspendLayout();
            this.connectionGroupBox.SuspendLayout();
            this.GPSPage.SuspendLayout();
            this.tabGradeControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openGLControl.ContextMenuStrip = this.contextMenuStripOpenGL;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.openGLControl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControl.FrameRate = 5;
            this.openGLControl.Location = new System.Drawing.Point(5, 46);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControl.Size = new System.Drawing.Size(624, 300);
            this.openGLControl.TabIndex = 6;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.Load += new System.EventHandler(this.openGLControl_Load);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            // 
            // contextMenuStripOpenGL
            // 
            this.contextMenuStripOpenGL.AutoSize = false;
            this.contextMenuStripOpenGL.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteFlagToolOpenGLContextMenu,
            this.toolStripSeparator5,
            this.googleEarthOpenGLContextMenu});
            this.contextMenuStripOpenGL.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStripOpenGL.Name = "contextMenuStripOpenGL";
            this.contextMenuStripOpenGL.Size = new System.Drawing.Size(72, 160);
            this.contextMenuStripOpenGL.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripOpenGL_Opening);
            // 
            // deleteFlagToolOpenGLContextMenu
            // 
            this.deleteFlagToolOpenGLContextMenu.AutoSize = false;
            this.deleteFlagToolOpenGLContextMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.deleteFlagToolOpenGLContextMenu.Image = ((System.Drawing.Image)(resources.GetObject("deleteFlagToolOpenGLContextMenu.Image")));
            this.deleteFlagToolOpenGLContextMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteFlagToolOpenGLContextMenu.Name = "deleteFlagToolOpenGLContextMenu";
            this.deleteFlagToolOpenGLContextMenu.Size = new System.Drawing.Size(70, 70);
            this.deleteFlagToolOpenGLContextMenu.Text = ".";
            this.deleteFlagToolOpenGLContextMenu.Click += new System.EventHandler(this.deleteFlagToolOpenGLContextMenu_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(68, 6);
            // 
            // googleEarthOpenGLContextMenu
            // 
            this.googleEarthOpenGLContextMenu.AutoSize = false;
            this.googleEarthOpenGLContextMenu.Image = ((System.Drawing.Image)(resources.GetObject("googleEarthOpenGLContextMenu.Image")));
            this.googleEarthOpenGLContextMenu.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.googleEarthOpenGLContextMenu.Name = "googleEarthOpenGLContextMenu";
            this.googleEarthOpenGLContextMenu.Size = new System.Drawing.Size(70, 70);
            this.googleEarthOpenGLContextMenu.Text = ".";
            this.googleEarthOpenGLContextMenu.Click += new System.EventHandler(this.googleEarthOpenGLContextMenu_Click);
            // 
            // txtDistanceOffABLine
            // 
            this.txtDistanceOffABLine.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDistanceOffABLine.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtDistanceOffABLine.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDistanceOffABLine.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.txtDistanceOffABLine.ForeColor = System.Drawing.Color.Green;
            this.txtDistanceOffABLine.Location = new System.Drawing.Point(261, 301);
            this.txtDistanceOffABLine.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.txtDistanceOffABLine.Name = "txtDistanceOffABLine";
            this.txtDistanceOffABLine.ReadOnly = true;
            this.txtDistanceOffABLine.Size = new System.Drawing.Size(110, 36);
            this.txtDistanceOffABLine.TabIndex = 7;
            this.txtDistanceOffABLine.Text = "00000";
            this.txtDistanceOffABLine.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.openGLControlBack.FrameRate = 5;
            this.openGLControlBack.Location = new System.Drawing.Point(4, 348);
            this.openGLControlBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.openGLControlBack.Name = "openGLControlBack";
            this.openGLControlBack.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControlBack.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControlBack.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControlBack.Size = new System.Drawing.Size(1175, 289);
            this.openGLControlBack.TabIndex = 91;
            this.openGLControlBack.OpenGLInitialized += new System.EventHandler(this.openGLControlBack_OpenGLInitialized);
            this.openGLControlBack.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControlBack_OpenGLDraw);
            this.openGLControlBack.Resized += new System.EventHandler(this.openGLControlBack_Resized);
            this.openGLControlBack.MouseClick += new System.Windows.Forms.MouseEventHandler(this.openGLControlBack_MouseClick);
            this.openGLControlBack.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControlBack_MouseMove);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator9,
            this.toolStripSeparator11,
            this.setWorkingDirectoryToolStripMenuItem,
            this.toolStripSeparator10,
            this.loadVehicleToolStripMenuItem,
            this.saveVehicleToolStripMenuItem,
            this.toolStripSeparator8,
            this.fieldToolStripMenuItem,
            this.fullscreenToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(69, 38);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(255, 6);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(255, 6);
            // 
            // setWorkingDirectoryToolStripMenuItem
            // 
            this.setWorkingDirectoryToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.setWorkingDirectoryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.setWorkingDirectoryToolStripMenuItem.Name = "setWorkingDirectoryToolStripMenuItem";
            this.setWorkingDirectoryToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.setWorkingDirectoryToolStripMenuItem.Text = "Directories";
            this.setWorkingDirectoryToolStripMenuItem.Click += new System.EventHandler(this.setWorkingDirectoryToolStripMenuItem_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStripSeparator10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(255, 6);
            // 
            // loadVehicleToolStripMenuItem
            // 
            this.loadVehicleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.loadVehicleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadVehicleToolStripMenuItem.Name = "loadVehicleToolStripMenuItem";
            this.loadVehicleToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.loadVehicleToolStripMenuItem.Text = "Load Vehicle";
            this.loadVehicleToolStripMenuItem.Click += new System.EventHandler(this.loadVehicleToolStripMenuItem_Click);
            // 
            // saveVehicleToolStripMenuItem
            // 
            this.saveVehicleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.saveVehicleToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.saveVehicleToolStripMenuItem.Name = "saveVehicleToolStripMenuItem";
            this.saveVehicleToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.saveVehicleToolStripMenuItem.Text = "Save Vehicle";
            this.saveVehicleToolStripMenuItem.Click += new System.EventHandler(this.saveVehicleToolStripMenuItem_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStripSeparator8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(255, 6);
            // 
            // fieldToolStripMenuItem
            // 
            this.fieldToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fieldToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fieldToolStripMenuItem.Name = "fieldToolStripMenuItem";
            this.fieldToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.fieldToolStripMenuItem.Text = "Start Field";
            this.fieldToolStripMenuItem.Click += new System.EventHandler(this.fieldToolStripMenuItem_Click);
            // 
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fullscreenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.fullscreenToolStripMenuItem.Text = "Full-Screen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.exitToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(258, 40);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.resetALLToolStripMenuItem,
            this.toolStripSeparator2,
            this.colorsToolStripMenuItem,
            this.toolStripUnitsMenu,
            this.gridToolStripMenuItem,
            this.lightbarToolStripMenuItem,
            this.polygonsToolStripMenuItem,
            this.logNMEAMenuItem,
            this.pursuitLineToolStripMenuItem,
            this.skyToolStripMenu,
            this.toolStripSeparator6,
            this.simulatorOnToolStripMenuItem,
            this.toolStripSeparator7});
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(118, 38);
            this.settingsToolStripMenuItem.Text = "Display";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(260, 6);
            // 
            // resetALLToolStripMenuItem
            // 
            this.resetALLToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.resetALLToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetALLToolStripMenuItem.Name = "resetALLToolStripMenuItem";
            this.resetALLToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.resetALLToolStripMenuItem.Text = "Reset ALL";
            this.resetALLToolStripMenuItem.Click += new System.EventHandler(this.resetALLToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStripSeparator2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(260, 6);
            // 
            // colorsToolStripMenuItem
            // 
            this.colorsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.colorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sectionToolStripMenuItem,
            this.fieldToolStripMenuItem1});
            this.colorsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.colorsToolStripMenuItem.Name = "colorsToolStripMenuItem";
            this.colorsToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.colorsToolStripMenuItem.Text = "Colors";
            // 
            // sectionToolStripMenuItem
            // 
            this.sectionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.sectionToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.sectionToolStripMenuItem.Name = "sectionToolStripMenuItem";
            this.sectionToolStripMenuItem.Size = new System.Drawing.Size(187, 40);
            this.sectionToolStripMenuItem.Text = "Section";
            this.sectionToolStripMenuItem.Click += new System.EventHandler(this.sectionToolStripMenuItem_Click);
            // 
            // fieldToolStripMenuItem1
            // 
            this.fieldToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fieldToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fieldToolStripMenuItem1.Name = "fieldToolStripMenuItem1";
            this.fieldToolStripMenuItem1.Size = new System.Drawing.Size(187, 40);
            this.fieldToolStripMenuItem1.Text = "Field";
            this.fieldToolStripMenuItem1.Click += new System.EventHandler(this.fieldToolStripMenuItem1_Click);
            // 
            // toolStripUnitsMenu
            // 
            this.toolStripUnitsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStripUnitsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.metricToolStrip,
            this.imperialToolStrip});
            this.toolStripUnitsMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripUnitsMenu.Name = "toolStripUnitsMenu";
            this.toolStripUnitsMenu.Size = new System.Drawing.Size(263, 40);
            this.toolStripUnitsMenu.Text = "Units";
            // 
            // metricToolStrip
            // 
            this.metricToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.metricToolStrip.CheckOnClick = true;
            this.metricToolStrip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.metricToolStrip.Name = "metricToolStrip";
            this.metricToolStrip.Size = new System.Drawing.Size(200, 40);
            this.metricToolStrip.Text = "Metric";
            this.metricToolStrip.Click += new System.EventHandler(this.metricToolStrip_Click);
            // 
            // imperialToolStrip
            // 
            this.imperialToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.imperialToolStrip.CheckOnClick = true;
            this.imperialToolStrip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.imperialToolStrip.Name = "imperialToolStrip";
            this.imperialToolStrip.Size = new System.Drawing.Size(200, 40);
            this.imperialToolStrip.Text = "Imperial";
            this.imperialToolStrip.Click += new System.EventHandler(this.imperialToolStrip_Click);
            // 
            // gridToolStripMenuItem
            // 
            this.gridToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gridToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gridToolStripMenuItem.Name = "gridToolStripMenuItem";
            this.gridToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.gridToolStripMenuItem.Text = "Grid On";
            this.gridToolStripMenuItem.Click += new System.EventHandler(this.gridToolStripMenuItem_Click);
            // 
            // lightbarToolStripMenuItem
            // 
            this.lightbarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.lightbarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lightbarToolStripMenuItem.Name = "lightbarToolStripMenuItem";
            this.lightbarToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.lightbarToolStripMenuItem.Text = "Lightbar On";
            this.lightbarToolStripMenuItem.Click += new System.EventHandler(this.lightbarToolStripMenuItem_Click);
            // 
            // polygonsToolStripMenuItem
            // 
            this.polygonsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.polygonsToolStripMenuItem.Checked = true;
            this.polygonsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.polygonsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.polygonsToolStripMenuItem.Name = "polygonsToolStripMenuItem";
            this.polygonsToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.polygonsToolStripMenuItem.Text = "Polygons On";
            this.polygonsToolStripMenuItem.Click += new System.EventHandler(this.polygonsToolStripMenuItem_Click);
            // 
            // logNMEAMenuItem
            // 
            this.logNMEAMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.logNMEAMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.logNMEAMenuItem.Name = "logNMEAMenuItem";
            this.logNMEAMenuItem.Size = new System.Drawing.Size(263, 40);
            this.logNMEAMenuItem.Text = "Log NMEA";
            this.logNMEAMenuItem.Click += new System.EventHandler(this.logNMEAMenuItem_Click);
            // 
            // pursuitLineToolStripMenuItem
            // 
            this.pursuitLineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.pursuitLineToolStripMenuItem.Checked = true;
            this.pursuitLineToolStripMenuItem.CheckOnClick = true;
            this.pursuitLineToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pursuitLineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.pursuitLineToolStripMenuItem.Name = "pursuitLineToolStripMenuItem";
            this.pursuitLineToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.pursuitLineToolStripMenuItem.Text = "Pursuit Line";
            this.pursuitLineToolStripMenuItem.Click += new System.EventHandler(this.pursuitLineToolStripMenuItem_Click);
            // 
            // skyToolStripMenu
            // 
            this.skyToolStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.skyToolStripMenu.Checked = true;
            this.skyToolStripMenu.CheckOnClick = true;
            this.skyToolStripMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.skyToolStripMenu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.skyToolStripMenu.Name = "skyToolStripMenu";
            this.skyToolStripMenu.Size = new System.Drawing.Size(263, 40);
            this.skyToolStripMenu.Text = "Sky On";
            this.skyToolStripMenu.Click += new System.EventHandler(this.skyToolStripMenu_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStripSeparator6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(260, 6);
            // 
            // simulatorOnToolStripMenuItem
            // 
            this.simulatorOnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.simulatorOnToolStripMenuItem.Checked = true;
            this.simulatorOnToolStripMenuItem.CheckOnClick = true;
            this.simulatorOnToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.simulatorOnToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.simulatorOnToolStripMenuItem.Name = "simulatorOnToolStripMenuItem";
            this.simulatorOnToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.simulatorOnToolStripMenuItem.Text = "Simulator On";
            this.simulatorOnToolStripMenuItem.Click += new System.EventHandler(this.simulatorOnToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(260, 6);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 22F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.toolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(5, 5);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip1.Size = new System.Drawing.Size(1296, 38);
            this.menuStrip1.TabIndex = 49;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.remoteConfigurationToolStripMenuItem,
            this.explorerToolStripMenuItem,
            this.webCamToolStripMenuItem,
            this.fieldViewerToolStripMenuItem,
            this.googleEarthToolStripMenuItem,
            this.gPSDataToolStripMenuItem1,
            this.helpToolStripMenuItem1,
            this.resetModulesToolStripMenuItem,
            this.zeroIMUToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.toolsToolStripMenuItem.Text = "Tools";
            // 
            // remoteConfigurationToolStripMenuItem
            // 
            this.remoteConfigurationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.remoteConfigurationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remoteConfigurationToolStripMenuItem.Name = "remoteConfigurationToolStripMenuItem";
            this.remoteConfigurationToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.remoteConfigurationToolStripMenuItem.Text = "Remote Config";
            this.remoteConfigurationToolStripMenuItem.Click += new System.EventHandler(this.remoteConfigurationToolStripMenuItem_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.explorerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.explorerToolStripMenuItem.Text = "Windows Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // webCamToolStripMenuItem
            // 
            this.webCamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.webCamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.webCamToolStripMenuItem.Name = "webCamToolStripMenuItem";
            this.webCamToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.webCamToolStripMenuItem.Text = "Web Cam";
            this.webCamToolStripMenuItem.Click += new System.EventHandler(this.webCamToolStripMenuItem_Click);
            // 
            // fieldViewerToolStripMenuItem
            // 
            this.fieldViewerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fieldViewerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fieldViewerToolStripMenuItem.Name = "fieldViewerToolStripMenuItem";
            this.fieldViewerToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.fieldViewerToolStripMenuItem.Text = "Field Viewer";
            this.fieldViewerToolStripMenuItem.Click += new System.EventHandler(this.fieldViewerToolStripMenuItem_Click);
            // 
            // googleEarthToolStripMenuItem
            // 
            this.googleEarthToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.googleEarthToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.googleEarthToolStripMenuItem.Name = "googleEarthToolStripMenuItem";
            this.googleEarthToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.googleEarthToolStripMenuItem.Text = "Google Earth - Flags";
            this.googleEarthToolStripMenuItem.Click += new System.EventHandler(this.googleEarthToolStripMenuItem_Click);
            // 
            // gPSDataToolStripMenuItem1
            // 
            this.gPSDataToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gPSDataToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gPSDataToolStripMenuItem1.Name = "gPSDataToolStripMenuItem1";
            this.gPSDataToolStripMenuItem1.Size = new System.Drawing.Size(360, 40);
            this.gPSDataToolStripMenuItem1.Text = "GPS Data";
            this.gPSDataToolStripMenuItem1.Click += new System.EventHandler(this.gPSDataToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem1
            // 
            this.helpToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.helpToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuHelpAbout,
            this.helpToolStripMenuHelpHelp});
            this.helpToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(360, 40);
            this.helpToolStripMenuItem1.Text = "Help";
            // 
            // aboutToolStripMenuHelpAbout
            // 
            this.aboutToolStripMenuHelpAbout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.aboutToolStripMenuHelpAbout.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.aboutToolStripMenuHelpAbout.Name = "aboutToolStripMenuHelpAbout";
            this.aboutToolStripMenuHelpAbout.Size = new System.Drawing.Size(168, 40);
            this.aboutToolStripMenuHelpAbout.Text = "About";
            this.aboutToolStripMenuHelpAbout.Click += new System.EventHandler(this.aboutToolStripMenuHelpAbout_Click);
            // 
            // helpToolStripMenuHelpHelp
            // 
            this.helpToolStripMenuHelpHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.helpToolStripMenuHelpHelp.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.helpToolStripMenuHelpHelp.Name = "helpToolStripMenuHelpHelp";
            this.helpToolStripMenuHelpHelp.Size = new System.Drawing.Size(168, 40);
            this.helpToolStripMenuHelpHelp.Text = "Help";
            this.helpToolStripMenuHelpHelp.Click += new System.EventHandler(this.helpToolStripMenuHelpHelp_Click);
            // 
            // resetModulesToolStripMenuItem
            // 
            this.resetModulesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.resetModulesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetAntennaToolStripMenuItem,
            this.resetGradeControlToolStripMenuItem,
            this.resetAllToolStripMenuItem1});
            this.resetModulesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetModulesToolStripMenuItem.Name = "resetModulesToolStripMenuItem";
            this.resetModulesToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.resetModulesToolStripMenuItem.Text = "Reset Modules";
            this.resetModulesToolStripMenuItem.Click += new System.EventHandler(this.resetModulesToolStripMenuItem_Click);
            // 
            // resetAntennaToolStripMenuItem
            // 
            this.resetAntennaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.resetAntennaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetAntennaToolStripMenuItem.Name = "resetAntennaToolStripMenuItem";
            this.resetAntennaToolStripMenuItem.Size = new System.Drawing.Size(348, 40);
            this.resetAntennaToolStripMenuItem.Text = "Reset Antenna";
            this.resetAntennaToolStripMenuItem.Click += new System.EventHandler(this.resetAntennaToolStripMenuItem_Click);
            // 
            // resetGradeControlToolStripMenuItem
            // 
            this.resetGradeControlToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.resetGradeControlToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetGradeControlToolStripMenuItem.Name = "resetGradeControlToolStripMenuItem";
            this.resetGradeControlToolStripMenuItem.Size = new System.Drawing.Size(348, 40);
            this.resetGradeControlToolStripMenuItem.Text = "Reset GradeControl";
            this.resetGradeControlToolStripMenuItem.Click += new System.EventHandler(this.resetGradeControlToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem1
            // 
            this.resetAllToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.resetAllToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.resetAllToolStripMenuItem1.Name = "resetAllToolStripMenuItem1";
            this.resetAllToolStripMenuItem1.Size = new System.Drawing.Size(348, 40);
            this.resetAllToolStripMenuItem1.Text = "Reset All";
            this.resetAllToolStripMenuItem1.Click += new System.EventHandler(this.resetAllToolStripMenuItem1_Click);
            // 
            // zeroIMUToolStripMenuItem
            // 
            this.zeroIMUToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.zeroIMUToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zeroIMUToolStripMenuItem.Name = "zeroIMUToolStripMenuItem";
            this.zeroIMUToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.zeroIMUToolStripMenuItem.Text = "Zero IMU";
            this.zeroIMUToolStripMenuItem.Click += new System.EventHandler(this.zeroIMUToolStripMenuItem_Click);
            // 
            // tmrWatchdog
            // 
            this.tmrWatchdog.Interval = 50;
            this.tmrWatchdog.Tick += new System.EventHandler(this.tmrWatchdog_tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.AutoSize = false;
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMinMax,
            this.toolStripDropDownBtnFuncs,
            this.stripDistance,
            this.stripEqWidth,
            this.toolStripDropDownButton2,
            this.stripTopoLocation,
            this.stripOnlineGPS,
            this.stripOnlineAutoSteer});
            this.statusStrip1.Location = new System.Drawing.Point(5, 638);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1296, 41);
            this.statusStrip1.TabIndex = 95;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // stripMinMax
            // 
            this.stripMinMax.AutoSize = false;
            this.stripMinMax.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripMinMax.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripMinMax.Name = "stripMinMax";
            this.stripMinMax.Size = new System.Drawing.Size(450, 41);
            this.stripMinMax.Text = "Min:Max";
            this.stripMinMax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // toolStripDropDownBtnFuncs
            // 
            this.toolStripDropDownBtnFuncs.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripDropDownBtnFuncs.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripField,
            this.toolstripResetTrip});
            this.toolStripDropDownBtnFuncs.Font = new System.Drawing.Font("Tahoma", 18F);
            this.toolStripDropDownBtnFuncs.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownBtnFuncs.Image")));
            this.toolStripDropDownBtnFuncs.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripDropDownBtnFuncs.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownBtnFuncs.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownBtnFuncs.Name = "toolStripDropDownBtnFuncs";
            this.toolStripDropDownBtnFuncs.ShowDropDownArrow = false;
            this.toolStripDropDownBtnFuncs.Size = new System.Drawing.Size(82, 39);
            this.toolStripDropDownBtnFuncs.Text = "Start";
            this.toolStripDropDownBtnFuncs.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripDropDownBtnFuncs.Click += new System.EventHandler(this.toolStripDropDownBtnFuncs_Click);
            // 
            // toolstripField
            // 
            this.toolstripField.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolstripField.Font = new System.Drawing.Font("Tahoma", 22F);
            this.toolstripField.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripField.Image = ((System.Drawing.Image)(resources.GetObject("toolstripField.Image")));
            this.toolstripField.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripField.Name = "toolstripField";
            this.toolstripField.Size = new System.Drawing.Size(246, 70);
            this.toolstripField.Text = "Field";
            this.toolstripField.Click += new System.EventHandler(this.toolstripField_Click);
            // 
            // toolstripResetTrip
            // 
            this.toolstripResetTrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.toolstripResetTrip.Font = new System.Drawing.Font("Tahoma", 20F);
            this.toolstripResetTrip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripResetTrip.Image = ((System.Drawing.Image)(resources.GetObject("toolstripResetTrip.Image")));
            this.toolstripResetTrip.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripResetTrip.Name = "toolstripResetTrip";
            this.toolstripResetTrip.Size = new System.Drawing.Size(246, 70);
            this.toolstripResetTrip.Text = ">0< Trip";
            this.toolstripResetTrip.Click += new System.EventHandler(this.toolstripResetTrip_Click);
            // 
            // stripDistance
            // 
            this.stripDistance.AutoSize = false;
            this.stripDistance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.stripDistance.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripDistance.Name = "stripDistance";
            this.stripDistance.Size = new System.Drawing.Size(102, 41);
            this.stripDistance.Text = "8888 ft";
            // 
            // stripEqWidth
            // 
            this.stripEqWidth.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.stripEqWidth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stripEqWidth.Font = new System.Drawing.Font("Tahoma", 18F);
            this.stripEqWidth.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.stripEqWidth.Margin = new System.Windows.Forms.Padding(0);
            this.stripEqWidth.Name = "stripEqWidth";
            this.stripEqWidth.Size = new System.Drawing.Size(340, 41);
            this.stripEqWidth.Spring = true;
            this.stripEqWidth.Text = "Width";
            this.stripEqWidth.Click += new System.EventHandler(this.stripEqWidth_Click);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripUDPConfig,
            this.toolstripVehicleConfig});
            this.toolStripDropDownButton2.Font = new System.Drawing.Font("Tahoma", 18F);
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripDropDownButton2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.ShowDropDownArrow = false;
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(83, 39);
            this.toolStripDropDownButton2.Text = "Config";
            this.toolStripDropDownButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            // 
            // toolstripUDPConfig
            // 
            this.toolstripUDPConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolstripUDPConfig.Font = new System.Drawing.Font("Tahoma", 22F);
            this.toolstripUDPConfig.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolstripUDPConfig.Image = ((System.Drawing.Image)(resources.GetObject("toolstripUDPConfig.Image")));
            this.toolstripUDPConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripUDPConfig.Name = "toolstripUDPConfig";
            this.toolstripUDPConfig.Size = new System.Drawing.Size(247, 86);
            this.toolstripUDPConfig.Text = "UDP";
            this.toolstripUDPConfig.Click += new System.EventHandler(this.toolstripUDPConfig_Click);
            // 
            // toolstripVehicleConfig
            // 
            this.toolstripVehicleConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolstripVehicleConfig.Font = new System.Drawing.Font("Tahoma", 22F);
            this.toolstripVehicleConfig.ForeColor = System.Drawing.SystemColors.Control;
            this.toolstripVehicleConfig.Image = global::OpenGrade.Properties.Resources.Settings64;
            this.toolstripVehicleConfig.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolstripVehicleConfig.Name = "toolstripVehicleConfig";
            this.toolstripVehicleConfig.Size = new System.Drawing.Size(247, 86);
            this.toolstripVehicleConfig.Text = "Vehicle";
            this.toolstripVehicleConfig.Click += new System.EventHandler(this.toolstripVehicleConfig_Click);
            // 
            // stripTopoLocation
            // 
            this.stripTopoLocation.AutoSize = false;
            this.stripTopoLocation.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripTopoLocation.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripTopoLocation.Name = "stripTopoLocation";
            this.stripTopoLocation.Size = new System.Drawing.Size(200, 41);
            this.stripTopoLocation.Text = "-- : -----";
            // 
            // stripOnlineGPS
            // 
            this.stripOnlineGPS.AutoSize = false;
            this.stripOnlineGPS.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.stripOnlineGPS.Name = "stripOnlineGPS";
            this.stripOnlineGPS.Size = new System.Drawing.Size(16, 35);
            this.stripOnlineGPS.Value = 1;
            // 
            // stripOnlineAutoSteer
            // 
            this.stripOnlineAutoSteer.AutoToolTip = true;
            this.stripOnlineAutoSteer.ForeColor = System.Drawing.Color.DodgerBlue;
            this.stripOnlineAutoSteer.Name = "stripOnlineAutoSteer";
            this.stripOnlineAutoSteer.Size = new System.Drawing.Size(16, 35);
            this.stripOnlineAutoSteer.ToolTipText = "Arduino";
            this.stripOnlineAutoSteer.Value = 1;
            // 
            // lblSpeed
            // 
            this.lblSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeed.BackColor = System.Drawing.Color.Black;
            this.lblSpeed.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblSpeed.ForeColor = System.Drawing.Color.Green;
            this.lblSpeed.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSpeed.Location = new System.Drawing.Point(893, 4);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(87, 41);
            this.lblSpeed.TabIndex = 116;
            this.lblSpeed.Text = "88.8";
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // contextMenuStripFlag
            // 
            this.contextMenuStripFlag.AutoSize = false;
            this.contextMenuStripFlag.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.contextMenuStripFlag.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFlagRed,
            this.toolStripMenuFlagGrn,
            this.toolStripMenuFlagYel,
            this.toolStripSeparator3,
            this.toolStripMenuFlagDelete,
            this.toolStripSeparator4,
            this.toolStripMenuFlagDeleteAll});
            this.contextMenuStripFlag.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.contextMenuStripFlag.Name = "contextMenuStripFlag";
            this.contextMenuStripFlag.Size = new System.Drawing.Size(72, 400);
            this.contextMenuStripFlag.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripFlag_Opening);
            // 
            // toolStripMenuItemFlagRed
            // 
            this.toolStripMenuItemFlagRed.AutoSize = false;
            this.toolStripMenuItemFlagRed.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuItemFlagRed.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuItemFlagRed.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItemFlagRed.Image")));
            this.toolStripMenuItemFlagRed.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuItemFlagRed.Name = "toolStripMenuItemFlagRed";
            this.toolStripMenuItemFlagRed.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuItemFlagRed.Text = ".";
            this.toolStripMenuItemFlagRed.Click += new System.EventHandler(this.toolStripMenuItemFlagRed_Click);
            // 
            // toolStripMenuFlagGrn
            // 
            this.toolStripMenuFlagGrn.AutoSize = false;
            this.toolStripMenuFlagGrn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuFlagGrn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuFlagGrn.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagGrn.Image")));
            this.toolStripMenuFlagGrn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagGrn.Name = "toolStripMenuFlagGrn";
            this.toolStripMenuFlagGrn.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagGrn.Text = ".";
            this.toolStripMenuFlagGrn.Click += new System.EventHandler(this.toolStripMenuGrn_Click);
            // 
            // toolStripMenuFlagYel
            // 
            this.toolStripMenuFlagYel.AutoSize = false;
            this.toolStripMenuFlagYel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuFlagYel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuFlagYel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagYel.Image")));
            this.toolStripMenuFlagYel.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagYel.Name = "toolStripMenuFlagYel";
            this.toolStripMenuFlagYel.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagYel.Text = ".";
            this.toolStripMenuFlagYel.Click += new System.EventHandler(this.toolStripMenuYel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.AutoSize = false;
            this.toolStripSeparator3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(68, 20);
            // 
            // toolStripMenuFlagDelete
            // 
            this.toolStripMenuFlagDelete.AutoSize = false;
            this.toolStripMenuFlagDelete.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenuFlagDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripMenuFlagDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagDelete.Image")));
            this.toolStripMenuFlagDelete.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagDelete.Name = "toolStripMenuFlagDelete";
            this.toolStripMenuFlagDelete.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagDelete.Text = ".";
            this.toolStripMenuFlagDelete.Click += new System.EventHandler(this.toolStripMenuFlagDelete_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.AutoSize = false;
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(68, 20);
            // 
            // toolStripMenuFlagDeleteAll
            // 
            this.toolStripMenuFlagDeleteAll.AutoSize = false;
            this.toolStripMenuFlagDeleteAll.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuFlagDeleteAll.Image")));
            this.toolStripMenuFlagDeleteAll.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripMenuFlagDeleteAll.Name = "toolStripMenuFlagDeleteAll";
            this.toolStripMenuFlagDeleteAll.Size = new System.Drawing.Size(70, 70);
            this.toolStripMenuFlagDeleteAll.Text = "toolStripMenuFlagDeleteAll";
            this.toolStripMenuFlagDeleteAll.Click += new System.EventHandler(this.toolStripMenuFlagDeleteAll_Click);
            // 
            // lblSpeedUnits
            // 
            this.lblSpeedUnits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSpeedUnits.BackColor = System.Drawing.Color.Black;
            this.lblSpeedUnits.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lblSpeedUnits.ForeColor = System.Drawing.Color.Green;
            this.lblSpeedUnits.Location = new System.Drawing.Point(979, 4);
            this.lblSpeedUnits.Name = "lblSpeedUnits";
            this.lblSpeedUnits.Size = new System.Drawing.Size(50, 41);
            this.lblSpeedUnits.TabIndex = 139;
            this.lblSpeedUnits.Text = "kmh";
            this.lblSpeedUnits.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblHeading
            // 
            this.lblHeading.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHeading.BackColor = System.Drawing.Color.Black;
            this.lblHeading.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.Green;
            this.lblHeading.Location = new System.Drawing.Point(1048, 4);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(130, 40);
            this.lblHeading.TabIndex = 117;
            this.lblHeading.Text = "359.8.";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "SateliteIcon.png");
            this.imageList1.Images.SetKeyName(1, "SettingsIcon.png");
            this.imageList1.Images.SetKeyName(2, "OpenGradeIcon.png");
            // 
            // lblDrawSlope
            // 
            this.lblDrawSlope.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblDrawSlope.AutoSize = true;
            this.lblDrawSlope.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblDrawSlope.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDrawSlope.ForeColor = System.Drawing.Color.Yellow;
            this.lblDrawSlope.Location = new System.Drawing.Point(713, 605);
            this.lblDrawSlope.Name = "lblDrawSlope";
            this.lblDrawSlope.Size = new System.Drawing.Size(23, 29);
            this.lblDrawSlope.TabIndex = 216;
            this.lblDrawSlope.Text = "-";
            this.lblDrawSlope.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblDrawSlope.Visible = false;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(644, 605);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 29);
            this.label2.TabIndex = 217;
            this.label2.Text = "Slope:";
            this.label2.Visible = false;
            // 
            // lblCutFillRatio
            // 
            this.lblCutFillRatio.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCutFillRatio.AutoSize = true;
            this.lblCutFillRatio.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCutFillRatio.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCutFillRatio.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutFillRatio.ForeColor = System.Drawing.Color.Yellow;
            this.lblCutFillRatio.Location = new System.Drawing.Point(1074, 313);
            this.lblCutFillRatio.Name = "lblCutFillRatio";
            this.lblCutFillRatio.Size = new System.Drawing.Size(23, 29);
            this.lblCutFillRatio.TabIndex = 212;
            this.lblCutFillRatio.Text = "-";
            this.lblCutFillRatio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFill
            // 
            this.lblFill.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFill.AutoSize = true;
            this.lblFill.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblFill.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFill.ForeColor = System.Drawing.Color.Yellow;
            this.lblFill.Location = new System.Drawing.Point(883, 313);
            this.lblFill.Name = "lblFill";
            this.lblFill.Size = new System.Drawing.Size(23, 29);
            this.lblFill.TabIndex = 201;
            this.lblFill.Text = "-";
            this.lblFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label27
            // 
            this.label27.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label27.AutoSize = true;
            this.label27.BackColor = System.Drawing.SystemColors.ControlText;
            this.label27.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.Color.Yellow;
            this.label27.Location = new System.Drawing.Point(843, 313);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(49, 29);
            this.label27.TabIndex = 202;
            this.label27.Text = "Fill:";
            // 
            // lblCut
            // 
            this.lblCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCut.AutoSize = true;
            this.lblCut.BackColor = System.Drawing.SystemColors.ControlText;
            this.lblCut.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblCut.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCut.ForeColor = System.Drawing.Color.Yellow;
            this.lblCut.Location = new System.Drawing.Point(691, 313);
            this.lblCut.Name = "lblCut";
            this.lblCut.Size = new System.Drawing.Size(23, 29);
            this.lblCut.TabIndex = 199;
            this.lblCut.Text = "-";
            this.lblCut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.SystemColors.ControlText;
            this.label25.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Yellow;
            this.label25.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label25.Location = new System.Drawing.Point(644, 313);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(56, 29);
            this.label25.TabIndex = 200;
            this.label25.Text = "Cut:";
            // 
            // lblAltitude
            // 
            this.lblAltitude.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAltitude.AutoSize = true;
            this.lblAltitude.BackColor = System.Drawing.SystemColors.WindowText;
            this.lblAltitude.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltitude.ForeColor = System.Drawing.Color.Green;
            this.lblAltitude.Location = new System.Drawing.Point(714, 7);
            this.lblAltitude.Name = "lblAltitude";
            this.lblAltitude.Size = new System.Drawing.Size(147, 39);
            this.lblAltitude.TabIndex = 179;
            this.lblAltitude.Text = "900.555";
            // 
            // panelSimControls
            // 
            this.panelSimControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSimControls.Controls.Add(this.label3);
            this.panelSimControls.Controls.Add(this.btnResetSteerAngle);
            this.panelSimControls.Controls.Add(this.btnResetSim);
            this.panelSimControls.Controls.Add(this.lblSteerAngle);
            this.panelSimControls.Controls.Add(this.label11);
            this.panelSimControls.Controls.Add(this.label12);
            this.panelSimControls.Controls.Add(this.tbarSteerAngle);
            this.panelSimControls.Controls.Add(this.tbarStepDistance);
            this.panelSimControls.Controls.Add(this.nudElevation);
            this.panelSimControls.Location = new System.Drawing.Point(8, 589);
            this.panelSimControls.Name = "panelSimControls";
            this.panelSimControls.Size = new System.Drawing.Size(544, 46);
            this.panelSimControls.TabIndex = 172;
            this.panelSimControls.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label3.Location = new System.Drawing.Point(304, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 16);
            this.label3.TabIndex = 172;
            this.label3.Text = "L";
            // 
            // btnResetSteerAngle
            // 
            this.btnResetSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSteerAngle.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnResetSteerAngle.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnResetSteerAngle.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnResetSteerAngle.Location = new System.Drawing.Point(182, 7);
            this.btnResetSteerAngle.Name = "btnResetSteerAngle";
            this.btnResetSteerAngle.Size = new System.Drawing.Size(52, 29);
            this.btnResetSteerAngle.TabIndex = 162;
            this.btnResetSteerAngle.Text = ">0<";
            this.btnResetSteerAngle.UseVisualStyleBackColor = false;
            this.btnResetSteerAngle.Click += new System.EventHandler(this.btnResetSteerAngle_Click);
            // 
            // btnResetSim
            // 
            this.btnResetSim.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnResetSim.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.btnResetSim.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnResetSim.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.btnResetSim.Location = new System.Drawing.Point(246, 8);
            this.btnResetSim.Name = "btnResetSim";
            this.btnResetSim.Size = new System.Drawing.Size(52, 26);
            this.btnResetSim.TabIndex = 164;
            this.btnResetSim.Text = "Reset";
            this.btnResetSim.UseVisualStyleBackColor = false;
            this.btnResetSim.Click += new System.EventHandler(this.btnResetSim_Click);
            // 
            // lblSteerAngle
            // 
            this.lblSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSteerAngle.AutoSize = true;
            this.lblSteerAngle.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSteerAngle.Location = new System.Drawing.Point(140, 24);
            this.lblSteerAngle.Name = "lblSteerAngle";
            this.lblSteerAngle.Size = new System.Drawing.Size(19, 19);
            this.lblSteerAngle.TabIndex = 163;
            this.lblSteerAngle.Text = "0";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label11.Location = new System.Drawing.Point(4, 20);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 16);
            this.label11.TabIndex = 170;
            this.label11.Text = "B N M";
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label12.Location = new System.Drawing.Point(367, 23);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 16);
            this.label12.TabIndex = 171;
            this.label12.Text = "H J K";
            // 
            // tbarSteerAngle
            // 
            this.tbarSteerAngle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarSteerAngle.LargeChange = 10;
            this.tbarSteerAngle.Location = new System.Drawing.Point(3, 5);
            this.tbarSteerAngle.Maximum = 300;
            this.tbarSteerAngle.Minimum = -300;
            this.tbarSteerAngle.Name = "tbarSteerAngle";
            this.tbarSteerAngle.RightToLeftLayout = true;
            this.tbarSteerAngle.Size = new System.Drawing.Size(181, 45);
            this.tbarSteerAngle.TabIndex = 161;
            this.tbarSteerAngle.TickFrequency = 30;
            this.tbarSteerAngle.Scroll += new System.EventHandler(this.tbarSteerAngle_Scroll);
            // 
            // tbarStepDistance
            // 
            this.tbarStepDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tbarStepDistance.LargeChange = 10;
            this.tbarStepDistance.Location = new System.Drawing.Point(307, 6);
            this.tbarStepDistance.Maximum = 300;
            this.tbarStepDistance.Name = "tbarStepDistance";
            this.tbarStepDistance.Size = new System.Drawing.Size(117, 45);
            this.tbarStepDistance.TabIndex = 160;
            this.tbarStepDistance.TickFrequency = 10;
            this.tbarStepDistance.Value = 20;
            this.tbarStepDistance.Scroll += new System.EventHandler(this.tbarStepDistance_Scroll);
            // 
            // nudElevation
            // 
            this.nudElevation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.nudElevation.DecimalPlaces = 3;
            this.nudElevation.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudElevation.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudElevation.Location = new System.Drawing.Point(421, 6);
            this.nudElevation.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudElevation.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudElevation.Name = "nudElevation";
            this.nudElevation.Size = new System.Drawing.Size(123, 36);
            this.nudElevation.TabIndex = 185;
            this.nudElevation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudElevation.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.nudElevation.ValueChanged += new System.EventHandler(this.nudElevation_ValueChanged);
            // 
            // sqrCutLine
            // 
            this.sqrCutLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqrCutLine.AutoSize = true;
            this.sqrCutLine.BackColor = System.Drawing.Color.Black;
            this.sqrCutLine.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold);
            this.sqrCutLine.ForeColor = System.Drawing.Color.Green;
            this.sqrCutLine.Location = new System.Drawing.Point(1189, 5);
            this.sqrCutLine.Name = "sqrCutLine";
            this.sqrCutLine.Size = new System.Drawing.Size(107, 39);
            this.sqrCutLine.TabIndex = 137;
            this.sqrCutLine.Text = "88.88";
            // 
            // timerSim
            // 
            this.timerSim.Enabled = true;
            this.timerSim.Interval = 200;
            this.timerSim.Tick += new System.EventHandler(this.timerSim_Tick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(334, 62);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlText;
            this.label4.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(1050, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 29);
            this.label4.TabIndex = 218;
            this.label4.Text = "d:";
            // 
            // pbarCutBelow
            // 
            this.pbarCutBelow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbarCutBelow.BarBackColor = System.Drawing.Color.Black;
            cBlendItems1.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems1.iPoint = new float[] {
        0F,
        1F};
            this.pbarCutBelow.BarColorBlend = cBlendItems1;
            this.pbarCutBelow.BarColorSolid = System.Drawing.Color.Black;
            this.pbarCutBelow.BarColorSolidB = System.Drawing.Color.Red;
            this.pbarCutBelow.BarLengthValue = ((short)(40));
            this.pbarCutBelow.BarPadding = new System.Windows.Forms.Padding(0);
            this.pbarCutBelow.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Hatch;
            this.pbarCutBelow.BarStyleHatch = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            this.pbarCutBelow.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Horizontal;
            this.pbarCutBelow.BarStyleTexture = null;
            this.pbarCutBelow.BorderWidth = ((short)(1));
            this.pbarCutBelow.Corners.All = ((short)(0));
            this.pbarCutBelow.Corners.LowerLeft = ((short)(0));
            this.pbarCutBelow.Corners.LowerRight = ((short)(0));
            this.pbarCutBelow.Corners.UpperLeft = ((short)(0));
            this.pbarCutBelow.Corners.UpperRight = ((short)(0));
            this.pbarCutBelow.CylonInterval = ((short)(1));
            this.pbarCutBelow.CylonMove = 5F;
            this.pbarCutBelow.FillDirection = ProgBar.ProgBarPlus.eFillDirection.Down_Left;
            cFocalPoints1.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints1.CenterPoint")));
            cFocalPoints1.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints1.FocusScales")));
            this.pbarCutBelow.FocalPoints = cFocalPoints1;
            this.pbarCutBelow.Location = new System.Drawing.Point(1226, 488);
            this.pbarCutBelow.Name = "pbarCutBelow";
            this.pbarCutBelow.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.pbarCutBelow.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.pbarCutBelow.Size = new System.Drawing.Size(72, 150);
            this.pbarCutBelow.TabIndex = 223;
            this.pbarCutBelow.TextFormat = "Process {1}% Done";
            this.pbarCutBelow.Click += new System.EventHandler(this.pbarCutBelow_Click);
            // 
            // pbarCutAbove
            // 
            this.pbarCutAbove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbarCutAbove.BarBackColor = System.Drawing.Color.Black;
            cBlendItems2.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.Navy,
        System.Drawing.Color.Blue};
            cBlendItems2.iPoint = new float[] {
        0F,
        1F};
            this.pbarCutAbove.BarColorBlend = cBlendItems2;
            this.pbarCutAbove.BarColorSolid = System.Drawing.Color.Black;
            this.pbarCutAbove.BarColorSolidB = System.Drawing.Color.LimeGreen;
            this.pbarCutAbove.BarLengthValue = ((short)(40));
            this.pbarCutAbove.BarPadding = new System.Windows.Forms.Padding(0);
            this.pbarCutAbove.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Hatch;
            this.pbarCutAbove.BarStyleHatch = System.Drawing.Drawing2D.HatchStyle.Horizontal;
            this.pbarCutAbove.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pbarCutAbove.BarStyleTexture = null;
            this.pbarCutAbove.BorderWidth = ((short)(1));
            this.pbarCutAbove.Corners.All = ((short)(0));
            this.pbarCutAbove.Corners.LowerLeft = ((short)(0));
            this.pbarCutAbove.Corners.LowerRight = ((short)(0));
            this.pbarCutAbove.Corners.UpperLeft = ((short)(0));
            this.pbarCutAbove.Corners.UpperRight = ((short)(0));
            this.pbarCutAbove.CylonInterval = ((short)(1));
            this.pbarCutAbove.CylonMove = 5F;
            cFocalPoints2.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints2.CenterPoint")));
            cFocalPoints2.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints2.FocusScales")));
            this.pbarCutAbove.FocalPoints = cFocalPoints2;
            this.pbarCutAbove.Location = new System.Drawing.Point(1226, 348);
            this.pbarCutAbove.Name = "pbarCutAbove";
            this.pbarCutAbove.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.pbarCutAbove.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.pbarCutAbove.Size = new System.Drawing.Size(72, 150);
            this.pbarCutAbove.TabIndex = 224;
            this.pbarCutAbove.TextFormat = "Process {1}% Done";
            this.pbarCutAbove.Click += new System.EventHandler(this.pbarCutAbove_Click);
            // 
            // lblBarGraphMax
            // 
            this.lblBarGraphMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBarGraphMax.AutoSize = true;
            this.lblBarGraphMax.BackColor = System.Drawing.Color.Black;
            this.lblBarGraphMax.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblBarGraphMax.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBarGraphMax.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBarGraphMax.Location = new System.Drawing.Point(1251, 317);
            this.lblBarGraphMax.Name = "lblBarGraphMax";
            this.lblBarGraphMax.Size = new System.Drawing.Size(23, 29);
            this.lblBarGraphMax.TabIndex = 225;
            this.lblBarGraphMax.Text = "-";
            this.lblBarGraphMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OpenGradePage
            // 
            this.OpenGradePage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.OpenGradePage.Controls.Add(this.label16);
            this.OpenGradePage.Controls.Add(this.label15);
            this.OpenGradePage.Controls.Add(this.lblCurrentCutDepth);
            this.OpenGradePage.Controls.Add(this.lblDistToTarget);
            this.OpenGradePage.Controls.Add(this.btnSaveCut);
            this.OpenGradePage.Controls.Add(this.btnAutoDrain);
            this.OpenGradePage.Controls.Add(this.lblDistanceToCut);
            this.OpenGradePage.Controls.Add(this.label6);
            this.OpenGradePage.Controls.Add(this.lblCutDelta);
            this.OpenGradePage.Controls.Add(this.btnLevel);
            this.OpenGradePage.Controls.Add(this.btnSurface);
            this.OpenGradePage.Controls.Add(this.btnDoneDraw);
            this.OpenGradePage.Controls.Add(this.btnDeleteLastPoint);
            this.OpenGradePage.Controls.Add(this.btnStartDraw);
            this.OpenGradePage.Controls.Add(this.btnClearLastPass);
            this.OpenGradePage.ImageIndex = 2;
            this.OpenGradePage.Location = new System.Drawing.Point(4, 4);
            this.OpenGradePage.Margin = new System.Windows.Forms.Padding(0);
            this.OpenGradePage.Name = "OpenGradePage";
            this.OpenGradePage.Size = new System.Drawing.Size(601, 255);
            this.OpenGradePage.TabIndex = 4;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(154, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 19);
            this.label16.TabIndex = 240;
            this.label16.Text = "Target Depth";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(358, 10);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 19);
            this.label15.TabIndex = 239;
            this.label15.Text = "Cut Depth";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // lblCurrentCutDepth
            // 
            this.lblCurrentCutDepth.BackColor = System.Drawing.Color.Black;
            this.lblCurrentCutDepth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentCutDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCutDepth.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentCutDepth.Location = new System.Drawing.Point(310, 29);
            this.lblCurrentCutDepth.Name = "lblCurrentCutDepth";
            this.lblCurrentCutDepth.Size = new System.Drawing.Size(176, 72);
            this.lblCurrentCutDepth.TabIndex = 238;
            this.lblCurrentCutDepth.Text = "93";
            this.lblCurrentCutDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistToTarget
            // 
            this.lblDistToTarget.BackColor = System.Drawing.Color.Black;
            this.lblDistToTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistToTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistToTarget.ForeColor = System.Drawing.Color.Yellow;
            this.lblDistToTarget.Location = new System.Drawing.Point(117, 29);
            this.lblDistToTarget.Name = "lblDistToTarget";
            this.lblDistToTarget.Size = new System.Drawing.Size(177, 72);
            this.lblDistToTarget.TabIndex = 237;
            this.lblDistToTarget.Text = "93";
            this.lblDistToTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSaveCut
            // 
            this.btnSaveCut.BackColor = System.Drawing.Color.Black;
            this.btnSaveCut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSaveCut.Enabled = false;
            this.btnSaveCut.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveCut.Image = global::OpenGrade.Properties.Resources.FileSave;
            this.btnSaveCut.Location = new System.Drawing.Point(13, 170);
            this.btnSaveCut.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnSaveCut.Name = "btnSaveCut";
            this.btnSaveCut.Size = new System.Drawing.Size(84, 84);
            this.btnSaveCut.TabIndex = 235;
            this.btnSaveCut.UseVisualStyleBackColor = false;
            this.btnSaveCut.Click += new System.EventHandler(this.btnSaveCut_Click_1);
            // 
            // btnAutoDrain
            // 
            this.btnAutoDrain.BackColor = System.Drawing.Color.Lime;
            this.btnAutoDrain.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAutoDrain.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoDrain.Location = new System.Drawing.Point(505, 3);
            this.btnAutoDrain.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnAutoDrain.Name = "btnAutoDrain";
            this.btnAutoDrain.Size = new System.Drawing.Size(84, 84);
            this.btnAutoDrain.TabIndex = 234;
            this.btnAutoDrain.Text = "Auto Drain";
            this.btnAutoDrain.UseVisualStyleBackColor = false;
            this.btnAutoDrain.Visible = false;
            this.btnAutoDrain.Click += new System.EventHandler(this.btnAutoDrain_Click);
            // 
            // lblDistanceToCut
            // 
            this.lblDistanceToCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDistanceToCut.AutoSize = true;
            this.lblDistanceToCut.BackColor = System.Drawing.Color.Transparent;
            this.lblDistanceToCut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistanceToCut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDistanceToCut.Location = new System.Drawing.Point(244, 233);
            this.lblDistanceToCut.Name = "lblDistanceToCut";
            this.lblDistanceToCut.Size = new System.Drawing.Size(115, 19);
            this.lblDistanceToCut.TabIndex = 232;
            this.lblDistanceToCut.Text = "Clear Cut Lines";
            this.lblDistanceToCut.Click += new System.EventHandler(this.label13_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(264, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 227;
            this.label6.Text = "Cut Delta";
            // 
            // lblCutDelta
            // 
            this.lblCutDelta.BackColor = System.Drawing.Color.Black;
            this.lblCutDelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCutDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutDelta.ForeColor = System.Drawing.Color.Yellow;
            this.lblCutDelta.Location = new System.Drawing.Point(117, 140);
            this.lblCutDelta.Name = "lblCutDelta";
            this.lblCutDelta.Size = new System.Drawing.Size(369, 92);
            this.lblCutDelta.TabIndex = 220;
            this.lblCutDelta.Text = "93";
            this.lblCutDelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCutDelta.Click += new System.EventHandler(this.lblCutDelta_Click);
            // 
            // btnLevel
            // 
            this.btnLevel.BackColor = System.Drawing.Color.DimGray;
            this.btnLevel.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnLevel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnLevel.Image = global::OpenGrade.Properties.Resources.levelOffBtn;
            this.btnLevel.Location = new System.Drawing.Point(13, 86);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(84, 84);
            this.btnLevel.TabIndex = 233;
            this.btnLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLevel.UseVisualStyleBackColor = false;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnSurface
            // 
            this.btnSurface.BackColor = System.Drawing.Color.DimGray;
            this.btnSurface.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnSurface.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnSurface.Image = global::OpenGrade.Properties.Resources.surfaceBtn;
            this.btnSurface.Location = new System.Drawing.Point(13, 3);
            this.btnSurface.Name = "btnSurface";
            this.btnSurface.Size = new System.Drawing.Size(84, 84);
            this.btnSurface.TabIndex = 231;
            this.btnSurface.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSurface.UseVisualStyleBackColor = false;
            this.btnSurface.Click += new System.EventHandler(this.btnSurface_Click_1);
            // 
            // btnDoneDraw
            // 
            this.btnDoneDraw.BackColor = System.Drawing.Color.DimGray;
            this.btnDoneDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDoneDraw.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoneDraw.Image = global::OpenGrade.Properties.Resources.PointDone;
            this.btnDoneDraw.Location = new System.Drawing.Point(505, 170);
            this.btnDoneDraw.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDoneDraw.Name = "btnDoneDraw";
            this.btnDoneDraw.Size = new System.Drawing.Size(84, 84);
            this.btnDoneDraw.TabIndex = 230;
            this.btnDoneDraw.UseVisualStyleBackColor = false;
            this.btnDoneDraw.Click += new System.EventHandler(this.btnDoneDraw_Click);
            // 
            // btnDeleteLastPoint
            // 
            this.btnDeleteLastPoint.BackColor = System.Drawing.Color.DimGray;
            this.btnDeleteLastPoint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDeleteLastPoint.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLastPoint.Image = global::OpenGrade.Properties.Resources.PointDelete;
            this.btnDeleteLastPoint.Location = new System.Drawing.Point(505, 86);
            this.btnDeleteLastPoint.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnDeleteLastPoint.Name = "btnDeleteLastPoint";
            this.btnDeleteLastPoint.Size = new System.Drawing.Size(84, 84);
            this.btnDeleteLastPoint.TabIndex = 229;
            this.btnDeleteLastPoint.UseVisualStyleBackColor = false;
            this.btnDeleteLastPoint.Click += new System.EventHandler(this.btnDeleteLastPoint_Click);
            // 
            // btnStartDraw
            // 
            this.btnStartDraw.BackColor = System.Drawing.Color.DimGray;
            this.btnStartDraw.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnStartDraw.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStartDraw.Image = global::OpenGrade.Properties.Resources.PointStart;
            this.btnStartDraw.Location = new System.Drawing.Point(505, 3);
            this.btnStartDraw.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnStartDraw.Name = "btnStartDraw";
            this.btnStartDraw.Size = new System.Drawing.Size(84, 84);
            this.btnStartDraw.TabIndex = 228;
            this.btnStartDraw.UseVisualStyleBackColor = false;
            this.btnStartDraw.Click += new System.EventHandler(this.btnStartDraw_Click);
            // 
            // btnClearLastPass
            // 
            this.btnClearLastPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearLastPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btnClearLastPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClearLastPass.Font = new System.Drawing.Font("Tahoma", 15.75F);
            this.btnClearLastPass.Image = global::OpenGrade.Properties.Resources.LastPassClear;
            this.btnClearLastPass.Location = new System.Drawing.Point(185, 117);
            this.btnClearLastPass.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnClearLastPass.Name = "btnClearLastPass";
            this.btnClearLastPass.Size = new System.Drawing.Size(10, 10);
            this.btnClearLastPass.TabIndex = 220;
            this.btnClearLastPass.UseVisualStyleBackColor = false;
            this.btnClearLastPass.Visible = false;
            this.btnClearLastPass.Click += new System.EventHandler(this.btnClearLastPass_Click);
            // 
            // SettingsPage
            // 
            this.SettingsPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SettingsPage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SettingsPage.Controls.Add(this.connectionGroupBox);
            this.SettingsPage.Controls.Add(this.btnFileExplorer);
            this.SettingsPage.Controls.Add(this.btnABLine);
            this.SettingsPage.Controls.Add(this.btnUnits);
            this.SettingsPage.Controls.Add(this.btnGPSData);
            this.SettingsPage.Controls.Add(this.btnFlag);
            this.SettingsPage.Controls.Add(this.btnSnap);
            this.SettingsPage.Controls.Add(this.btnGoogleEarth);
            this.SettingsPage.ImageIndex = 1;
            this.SettingsPage.Location = new System.Drawing.Point(4, 4);
            this.SettingsPage.Name = "SettingsPage";
            this.SettingsPage.Padding = new System.Windows.Forms.Padding(3);
            this.SettingsPage.Size = new System.Drawing.Size(601, 255);
            this.SettingsPage.TabIndex = 0;
            // 
            // connectionGroupBox
            // 
            this.connectionGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.connectionGroupBox.Controls.Add(this.ledGradeControl);
            this.connectionGroupBox.Controls.Add(this.ledAntenna);
            this.connectionGroupBox.Controls.Add(this.lblUdpConnected);
            this.connectionGroupBox.Controls.Add(this.lblAntennaConnected);
            this.connectionGroupBox.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connectionGroupBox.ForeColor = System.Drawing.SystemColors.Control;
            this.connectionGroupBox.Location = new System.Drawing.Point(356, 70);
            this.connectionGroupBox.Name = "connectionGroupBox";
            this.connectionGroupBox.Size = new System.Drawing.Size(231, 108);
            this.connectionGroupBox.TabIndex = 166;
            this.connectionGroupBox.TabStop = false;
            this.connectionGroupBox.Text = "Modules";
            // 
            // ledGradeControl
            // 
            this.ledGradeControl.BackColor = System.Drawing.Color.Black;
            this.ledGradeControl.FlatAppearance.BorderSize = 0;
            this.ledGradeControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledGradeControl.Location = new System.Drawing.Point(20, 38);
            this.ledGradeControl.Name = "ledGradeControl";
            this.ledGradeControl.Size = new System.Drawing.Size(26, 23);
            this.ledGradeControl.TabIndex = 164;
            this.ledGradeControl.UseVisualStyleBackColor = false;
            // 
            // ledAntenna
            // 
            this.ledAntenna.BackColor = System.Drawing.Color.Black;
            this.ledAntenna.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ledAntenna.FlatAppearance.BorderSize = 0;
            this.ledAntenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledAntenna.Location = new System.Drawing.Point(20, 67);
            this.ledAntenna.Name = "ledAntenna";
            this.ledAntenna.Size = new System.Drawing.Size(26, 23);
            this.ledAntenna.TabIndex = 163;
            this.ledAntenna.UseVisualStyleBackColor = false;
            // 
            // lblUdpConnected
            // 
            this.lblUdpConnected.AutoSize = true;
            this.lblUdpConnected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUdpConnected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUdpConnected.Location = new System.Drawing.Point(52, 67);
            this.lblUdpConnected.Name = "lblUdpConnected";
            this.lblUdpConnected.Size = new System.Drawing.Size(89, 23);
            this.lblUdpConnected.TabIndex = 161;
            this.lblUdpConnected.Text = "Antenna";
            // 
            // lblAntennaConnected
            // 
            this.lblAntennaConnected.AutoSize = true;
            this.lblAntennaConnected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntennaConnected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAntennaConnected.Location = new System.Drawing.Point(52, 38);
            this.lblAntennaConnected.Name = "lblAntennaConnected";
            this.lblAntennaConnected.Size = new System.Drawing.Size(137, 23);
            this.lblAntennaConnected.TabIndex = 162;
            this.lblAntennaConnected.Text = "GradeControl";
            // 
            // btnFileExplorer
            // 
            this.btnFileExplorer.BackColor = System.Drawing.Color.DimGray;
            this.btnFileExplorer.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnFileExplorer.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnFileExplorer.Image = ((System.Drawing.Image)(resources.GetObject("btnFileExplorer.Image")));
            this.btnFileExplorer.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnFileExplorer.Location = new System.Drawing.Point(572, 232);
            this.btnFileExplorer.Name = "btnFileExplorer";
            this.btnFileExplorer.Size = new System.Drawing.Size(23, 23);
            this.btnFileExplorer.TabIndex = 141;
            this.btnFileExplorer.Text = "Files";
            this.btnFileExplorer.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFileExplorer.UseVisualStyleBackColor = false;
            this.btnFileExplorer.Visible = false;
            this.btnFileExplorer.Click += new System.EventHandler(this.btnFileExplorer_Click);
            // 
            // btnABLine
            // 
            this.btnABLine.BackColor = System.Drawing.Color.DimGray;
            this.btnABLine.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnABLine.Enabled = false;
            this.btnABLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnABLine.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnABLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnABLine.Image = ((System.Drawing.Image)(resources.GetObject("btnABLine.Image")));
            this.btnABLine.Location = new System.Drawing.Point(63, 32);
            this.btnABLine.Name = "btnABLine";
            this.btnABLine.Size = new System.Drawing.Size(90, 90);
            this.btnABLine.TabIndex = 0;
            this.btnABLine.Text = "0";
            this.btnABLine.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnABLine.UseVisualStyleBackColor = false;
            this.btnABLine.Click += new System.EventHandler(this.btnABLine_Click);
            // 
            // btnUnits
            // 
            this.btnUnits.BackColor = System.Drawing.Color.DimGray;
            this.btnUnits.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnUnits.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnUnits.Image = ((System.Drawing.Image)(resources.GetObject("btnUnits.Image")));
            this.btnUnits.Location = new System.Drawing.Point(160, 32);
            this.btnUnits.Name = "btnUnits";
            this.btnUnits.Size = new System.Drawing.Size(90, 90);
            this.btnUnits.TabIndex = 142;
            this.btnUnits.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnUnits.UseVisualStyleBackColor = false;
            this.btnUnits.Click += new System.EventHandler(this.btnUnits_Click);
            // 
            // btnGPSData
            // 
            this.btnGPSData.BackColor = System.Drawing.Color.DimGray;
            this.btnGPSData.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnGPSData.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnGPSData.Image = ((System.Drawing.Image)(resources.GetObject("btnGPSData.Image")));
            this.btnGPSData.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGPSData.Location = new System.Drawing.Point(160, 129);
            this.btnGPSData.Name = "btnGPSData";
            this.btnGPSData.Size = new System.Drawing.Size(90, 90);
            this.btnGPSData.TabIndex = 138;
            this.btnGPSData.Text = "GPS";
            this.btnGPSData.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGPSData.UseVisualStyleBackColor = false;
            this.btnGPSData.Click += new System.EventHandler(this.btnGPSData_Click);
            // 
            // btnFlag
            // 
            this.btnFlag.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFlag.BackColor = System.Drawing.Color.DimGray;
            this.btnFlag.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnFlag.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnFlag.Image = ((System.Drawing.Image)(resources.GetObject("btnFlag.Image")));
            this.btnFlag.Location = new System.Drawing.Point(257, 32);
            this.btnFlag.Name = "btnFlag";
            this.btnFlag.Size = new System.Drawing.Size(90, 90);
            this.btnFlag.TabIndex = 121;
            this.btnFlag.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnFlag.UseVisualStyleBackColor = false;
            this.btnFlag.Click += new System.EventHandler(this.btnFlag_Click);
            // 
            // btnSnap
            // 
            this.btnSnap.BackColor = System.Drawing.Color.DimGray;
            this.btnSnap.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnSnap.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnSnap.Image = ((System.Drawing.Image)(resources.GetObject("btnSnap.Image")));
            this.btnSnap.Location = new System.Drawing.Point(63, 129);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(90, 90);
            this.btnSnap.TabIndex = 132;
            this.btnSnap.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSnap.UseVisualStyleBackColor = false;
            this.btnSnap.Click += new System.EventHandler(this.btnSnap_Click);
            // 
            // btnGoogleEarth
            // 
            this.btnGoogleEarth.BackColor = System.Drawing.Color.DimGray;
            this.btnGoogleEarth.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnGoogleEarth.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoogleEarth.Image = global::OpenGrade.Properties.Resources.GoogleEarth;
            this.btnGoogleEarth.Location = new System.Drawing.Point(257, 129);
            this.btnGoogleEarth.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnGoogleEarth.Name = "btnGoogleEarth";
            this.btnGoogleEarth.Size = new System.Drawing.Size(90, 90);
            this.btnGoogleEarth.TabIndex = 159;
            this.btnGoogleEarth.UseVisualStyleBackColor = false;
            this.btnGoogleEarth.Click += new System.EventHandler(this.btnGoogleEarth_Click);
            // 
            // GPSPage
            // 
            this.GPSPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GPSPage.Controls.Add(this.alt);
            this.GPSPage.Controls.Add(this.lblAltitude2);
            this.GPSPage.Controls.Add(this.lblPitch);
            this.GPSPage.Controls.Add(this.label14);
            this.GPSPage.Controls.Add(this.lblSats);
            this.GPSPage.Controls.Add(this.lblFixQuality);
            this.GPSPage.Controls.Add(this.lblGPSHeading);
            this.GPSPage.Controls.Add(this.lblZone);
            this.GPSPage.Controls.Add(this.lblEasting);
            this.GPSPage.Controls.Add(this.lblNorthing);
            this.GPSPage.Controls.Add(this.label1);
            this.GPSPage.Controls.Add(this.label7);
            this.GPSPage.Controls.Add(this.label17);
            this.GPSPage.Controls.Add(this.label19);
            this.GPSPage.Controls.Add(this.label18);
            this.GPSPage.Controls.Add(this.lblLongitude);
            this.GPSPage.Controls.Add(this.lblLatitude);
            this.GPSPage.Controls.Add(this.lblRoll);
            this.GPSPage.Controls.Add(this.lblGyroHeading);
            this.GPSPage.Controls.Add(this.tboxSentence);
            this.GPSPage.Controls.Add(this.label10);
            this.GPSPage.Controls.Add(this.label9);
            this.GPSPage.Controls.Add(this.label8);
            this.GPSPage.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.GPSPage.ImageIndex = 0;
            this.GPSPage.Location = new System.Drawing.Point(4, 4);
            this.GPSPage.Name = "GPSPage";
            this.GPSPage.Size = new System.Drawing.Size(601, 255);
            this.GPSPage.TabIndex = 3;
            // 
            // alt
            // 
            this.alt.AutoSize = true;
            this.alt.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.alt.ForeColor = System.Drawing.Color.Lime;
            this.alt.Location = new System.Drawing.Point(32, 76);
            this.alt.Name = "alt";
            this.alt.Size = new System.Drawing.Size(38, 23);
            this.alt.TabIndex = 189;
            this.alt.Text = "Alt:";
            // 
            // lblAltitude2
            // 
            this.lblAltitude2.AutoSize = true;
            this.lblAltitude2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblAltitude2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAltitude2.Location = new System.Drawing.Point(67, 76);
            this.lblAltitude2.Name = "lblAltitude2";
            this.lblAltitude2.Size = new System.Drawing.Size(106, 23);
            this.lblAltitude2.TabIndex = 188;
            this.lblAltitude2.Text = "------------";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.BackColor = System.Drawing.Color.Transparent;
            this.lblPitch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblPitch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblPitch.Location = new System.Drawing.Point(281, 76);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(40, 23);
            this.lblPitch.TabIndex = 187;
            this.lblPitch.Text = "1.2";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label14.ForeColor = System.Drawing.Color.Lime;
            this.label14.Location = new System.Drawing.Point(228, 76);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 23);
            this.label14.TabIndex = 186;
            this.label14.Text = "Pitch:";
            // 
            // lblSats
            // 
            this.lblSats.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSats.AutoSize = true;
            this.lblSats.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblSats.Location = new System.Drawing.Point(555, 27);
            this.lblSats.Name = "lblSats";
            this.lblSats.Size = new System.Drawing.Size(19, 19);
            this.lblSats.TabIndex = 183;
            this.lblSats.Text = "S";
            // 
            // lblFixQuality
            // 
            this.lblFixQuality.AutoSize = true;
            this.lblFixQuality.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblFixQuality.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblFixQuality.Location = new System.Drawing.Point(414, 65);
            this.lblFixQuality.Name = "lblFixQuality";
            this.lblFixQuality.Size = new System.Drawing.Size(41, 19);
            this.lblFixQuality.TabIndex = 181;
            this.lblFixQuality.Text = "PPS";
            // 
            // lblGPSHeading
            // 
            this.lblGPSHeading.AutoSize = true;
            this.lblGPSHeading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGPSHeading.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblGPSHeading.Location = new System.Drawing.Point(415, 92);
            this.lblGPSHeading.Name = "lblGPSHeading";
            this.lblGPSHeading.Size = new System.Drawing.Size(52, 23);
            this.lblGPSHeading.TabIndex = 136;
            this.lblGPSHeading.Text = "99.3";
            // 
            // lblZone
            // 
            this.lblZone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblZone.AutoSize = true;
            this.lblZone.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblZone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblZone.Location = new System.Drawing.Point(555, 4);
            this.lblZone.Name = "lblZone";
            this.lblZone.Size = new System.Drawing.Size(29, 19);
            this.lblZone.TabIndex = 135;
            this.lblZone.Text = "Zn";
            this.lblZone.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblEasting
            // 
            this.lblEasting.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblEasting.AutoSize = true;
            this.lblEasting.BackColor = System.Drawing.Color.Transparent;
            this.lblEasting.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblEasting.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEasting.Location = new System.Drawing.Point(438, 4);
            this.lblEasting.Name = "lblEasting";
            this.lblEasting.Size = new System.Drawing.Size(59, 19);
            this.lblEasting.TabIndex = 111;
            this.lblEasting.Text = "label2";
            this.lblEasting.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblNorthing
            // 
            this.lblNorthing.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNorthing.AutoSize = true;
            this.lblNorthing.BackColor = System.Drawing.Color.Transparent;
            this.lblNorthing.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lblNorthing.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblNorthing.Location = new System.Drawing.Point(438, 27);
            this.lblNorthing.Name = "lblNorthing";
            this.lblNorthing.Size = new System.Drawing.Size(59, 19);
            this.lblNorthing.TabIndex = 110;
            this.lblNorthing.Text = "label1";
            this.lblNorthing.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(394, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 19);
            this.label1.TabIndex = 185;
            this.label1.Text = "E:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Lime;
            this.label7.Location = new System.Drawing.Point(392, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 19);
            this.label7.TabIndex = 184;
            this.label7.Text = "N:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.Lime;
            this.label17.Location = new System.Drawing.Point(380, 61);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 23);
            this.label17.TabIndex = 182;
            this.label17.Text = "Fix:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label19.ForeColor = System.Drawing.Color.Lime;
            this.label19.Location = new System.Drawing.Point(28, 13);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(42, 23);
            this.label19.TabIndex = 178;
            this.label19.Text = "Lat:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label18.ForeColor = System.Drawing.Color.Lime;
            this.label18.Location = new System.Drawing.Point(23, 44);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 23);
            this.label18.TabIndex = 177;
            this.label18.Text = "Lon:";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLongitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLongitude.Location = new System.Drawing.Point(67, 44);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(124, 23);
            this.lblLongitude.TabIndex = 176;
            this.lblLongitude.Text = "111.253475";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblLatitude.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblLatitude.Location = new System.Drawing.Point(67, 13);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(112, 23);
            this.lblLatitude.TabIndex = 175;
            this.lblLatitude.Text = "53.234455";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.BackColor = System.Drawing.Color.Transparent;
            this.lblRoll.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblRoll.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRoll.Location = new System.Drawing.Point(281, 44);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(40, 23);
            this.lblRoll.TabIndex = 138;
            this.lblRoll.Text = "1.2";
            // 
            // lblGyroHeading
            // 
            this.lblGyroHeading.AutoSize = true;
            this.lblGyroHeading.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblGyroHeading.ForeColor = System.Drawing.Color.White;
            this.lblGyroHeading.Location = new System.Drawing.Point(281, 13);
            this.lblGyroHeading.Name = "lblGyroHeading";
            this.lblGyroHeading.Size = new System.Drawing.Size(52, 23);
            this.lblGyroHeading.TabIndex = 135;
            this.lblGyroHeading.Text = "22.6";
            // 
            // tboxSentence
            // 
            this.tboxSentence.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxSentence.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tboxSentence.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tboxSentence.ForeColor = System.Drawing.SystemColors.Window;
            this.tboxSentence.Location = new System.Drawing.Point(18, 127);
            this.tboxSentence.Multiline = true;
            this.tboxSentence.Name = "tboxSentence";
            this.tboxSentence.ReadOnly = true;
            this.tboxSentence.Size = new System.Drawing.Size(566, 112);
            this.tboxSentence.TabIndex = 134;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label10.ForeColor = System.Drawing.Color.Lime;
            this.label10.Location = new System.Drawing.Point(239, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(47, 23);
            this.label10.TabIndex = 4;
            this.label10.Text = "Roll:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label9.ForeColor = System.Drawing.Color.Lime;
            this.label9.Location = new System.Drawing.Point(230, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 23);
            this.label9.TabIndex = 3;
            this.label9.Text = "Gyro:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.label8.ForeColor = System.Drawing.Color.Lime;
            this.label8.Location = new System.Drawing.Point(370, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 2;
            this.label8.Text = "GPS:";
            // 
            // tabGradeControl
            // 
            this.tabGradeControl.AccessibleDescription = "";
            this.tabGradeControl.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabGradeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tabGradeControl.Controls.Add(this.OpenGradePage);
            this.tabGradeControl.Controls.Add(this.GPSPage);
            this.tabGradeControl.Controls.Add(this.SettingsPage);
            this.tabGradeControl.Font = new System.Drawing.Font("Times New Roman", 20.25F);
            this.tabGradeControl.ImageList = this.imageList1;
            this.tabGradeControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabGradeControl.ItemSize = new System.Drawing.Size(86, 60);
            this.tabGradeControl.Location = new System.Drawing.Point(632, 46);
            this.tabGradeControl.Margin = new System.Windows.Forms.Padding(0);
            this.tabGradeControl.Multiline = true;
            this.tabGradeControl.Name = "tabGradeControl";
            this.tabGradeControl.SelectedIndex = 0;
            this.tabGradeControl.Size = new System.Drawing.Size(669, 263);
            this.tabGradeControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabGradeControl.TabIndex = 150;
            // 
            // lblDiagnostics
            // 
            this.lblDiagnostics.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDiagnostics.BackColor = System.Drawing.SystemColors.InfoText;
            this.lblDiagnostics.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblDiagnostics.Font = new System.Drawing.Font("Tahoma", 21.75F);
            this.lblDiagnostics.ForeColor = System.Drawing.Color.Green;
            this.lblDiagnostics.Location = new System.Drawing.Point(419, 7);
            this.lblDiagnostics.Margin = new System.Windows.Forms.Padding(0, 0, 0, 4);
            this.lblDiagnostics.Name = "lblDiagnostics";
            this.lblDiagnostics.ReadOnly = true;
            this.lblDiagnostics.Size = new System.Drawing.Size(200, 36);
            this.lblDiagnostics.TabIndex = 227;
            this.lblDiagnostics.Text = "---------------\r\n";
            this.lblDiagnostics.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblDiagnostics.TextChanged += new System.EventHandler(this.labelDiagnostics_TextChanged);
            // 
            // lblMaxDepth
            // 
            this.lblMaxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxDepth.AutoSize = true;
            this.lblMaxDepth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMaxDepth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxDepth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaxDepth.Location = new System.Drawing.Point(1000, 377);
            this.lblMaxDepth.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblMaxDepth.MinimumSize = new System.Drawing.Size(133, 0);
            this.lblMaxDepth.Name = "lblMaxDepth";
            this.lblMaxDepth.Size = new System.Drawing.Size(133, 19);
            this.lblMaxDepth.TabIndex = 228;
            this.lblMaxDepth.Text = "-Max Cut Depth";
            this.lblMaxDepth.Visible = false;
            // 
            // lblMinCover
            // 
            this.lblMinCover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinCover.AutoSize = true;
            this.lblMinCover.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMinCover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMinCover.Location = new System.Drawing.Point(1000, 358);
            this.lblMinCover.Name = "lblMinCover";
            this.lblMinCover.Size = new System.Drawing.Size(133, 19);
            this.lblMinCover.TabIndex = 229;
            this.lblMinCover.Text = "-Min Cover Depth";
            this.lblMinCover.Visible = false;
            // 
            // sqrMinCover
            // 
            this.sqrMinCover.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sqrMinCover.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqrMinCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(39)))));
            this.sqrMinCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrMinCover.Location = new System.Drawing.Point(976, 358);
            this.sqrMinCover.Name = "sqrMinCover";
            this.sqrMinCover.Size = new System.Drawing.Size(19, 19);
            this.sqrMinCover.TabIndex = 230;
            this.sqrMinCover.UseVisualStyleBackColor = false;
            this.sqrMinCover.Visible = false;
            // 
            // sqrMaxDepth
            // 
            this.sqrMaxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqrMaxDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sqrMaxDepth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrMaxDepth.Location = new System.Drawing.Point(976, 377);
            this.sqrMaxDepth.Name = "sqrMaxDepth";
            this.sqrMaxDepth.Size = new System.Drawing.Size(19, 19);
            this.sqrMaxDepth.TabIndex = 231;
            this.sqrMaxDepth.UseVisualStyleBackColor = false;
            this.sqrMaxDepth.Visible = false;
            // 
            // sqrCutLine1
            // 
            this.sqrCutLine1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqrCutLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.sqrCutLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrCutLine1.Location = new System.Drawing.Point(813, 358);
            this.sqrCutLine1.Name = "sqrCutLine1";
            this.sqrCutLine1.Size = new System.Drawing.Size(19, 19);
            this.sqrCutLine1.TabIndex = 233;
            this.sqrCutLine1.UseVisualStyleBackColor = false;
            this.sqrCutLine1.Visible = false;
            // 
            // lblCutLine
            // 
            this.lblCutLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCutLine.AutoSize = true;
            this.lblCutLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCutLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCutLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCutLine.Location = new System.Drawing.Point(837, 358);
            this.lblCutLine.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblCutLine.MinimumSize = new System.Drawing.Size(133, 0);
            this.lblCutLine.Name = "lblCutLine";
            this.lblCutLine.Size = new System.Drawing.Size(133, 19);
            this.lblCutLine.TabIndex = 232;
            this.lblCutLine.Text = "-Cut Line";
            this.lblCutLine.Visible = false;
            // 
            // sqrDitchCutLine
            // 
            this.sqrDitchCutLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sqrDitchCutLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.sqrDitchCutLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrDitchCutLine.Location = new System.Drawing.Point(813, 377);
            this.sqrDitchCutLine.Name = "sqrDitchCutLine";
            this.sqrDitchCutLine.Size = new System.Drawing.Size(19, 19);
            this.sqrDitchCutLine.TabIndex = 235;
            this.sqrDitchCutLine.UseVisualStyleBackColor = false;
            this.sqrDitchCutLine.Visible = false;
            // 
            // lblDitchCutLine
            // 
            this.lblDitchCutLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDitchCutLine.AutoSize = true;
            this.lblDitchCutLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDitchCutLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDitchCutLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDitchCutLine.Location = new System.Drawing.Point(837, 377);
            this.lblDitchCutLine.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblDitchCutLine.MinimumSize = new System.Drawing.Size(133, 0);
            this.lblDitchCutLine.Name = "lblDitchCutLine";
            this.lblDitchCutLine.Size = new System.Drawing.Size(133, 19);
            this.lblDitchCutLine.TabIndex = 234;
            this.lblDitchCutLine.Text = "-Ditch Cut line";
            this.lblDitchCutLine.Visible = false;
            // 
            // btnContour
            // 
            this.btnContour.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnContour.BackColor = System.Drawing.Color.Lavender;
            this.btnContour.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnContour.Enabled = false;
            this.btnContour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnContour.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnContour.Image = ((System.Drawing.Image)(resources.GetObject("btnContour.Image")));
            this.btnContour.Location = new System.Drawing.Point(530, 227);
            this.btnContour.Name = "btnContour";
            this.btnContour.Size = new System.Drawing.Size(10, 10);
            this.btnContour.TabIndex = 105;
            this.btnContour.Text = "Contour";
            this.btnContour.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnContour.UseVisualStyleBackColor = false;
            this.btnContour.Visible = false;
            this.btnContour.Click += new System.EventHandler(this.btnContour_Click);
            // 
            // btnGradeControl
            // 
            this.btnGradeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGradeControl.BackColor = System.Drawing.Color.Transparent;
            this.btnGradeControl.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnGradeControl.Enabled = false;
            this.btnGradeControl.FlatAppearance.BorderSize = 0;
            this.btnGradeControl.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnGradeControl.Image = global::OpenGrade.Properties.Resources.GradeControlOff1;
            this.btnGradeControl.Location = new System.Drawing.Point(530, 248);
            this.btnGradeControl.Name = "btnGradeControl";
            this.btnGradeControl.Size = new System.Drawing.Size(90, 90);
            this.btnGradeControl.TabIndex = 128;
            this.btnGradeControl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGradeControl.UseVisualStyleBackColor = false;
            this.btnGradeControl.Click += new System.EventHandler(this.btnGradeControl_Click);
            // 
            // btnZoomIn
            // 
            this.btnZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomIn.BackColor = System.Drawing.Color.Black;
            this.btnZoomIn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomIn.BackgroundImage")));
            this.btnZoomIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomIn.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnZoomIn.Location = new System.Drawing.Point(458, 56);
            this.btnZoomIn.Name = "btnZoomIn";
            this.btnZoomIn.Size = new System.Drawing.Size(69, 52);
            this.btnZoomIn.TabIndex = 120;
            this.btnZoomIn.UseVisualStyleBackColor = false;
            this.btnZoomIn.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomIn_MouseDown);
            // 
            // btnTiltDown
            // 
            this.btnTiltDown.BackColor = System.Drawing.Color.Black;
            this.btnTiltDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiltDown.BackgroundImage")));
            this.btnTiltDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTiltDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTiltDown.Location = new System.Drawing.Point(103, 51);
            this.btnTiltDown.Name = "btnTiltDown";
            this.btnTiltDown.Size = new System.Drawing.Size(69, 52);
            this.btnTiltDown.TabIndex = 122;
            this.btnTiltDown.UseVisualStyleBackColor = false;
            this.btnTiltDown.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTiltDown_MouseDown);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnZoomOut.BackColor = System.Drawing.Color.Black;
            this.btnZoomOut.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnZoomOut.BackgroundImage")));
            this.btnZoomOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnZoomOut.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnZoomOut.Location = new System.Drawing.Point(551, 56);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(69, 52);
            this.btnZoomOut.TabIndex = 119;
            this.btnZoomOut.UseVisualStyleBackColor = false;
            this.btnZoomOut.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnZoomOut_MouseDown);
            // 
            // btnTiltUp
            // 
            this.btnTiltUp.BackColor = System.Drawing.Color.Black;
            this.btnTiltUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiltUp.BackgroundImage")));
            this.btnTiltUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTiltUp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnTiltUp.Location = new System.Drawing.Point(6, 51);
            this.btnTiltUp.Name = "btnTiltUp";
            this.btnTiltUp.Size = new System.Drawing.Size(69, 52);
            this.btnTiltUp.TabIndex = 123;
            this.btnTiltUp.UseVisualStyleBackColor = false;
            this.btnTiltUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnTiltUp_MouseDown);
            // 
            // btnManualOffOn
            // 
            this.btnManualOffOn.BackColor = System.Drawing.Color.Black;
            this.btnManualOffOn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnManualOffOn.Enabled = false;
            this.btnManualOffOn.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnManualOffOn.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnManualOffOn.Image = global::OpenGrade.Properties.Resources.SurveyStart;
            this.btnManualOffOn.Location = new System.Drawing.Point(12, 242);
            this.btnManualOffOn.Name = "btnManualOffOn";
            this.btnManualOffOn.Size = new System.Drawing.Size(90, 90);
            this.btnManualOffOn.TabIndex = 98;
            this.btnManualOffOn.UseVisualStyleBackColor = false;
            this.btnManualOffOn.Click += new System.EventHandler(this.btnManualOffOn_Click);
            // 
            // voltageBar
            // 
            this.voltageBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voltageBar.BarBackColor = System.Drawing.Color.Black;
            cBlendItems3.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            cBlendItems3.iPoint = new float[] {
        0F,
        0.4378882F,
        0.5031056F,
        1F};
            this.voltageBar.BarColorBlend = cBlendItems3;
            this.voltageBar.BarColorSolid = System.Drawing.Color.RoyalBlue;
            this.voltageBar.BarColorSolidB = System.Drawing.Color.RoyalBlue;
            this.voltageBar.BarLength = ProgBar.ProgBarPlus.eBarLength.Fixed;
            this.voltageBar.BarLengthValue = ((short)(25));
            this.voltageBar.BarPadding = new System.Windows.Forms.Padding(0);
            this.voltageBar.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.voltageBar.BarStyleHatch = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            this.voltageBar.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.voltageBar.BarStyleTexture = null;
            this.voltageBar.BorderWidth = ((short)(1));
            this.voltageBar.Corners.All = ((short)(0));
            this.voltageBar.Corners.LowerLeft = ((short)(0));
            this.voltageBar.Corners.LowerRight = ((short)(0));
            this.voltageBar.Corners.UpperLeft = ((short)(0));
            this.voltageBar.Corners.UpperRight = ((short)(0));
            this.voltageBar.CylonInterval = ((short)(1));
            this.voltageBar.CylonMove = 1F;
            cFocalPoints3.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints3.CenterPoint")));
            cFocalPoints3.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints3.FocusScales")));
            this.voltageBar.FocalPoints = cFocalPoints3;
            this.voltageBar.Location = new System.Drawing.Point(1184, 347);
            this.voltageBar.Max = 500;
            this.voltageBar.Name = "voltageBar";
            this.voltageBar.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.voltageBar.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.voltageBar.Size = new System.Drawing.Size(18, 271);
            this.voltageBar.TabIndex = 236;
            this.voltageBar.TextFormat = "Process {1}% Done";
            this.voltageBar.Value = 300;
            // 
            // lblMaxVoltage
            // 
            this.lblMaxVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxVoltage.AutoSize = true;
            this.lblMaxVoltage.BackColor = System.Drawing.Color.Black;
            this.lblMaxVoltage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMaxVoltage.Location = new System.Drawing.Point(1141, 351);
            this.lblMaxVoltage.Name = "lblMaxVoltage";
            this.lblMaxVoltage.Size = new System.Drawing.Size(37, 19);
            this.lblMaxVoltage.TabIndex = 237;
            this.lblMaxVoltage.Text = "EXT";
            // 
            // lblMinVoltage
            // 
            this.lblMinVoltage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMinVoltage.AutoSize = true;
            this.lblMinVoltage.BackColor = System.Drawing.Color.Black;
            this.lblMinVoltage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblMinVoltage.Location = new System.Drawing.Point(1141, 616);
            this.lblMinVoltage.Name = "lblMinVoltage";
            this.lblMinVoltage.Size = new System.Drawing.Size(38, 19);
            this.lblMinVoltage.TabIndex = 238;
            this.lblMinVoltage.Text = "RET";
            // 
            // lblFloatVoltage
            // 
            this.lblFloatVoltage.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblFloatVoltage.AutoSize = true;
            this.lblFloatVoltage.BackColor = System.Drawing.Color.Black;
            this.lblFloatVoltage.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblFloatVoltage.Location = new System.Drawing.Point(1152, 485);
            this.lblFloatVoltage.Name = "lblFloatVoltage";
            this.lblFloatVoltage.Size = new System.Drawing.Size(20, 19);
            this.lblFloatVoltage.TabIndex = 239;
            this.lblFloatVoltage.Text = "N";
            // 
            // lblBladeOffset
            // 
            this.lblBladeOffset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBladeOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBladeOffset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBladeOffset.Location = new System.Drawing.Point(154, 354);
            this.lblBladeOffset.Name = "lblBladeOffset";
            this.lblBladeOffset.Size = new System.Drawing.Size(55, 38);
            this.lblBladeOffset.TabIndex = 240;
            this.lblBladeOffset.Text = "0";
            this.lblBladeOffset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBladeOffset.Click += new System.EventHandler(this.lblBladeOffset_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label5.Location = new System.Drawing.Point(9, 354);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 38);
            this.label5.TabIndex = 241;
            this.label5.Text = "Blade Offset";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnAutoCut
            // 
            this.btnAutoCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutoCut.BackColor = System.Drawing.Color.Black;
            this.btnAutoCut.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoCut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutoCut.Location = new System.Drawing.Point(12, 494);
            this.btnAutoCut.Name = "btnAutoCut";
            this.btnAutoCut.Size = new System.Drawing.Size(90, 89);
            this.btnAutoCut.TabIndex = 242;
            this.btnAutoCut.Text = "Auto Cut";
            this.btnAutoCut.UseVisualStyleBackColor = false;
            this.btnAutoCut.Visible = false;
            this.btnAutoCut.Click += new System.EventHandler(this.btnAutoCut_Click);
            // 
            // btnIncCut
            // 
            this.btnIncCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnIncCut.BackColor = System.Drawing.Color.Black;
            this.btnIncCut.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncCut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIncCut.Location = new System.Drawing.Point(252, 530);
            this.btnIncCut.Name = "btnIncCut";
            this.btnIncCut.Size = new System.Drawing.Size(59, 53);
            this.btnIncCut.TabIndex = 243;
            this.btnIncCut.Text = "+";
            this.btnIncCut.UseVisualStyleBackColor = false;
            this.btnIncCut.Visible = false;
            this.btnIncCut.Click += new System.EventHandler(this.btnIncCut_Click);
            // 
            // btnDecCut
            // 
            this.btnDecCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDecCut.BackColor = System.Drawing.Color.Black;
            this.btnDecCut.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecCut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecCut.Location = new System.Drawing.Point(105, 530);
            this.btnDecCut.Name = "btnDecCut";
            this.btnDecCut.Size = new System.Drawing.Size(59, 53);
            this.btnDecCut.TabIndex = 244;
            this.btnDecCut.Text = "-";
            this.btnDecCut.UseVisualStyleBackColor = false;
            this.btnDecCut.Visible = false;
            this.btnDecCut.Click += new System.EventHandler(this.btnDecCut_Click);
            // 
            // lblAutoCutDepth
            // 
            this.lblAutoCutDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblAutoCutDepth.BackColor = System.Drawing.Color.Black;
            this.lblAutoCutDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutoCutDepth.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lblAutoCutDepth.Location = new System.Drawing.Point(167, 530);
            this.lblAutoCutDepth.Name = "lblAutoCutDepth";
            this.lblAutoCutDepth.Size = new System.Drawing.Size(82, 53);
            this.lblAutoCutDepth.TabIndex = 245;
            this.lblAutoCutDepth.Text = "0";
            this.lblAutoCutDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblAutoCutDepth.Visible = false;
            // 
            // lblPassDepth
            // 
            this.lblPassDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPassDepth.AutoSize = true;
            this.lblPassDepth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblPassDepth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPassDepth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblPassDepth.Location = new System.Drawing.Point(136, 508);
            this.lblPassDepth.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblPassDepth.MinimumSize = new System.Drawing.Size(133, 0);
            this.lblPassDepth.Name = "lblPassDepth";
            this.lblPassDepth.Size = new System.Drawing.Size(145, 19);
            this.lblPassDepth.TabIndex = 246;
            this.lblPassDepth.Text = "Desired Pass Depth";
            this.lblPassDepth.Visible = false;
            // 
            // voltageBar2
            // 
            this.voltageBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.voltageBar2.BarBackColor = System.Drawing.Color.Black;
            cBlendItems4.iColor = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(0))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))))};
            cBlendItems4.iPoint = new float[] {
        0F,
        0.4378882F,
        0.5031056F,
        1F};
            this.voltageBar2.BarColorBlend = cBlendItems4;
            this.voltageBar2.BarColorSolid = System.Drawing.Color.RoyalBlue;
            this.voltageBar2.BarColorSolidB = System.Drawing.Color.RoyalBlue;
            this.voltageBar2.BarLength = ProgBar.ProgBarPlus.eBarLength.Fixed;
            this.voltageBar2.BarLengthValue = ((short)(25));
            this.voltageBar2.BarPadding = new System.Windows.Forms.Padding(0);
            this.voltageBar2.BarStyleFill = ProgBar.ProgBarPlus.eBarStyle.Solid;
            this.voltageBar2.BarStyleHatch = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
            this.voltageBar2.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.voltageBar2.BarStyleTexture = null;
            this.voltageBar2.BorderWidth = ((short)(1));
            this.voltageBar2.Corners.All = ((short)(0));
            this.voltageBar2.Corners.LowerLeft = ((short)(0));
            this.voltageBar2.Corners.LowerRight = ((short)(0));
            this.voltageBar2.Corners.UpperLeft = ((short)(0));
            this.voltageBar2.Corners.UpperRight = ((short)(0));
            this.voltageBar2.CylonInterval = ((short)(1));
            this.voltageBar2.CylonMove = 1F;
            cFocalPoints4.CenterPoint = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints4.CenterPoint")));
            cFocalPoints4.FocusScales = ((System.Drawing.PointF)(resources.GetObject("cFocalPoints4.FocusScales")));
            this.voltageBar2.FocalPoints = cFocalPoints4;
            this.voltageBar2.Location = new System.Drawing.Point(1205, 347);
            this.voltageBar2.Max = 500;
            this.voltageBar2.Name = "voltageBar2";
            this.voltageBar2.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.voltageBar2.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.voltageBar2.Size = new System.Drawing.Size(18, 271);
            this.voltageBar2.TabIndex = 247;
            this.voltageBar2.TextFormat = "Process {1}% Done";
            this.voltageBar2.Value = 300;
            // 
            // label20
            // 
            this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Black;
            this.label20.ForeColor = System.Drawing.Color.Lime;
            this.label20.Location = new System.Drawing.Point(1184, 619);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(18, 19);
            this.label20.TabIndex = 248;
            this.label20.Text = "1";
            // 
            // label21
            // 
            this.label21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Black;
            this.label21.ForeColor = System.Drawing.Color.Lime;
            this.label21.Location = new System.Drawing.Point(1205, 619);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(18, 19);
            this.label21.TabIndex = 249;
            this.label21.Text = "3";
            // 
            // btnAutoShore
            // 
            this.btnAutoShore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAutoShore.BackColor = System.Drawing.Color.Black;
            this.btnAutoShore.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutoShore.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAutoShore.Location = new System.Drawing.Point(12, 399);
            this.btnAutoShore.Name = "btnAutoShore";
            this.btnAutoShore.Size = new System.Drawing.Size(90, 89);
            this.btnAutoShore.TabIndex = 250;
            this.btnAutoShore.Text = "Auto Shore";
            this.btnAutoShore.UseVisualStyleBackColor = false;
            this.btnAutoShore.Visible = false;
            this.btnAutoShore.Click += new System.EventHandler(this.btnAutoShore_Click);
            // 
            // FormGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1306, 684);
            this.Controls.Add(this.btnAutoShore);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.voltageBar2);
            this.Controls.Add(this.lblPassDepth);
            this.Controls.Add(this.lblAutoCutDepth);
            this.Controls.Add(this.btnDecCut);
            this.Controls.Add(this.btnIncCut);
            this.Controls.Add(this.btnAutoCut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblBladeOffset);
            this.Controls.Add(this.lblFloatVoltage);
            this.Controls.Add(this.lblMinVoltage);
            this.Controls.Add(this.lblMaxVoltage);
            this.Controls.Add(this.voltageBar);
            this.Controls.Add(this.sqrDitchCutLine);
            this.Controls.Add(this.lblDitchCutLine);
            this.Controls.Add(this.sqrCutLine1);
            this.Controls.Add(this.lblCutLine);
            this.Controls.Add(this.sqrMaxDepth);
            this.Controls.Add(this.sqrMinCover);
            this.Controls.Add(this.lblMinCover);
            this.Controls.Add(this.lblMaxDepth);
            this.Controls.Add(this.lblDiagnostics);
            this.Controls.Add(this.lblBarGraphMax);
            this.Controls.Add(this.pbarCutAbove);
            this.Controls.Add(this.btnContour);
            this.Controls.Add(this.pbarCutBelow);
            this.Controls.Add(this.btnGradeControl);
            this.Controls.Add(this.lblCutFillRatio);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDrawSlope);
            this.Controls.Add(this.lblCut);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.btnZoomIn);
            this.Controls.Add(this.btnTiltDown);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnTiltUp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAltitude);
            this.Controls.Add(this.tabGradeControl);
            this.Controls.Add(this.lblHeading);
            this.Controls.Add(this.panelSimControls);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.sqrCutLine);
            this.Controls.Add(this.lblFill);
            this.Controls.Add(this.btnManualOffOn);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.lblSpeedUnits);
            this.Controls.Add(this.lblSpeed);
            this.Controls.Add(this.txtDistanceOffABLine);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.openGLControl);
            this.Controls.Add(this.openGLControlBack);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(520, 600);
            this.Name = "FormGPS";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OpenGradeX - Black Ace";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGPS_FormClosing);
            this.Load += new System.EventHandler(this.FormGPS_Load);
            this.Resize += new System.EventHandler(this.FormGPS_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.contextMenuStripOpenGL.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlBack)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripFlag.ResumeLayout(false);
            this.panelSimControls.ResumeLayout(false);
            this.panelSimControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElevation)).EndInit();
            this.OpenGradePage.ResumeLayout(false);
            this.OpenGradePage.PerformLayout();
            this.SettingsPage.ResumeLayout(false);
            this.connectionGroupBox.ResumeLayout(false);
            this.connectionGroupBox.PerformLayout();
            this.GPSPage.ResumeLayout(false);
            this.GPSPage.PerformLayout();
            this.tabGradeControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.TextBox txtDistanceOffABLine;
        private SharpGL.OpenGLControl openGLControlBack;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Timer tmrWatchdog;
        private System.Windows.Forms.ToolStripMenuItem polygonsToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel stripDistance;
        private System.Windows.Forms.ToolStripMenuItem resetALLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveVehicleToolStripMenuItem;
        public System.Windows.Forms.Button btnManualOffOn;
        private System.Windows.Forms.Button btnContour;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightbarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldViewerToolStripMenuItem;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.ToolStripMenuItem googleEarthToolStripMenuItem;
        private ProXoft.WinForms.RepeatButton btnZoomOut;
        private ProXoft.WinForms.RepeatButton btnZoomIn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFlag;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFlagRed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagGrn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagYel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private ProXoft.WinForms.RepeatButton btnTiltUp;
        private ProXoft.WinForms.RepeatButton btnTiltDown;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagDeleteAll;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripOpenGL;
        private System.Windows.Forms.ToolStripMenuItem deleteFlagToolOpenGLContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem googleEarthOpenGLContextMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem gPSDataToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fieldToolStripMenuItem;
        private System.Windows.Forms.ToolStripProgressBar stripOnlineGPS;
        private System.Windows.Forms.ToolStripMenuItem colorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldToolStripMenuItem1;
        private System.Windows.Forms.ToolStripProgressBar stripOnlineAutoSteer;
        private System.Windows.Forms.ToolStripMenuItem logNMEAMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripUnitsMenu;
        private System.Windows.Forms.ToolStripMenuItem metricToolStrip;
        private System.Windows.Forms.ToolStripMenuItem imperialToolStrip;
        private System.Windows.Forms.ToolStripMenuItem skyToolStripMenu;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuHelpHelp;
        private System.Windows.Forms.Label lblSpeedUnits;
        private System.Windows.Forms.ToolStripMenuItem pursuitLineToolStripMenuItem;
        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btnGradeControl;
        private System.Windows.Forms.Timer timerSim;
        private System.Windows.Forms.TrackBar tbarStepDistance;
        private System.Windows.Forms.TrackBar tbarSteerAngle;
        private System.Windows.Forms.Button btnResetSteerAngle;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Button btnResetSim;
        private System.Windows.Forms.ToolStripMenuItem simulatorOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownBtnFuncs;
        private System.Windows.Forms.Label sqrCutLine;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem toolstripVehicleConfig;
        private System.Windows.Forms.ToolStripMenuItem toolstripResetTrip;
        private System.Windows.Forms.ToolStripMenuItem toolstripField;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ToolStripMenuItem toolstripUDPConfig;
        private System.Windows.Forms.Label lblAltitude;
        private System.Windows.Forms.Panel panelSimControls;
        private System.Windows.Forms.ToolStripStatusLabel stripEqWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem setWorkingDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.NumericUpDown nudElevation;
        private System.Windows.Forms.ToolStripStatusLabel stripTopoLocation;
        private System.Windows.Forms.Label lblFill;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label lblCut;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ToolStripStatusLabel stripMinMax;
        private System.Windows.Forms.Label lblCutFillRatio;
        private System.Windows.Forms.Label lblDrawSlope;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnGoogleEarth;
        private ProgBar.ProgBarPlus pbarCutBelow;
        private ProgBar.ProgBarPlus pbarCutAbove;
        private System.Windows.Forms.Label lblBarGraphMax;
        private System.Windows.Forms.TabPage OpenGradePage;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCutDelta;
        private System.Windows.Forms.Button btnClearLastPass;
        private System.Windows.Forms.TabPage SettingsPage;
        private System.Windows.Forms.Button btnABLine;
        private System.Windows.Forms.Button btnUnits;
        private System.Windows.Forms.Button btnFileExplorer;
        private System.Windows.Forms.Button btnGPSData;
        private System.Windows.Forms.Button btnFlag;
        private System.Windows.Forms.Button btnSnap;
        private System.Windows.Forms.TabPage GPSPage;
        private System.Windows.Forms.Label lblSats;
        private System.Windows.Forms.Label lblFixQuality;
        private System.Windows.Forms.Label lblGPSHeading;
        private System.Windows.Forms.Label lblZone;
        private System.Windows.Forms.Label lblEasting;
        private System.Windows.Forms.Label lblNorthing;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblRoll;
        private System.Windows.Forms.Label lblGyroHeading;
        private System.Windows.Forms.TextBox tboxSentence;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TabControl tabGradeControl;
        private System.Windows.Forms.Button btnDoneDraw;
        private System.Windows.Forms.Button btnDeleteLastPoint;
        private System.Windows.Forms.Button btnStartDraw;
        private System.Windows.Forms.TextBox lblDiagnostics;
        private System.Windows.Forms.Button btnSurface;
        private System.Windows.Forms.Label lblDistanceToCut;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Label lblMaxDepth;
        private System.Windows.Forms.Label lblMinCover;
        private System.Windows.Forms.Button sqrMinCover;
        private System.Windows.Forms.Button sqrMaxDepth;
        private System.Windows.Forms.Button sqrCutLine1;
        private System.Windows.Forms.Label lblCutLine;
        private System.Windows.Forms.Button sqrDitchCutLine;
        private System.Windows.Forms.Label lblDitchCutLine;
        private System.Windows.Forms.Button btnAutoDrain;
        private ProgBar.ProgBarPlus voltageBar;
        private System.Windows.Forms.Label lblMaxVoltage;
        private System.Windows.Forms.Label lblMinVoltage;
        private System.Windows.Forms.Label lblFloatVoltage;
        public System.Windows.Forms.Button btnSaveCut;
        public System.Windows.Forms.Label lblBladeOffset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPitch;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ToolStripMenuItem remoteConfigurationToolStripMenuItem;
        private System.Windows.Forms.Label alt;
        private System.Windows.Forms.Label lblAltitude2;
        private System.Windows.Forms.Label lblUdpConnected;
        private System.Windows.Forms.Label lblAntennaConnected;
        private System.Windows.Forms.Button ledGradeControl;
        private System.Windows.Forms.Button ledAntenna;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAntennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGradeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCurrentCutDepth;
        private System.Windows.Forms.Label lblDistToTarget;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnAutoCut;
        private System.Windows.Forms.ToolStripMenuItem zeroIMUToolStripMenuItem;
        private System.Windows.Forms.Button btnIncCut;
        private System.Windows.Forms.Button btnDecCut;
        public System.Windows.Forms.Label lblAutoCutDepth;
        private System.Windows.Forms.Label lblPassDepth;
        private ProgBar.ProgBarPlus voltageBar2;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnAutoShore;
        private System.Windows.Forms.GroupBox connectionGroupBox;
    }
}

