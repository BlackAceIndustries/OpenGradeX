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
            this.fullscreenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.smoothLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tStripSmootingCB = new System.Windows.Forms.ToolStripComboBox();
            this.verifyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importAGSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tmrWatchdog = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.stripMinMax = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDistance = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDepth = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripDepthtoTarget = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripTopoLocation = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripOnlineGPS = new System.Windows.Forms.ToolStripProgressBar();
            this.stripOnlineAutoSteer = new System.Windows.Forms.ToolStripProgressBar();
            this.contextMenuStripFlag = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemFlagRed = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFlagGrn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuFlagYel = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuFlagDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuFlagDeleteAll = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panelSimControls = new System.Windows.Forms.Panel();
            this.nudLongitude = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.nudLatitude = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnResetSteerAngle = new System.Windows.Forms.Button();
            this.btnResetSim = new System.Windows.Forms.Button();
            this.lblSteerAngle = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tbarSteerAngle = new System.Windows.Forms.TrackBar();
            this.tbarStepDistance = new System.Windows.Forms.TrackBar();
            this.nudElevation = new System.Windows.Forms.NumericUpDown();
            this.timerSim = new System.Windows.Forms.Timer(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.pbarCutBelow = new ProgBar.ProgBarPlus();
            this.pbarCutAbove = new ProgBar.ProgBarPlus();
            this.lblBarGraphMax = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.lblCurrentCutDepth = new System.Windows.Forms.Label();
            this.lblDistToTarget = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCutDelta = new System.Windows.Forms.Label();
            this.ledNTRIP = new System.Windows.Forms.Button();
            this.ledRadio = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.lblMaxDepth = new System.Windows.Forms.Label();
            this.lblMinCover = new System.Windows.Forms.Label();
            this.sqrMinCover = new System.Windows.Forms.Button();
            this.sqrMaxDepth = new System.Windows.Forms.Button();
            this.sqrCutLine1 = new System.Windows.Forms.Button();
            this.lblCutLine = new System.Windows.Forms.Label();
            this.sqrDitchCutLine = new System.Windows.Forms.Button();
            this.lblDitchCutLine = new System.Windows.Forms.Label();
            this.voltageBar = new ProgBar.ProgBarPlus();
            this.lblBladeOffset = new System.Windows.Forms.Label();
            this.lblMode = new System.Windows.Forms.Label();
            this.btnIncCut = new System.Windows.Forms.Button();
            this.btnDecCut = new System.Windows.Forms.Button();
            this.voltageBar2 = new ProgBar.ProgBarPlus();
            this.lblCutDelta2 = new System.Windows.Forms.Label();
            this.lblRTKPopupTime = new System.Windows.Forms.Label();
            this.lblRTKPopup = new System.Windows.Forms.Label();
            this.toolStripDisplay = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton5 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStripDropDownButton3 = new System.Windows.Forms.ToolStripDropDownButton();
            this.vehicleSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nTRIPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.dSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dSettingsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.surfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ditchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip3DSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2DSurveyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripFieldInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeroTripToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSaveCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadCutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBoundaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripDropDownButton4 = new System.Windows.Forms.ToolStripDropDownButton();
            this.BottomToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.TopToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.RightToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.LeftToolStripPanel = new System.Windows.Forms.ToolStripPanel();
            this.ContentPanel = new System.Windows.Forms.ToolStripContentPanel();
            this.btnLevel = new System.Windows.Forms.Button();
            this.btnGradeControl = new System.Windows.Forms.Button();
            this.panelNavigation = new System.Windows.Forms.TableLayoutPanel();
            this.btnpTiltUp = new ProXoft.WinForms.RepeatButton();
            this.btn2D = new System.Windows.Forms.Button();
            this.btnN3D = new System.Windows.Forms.Button();
            this.btnDayNightMode = new System.Windows.Forms.Button();
            this.repeatButton1 = new ProXoft.WinForms.RepeatButton();
            this.repeatButton2 = new ProXoft.WinForms.RepeatButton();
            this.btnpTiltDown = new ProXoft.WinForms.RepeatButton();
            this.btn3D = new System.Windows.Forms.Button();
            this.btnN2D = new System.Windows.Forms.Button();
            this.lblHz = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelLegend = new System.Windows.Forms.Panel();
            this.ledGradeControl = new System.Windows.Forms.Button();
            this.lblAntennaConnected = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ledSurvey = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ledAuto = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ledRTK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ledAntenna = new System.Windows.Forms.Button();
            this.lblUdpConnected = new System.Windows.Forms.Label();
            this.panelCutDelta = new System.Windows.Forms.Panel();
            this.panelpBar = new System.Windows.Forms.Panel();
            this.panelDirectory = new System.Windows.Forms.Panel();
            this.lblTask = new System.Windows.Forms.Label();
            this.lblField = new System.Windows.Forms.Label();
            this.lblFarm = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnABLine = new System.Windows.Forms.Button();
            this.btnSimGoTo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.contextMenuStripOpenGL.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControlBack)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripFlag.SuspendLayout();
            this.panelSimControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElevation)).BeginInit();
            this.toolStripDisplay.SuspendLayout();
            this.panelNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelLegend.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panelCutDelta.SuspendLayout();
            this.panelpBar.SuspendLayout();
            this.panelDirectory.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControl.AutoSize = true;
            this.openGLControl.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openGLControl.ContextMenuStrip = this.contextMenuStripOpenGL;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Font = new System.Drawing.Font("Tahoma", 12F);
            this.openGLControl.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControl.FrameRate = 5;
            this.openGLControl.Location = new System.Drawing.Point(99, 45);
            this.openGLControl.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControl.Size = new System.Drawing.Size(1415, 500);
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
            // openGLControlBack
            // 
            this.openGLControlBack.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.openGLControlBack.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.openGLControlBack.Cursor = System.Windows.Forms.Cursors.Cross;
            this.openGLControlBack.DrawFPS = false;
            this.openGLControlBack.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.openGLControlBack.Location = new System.Drawing.Point(99, 550);
            this.openGLControlBack.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.openGLControlBack.Name = "openGLControlBack";
            this.openGLControlBack.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControlBack.RenderContextType = SharpGL.RenderContextType.NativeWindow;
            this.openGLControlBack.RenderTrigger = SharpGL.RenderTrigger.Manual;
            this.openGLControlBack.Size = new System.Drawing.Size(1415, 212);
            this.openGLControlBack.TabIndex = 91;
            this.openGLControlBack.OpenGLInitialized += new System.EventHandler(this.openGLControlBack_OpenGLInitialized);
            this.openGLControlBack.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControlBack_OpenGLDraw);
            this.openGLControlBack.Resized += new System.EventHandler(this.openGLControlBack_Resized);
            this.openGLControlBack.Load += new System.EventHandler(this.openGLControlBack_Load);
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
            this.fullscreenToolStripMenuItem,
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
            // fullscreenToolStripMenuItem
            // 
            this.fullscreenToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fullscreenToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fullscreenToolStripMenuItem.Name = "fullscreenToolStripMenuItem";
            this.fullscreenToolStripMenuItem.Size = new System.Drawing.Size(263, 40);
            this.fullscreenToolStripMenuItem.Text = "Full-Screen";
            this.fullscreenToolStripMenuItem.Click += new System.EventHandler(this.fullscreenToolStripMenuItem_Click_1);
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
            this.menuStrip1.Size = new System.Drawing.Size(1603, 38);
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
            this.zeroIMUToolStripMenuItem,
            this.toolStripMenuItem1,
            this.smoothLineToolStripMenuItem,
            this.importAGSToolStripMenuItem});
            this.toolsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Padding = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(93, 38);
            this.toolsToolStripMenuItem.Text = "Tools";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.toolsToolStripMenuItem_Click);
            // 
            // remoteConfigurationToolStripMenuItem
            // 
            this.remoteConfigurationToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.remoteConfigurationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.remoteConfigurationToolStripMenuItem.Name = "remoteConfigurationToolStripMenuItem";
            this.remoteConfigurationToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.remoteConfigurationToolStripMenuItem.Text = "Remote Setup";
            this.remoteConfigurationToolStripMenuItem.Click += new System.EventHandler(this.remoteConfigurationToolStripMenuItem_Click);
            // 
            // explorerToolStripMenuItem
            // 
            this.explorerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.explorerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.explorerToolStripMenuItem.Name = "explorerToolStripMenuItem";
            this.explorerToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.explorerToolStripMenuItem.Text = "Windows Explorer";
            this.explorerToolStripMenuItem.Click += new System.EventHandler(this.explorerToolStripMenuItem_Click);
            // 
            // webCamToolStripMenuItem
            // 
            this.webCamToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.webCamToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.webCamToolStripMenuItem.Name = "webCamToolStripMenuItem";
            this.webCamToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.webCamToolStripMenuItem.Text = "Web Cam";
            this.webCamToolStripMenuItem.Click += new System.EventHandler(this.webCamToolStripMenuItem_Click);
            // 
            // fieldViewerToolStripMenuItem
            // 
            this.fieldViewerToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.fieldViewerToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.fieldViewerToolStripMenuItem.Name = "fieldViewerToolStripMenuItem";
            this.fieldViewerToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.fieldViewerToolStripMenuItem.Text = "Field Viewer";
            this.fieldViewerToolStripMenuItem.Click += new System.EventHandler(this.fieldViewerToolStripMenuItem_Click);
            // 
            // googleEarthToolStripMenuItem
            // 
            this.googleEarthToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.googleEarthToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.googleEarthToolStripMenuItem.Name = "googleEarthToolStripMenuItem";
            this.googleEarthToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.googleEarthToolStripMenuItem.Text = "Google Earth - Flags";
            this.googleEarthToolStripMenuItem.Click += new System.EventHandler(this.googleEarthToolStripMenuItem_Click);
            // 
            // gPSDataToolStripMenuItem1
            // 
            this.gPSDataToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.gPSDataToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gPSDataToolStripMenuItem1.Name = "gPSDataToolStripMenuItem1";
            this.gPSDataToolStripMenuItem1.Size = new System.Drawing.Size(360, 46);
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
            this.helpToolStripMenuItem1.Size = new System.Drawing.Size(360, 46);
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
            this.resetModulesToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
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
            this.zeroIMUToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.zeroIMUToolStripMenuItem.Text = "Zero IMU";
            this.zeroIMUToolStripMenuItem.Click += new System.EventHandler(this.zeroIMUToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.toolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(360, 46);
            this.toolStripMenuItem1.Text = "DRO\'s";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // smoothLineToolStripMenuItem
            // 
            this.smoothLineToolStripMenuItem.AutoSize = false;
            this.smoothLineToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.smoothLineToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tStripSmootingCB,
            this.verifyToolStripMenuItem,
            this.applyToolStripMenuItem});
            this.smoothLineToolStripMenuItem.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.smoothLineToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.smoothLineToolStripMenuItem.Name = "smoothLineToolStripMenuItem";
            this.smoothLineToolStripMenuItem.Size = new System.Drawing.Size(360, 40);
            this.smoothLineToolStripMenuItem.Text = "Smooth line";
            this.smoothLineToolStripMenuItem.Click += new System.EventHandler(this.smoothLineToolStripMenuItem_Click);
            // 
            // tStripSmootingCB
            // 
            this.tStripSmootingCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.tStripSmootingCB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tStripSmootingCB.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.tStripSmootingCB.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.tStripSmootingCB.Margin = new System.Windows.Forms.Padding(0);
            this.tStripSmootingCB.Name = "tStripSmootingCB";
            this.tStripSmootingCB.Size = new System.Drawing.Size(300, 29);
            this.tStripSmootingCB.Text = "Smooting Factor";
            // 
            // verifyToolStripMenuItem
            // 
            this.verifyToolStripMenuItem.BackColor = System.Drawing.Color.Yellow;
            this.verifyToolStripMenuItem.Name = "verifyToolStripMenuItem";
            this.verifyToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.verifyToolStripMenuItem.Text = "Verify";
            this.verifyToolStripMenuItem.Click += new System.EventHandler(this.verifyToolStripMenuItem_Click);
            // 
            // applyToolStripMenuItem
            // 
            this.applyToolStripMenuItem.BackColor = System.Drawing.Color.LightGray;
            this.applyToolStripMenuItem.Enabled = false;
            this.applyToolStripMenuItem.Name = "applyToolStripMenuItem";
            this.applyToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.applyToolStripMenuItem.Text = "Apply";
            this.applyToolStripMenuItem.Click += new System.EventHandler(this.applyToolStripMenuItem_Click);
            // 
            // importAGSToolStripMenuItem
            // 
            this.importAGSToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.importAGSToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.importAGSToolStripMenuItem.Name = "importAGSToolStripMenuItem";
            this.importAGSToolStripMenuItem.Size = new System.Drawing.Size(360, 46);
            this.importAGSToolStripMenuItem.Text = "Import AGD";
            this.importAGSToolStripMenuItem.Click += new System.EventHandler(this.importAGSToolStripMenuItem_Click);
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
            this.stripDistance,
            this.stripDepth,
            this.stripDepthtoTarget,
            this.stripTopoLocation,
            this.stripOnlineGPS,
            this.stripOnlineAutoSteer});
            this.statusStrip1.Location = new System.Drawing.Point(5, 758);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(1603, 41);
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
            // stripDistance
            // 
            this.stripDistance.AutoSize = false;
            this.stripDistance.Font = new System.Drawing.Font("Tahoma", 18F);
            this.stripDistance.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripDistance.Name = "stripDistance";
            this.stripDistance.Size = new System.Drawing.Size(52, 41);
            this.stripDistance.Text = "8888 ft";
            // 
            // stripDepth
            // 
            this.stripDepth.AutoSize = false;
            this.stripDepth.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripDepth.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripDepth.Name = "stripDepth";
            this.stripDepth.Size = new System.Drawing.Size(200, 41);
            this.stripDepth.Text = "-- : -----";
            // 
            // stripDepthtoTarget
            // 
            this.stripDepthtoTarget.AutoSize = false;
            this.stripDepthtoTarget.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripDepthtoTarget.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripDepthtoTarget.Name = "stripDepthtoTarget";
            this.stripDepthtoTarget.Size = new System.Drawing.Size(200, 41);
            this.stripDepthtoTarget.Text = "-- : -----";
            // 
            // stripTopoLocation
            // 
            this.stripTopoLocation.AutoSize = false;
            this.stripTopoLocation.Font = new System.Drawing.Font("Tahoma", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stripTopoLocation.Margin = new System.Windows.Forms.Padding(-4, 0, 0, 0);
            this.stripTopoLocation.Name = "stripTopoLocation";
            this.stripTopoLocation.Size = new System.Drawing.Size(200, 41);
            this.stripTopoLocation.Text = "-- : -----";
            this.stripTopoLocation.Click += new System.EventHandler(this.stripTopoLocation_Click);
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
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "SateliteIcon.png");
            this.imageList1.Images.SetKeyName(1, "SettingsIcon.png");
            this.imageList1.Images.SetKeyName(2, "OpenGradeIcon.png");
            // 
            // panelSimControls
            // 
            this.panelSimControls.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panelSimControls.Controls.Add(this.btnSimGoTo);
            this.panelSimControls.Controls.Add(this.nudLongitude);
            this.panelSimControls.Controls.Add(this.label9);
            this.panelSimControls.Controls.Add(this.label10);
            this.panelSimControls.Controls.Add(this.nudLatitude);
            this.panelSimControls.Controls.Add(this.label3);
            this.panelSimControls.Controls.Add(this.btnResetSteerAngle);
            this.panelSimControls.Controls.Add(this.btnResetSim);
            this.panelSimControls.Controls.Add(this.lblSteerAngle);
            this.panelSimControls.Controls.Add(this.label11);
            this.panelSimControls.Controls.Add(this.label12);
            this.panelSimControls.Controls.Add(this.tbarSteerAngle);
            this.panelSimControls.Controls.Add(this.tbarStepDistance);
            this.panelSimControls.Controls.Add(this.nudElevation);
            this.panelSimControls.Location = new System.Drawing.Point(290, 648);
            this.panelSimControls.Name = "panelSimControls";
            this.panelSimControls.Size = new System.Drawing.Size(544, 104);
            this.panelSimControls.TabIndex = 172;
            // 
            // nudLongitude
            // 
            this.nudLongitude.DecimalPlaces = 7;
            this.nudLongitude.Location = new System.Drawing.Point(219, 72);
            this.nudLongitude.Maximum = new decimal(new int[] {
            180,
            0,
            0,
            0});
            this.nudLongitude.Minimum = new decimal(new int[] {
            180,
            0,
            0,
            -2147483648});
            this.nudLongitude.Name = "nudLongitude";
            this.nudLongitude.Size = new System.Drawing.Size(120, 27);
            this.nudLongitude.TabIndex = 194;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 19);
            this.label9.TabIndex = 193;
            this.label9.Text = "Long";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(8, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(30, 19);
            this.label10.TabIndex = 192;
            this.label10.Text = "Lat";
            // 
            // nudLatitude
            // 
            this.nudLatitude.DecimalPlaces = 7;
            this.nudLatitude.Location = new System.Drawing.Point(44, 72);
            this.nudLatitude.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.nudLatitude.Minimum = new decimal(new int[] {
            90,
            0,
            0,
            -2147483648});
            this.nudLatitude.Name = "nudLatitude";
            this.nudLatitude.Size = new System.Drawing.Size(120, 27);
            this.nudLatitude.TabIndex = 191;
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
            this.nudElevation.Location = new System.Drawing.Point(421, 64);
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
            // pbarCutBelow
            // 
            this.pbarCutBelow.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.pbarCutBelow.BarStyleLinear = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
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
            this.pbarCutBelow.Location = new System.Drawing.Point(0, 221);
            this.pbarCutBelow.Name = "pbarCutBelow";
            this.pbarCutBelow.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.pbarCutBelow.Shape = ProgBar.ProgBarPlus.eShape.TriangleUp;
            this.pbarCutBelow.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.pbarCutBelow.Size = new System.Drawing.Size(72, 229);
            this.pbarCutBelow.TabIndex = 223;
            this.pbarCutBelow.TextFormat = "Process {1}% Done";
            this.pbarCutBelow.Click += new System.EventHandler(this.pbarCutBelow_Click);
            // 
            // pbarCutAbove
            // 
            this.pbarCutAbove.Anchor = System.Windows.Forms.AnchorStyles.Top;
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
            this.pbarCutAbove.Location = new System.Drawing.Point(0, 5);
            this.pbarCutAbove.Name = "pbarCutAbove";
            this.pbarCutAbove.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.pbarCutAbove.Shape = ProgBar.ProgBarPlus.eShape.TriangleDown;
            this.pbarCutAbove.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.pbarCutAbove.Size = new System.Drawing.Size(72, 185);
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
            this.lblBarGraphMax.Location = new System.Drawing.Point(-4, -79);
            this.lblBarGraphMax.Name = "lblBarGraphMax";
            this.lblBarGraphMax.Size = new System.Drawing.Size(23, 29);
            this.lblBarGraphMax.TabIndex = 225;
            this.lblBarGraphMax.Text = "-";
            this.lblBarGraphMax.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label16.Location = new System.Drawing.Point(54, 106);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(102, 19);
            this.label16.TabIndex = 240;
            this.label16.Text = "Target Depth";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label15.Location = new System.Drawing.Point(65, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(80, 19);
            this.label15.TabIndex = 239;
            this.label15.Text = "Cut Depth";
            // 
            // lblCurrentCutDepth
            // 
            this.lblCurrentCutDepth.BackColor = System.Drawing.Color.Black;
            this.lblCurrentCutDepth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentCutDepth.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentCutDepth.ForeColor = System.Drawing.Color.Yellow;
            this.lblCurrentCutDepth.Location = new System.Drawing.Point(17, 29);
            this.lblCurrentCutDepth.Name = "lblCurrentCutDepth";
            this.lblCurrentCutDepth.Size = new System.Drawing.Size(176, 72);
            this.lblCurrentCutDepth.TabIndex = 238;
            this.lblCurrentCutDepth.Text = "--";
            this.lblCurrentCutDepth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDistToTarget
            // 
            this.lblDistToTarget.BackColor = System.Drawing.Color.Black;
            this.lblDistToTarget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDistToTarget.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistToTarget.ForeColor = System.Drawing.Color.Yellow;
            this.lblDistToTarget.Location = new System.Drawing.Point(17, 130);
            this.lblDistToTarget.Name = "lblDistToTarget";
            this.lblDistToTarget.Size = new System.Drawing.Size(177, 72);
            this.lblDistToTarget.TabIndex = 237;
            this.lblDistToTarget.Text = "--";
            this.lblDistToTarget.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(71, 202);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 227;
            this.label6.Text = "Cut Delta";
            // 
            // lblCutDelta
            // 
            this.lblCutDelta.BackColor = System.Drawing.Color.Black;
            this.lblCutDelta.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCutDelta.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutDelta.ForeColor = System.Drawing.Color.Yellow;
            this.lblCutDelta.Location = new System.Drawing.Point(17, 221);
            this.lblCutDelta.Name = "lblCutDelta";
            this.lblCutDelta.Size = new System.Drawing.Size(179, 92);
            this.lblCutDelta.TabIndex = 220;
            this.lblCutDelta.Text = "93";
            this.lblCutDelta.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCutDelta.Click += new System.EventHandler(this.lblCutDelta_Click);
            // 
            // ledNTRIP
            // 
            this.ledNTRIP.BackColor = System.Drawing.Color.Black;
            this.ledNTRIP.FlatAppearance.BorderSize = 0;
            this.ledNTRIP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledNTRIP.Location = new System.Drawing.Point(9, 6);
            this.ledNTRIP.Name = "ledNTRIP";
            this.ledNTRIP.Size = new System.Drawing.Size(26, 23);
            this.ledNTRIP.TabIndex = 164;
            this.ledNTRIP.UseVisualStyleBackColor = false;
            this.ledNTRIP.Click += new System.EventHandler(this.ledNTRIP_Click);
            // 
            // ledRadio
            // 
            this.ledRadio.BackColor = System.Drawing.Color.Black;
            this.ledRadio.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ledRadio.FlatAppearance.BorderSize = 0;
            this.ledRadio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledRadio.Location = new System.Drawing.Point(115, 6);
            this.ledRadio.Name = "ledRadio";
            this.ledRadio.Size = new System.Drawing.Size(26, 23);
            this.ledRadio.TabIndex = 163;
            this.ledRadio.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(145, 6);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 23);
            this.label13.TabIndex = 161;
            this.label13.Text = "Radio";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label22.Location = new System.Drawing.Point(39, 6);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(72, 23);
            this.label22.TabIndex = 162;
            this.label22.Text = "NTRIP";
            // 
            // lblMaxDepth
            // 
            this.lblMaxDepth.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMaxDepth.AutoSize = true;
            this.lblMaxDepth.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMaxDepth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMaxDepth.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMaxDepth.Location = new System.Drawing.Point(194, 25);
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
            this.lblMinCover.AutoSize = true;
            this.lblMinCover.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblMinCover.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMinCover.Location = new System.Drawing.Point(194, 6);
            this.lblMinCover.Name = "lblMinCover";
            this.lblMinCover.Size = new System.Drawing.Size(133, 19);
            this.lblMinCover.TabIndex = 229;
            this.lblMinCover.Text = "-Min Cover Depth";
            this.lblMinCover.Visible = false;
            // 
            // sqrMinCover
            // 
            this.sqrMinCover.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.sqrMinCover.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(212)))), ((int)(((byte)(39)))));
            this.sqrMinCover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrMinCover.Location = new System.Drawing.Point(170, 6);
            this.sqrMinCover.Name = "sqrMinCover";
            this.sqrMinCover.Size = new System.Drawing.Size(19, 19);
            this.sqrMinCover.TabIndex = 230;
            this.sqrMinCover.UseVisualStyleBackColor = false;
            this.sqrMinCover.Visible = false;
            // 
            // sqrMaxDepth
            // 
            this.sqrMaxDepth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.sqrMaxDepth.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrMaxDepth.Location = new System.Drawing.Point(170, 25);
            this.sqrMaxDepth.Name = "sqrMaxDepth";
            this.sqrMaxDepth.Size = new System.Drawing.Size(19, 19);
            this.sqrMaxDepth.TabIndex = 231;
            this.sqrMaxDepth.UseVisualStyleBackColor = false;
            this.sqrMaxDepth.Visible = false;
            // 
            // sqrCutLine1
            // 
            this.sqrCutLine1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.sqrCutLine1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrCutLine1.Location = new System.Drawing.Point(7, 6);
            this.sqrCutLine1.Name = "sqrCutLine1";
            this.sqrCutLine1.Size = new System.Drawing.Size(19, 19);
            this.sqrCutLine1.TabIndex = 233;
            this.sqrCutLine1.UseVisualStyleBackColor = false;
            this.sqrCutLine1.Visible = false;
            // 
            // lblCutLine
            // 
            this.lblCutLine.AutoSize = true;
            this.lblCutLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblCutLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblCutLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCutLine.Location = new System.Drawing.Point(31, 6);
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
            this.sqrDitchCutLine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(51)))));
            this.sqrDitchCutLine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqrDitchCutLine.Location = new System.Drawing.Point(7, 25);
            this.sqrDitchCutLine.Name = "sqrDitchCutLine";
            this.sqrDitchCutLine.Size = new System.Drawing.Size(19, 19);
            this.sqrDitchCutLine.TabIndex = 235;
            this.sqrDitchCutLine.UseVisualStyleBackColor = false;
            this.sqrDitchCutLine.Visible = false;
            // 
            // lblDitchCutLine
            // 
            this.lblDitchCutLine.AutoSize = true;
            this.lblDitchCutLine.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.lblDitchCutLine.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblDitchCutLine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblDitchCutLine.Location = new System.Drawing.Point(31, 25);
            this.lblDitchCutLine.MaximumSize = new System.Drawing.Size(150, 0);
            this.lblDitchCutLine.MinimumSize = new System.Drawing.Size(133, 0);
            this.lblDitchCutLine.Name = "lblDitchCutLine";
            this.lblDitchCutLine.Size = new System.Drawing.Size(133, 19);
            this.lblDitchCutLine.TabIndex = 234;
            this.lblDitchCutLine.Text = "-Ditch Cut line";
            this.lblDitchCutLine.Visible = false;
            // 
            // voltageBar
            // 
            this.voltageBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.voltageBar.Location = new System.Drawing.Point(8, 385);
            this.voltageBar.Max = 500;
            this.voltageBar.Name = "voltageBar";
            this.voltageBar.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.voltageBar.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.voltageBar.Size = new System.Drawing.Size(40, 367);
            this.voltageBar.TabIndex = 236;
            this.voltageBar.TextFormat = "Process {1}% Done";
            this.voltageBar.Value = 300;
            this.voltageBar.Load += new System.EventHandler(this.voltageBar_Load);
            // 
            // lblBladeOffset
            // 
            this.lblBladeOffset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBladeOffset.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblBladeOffset.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBladeOffset.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblBladeOffset.Location = new System.Drawing.Point(1523, 129);
            this.lblBladeOffset.Name = "lblBladeOffset";
            this.lblBladeOffset.Size = new System.Drawing.Size(80, 80);
            this.lblBladeOffset.TabIndex = 240;
            this.lblBladeOffset.Text = "0";
            this.lblBladeOffset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBladeOffset.Click += new System.EventHandler(this.lblBladeOffset_Click);
            // 
            // lblMode
            // 
            this.lblMode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMode.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblMode.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMode.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblMode.Location = new System.Drawing.Point(1413, 761);
            this.lblMode.Name = "lblMode";
            this.lblMode.Size = new System.Drawing.Size(101, 38);
            this.lblMode.TabIndex = 241;
            this.lblMode.Text = "MODE";
            this.lblMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMode.Click += new System.EventHandler(this.label5_Click);
            // 
            // btnIncCut
            // 
            this.btnIncCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIncCut.BackColor = System.Drawing.Color.Black;
            this.btnIncCut.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIncCut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnIncCut.Location = new System.Drawing.Point(1523, 45);
            this.btnIncCut.Name = "btnIncCut";
            this.btnIncCut.Size = new System.Drawing.Size(80, 80);
            this.btnIncCut.TabIndex = 243;
            this.btnIncCut.Text = "+";
            this.btnIncCut.UseVisualStyleBackColor = false;
            this.btnIncCut.Click += new System.EventHandler(this.btnIncCut_Click);
            // 
            // btnDecCut
            // 
            this.btnDecCut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDecCut.BackColor = System.Drawing.Color.Black;
            this.btnDecCut.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecCut.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDecCut.Location = new System.Drawing.Point(1523, 212);
            this.btnDecCut.Name = "btnDecCut";
            this.btnDecCut.Size = new System.Drawing.Size(80, 80);
            this.btnDecCut.TabIndex = 244;
            this.btnDecCut.Text = "-";
            this.btnDecCut.UseVisualStyleBackColor = false;
            this.btnDecCut.Click += new System.EventHandler(this.btnDecCut_Click);
            // 
            // voltageBar2
            // 
            this.voltageBar2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
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
            this.voltageBar2.Location = new System.Drawing.Point(50, 385);
            this.voltageBar2.Max = 500;
            this.voltageBar2.Name = "voltageBar2";
            this.voltageBar2.Orientation = ProgBar.ProgBarPlus.eOrientation.Vertical;
            this.voltageBar2.ShapeTextFont = new System.Drawing.Font("Arial Black", 30F);
            this.voltageBar2.Size = new System.Drawing.Size(40, 367);
            this.voltageBar2.TabIndex = 247;
            this.voltageBar2.TextFormat = "Process {1}% Done";
            this.voltageBar2.Value = 300;
            // 
            // lblCutDelta2
            // 
            this.lblCutDelta2.BackColor = System.Drawing.Color.Black;
            this.lblCutDelta2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCutDelta2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCutDelta2.ForeColor = System.Drawing.Color.Black;
            this.lblCutDelta2.Location = new System.Drawing.Point(0, 193);
            this.lblCutDelta2.Name = "lblCutDelta2";
            this.lblCutDelta2.Size = new System.Drawing.Size(72, 25);
            this.lblCutDelta2.TabIndex = 241;
            this.lblCutDelta2.Text = "93";
            this.lblCutDelta2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblCutDelta2.Click += new System.EventHandler(this.lblCutDelta2_Click);
            // 
            // lblRTKPopupTime
            // 
            this.lblRTKPopupTime.AutoSize = true;
            this.lblRTKPopupTime.BackColor = System.Drawing.Color.Black;
            this.lblRTKPopupTime.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold);
            this.lblRTKPopupTime.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRTKPopupTime.Location = new System.Drawing.Point(491, 51);
            this.lblRTKPopupTime.Name = "lblRTKPopupTime";
            this.lblRTKPopupTime.Size = new System.Drawing.Size(68, 33);
            this.lblRTKPopupTime.TabIndex = 193;
            this.lblRTKPopupTime.Text = "PPS";
            this.lblRTKPopupTime.Visible = false;
            this.lblRTKPopupTime.Click += new System.EventHandler(this.lblRTKPopupTime_Click);
            // 
            // lblRTKPopup
            // 
            this.lblRTKPopup.AutoSize = true;
            this.lblRTKPopup.BackColor = System.Drawing.Color.Black;
            this.lblRTKPopup.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRTKPopup.ForeColor = System.Drawing.Color.DarkOrange;
            this.lblRTKPopup.Location = new System.Drawing.Point(373, 51);
            this.lblRTKPopup.Name = "lblRTKPopup";
            this.lblRTKPopup.Size = new System.Drawing.Size(127, 33);
            this.lblRTKPopup.TabIndex = 194;
            this.lblRTKPopup.Text = "RTK Age:";
            this.lblRTKPopup.Visible = false;
            this.lblRTKPopup.Click += new System.EventHandler(this.label24_Click);
            // 
            // toolStripDisplay
            // 
            this.toolStripDisplay.AutoSize = false;
            this.toolStripDisplay.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDisplay.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStripDisplay.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton5,
            this.toolStripDropDownButton3,
            this.toolStripDropDownButton1,
            this.toolStripDropDownButton4});
            this.toolStripDisplay.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.toolStripDisplay.Location = new System.Drawing.Point(13, 51);
            this.toolStripDisplay.Name = "toolStripDisplay";
            this.toolStripDisplay.Size = new System.Drawing.Size(79, 293);
            this.toolStripDisplay.TabIndex = 263;
            this.toolStripDisplay.Text = "toolStrip1";
            this.toolStripDisplay.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripDropDownButton5
            // 
            this.toolStripDropDownButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton5.Image = global::OpenGrade.Properties.Resources.NavigationSettings;
            this.toolStripDropDownButton5.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton5.Name = "toolStripDropDownButton5";
            this.toolStripDropDownButton5.Size = new System.Drawing.Size(77, 68);
            this.toolStripDropDownButton5.Text = "toolStripDropDownButton3";
            this.toolStripDropDownButton5.Click += new System.EventHandler(this.toolStripDropDownButton5_Click_1);
            // 
            // toolStripDropDownButton3
            // 
            this.toolStripDropDownButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripDropDownButton3.BackColor = System.Drawing.Color.Transparent;
            this.toolStripDropDownButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleSettingsToolStripMenuItem,
            this.nTRIPToolStripMenuItem,
            this.toolStripMenuItem7,
            this.toolStripMenuItem6,
            this.dSettingsToolStripMenuItem,
            this.dSettingsToolStripMenuItem1,
            this.modeToolStripMenuItem,
            this.dModeToolStripMenuItem});
            this.toolStripDropDownButton3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripDropDownButton3.Image = global::OpenGrade.Properties.Resources.Settings48;
            this.toolStripDropDownButton3.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton3.ImageTransparentColor = System.Drawing.Color.Black;
            this.toolStripDropDownButton3.Name = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Size = new System.Drawing.Size(77, 68);
            this.toolStripDropDownButton3.Text = "toolStripDropDownButton3";
            this.toolStripDropDownButton3.Click += new System.EventHandler(this.toolStripDropDownButton3_Click_1);
            // 
            // vehicleSettingsToolStripMenuItem
            // 
            this.vehicleSettingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.vehicleSettingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicleSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.vehicleSettingsToolStripMenuItem.Name = "vehicleSettingsToolStripMenuItem";
            this.vehicleSettingsToolStripMenuItem.Size = new System.Drawing.Size(373, 56);
            this.vehicleSettingsToolStripMenuItem.Text = "VehicleSettings";
            this.vehicleSettingsToolStripMenuItem.Click += new System.EventHandler(this.vehicleSettingsToolStripMenuItem_Click);
            // 
            // nTRIPToolStripMenuItem
            // 
            this.nTRIPToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nTRIPToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 28F);
            this.nTRIPToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nTRIPToolStripMenuItem.Name = "nTRIPToolStripMenuItem";
            this.nTRIPToolStripMenuItem.Size = new System.Drawing.Size(373, 56);
            this.nTRIPToolStripMenuItem.Text = "NTRIP";
            this.nTRIPToolStripMenuItem.Click += new System.EventHandler(this.nTRIPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(373, 56);
            this.toolStripMenuItem7.Text = "Connect";
            this.toolStripMenuItem7.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.toolStripMenuItem6.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripMenuItem6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(373, 56);
            this.toolStripMenuItem6.Text = "ImplementSettings";
            this.toolStripMenuItem6.Click += new System.EventHandler(this.implementSettingsToolStripMenuItem_Click);
            // 
            // dSettingsToolStripMenuItem
            // 
            this.dSettingsToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dSettingsToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dSettingsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dSettingsToolStripMenuItem.Name = "dSettingsToolStripMenuItem";
            this.dSettingsToolStripMenuItem.Size = new System.Drawing.Size(373, 56);
            this.dSettingsToolStripMenuItem.Text = "2DSettings ";
            // 
            // dSettingsToolStripMenuItem1
            // 
            this.dSettingsToolStripMenuItem1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dSettingsToolStripMenuItem1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dSettingsToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dSettingsToolStripMenuItem1.Name = "dSettingsToolStripMenuItem1";
            this.dSettingsToolStripMenuItem1.Size = new System.Drawing.Size(373, 56);
            this.dSettingsToolStripMenuItem1.Text = "3D Settings";
            // 
            // modeToolStripMenuItem
            // 
            this.modeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.modeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.surfaceToolStripMenuItem,
            this.tileToolStripMenuItem,
            this.ditchToolStripMenuItem,
            this.contourToolStripMenuItem});
            this.modeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.modeToolStripMenuItem.Name = "modeToolStripMenuItem";
            this.modeToolStripMenuItem.Size = new System.Drawing.Size(373, 56);
            this.modeToolStripMenuItem.Text = "2D Mode";
            this.modeToolStripMenuItem.Click += new System.EventHandler(this.modeToolStripMenuItem_Click);
            // 
            // surfaceToolStripMenuItem
            // 
            this.surfaceToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.surfaceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.surfaceToolStripMenuItem.Name = "surfaceToolStripMenuItem";
            this.surfaceToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.surfaceToolStripMenuItem.Text = "Surface";
            this.surfaceToolStripMenuItem.Click += new System.EventHandler(this.surfaceToolStripMenuItem_Click);
            // 
            // tileToolStripMenuItem
            // 
            this.tileToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tileToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tileToolStripMenuItem.Name = "tileToolStripMenuItem";
            this.tileToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.tileToolStripMenuItem.Text = "Tile";
            this.tileToolStripMenuItem.Click += new System.EventHandler(this.tileToolStripMenuItem_Click);
            // 
            // ditchToolStripMenuItem
            // 
            this.ditchToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ditchToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ditchToolStripMenuItem.Name = "ditchToolStripMenuItem";
            this.ditchToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.ditchToolStripMenuItem.Text = "Ditch";
            this.ditchToolStripMenuItem.Click += new System.EventHandler(this.ditchToolStripMenuItem_Click);
            // 
            // contourToolStripMenuItem
            // 
            this.contourToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contourToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.contourToolStripMenuItem.Name = "contourToolStripMenuItem";
            this.contourToolStripMenuItem.Size = new System.Drawing.Size(217, 44);
            this.contourToolStripMenuItem.Text = "Contour";
            this.contourToolStripMenuItem.Click += new System.EventHandler(this.contourToolStripMenuItem_Click);
            // 
            // dModeToolStripMenuItem
            // 
            this.dModeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dModeToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dModeToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dModeToolStripMenuItem.Name = "dModeToolStripMenuItem";
            this.dModeToolStripMenuItem.Size = new System.Drawing.Size(373, 56);
            this.dModeToolStripMenuItem.Text = "3D Mode";
            this.dModeToolStripMenuItem.Click += new System.EventHandler(this.dModeToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip3DSurveyToolStripMenuItem,
            this.toolStrip2DSurveyToolStripMenuItem,
            this.toolStripFieldInfoToolStripMenuItem,
            this.zeroTripToolStripMenuItem,
            this.toolStripSaveCutToolStripMenuItem,
            this.loadCutToolStripMenuItem,
            this.toolStripBoundaryToolStripMenuItem});
            this.toolStripDropDownButton1.Image = global::OpenGrade.Properties.Resources.JobActive;
            this.toolStripDropDownButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(77, 68);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton3";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click_1);
            // 
            // toolStrip3DSurveyToolStripMenuItem
            // 
            this.toolStrip3DSurveyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolStrip3DSurveyToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip3DSurveyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip3DSurveyToolStripMenuItem.Name = "toolStrip3DSurveyToolStripMenuItem";
            this.toolStrip3DSurveyToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.toolStrip3DSurveyToolStripMenuItem.Text = "3D Survey";
            this.toolStrip3DSurveyToolStripMenuItem.Click += new System.EventHandler(this.toolStrip3DSurveyToolStripMenuItem_Click);
            // 
            // toolStrip2DSurveyToolStripMenuItem
            // 
            this.toolStrip2DSurveyToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolStrip2DSurveyToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2DSurveyToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStrip2DSurveyToolStripMenuItem.Name = "toolStrip2DSurveyToolStripMenuItem";
            this.toolStrip2DSurveyToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.toolStrip2DSurveyToolStripMenuItem.Text = "2D Survey";
            this.toolStrip2DSurveyToolStripMenuItem.Click += new System.EventHandler(this.toolStrip2DSurveyToolStripMenuItem_Click);
            // 
            // toolStripFieldInfoToolStripMenuItem
            // 
            this.toolStripFieldInfoToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolStripFieldInfoToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripFieldInfoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripFieldInfoToolStripMenuItem.Name = "toolStripFieldInfoToolStripMenuItem";
            this.toolStripFieldInfoToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.toolStripFieldInfoToolStripMenuItem.Text = "Field Info";
            // 
            // zeroTripToolStripMenuItem
            // 
            this.zeroTripToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.zeroTripToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zeroTripToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.zeroTripToolStripMenuItem.Name = "zeroTripToolStripMenuItem";
            this.zeroTripToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.zeroTripToolStripMenuItem.Text = "ZeroTrip";
            this.zeroTripToolStripMenuItem.Click += new System.EventHandler(this.zeroTripToolStripMenuItem_Click);
            // 
            // toolStripSaveCutToolStripMenuItem
            // 
            this.toolStripSaveCutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolStripSaveCutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSaveCutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripSaveCutToolStripMenuItem.Name = "toolStripSaveCutToolStripMenuItem";
            this.toolStripSaveCutToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.toolStripSaveCutToolStripMenuItem.Text = "Save Cut";
            this.toolStripSaveCutToolStripMenuItem.Click += new System.EventHandler(this.toolStripSaveCutToolStripMenuItem_Click);
            // 
            // loadCutToolStripMenuItem
            // 
            this.loadCutToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.loadCutToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadCutToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.loadCutToolStripMenuItem.Name = "loadCutToolStripMenuItem";
            this.loadCutToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.loadCutToolStripMenuItem.Text = "Load Cut";
            this.loadCutToolStripMenuItem.Click += new System.EventHandler(this.loadCutToolStripMenuItem_Click);
            // 
            // toolStripBoundaryToolStripMenuItem
            // 
            this.toolStripBoundaryToolStripMenuItem.BackColor = System.Drawing.SystemColors.Desktop;
            this.toolStripBoundaryToolStripMenuItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripBoundaryToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripBoundaryToolStripMenuItem.Name = "toolStripBoundaryToolStripMenuItem";
            this.toolStripBoundaryToolStripMenuItem.Size = new System.Drawing.Size(257, 44);
            this.toolStripBoundaryToolStripMenuItem.Text = "Close Field";
            this.toolStripBoundaryToolStripMenuItem.Click += new System.EventHandler(this.toolStripBoundaryToolStripMenuItem_Click);
            // 
            // toolStripDropDownButton4
            // 
            this.toolStripDropDownButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton4.Image = global::OpenGrade.Properties.Resources.SpecialFunctions;
            this.toolStripDropDownButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripDropDownButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton4.Name = "toolStripDropDownButton4";
            this.toolStripDropDownButton4.Size = new System.Drawing.Size(77, 68);
            this.toolStripDropDownButton4.Text = "toolStripDropDownButton3";
            // 
            // BottomToolStripPanel
            // 
            this.BottomToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.BottomToolStripPanel.Name = "BottomToolStripPanel";
            this.BottomToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.BottomToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.BottomToolStripPanel.Size = new System.Drawing.Size(0, 0);
            this.BottomToolStripPanel.Click += new System.EventHandler(this.toolStripContainer1_BottomToolStripPanel_Click);
            // 
            // TopToolStripPanel
            // 
            this.TopToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.TopToolStripPanel.Name = "TopToolStripPanel";
            this.TopToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.TopToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.TopToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // RightToolStripPanel
            // 
            this.RightToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.RightToolStripPanel.Name = "RightToolStripPanel";
            this.RightToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.RightToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.RightToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // LeftToolStripPanel
            // 
            this.LeftToolStripPanel.Location = new System.Drawing.Point(0, 0);
            this.LeftToolStripPanel.Name = "LeftToolStripPanel";
            this.LeftToolStripPanel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.LeftToolStripPanel.RowMargin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LeftToolStripPanel.Size = new System.Drawing.Size(0, 0);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Size = new System.Drawing.Size(150, 150);
            // 
            // btnLevel
            // 
            this.btnLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLevel.BackColor = System.Drawing.Color.DimGray;
            this.btnLevel.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnLevel.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnLevel.Image = ((System.Drawing.Image)(resources.GetObject("btnLevel.Image")));
            this.btnLevel.Location = new System.Drawing.Point(1523, 591);
            this.btnLevel.Name = "btnLevel";
            this.btnLevel.Size = new System.Drawing.Size(80, 80);
            this.btnLevel.TabIndex = 233;
            this.btnLevel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLevel.UseVisualStyleBackColor = false;
            this.btnLevel.Click += new System.EventHandler(this.btnLevel_Click);
            // 
            // btnGradeControl
            // 
            this.btnGradeControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGradeControl.BackColor = System.Drawing.Color.Transparent;
            this.btnGradeControl.ContextMenuStrip = this.contextMenuStripFlag;
            this.btnGradeControl.Enabled = false;
            this.btnGradeControl.FlatAppearance.BorderSize = 0;
            this.btnGradeControl.Font = new System.Drawing.Font("Tahoma", 14.25F);
            this.btnGradeControl.Image = ((System.Drawing.Image)(resources.GetObject("btnGradeControl.Image")));
            this.btnGradeControl.Location = new System.Drawing.Point(1523, 677);
            this.btnGradeControl.Name = "btnGradeControl";
            this.btnGradeControl.Size = new System.Drawing.Size(80, 80);
            this.btnGradeControl.TabIndex = 128;
            this.btnGradeControl.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            this.btnGradeControl.UseVisualStyleBackColor = false;
            this.btnGradeControl.Click += new System.EventHandler(this.btnGradeControl_Click);
            // 
            // panelNavigation
            // 
            this.panelNavigation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(40)))));
            this.panelNavigation.ColumnCount = 2;
            this.panelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.375F));
            this.panelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.375F));
            this.panelNavigation.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.25F));
            this.panelNavigation.Controls.Add(this.btnpTiltUp, 1, 0);
            this.panelNavigation.Controls.Add(this.btn2D, 0, 0);
            this.panelNavigation.Controls.Add(this.btnN3D, 0, 3);
            this.panelNavigation.Controls.Add(this.btnDayNightMode, 0, 4);
            this.panelNavigation.Controls.Add(this.repeatButton1, 1, 3);
            this.panelNavigation.Controls.Add(this.repeatButton2, 1, 2);
            this.panelNavigation.Controls.Add(this.btnpTiltDown, 1, 1);
            this.panelNavigation.Controls.Add(this.btn3D, 0, 1);
            this.panelNavigation.Controls.Add(this.btnN2D, 0, 2);
            this.panelNavigation.Controls.Add(this.lblHz, 1, 4);
            this.panelNavigation.Location = new System.Drawing.Point(104, 49);
            this.panelNavigation.Name = "panelNavigation";
            this.panelNavigation.RowCount = 5;
            this.panelNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNavigation.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.panelNavigation.Size = new System.Drawing.Size(159, 394);
            this.panelNavigation.TabIndex = 469;
            this.panelNavigation.Visible = false;
            // 
            // btnpTiltUp
            // 
            this.btnpTiltUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnpTiltUp.BackColor = System.Drawing.Color.Transparent;
            this.btnpTiltUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpTiltUp.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnpTiltUp.FlatAppearance.BorderSize = 0;
            this.btnpTiltUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpTiltUp.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnpTiltUp.Image = global::OpenGrade.Properties.Resources.TiltUp;
            this.btnpTiltUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnpTiltUp.Location = new System.Drawing.Point(87, 7);
            this.btnpTiltUp.Name = "btnpTiltUp";
            this.btnpTiltUp.Size = new System.Drawing.Size(63, 63);
            this.btnpTiltUp.TabIndex = 447;
            this.btnpTiltUp.UseVisualStyleBackColor = false;
            this.btnpTiltUp.Click += new System.EventHandler(this.btnpTiltUp_Click);
            // 
            // btn2D
            // 
            this.btn2D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn2D.BackColor = System.Drawing.Color.Transparent;
            this.btn2D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn2D.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn2D.FlatAppearance.BorderSize = 0;
            this.btn2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn2D.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2D.Image = global::OpenGrade.Properties.Resources.Camera2D64;
            this.btn2D.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn2D.Location = new System.Drawing.Point(11, 11);
            this.btn2D.Name = "btn2D";
            this.btn2D.Size = new System.Drawing.Size(57, 55);
            this.btn2D.TabIndex = 469;
            this.btn2D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn2D.UseVisualStyleBackColor = false;
            // 
            // btnN3D
            // 
            this.btnN3D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnN3D.BackColor = System.Drawing.Color.Transparent;
            this.btnN3D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnN3D.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnN3D.FlatAppearance.BorderSize = 0;
            this.btnN3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN3D.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN3D.Image = global::OpenGrade.Properties.Resources.CameraNorth64;
            this.btnN3D.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnN3D.Location = new System.Drawing.Point(11, 245);
            this.btnN3D.Name = "btnN3D";
            this.btnN3D.Size = new System.Drawing.Size(57, 55);
            this.btnN3D.TabIndex = 472;
            this.btnN3D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnN3D.UseVisualStyleBackColor = false;
            // 
            // btnDayNightMode
            // 
            this.btnDayNightMode.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDayNightMode.BackColor = System.Drawing.Color.Transparent;
            this.btnDayNightMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnDayNightMode.FlatAppearance.BorderSize = 0;
            this.btnDayNightMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDayNightMode.Image = global::OpenGrade.Properties.Resources.WindowNightMode;
            this.btnDayNightMode.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDayNightMode.Location = new System.Drawing.Point(11, 325);
            this.btnDayNightMode.Name = "btnDayNightMode";
            this.btnDayNightMode.Size = new System.Drawing.Size(57, 55);
            this.btnDayNightMode.TabIndex = 452;
            this.btnDayNightMode.UseVisualStyleBackColor = false;
            // 
            // repeatButton1
            // 
            this.repeatButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repeatButton1.BackColor = System.Drawing.Color.Transparent;
            this.repeatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.repeatButton1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.repeatButton1.FlatAppearance.BorderSize = 0;
            this.repeatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatButton1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.repeatButton1.Image = global::OpenGrade.Properties.Resources.ZoomIn48;
            this.repeatButton1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.repeatButton1.Location = new System.Drawing.Point(87, 241);
            this.repeatButton1.Name = "repeatButton1";
            this.repeatButton1.Size = new System.Drawing.Size(63, 63);
            this.repeatButton1.TabIndex = 120;
            this.repeatButton1.UseVisualStyleBackColor = false;
            this.repeatButton1.Click += new System.EventHandler(this.repeatButton1_Click);
            // 
            // repeatButton2
            // 
            this.repeatButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.repeatButton2.BackColor = System.Drawing.Color.Transparent;
            this.repeatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.repeatButton2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlText;
            this.repeatButton2.FlatAppearance.BorderSize = 0;
            this.repeatButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatButton2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.repeatButton2.Image = global::OpenGrade.Properties.Resources.ZoomOut48;
            this.repeatButton2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.repeatButton2.Location = new System.Drawing.Point(87, 163);
            this.repeatButton2.Name = "repeatButton2";
            this.repeatButton2.Size = new System.Drawing.Size(63, 63);
            this.repeatButton2.TabIndex = 119;
            this.repeatButton2.UseVisualStyleBackColor = false;
            this.repeatButton2.Click += new System.EventHandler(this.repeatButton2_Click);
            // 
            // btnpTiltDown
            // 
            this.btnpTiltDown.BackColor = System.Drawing.Color.Transparent;
            this.btnpTiltDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnpTiltDown.FlatAppearance.BorderColor = System.Drawing.SystemColors.HotTrack;
            this.btnpTiltDown.FlatAppearance.BorderSize = 0;
            this.btnpTiltDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpTiltDown.Font = new System.Drawing.Font("Tahoma", 12F);
            this.btnpTiltDown.Image = global::OpenGrade.Properties.Resources.TiltDown;
            this.btnpTiltDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnpTiltDown.Location = new System.Drawing.Point(82, 81);
            this.btnpTiltDown.Name = "btnpTiltDown";
            this.btnpTiltDown.Size = new System.Drawing.Size(63, 63);
            this.btnpTiltDown.TabIndex = 446;
            this.btnpTiltDown.UseVisualStyleBackColor = false;
            this.btnpTiltDown.Click += new System.EventHandler(this.btnpTiltDown_Click);
            // 
            // btn3D
            // 
            this.btn3D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn3D.BackColor = System.Drawing.Color.Transparent;
            this.btn3D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn3D.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btn3D.FlatAppearance.BorderSize = 0;
            this.btn3D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn3D.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3D.Image = global::OpenGrade.Properties.Resources.Camera3D64;
            this.btn3D.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btn3D.Location = new System.Drawing.Point(11, 89);
            this.btn3D.Name = "btn3D";
            this.btn3D.Size = new System.Drawing.Size(57, 55);
            this.btn3D.TabIndex = 471;
            this.btn3D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn3D.UseVisualStyleBackColor = false;
            // 
            // btnN2D
            // 
            this.btnN2D.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnN2D.BackColor = System.Drawing.Color.Transparent;
            this.btnN2D.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnN2D.FlatAppearance.BorderColor = System.Drawing.Color.RoyalBlue;
            this.btnN2D.FlatAppearance.BorderSize = 0;
            this.btnN2D.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnN2D.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnN2D.Image = global::OpenGrade.Properties.Resources.CameraNorth2D;
            this.btnN2D.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnN2D.Location = new System.Drawing.Point(11, 167);
            this.btnN2D.Name = "btnN2D";
            this.btnN2D.Size = new System.Drawing.Size(57, 55);
            this.btnN2D.TabIndex = 470;
            this.btnN2D.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnN2D.UseVisualStyleBackColor = false;
            // 
            // lblHz
            // 
            this.lblHz.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(50)))));
            this.lblHz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblHz.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHz.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblHz.Location = new System.Drawing.Point(82, 312);
            this.lblHz.Name = "lblHz";
            this.lblHz.Size = new System.Drawing.Size(74, 82);
            this.lblHz.TabIndex = 249;
            this.lblHz.Text = "5 Hz 32\r\nPPS";
            this.lblHz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHz.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = global::OpenGrade.Properties.Resources.ZeroPitchRoll;
            this.pictureBox1.ImageLocation = "";
            this.pictureBox1.Location = new System.Drawing.Point(1523, 506);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 471;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelLegend
            // 
            this.panelLegend.Controls.Add(this.lblCutLine);
            this.panelLegend.Controls.Add(this.lblMaxDepth);
            this.panelLegend.Controls.Add(this.lblMinCover);
            this.panelLegend.Controls.Add(this.sqrMinCover);
            this.panelLegend.Controls.Add(this.sqrMaxDepth);
            this.panelLegend.Controls.Add(this.sqrCutLine1);
            this.panelLegend.Controls.Add(this.lblDitchCutLine);
            this.panelLegend.Controls.Add(this.sqrDitchCutLine);
            this.panelLegend.Location = new System.Drawing.Point(1174, 550);
            this.panelLegend.Name = "panelLegend";
            this.panelLegend.Size = new System.Drawing.Size(339, 52);
            this.panelLegend.TabIndex = 472;
            this.panelLegend.Visible = false;
            // 
            // ledGradeControl
            // 
            this.ledGradeControl.BackColor = System.Drawing.Color.Black;
            this.ledGradeControl.FlatAppearance.BorderSize = 0;
            this.ledGradeControl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledGradeControl.Location = new System.Drawing.Point(214, 6);
            this.ledGradeControl.Name = "ledGradeControl";
            this.ledGradeControl.Size = new System.Drawing.Size(26, 23);
            this.ledGradeControl.TabIndex = 168;
            this.ledGradeControl.UseVisualStyleBackColor = false;
            // 
            // lblAntennaConnected
            // 
            this.lblAntennaConnected.AutoSize = true;
            this.lblAntennaConnected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAntennaConnected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAntennaConnected.Location = new System.Drawing.Point(244, 6);
            this.lblAntennaConnected.Name = "lblAntennaConnected";
            this.lblAntennaConnected.Size = new System.Drawing.Size(137, 23);
            this.lblAntennaConnected.TabIndex = 166;
            this.lblAntennaConnected.Text = "GradeControl";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ledSurvey);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.ledAuto);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ledRTK);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.ledGradeControl);
            this.panel2.Controls.Add(this.ledRadio);
            this.panel2.Controls.Add(this.ledAntenna);
            this.panel2.Controls.Add(this.ledNTRIP);
            this.panel2.Controls.Add(this.lblAntennaConnected);
            this.panel2.Controls.Add(this.lblUdpConnected);
            this.panel2.Controls.Add(this.label13);
            this.panel2.Controls.Add(this.label22);
            this.panel2.Location = new System.Drawing.Point(300, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1303, 34);
            this.panel2.TabIndex = 474;
            // 
            // ledSurvey
            // 
            this.ledSurvey.BackColor = System.Drawing.Color.Black;
            this.ledSurvey.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ledSurvey.FlatAppearance.BorderSize = 0;
            this.ledSurvey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledSurvey.Location = new System.Drawing.Point(680, 6);
            this.ledSurvey.Name = "ledSurvey";
            this.ledSurvey.Size = new System.Drawing.Size(26, 23);
            this.ledSurvey.TabIndex = 482;
            this.ledSurvey.UseVisualStyleBackColor = false;
            this.ledSurvey.Click += new System.EventHandler(this.button4_Click_2);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(710, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 23);
            this.label4.TabIndex = 481;
            this.label4.Text = "Survey";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // ledAuto
            // 
            this.ledAuto.BackColor = System.Drawing.Color.Black;
            this.ledAuto.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ledAuto.FlatAppearance.BorderSize = 0;
            this.ledAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledAuto.Location = new System.Drawing.Point(591, 6);
            this.ledAuto.Name = "ledAuto";
            this.ledAuto.Size = new System.Drawing.Size(26, 23);
            this.ledAuto.TabIndex = 480;
            this.ledAuto.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(621, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 23);
            this.label2.TabIndex = 479;
            this.label2.Text = "Auto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ledRTK
            // 
            this.ledRTK.BackColor = System.Drawing.Color.Black;
            this.ledRTK.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ledRTK.FlatAppearance.BorderSize = 0;
            this.ledRTK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledRTK.Location = new System.Drawing.Point(508, 6);
            this.ledRTK.Name = "ledRTK";
            this.ledRTK.Size = new System.Drawing.Size(26, 23);
            this.ledRTK.TabIndex = 478;
            this.ledRTK.UseVisualStyleBackColor = false;
            this.ledRTK.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(538, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 23);
            this.label1.TabIndex = 477;
            this.label1.Text = "RTK";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // ledAntenna
            // 
            this.ledAntenna.BackColor = System.Drawing.Color.Black;
            this.ledAntenna.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ledAntenna.FlatAppearance.BorderSize = 0;
            this.ledAntenna.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ledAntenna.Location = new System.Drawing.Point(385, 6);
            this.ledAntenna.Name = "ledAntenna";
            this.ledAntenna.Size = new System.Drawing.Size(26, 23);
            this.ledAntenna.TabIndex = 167;
            this.ledAntenna.UseVisualStyleBackColor = false;
            // 
            // lblUdpConnected
            // 
            this.lblUdpConnected.AutoSize = true;
            this.lblUdpConnected.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUdpConnected.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUdpConnected.Location = new System.Drawing.Point(415, 6);
            this.lblUdpConnected.Name = "lblUdpConnected";
            this.lblUdpConnected.Size = new System.Drawing.Size(89, 23);
            this.lblUdpConnected.TabIndex = 165;
            this.lblUdpConnected.Text = "Antenna";
            // 
            // panelCutDelta
            // 
            this.panelCutDelta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelCutDelta.BackColor = System.Drawing.Color.Black;
            this.panelCutDelta.Controls.Add(this.lblCutDelta);
            this.panelCutDelta.Controls.Add(this.label6);
            this.panelCutDelta.Controls.Add(this.lblDistToTarget);
            this.panelCutDelta.Controls.Add(this.lblCurrentCutDepth);
            this.panelCutDelta.Controls.Add(this.label15);
            this.panelCutDelta.Controls.Add(this.label16);
            this.panelCutDelta.Location = new System.Drawing.Point(1301, 183);
            this.panelCutDelta.Name = "panelCutDelta";
            this.panelCutDelta.Size = new System.Drawing.Size(212, 319);
            this.panelCutDelta.TabIndex = 475;
            this.panelCutDelta.Visible = false;
            // 
            // panelpBar
            // 
            this.panelpBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelpBar.BackColor = System.Drawing.Color.Black;
            this.panelpBar.Controls.Add(this.pbarCutAbove);
            this.panelpBar.Controls.Add(this.pbarCutBelow);
            this.panelpBar.Controls.Add(this.lblBarGraphMax);
            this.panelpBar.Controls.Add(this.lblCutDelta2);
            this.panelpBar.Location = new System.Drawing.Point(99, 84);
            this.panelpBar.Name = "panelpBar";
            this.panelpBar.Size = new System.Drawing.Size(75, 450);
            this.panelpBar.TabIndex = 476;
            this.panelpBar.Visible = false;
            // 
            // panelDirectory
            // 
            this.panelDirectory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelDirectory.BackColor = System.Drawing.Color.Black;
            this.panelDirectory.Controls.Add(this.lblTask);
            this.panelDirectory.Controls.Add(this.lblField);
            this.panelDirectory.Controls.Add(this.lblFarm);
            this.panelDirectory.Controls.Add(this.label8);
            this.panelDirectory.Controls.Add(this.label7);
            this.panelDirectory.Controls.Add(this.label5);
            this.panelDirectory.Location = new System.Drawing.Point(1301, 88);
            this.panelDirectory.Name = "panelDirectory";
            this.panelDirectory.Size = new System.Drawing.Size(212, 73);
            this.panelDirectory.TabIndex = 477;
            // 
            // lblTask
            // 
            this.lblTask.AutoSize = true;
            this.lblTask.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTask.ForeColor = System.Drawing.Color.Lime;
            this.lblTask.Location = new System.Drawing.Point(48, 50);
            this.lblTask.Name = "lblTask";
            this.lblTask.Size = new System.Drawing.Size(88, 19);
            this.lblTask.TabIndex = 5;
            this.lblTask.Text = "Task Name";
            // 
            // lblField
            // 
            this.lblField.AutoSize = true;
            this.lblField.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblField.ForeColor = System.Drawing.Color.Lime;
            this.lblField.Location = new System.Drawing.Point(48, 27);
            this.lblField.Name = "lblField";
            this.lblField.Size = new System.Drawing.Size(88, 19);
            this.lblField.TabIndex = 4;
            this.lblField.Text = "Field Name";
            // 
            // lblFarm
            // 
            this.lblFarm.AutoSize = true;
            this.lblFarm.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFarm.ForeColor = System.Drawing.Color.Lime;
            this.lblFarm.Location = new System.Drawing.Point(48, 4);
            this.lblFarm.Name = "lblFarm";
            this.lblFarm.Size = new System.Drawing.Size(91, 19);
            this.lblFarm.TabIndex = 3;
            this.lblFarm.Text = "Farm Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(5, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 19);
            this.label8.TabIndex = 2;
            this.label8.Text = "Task:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(5, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 19);
            this.label7.TabIndex = 1;
            this.label7.Text = "‏Field:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 19);
            this.label5.TabIndex = 0;
            this.label5.Text = "Farm:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Image = global::OpenGrade.Properties.Resources.UpArrow32;
            this.button1.Location = new System.Drawing.Point(1301, 498);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(212, 43);
            this.button1.TabIndex = 478;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Image = global::OpenGrade.Properties.Resources.DnArrow32;
            this.button2.Location = new System.Drawing.Point(1301, 44);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 43);
            this.button2.TabIndex = 479;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_3);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Image = global::OpenGrade.Properties.Resources.DnArrow32;
            this.button3.Location = new System.Drawing.Point(99, 710);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(186, 43);
            this.button3.TabIndex = 480;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnABLine
            // 
            this.btnABLine.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnABLine.BackColor = System.Drawing.Color.Black;
            this.btnABLine.Image = global::OpenGrade.Properties.Resources.DnArrow32;
            this.btnABLine.Location = new System.Drawing.Point(1147, 41);
            this.btnABLine.Name = "btnABLine";
            this.btnABLine.Size = new System.Drawing.Size(42, 43);
            this.btnABLine.TabIndex = 481;
            this.btnABLine.UseVisualStyleBackColor = false;
            this.btnABLine.Visible = false;
            // 
            // btnSimGoTo
            // 
            this.btnSimGoTo.Location = new System.Drawing.Point(447, 13);
            this.btnSimGoTo.Name = "btnSimGoTo";
            this.btnSimGoTo.Size = new System.Drawing.Size(79, 40);
            this.btnSimGoTo.TabIndex = 195;
            this.btnSimGoTo.Text = "Go To";
            this.btnSimGoTo.UseVisualStyleBackColor = true;
            this.btnSimGoTo.Click += new System.EventHandler(this.btnSimGoTo_Click);
            // 
            // FormGPS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1613, 804);
            this.Controls.Add(this.btnABLine);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panelDirectory);
            this.Controls.Add(this.panelNavigation);
            this.Controls.Add(this.panelpBar);
            this.Controls.Add(this.panelCutDelta);
            this.Controls.Add(this.lblMode);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelLegend);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStripDisplay);
            this.Controls.Add(this.btnLevel);
            this.Controls.Add(this.btnIncCut);
            this.Controls.Add(this.lblBladeOffset);
            this.Controls.Add(this.lblRTKPopupTime);
            this.Controls.Add(this.lblRTKPopup);
            this.Controls.Add(this.voltageBar2);
            this.Controls.Add(this.btnDecCut);
            this.Controls.Add(this.voltageBar);
            this.Controls.Add(this.btnGradeControl);
            this.Controls.Add(this.panelSimControls);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.openGLControlBack);
            this.Controls.Add(this.openGLControl);
            this.Font = new System.Drawing.Font("Tahoma", 12F);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1150, 800);
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
            ((System.ComponentModel.ISupportInitialize)(this.nudLongitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudLatitude)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarSteerAngle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbarStepDistance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudElevation)).EndInit();
            this.toolStripDisplay.ResumeLayout(false);
            this.toolStripDisplay.PerformLayout();
            this.panelNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelLegend.ResumeLayout(false);
            this.panelLegend.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCutDelta.ResumeLayout(false);
            this.panelCutDelta.PerformLayout();
            this.panelpBar.ResumeLayout(false);
            this.panelpBar.PerformLayout();
            this.panelDirectory.ResumeLayout(false);
            this.panelDirectory.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
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
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem gridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightbarToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem explorerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem webCamToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fieldViewerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem googleEarthToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripFlag;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFlagRed;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagGrn;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagYel;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuFlagDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
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
        private System.Windows.Forms.ToolStripMenuItem pursuitLineToolStripMenuItem;
        private System.Windows.Forms.ImageList imageList1;
        public System.Windows.Forms.Button btnGradeControl;
        private System.Windows.Forms.Timer timerSim;
        private System.Windows.Forms.TrackBar tbarStepDistance;
        private System.Windows.Forms.TrackBar tbarSteerAngle;
        private System.Windows.Forms.Button btnResetSteerAngle;
        private System.Windows.Forms.Label lblSteerAngle;
        private System.Windows.Forms.Button btnResetSim;
        private System.Windows.Forms.ToolStripMenuItem simulatorOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelSimControls;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem setWorkingDirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.NumericUpDown nudElevation;
        private System.Windows.Forms.ToolStripStatusLabel stripTopoLocation;
        private System.Windows.Forms.ToolStripStatusLabel stripMinMax;
        private ProgBar.ProgBarPlus pbarCutBelow;
        private ProgBar.ProgBarPlus pbarCutAbove;
        private System.Windows.Forms.Label lblBarGraphMax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCutDelta;
        private System.Windows.Forms.Button btnLevel;
        private System.Windows.Forms.Label lblMaxDepth;
        private System.Windows.Forms.Label lblMinCover;
        private System.Windows.Forms.Button sqrMinCover;
        private System.Windows.Forms.Button sqrMaxDepth;
        private System.Windows.Forms.Button sqrCutLine1;
        private System.Windows.Forms.Label lblCutLine;
        private System.Windows.Forms.Button sqrDitchCutLine;
        private System.Windows.Forms.Label lblDitchCutLine;
        private ProgBar.ProgBarPlus voltageBar;
        public System.Windows.Forms.Label lblBladeOffset;
        private System.Windows.Forms.Label lblMode;
        private System.Windows.Forms.ToolStripMenuItem remoteConfigurationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetModulesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAntennaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetGradeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblCurrentCutDepth;
        private System.Windows.Forms.Label lblDistToTarget;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ToolStripMenuItem zeroIMUToolStripMenuItem;
        private System.Windows.Forms.Button btnIncCut;
        private System.Windows.Forms.Button btnDecCut;
        private ProgBar.ProgBarPlus voltageBar2;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem;
        private System.Windows.Forms.Button ledNTRIP;
        private System.Windows.Forms.Button ledRadio;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ToolStripStatusLabel stripDepth;
        private System.Windows.Forms.ToolStripStatusLabel stripDepthtoTarget;
        private System.Windows.Forms.Label lblCutDelta2;
        public System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.Label lblRTKPopupTime;
        private System.Windows.Forms.Label lblRTKPopup;
        private System.Windows.Forms.ToolStripMenuItem smoothLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox tStripSmootingCB;
        private System.Windows.Forms.ToolStripMenuItem applyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verifyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importAGSToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStripDisplay;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton3;
        private System.Windows.Forms.ToolStripPanel BottomToolStripPanel;
        private System.Windows.Forms.ToolStripPanel TopToolStripPanel;
        private System.Windows.Forms.ToolStripPanel RightToolStripPanel;
        private System.Windows.Forms.ToolStripPanel LeftToolStripPanel;
        private System.Windows.Forms.ToolStripContentPanel ContentPanel;
        private System.Windows.Forms.TableLayoutPanel panelNavigation;
        private ProXoft.WinForms.RepeatButton btnpTiltUp;
        public System.Windows.Forms.Button btn2D;
        public System.Windows.Forms.Button btnN3D;
        public System.Windows.Forms.Button btnDayNightMode;
        private ProXoft.WinForms.RepeatButton repeatButton1;
        private ProXoft.WinForms.RepeatButton repeatButton2;
        private ProXoft.WinForms.RepeatButton btnpTiltDown;
        public System.Windows.Forms.Button btn3D;
        public System.Windows.Forms.Button btnN2D;
        private System.Windows.Forms.Label lblHz;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton5;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem toolStripBoundaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip3DSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStrip2DSurveyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripFieldInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton4;
        private System.Windows.Forms.ToolStripMenuItem vehicleSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dSettingsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripSaveCutToolStripMenuItem;
        private System.Windows.Forms.Panel panelLegend;
        private System.Windows.Forms.ToolStripMenuItem modeToolStripMenuItem;
        private System.Windows.Forms.Button ledGradeControl;
        private System.Windows.Forms.Label lblAntennaConnected;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCutDelta;
        private System.Windows.Forms.ToolStripMenuItem zeroTripToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nTRIPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem6;
        private System.Windows.Forms.Button ledAntenna;
        private System.Windows.Forms.Label lblUdpConnected;
        private System.Windows.Forms.Button ledRTK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelpBar;
        private System.Windows.Forms.Button ledAuto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem loadCutToolStripMenuItem;
        private System.Windows.Forms.Button ledSurvey;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem dModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem surfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ditchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contourToolStripMenuItem;
        private System.Windows.Forms.Panel panelDirectory;
        private System.Windows.Forms.Label lblTask;
        private System.Windows.Forms.Label lblField;
        private System.Windows.Forms.Label lblFarm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnABLine;
        private System.Windows.Forms.NumericUpDown nudLongitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown nudLatitude;
        private System.Windows.Forms.Button btnSimGoTo;
    }
}

