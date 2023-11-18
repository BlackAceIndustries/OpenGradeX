//Please, if you use this, share the improvements

using Microsoft.Win32;
using OpenGrade.Properties;
using SharpGL;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Reflection;
using System.Resources;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace OpenGrade
{
    //the main form object
    public partial class FormGPS : Form
    {
        
        //for the NTRIP CLient counting
        private int ntripCounter = 10;
        #region // Class Props and instances

        //The base directory where OpenGrade will be stored and fields and vehicles branch from
        public string baseDirectory;

        //current directory of vehicle
        public string vehiclesDirectory, vehiclefileName = "";

        //current fields and field directory
        public string fieldsDirectory, currentFieldDirectory, cutName;

        public string curFarmName, curFieldName, curTaskName;

        // Cutlines directory
        public string cutDirectory;

        //maximum sections available
        private const int MAXSECTIONS = 17;

        //ABLines directory
        public string ablinesDirectory;

        //colors for sections and field background
        public byte redSections, grnSections, bluSections;

        public byte redField, grnField, bluField;

        //colors for mapping
        //Fill and low altitude  default green
        public byte redFill, grnFill, bluFill;

        // center color
        public byte redCenter, grnCenter, bluCenter;

        // Cut and high altitude default red
        public byte redCut, grnCut, bluCut;











        //polygon mode for section drawing
        public bool isDrawPolygons;

        //flag for free drive window to control autosteer
        public bool isInFreeDriveMode;

        //Flag stuff
        public byte flagColor = 0;

        private bool leftMouseDownOnOpenGL = false; //mousedown event in opengl window
        private int flagNumberPicked = 0;

        //Is it in 2D or 3D, metric or imperial, display lightbar, display grid etc
        public bool isIn3D = true, isDualAntenna = false, isImuAsDual = false, isMetric = true, isLightbarOn = true, isGridOn = true, isSideGuideLines = true, isFullScreen = false;



        public bool isPureDisplayOn = true, isSkyOn = true, isBigAltitudeOn = false, isSimOn = false, isGuidelineOn = true;

        //bool for whether or not a job is active
        public bool isJobStarted = false, isAreaOnRight = true, isGradeControlBtnOn = false,  isLevelOn = false, isFirstPtSet = false, isCutSaved = false;

        public bool isAutoTiltOn = false, isAutoVertOn = false;

        // isSurfaceModeOn = true, isPipeModeOn = false, isDitchModeOn = false,
        // 
        // Grade Modes
        public enum gradeMode { surface, ditch, tile, contour }
        
        
        public enum surveyMode { survey2D, survey3D, }

        public surveyMode curSurveyMode = surveyMode.survey3D;
        public gradeMode curMode = gradeMode.surface;


        // Manual, 3 states possible
        public enum btnStates { Off, Rec, RecBnd, Work, Stdby}

        public btnStates manualBtnState = btnStates.Off;

        //if we are saving a file
        public bool isSavingFile = false, isLogNMEA = false;

        //Zoom variables
        public double gridZoom;

        public double zoomValue = 3.5;
        public double triangleResolution = 1.0;
        private double previousZoom = 25;
        public uint[] texture = new uint[3];

        //create the scene camera
        public CCamera camera = new CCamera();

        //create world grid
        public CWorldGrid worldGrid;

        //create instance of a stopwatch for timing of frames and NMEA hz determination
        private readonly Stopwatch swFrame = new Stopwatch();

        //Time to do fix position update and draw routine
        private double frameTime = 0;

        //For field saving in background
        private int saveCounter = 1;

        //used to update the screen status bar etc
        private int statusUpdateCounter = 1;

        private int fiveSecondCounter = 0;

        public string gcVerison, atVersion;

        //used in altitude window for gain
        private double altitudeWindowGain = 10.0;

        private double barGraphMax = 50;

        /// <summary>
        /// The NMEA class that decodes it
        /// </summary>
        public CNMEA pn;
        public CNMEA pn2;

        /// <summary>
        /// AB Line object
        /// </summary>
        public CABLine ABLine;

        /// <summary>
        /// Contour Mode Instance
        /// </summary>
        public CContour ct;

        /// <summary>
        /// Our vehicle including the tool
        /// </summary>
        public CVehicle vehicle;

        /// <summary>
        /// All the structs for recv and send of information out ports
        /// </summary>
        public CModuleComm mc;

        /// <summary>
        /// The internal simulator
        /// </summary>
        public CSim sim;

        /// <summary>
        /// Resource manager for gloabal strings
        /// </summary>
        public ResourceManager _rm;

        /// <summary>
        /// Resource manager for gloabal strings
        /// </summary>
        public CRemote rem;
        /// <summary>
        /// an array of sections, so far 16 section + 1 fullWidth Section
        /// </summary>
        public CSection[] section;

        /// <summary>
        /// Ntrip Logger
        /// </summary>
        public NtripLog ntrip;



        #endregion // Class Props and instances

        #region Gesture

        // Private variables used to maintain the state of gestures
        //private DrawingObject _dwo = new DrawingObject();
        private Point _ptFirst = new Point();

        private Point _ptSecond = new Point();
        private int _iArguments = 0;

        // One of the fields in GESTUREINFO structure is type of Int64 (8 bytes).
        // The relevant gesture information is stored in lower 4 bytes. This
        // bit mask is used to get 4 lower bytes from this argument.
        private const Int64 ULL_ARGUMENTS_BIT_MASK = 0x00000000FFFFFFFF;

        //-----------------------------------------------------------------------
        // Multitouch/Touch glue (from winuser.h file)
        // Since the managed layer between C# and WinAPI functions does not
        // exist at the moment for multi-touch related functions this part of
        // code is required to replicate definitions from winuser.h file.
        //-----------------------------------------------------------------------
        // Touch event window message constants [winuser.h]
        private const int WM_GESTURENOTIFY = 0x011A;

        private const int WM_GESTURE = 0x0119;

        private const int GC_ALLGESTURES = 0x00000001;

        // Gesture IDs
        private const int GID_BEGIN = 1;

        private const int GID_END = 2;
        private const int GID_ZOOM = 3;
        private const int GID_PAN = 4;
        private const int GID_ROTATE = 5;
        private const int GID_TWOFINGERTAP = 6;
        private const int GID_PRESSANDTAP = 7;

        // Gesture flags - GESTUREINFO.dwFlags
        private const int GF_BEGIN = 0x00000001;

        private const int GF_INERTIA = 0x00000002;
        private const int GF_END = 0x00000004;

        //
        // Gesture configuration structure
        //   - Used in SetGestureConfig and GetGestureConfig
        //   - Note that any setting not included in either GESTURECONFIG.dwWant
        //     or GESTURECONFIG.dwBlock will use the parent window's preferences
        //     or system defaults.
        //
        // Touch API defined structures [winuser.h]
        [StructLayout(LayoutKind.Sequential)]
        private struct GESTURECONFIG
        {
            public int dwID;    // gesture ID
            public int dwWant;  // settings related to gesture ID that are to be

            // turned on
            public int dwBlock; // settings related to gesture ID that are to be

            // turned off
        }

        [StructLayout(LayoutKind.Sequential)]
        private struct POINTS
        {
            public short x;
            public short y;
        }

        //
        // Gesture information structure
        //   - Pass the HGESTUREINFO received in the WM_GESTURE message lParam
        //     into the GetGestureInfo function to retrieve this information.
        //   - If cbExtraArgs is non-zero, pass the HGESTUREINFO received in
        //     the WM_GESTURE message lParam into the GetGestureExtraArgs
        //     function to retrieve extended argument information.
        //
        [StructLayout(LayoutKind.Sequential)]
        private struct GESTUREINFO
        {
            public int cbSize;           // size, in bytes, of this structure

            // (including variable length Args
            // field)
            public int dwFlags;          // see GF_* flags

            public int dwID;             // gesture ID, see GID_* defines
            public IntPtr hwndTarget;    // handle to window targeted by this

            // gesture
            [MarshalAs(UnmanagedType.Struct)]
            internal POINTS ptsLocation; // current location of this gesture

            public int dwInstanceID;     // internally used
            public int dwSequenceID;     // internally used
            public Int64 ullArguments;   // arguments for gestures whose

            // arguments fit in 8 BYTES
            public int cbExtraArgs;      // size, in bytes, of extra arguments,

            // if any, that accompany this gesture
        }

        // Currently touch/multitouch access is done through unmanaged code
        // We must p/invoke into user32 [winuser.h]
        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetGestureConfig(IntPtr hWnd, int dwReserved, int cIDs, ref GESTURECONFIG pGestureConfig, int cbSize);

        [DllImport("user32")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetGestureInfo(IntPtr hGestureInfo, ref GESTUREINFO pGestureInfo);

        // size of GESTURECONFIG structure
        private int _gestureConfigSize;

        // size of GESTUREINFO structure
        private int _gestureInfoSize;

        [SecurityPermission(SecurityAction.Demand)]
        private void SetupStructSizes()
        {
            // Both GetGestureCommandInfo and GetTouchInputInfo need to be
            // passed the size of the structure they will be filling
            // we get the sizes upfront so they can be used later.
            _gestureConfigSize = Marshal.SizeOf(new GESTURECONFIG());
            _gestureInfoSize = Marshal.SizeOf(new GESTUREINFO());
        }

        //-------------------------------------------------------------
        // Since there is no managed layer at the moment that supports
        // event handlers for WM_GESTURENOTIFY and WM_GESTURE
        // messages we have to override WndProc function
        //
        // in
        //   m - Message object
        //-------------------------------------------------------------
        [PermissionSet(SecurityAction.Demand, Name = "FullTrust")]
        protected override void WndProc(ref Message m)
        {
            bool handled = false;

            switch (m.Msg)
            {
                case WM_GESTURENOTIFY:
                    {
                        // This is the right place to define the list of gestures
                        // that this application will support. By populating
                        // GESTURECONFIG structure and calling SetGestureConfig
                        // function. We can choose gestures that we want to
                        // handle in our application. In this app we decide to
                        // handle all gestures.
                        GESTURECONFIG gc = new GESTURECONFIG
                        {
                            dwID = 0,                // gesture ID
                            dwWant = GC_ALLGESTURES, // settings related to gesture
                                                     // ID that are to be turned on
                            dwBlock = 0 // settings related to gesture ID that are
                        };
                        // to be

                        // We must p/invoke into user32 [winuser.h]
                        bool bResult = SetGestureConfig(
                            Handle, // window for which configuration is specified
                            0,      // reserved, must be 0
                            1,      // count of GESTURECONFIG structures
                            ref gc, // array of GESTURECONFIG structures, dwIDs
                                    // will be processed in the order specified
                                    // and repeated occurances will overwrite
                                    // previous ones
                            _gestureConfigSize // sizeof(GESTURECONFIG)
                        );

                        if (!bResult)
                        {
                            throw new Exception("Error in execution of SetGestureConfig");
                        }
                    }
                    handled = true;
                    break;

                case WM_GESTURE:
                    // The gesture processing code is implemented in
                    // the DecodeGesture method
                    handled = DecodeGesture(ref m);
                    break;

                default:
                    handled = false;
                    break;
            }

            // Filter message back up to parents.
            base.WndProc(ref m);

            if (handled)
            {
                // Acknowledge event if handled.
                try
                {
                    m.Result = new System.IntPtr(1);
                }
                catch (Exception excep)
                {
                    Debug.Print("Could not allocate result ptr");
                    Debug.Print(excep.ToString());
                }
            }
        }

        // Taken from GCI_ROTATE_ANGLE_FROM_ARGUMENT.
        // Converts from "binary radians" to traditional radians.
        static protected double ArgToRadians(Int64 arg)
        {
            return (((double)(arg) / 65535.0) * 4.0 * 3.14159265) - (2.0 * 3.14159265);
        }

        // Handler of gestures
        //in:
        //  m - Message object
        private bool DecodeGesture(ref Message m)
        {
            GESTUREINFO gi;

            try
            {
                gi = new GESTUREINFO();
            }
            catch (Exception excep)
            {
                Debug.Print("Could not allocate resources to decode gesture");
                Debug.Print(excep.ToString());

                return false;
            }

            gi.cbSize = _gestureInfoSize;

            // Load the gesture information.
            // We must p/invoke into user32 [winuser.h]
            if (!GetGestureInfo(m.LParam, ref gi))
            {
                return false;
            }

            switch (gi.dwID)
            {
                case GID_BEGIN:
                case GID_END:
                    break;

                case GID_ZOOM:
                    switch (gi.dwFlags)
                    {
                        case GF_BEGIN:
                            _iArguments = (int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                            _ptFirst.X = gi.ptsLocation.x;
                            _ptFirst.Y = gi.ptsLocation.y;
                            _ptFirst = PointToClient(_ptFirst);
                            break;

                        default:
                            // We read here the second point of the gesture. This
                            // is middle point between fingers in this new
                            // position.
                            _ptSecond.X = gi.ptsLocation.x;
                            _ptSecond.Y = gi.ptsLocation.y;
                            _ptSecond = PointToClient(_ptSecond);
                            {
                                // The zoom factor is the ratio of the new
                                // and the old distance. The new distance
                                // between two fingers is stored in
                                // gi.ullArguments (lower 4 bytes) and the old
                                // distance is stored in _iArguments.
                                double k = (double)(_iArguments)
                                            / (double)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                                //lblX.Text = k.ToString();
                                zoomValue *= k;
                                if (zoomValue < 6.0) zoomValue = 6;
                                camera.camSetDistance = zoomValue * zoomValue * -1;
                                SetZoom();
                            }

                            // Now we have to store new information as a starting
                            // information for the next step in this gesture.
                            _ptFirst = _ptSecond;
                            _iArguments = (int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                            break;
                    }
                    break;

                //case GID_PAN:
                //    switch (gi.dwFlags)
                //    {
                //        case GF_BEGIN:
                //            _ptFirst.X = gi.ptsLocation.x;
                //            _ptFirst.Y = gi.ptsLocation.y;
                //            _ptFirst = PointToClient(_ptFirst);
                //            break;

                //        default:
                //            // We read the second point of this gesture. It is a
                //            // middle point between fingers in this new position
                //            _ptSecond.X = gi.ptsLocation.x;
                //            _ptSecond.Y = gi.ptsLocation.y;
                //            _ptSecond = PointToClient(_ptSecond);

                //            // We apply move operation of the object
                //            _dwo.Move(_ptSecond.X - _ptFirst.X, _ptSecond.Y - _ptFirst.Y);

                //            Invalidate();

                //            // We have to copy second point into first one to
                //            // prepare for the next step of this gesture.
                //            _ptFirst = _ptSecond;
                //            break;
                //    }
                //    break;

                case GID_ROTATE:
                    switch (gi.dwFlags)
                    {
                        case GF_BEGIN:
                            _iArguments = 32768;
                            break;

                        default:
                            // Gesture handler returns cumulative rotation angle. However we
                            // have to pass the delta angle to our function responsible
                            // to process the rotation gesture.
                            double k = ((int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK) - _iArguments) * 0.01;
                            camera.camPitch -= k;
                            if (camera.camPitch < -80) camera.camPitch = -80;
                            if (camera.camPitch > 0) camera.camPitch = 0;
                            _iArguments = (int)(gi.ullArguments & ULL_ARGUMENTS_BIT_MASK);
                            break;
                    }
                    break;

                    //case GID_TWOFINGERTAP:
                    //    // Toggle drawing of diagonals
                    //    _dwo.ToggleDrawDiagonals();
                    //    Invalidate();
                    //    break;

                    //case GID_PRESSANDTAP:
                    //    if (gi.dwFlags == GF_BEGIN)
                    //    {
                    //        // Shift drawing color
                    //        _dwo.ShiftColor();
                    //        Invalidate();
                    //    }
                    //    break;
            }

            return true;
        }

        #endregion Gesture

        // Constructor, Initializes a new instance of the "FormGPS" class.
        public FormGPS()
        {

            //winform initialization
            InitializeComponent();

            //build the gesture structures
            SetupStructSizes();

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            OpenGL glBack = openGLControlBack.OpenGL;

            //create the world grid
            worldGrid = new CWorldGrid(gl, this);

            //our vehicle made with gl object and pointer of mainform
            vehicle = new CVehicle(gl, this);

            //create a new section and set left and right positions
            //created whether used or not, saves restarting program
            section = new CSection[MAXSECTIONS];
            for (int j = 0; j < MAXSECTIONS; j++) section[j] = new CSection(this);

            //NMEA Parser1
            pn = new CNMEA(this);
            //NMEA PArser2
            pn2 = new CNMEA(this);

            //create the ABLine instance
            ABLine = new CABLine(gl, this);

            //new instance of contour mode
            ct = new CContour(gl, this);

            //module communication
            mc = new CModuleComm(this);

            sim = new CSim(this);

            rem = new CRemote(this);

            ntrip = new NtripLog(this);

            //start the stopwatch
            swFrame.Start();
                      
            //resource for gloabal language strings
            _rm = new ResourceManager("OpenGrade.gStr", Assembly.GetExecutingAssembly());

            // Add Message Event handler for Form decoupling from client socket thread
            updateRTCM_DataEvent = new UpdateRTCM_Data(OnAddMessage);
        }

        //keystrokes for easy and quick startup

        // Keyboard shortCuts
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            //////////////////////////////////////////////
            /////////// Keyboard Shortcuts ///////////////
            //////////////////////////////////////////////

            //reset Sim
            if (keyData == Keys.L)
            {
                btnResetSim.PerformClick();
                return true;
            }

            // Increase Elevation
            if (keyData == (Keys.PageUp))
            {
                sim.altitude = (double)nudElevation.Value;
                sim.altitude = sim.altitude + .005;
                nudElevation.Value = (decimal)sim.altitude;
                return true;    // indicate that you handled this keystroke
            }

            //Decrease Elevation
            if (keyData == (Keys.PageDown))
            {
                sim.altitude = (double)nudElevation.Value;
                sim.altitude = sim.altitude - .005; ;
                nudElevation.Value = (decimal)sim.altitude;
                return true;    // indicate that you handled this keystroke
            }

            //speed up
            if (keyData == Keys.K)
            {
                sim.stepDistance += 0.05;
                if (sim.stepDistance > 5.8) sim.stepDistance = 5.8;
                tbarStepDistance.Value = (int)(sim.stepDistance * 10.0 * fixUpdateHz);

                return true;
            }

            //Stop
            if (keyData == Keys.J)
            {
                sim.stepDistance = 0;
                tbarStepDistance.Value = 0;
                return true;
            }

            //slow down
            if (keyData == Keys.H)
            {
                sim.stepDistance -= 0.05;
                if (sim.stepDistance < 0) sim.stepDistance = 0;
                tbarStepDistance.Value = (int)(sim.stepDistance * 10.0 * fixUpdateHz);
                return true;
            }

            //turn right
            if (keyData == Keys.M)
            {
                sim.steerAngle++;
                if (sim.steerAngle > 30) sim.steerAngle = 30;
                sim.steerAngleScrollBar = sim.steerAngle;
                lblSteerAngle.Text = sim.steerAngle.ToString();
                tbarSteerAngle.Value = (int)(10 * sim.steerAngle);
                return true;
            }

            //turn left
            if (keyData == Keys.B)
            {
                sim.steerAngle--;
                if (sim.steerAngle < -30) sim.steerAngle = -30;
                sim.steerAngleScrollBar = sim.steerAngle;
                lblSteerAngle.Text = sim.steerAngle.ToString();
                tbarSteerAngle.Value = (int)(10 * sim.steerAngle);
                return true;
            }

            //zero steering
            if (keyData == Keys.N)
            {
                sim.steerAngle = 0.0;
                sim.steerAngleScrollBar = sim.steerAngle;
                lblSteerAngle.Text = sim.steerAngle.ToString();
                tbarSteerAngle.Value = (int)(10 * sim.steerAngle);
                return true;
            }

            //Open Job
            if (keyData == (Keys.F))
            {
                JobNewOpenResume();
                return true;    // indicate that you handled this keystroke
            }

            //Open Job
            if (keyData == (Keys.Escape))
            {
                //fullscreenToolStripMenuItem.PerformClick();
                return true;    // indicate that you handled this keystroke
            }

            //////////////////////////////////////////////
            /////////// Remote   Shortcuts ///////////////
            /////////////////////////////////////////////////

            // Start Btn
            if (keyData == (Keys.D0))
            {
                rem.DoFunction(rem.startBtn);
                return true;    // indicate that you handled this keystroke
            }

            // X Btn
            if (keyData == (Keys.D1))
            {
                rem.DoFunction(rem.xBtn);
                return true;    // indicate that you handled this keystroke
            }

            //  A Btn
            if (keyData == (Keys.D2))
            {
                rem.DoFunction(rem.aBtn);
                return true;    // indicate that you handled this keystroke
            }

            // b Btn 
            if (keyData == (Keys.D3))
            {
                rem.DoFunction(rem.bBtn);
                return true;    // indicate that you handled this keystroke
            }

            // Y Btn
            if (keyData == (Keys.D4))
            {
                rem.DoFunction(rem.yBtn);
                return true;    // indicate that you handled this keystroke
            }

            //  Start Btn + A Btn
            if (keyData == (Keys.D5))
            {

                return true;    // indicate that you handled this keystroke
            }

            // Start Btn + X Btn
            if (keyData == (Keys.D6))
            {

                return true;    // indicate that you handled this keystroke
            }

            // Start Btn + Y Btn
            if (keyData == (Keys.D7))
            {

                return true;    // indicate that you handled this keystroke
            }

            // Start Btn + b Btn 
            if (keyData == (Keys.D9))
            {

                return true;    // indicate that you handled this keystroke
            }

            // UP Btn
            if (keyData == (Keys.Left))
            {
                rem.DoFunction(rem.upBtn);
                return true;    // indicate that you handled this keystroke
            }

            // Down Btn
            if (keyData == (Keys.Right))
            {
                rem.DoFunction(rem.downBtn);
                //rem.DoFunction(Properties.Remote.Default.downBtn);
                return true;    // indicate that you handled this keystroke
            }

            // Open to Options
            if (keyData == (Keys.Up)) // Right Btn
            {
                rem.DoFunction(rem.rightBtn);
                return true;    // indicate that you handled this keystroke
            }

            // Open to Options
            if (keyData == (Keys.Down))  // Left Btn
            {
                rem.DoFunction(rem.leftBtn);
                return true;    // indicate that you handled this keystroke
            }




            // Call the base class
            return base.ProcessCmdKey(ref msg, keyData);
        }

        //Initialize items before the form Loads or is visible
        private void FormGPS_Load(object sender, EventArgs e)
        {
            //tooltips of controls
            ToolTip ToolTip1 = new ToolTip();
            //ToolTip1.SetToolTip(btnABLine, "Set and configure\n an ABLine");

            if (Settings.Default.setF_workingDirectory == "Default")
                baseDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\OpenGradeX\\";
            else baseDirectory = Settings.Default.setF_workingDirectory + "\\OpenGradeX\\";

            //get the fields directory, if not exist, create
            fieldsDirectory = baseDirectory + "Fields\\";
            string dir = Path.GetDirectoryName(fieldsDirectory);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) { Directory.CreateDirectory(dir); }

            //get the fields directory, if not exist, create
            vehiclesDirectory = baseDirectory + "Vehicles\\";
            dir = Path.GetDirectoryName(vehiclesDirectory);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) { Directory.CreateDirectory(dir); }

            //make sure current field directory exists, null if not
            currentFieldDirectory = Settings.Default.setF_CurrentDir;

            string curDir;
            if (currentFieldDirectory != "")
            {
                curDir = fieldsDirectory + currentFieldDirectory + "\\";
                dir = Path.GetDirectoryName(curDir);
                if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir))
                {
                    currentFieldDirectory = "";
                    Settings.Default.setF_CurrentDir = "";
                    Settings.Default.Save();
                }
            }

            //grab the current vehicle filename - make sure it exists
            vehiclefileName = Vehicle.Default.setVehicle_Name;

            //get the abLines directory, if not exist, create
            ablinesDirectory = baseDirectory + "ABLines\\";
            dir = Path.GetDirectoryName(fieldsDirectory);
            if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) { Directory.CreateDirectory(dir); }


            //get the cut Lines directory, if not exist, create
            //cutDirectory = baseDirectory + fieldsDirectory + "CutLines\\";
            //dir = Path.GetDirectoryName(fieldsDirectory);
            //if (!string.IsNullOrEmpty(dir) && !Directory.Exists(dir)) { Directory.CreateDirectory(dir); }

            //start udp server
            StartUDPServer();

            //set the correct zoom and grid
            camera.camSetDistance = zoomValue * zoomValue * -1;
            SetZoom();

            //remembered window position
            if (Settings.Default.setWindow_Maximized)
            {
                WindowState = FormWindowState.Maximized;
                Location = Settings.Default.setWindow_Location;
                Size = Settings.Default.setWindow_Size;
            }
            else if (Settings.Default.setWindow_Minimized)
            {
                //WindowState = FormWindowState.Minimized;
                Location = Settings.Default.setWindow_Location;
                Size = Settings.Default.setWindow_Size;
            }
            else
            {
                Location = Settings.Default.setWindow_Location;
                Size = Settings.Default.setWindow_Size;
            }

            //clear the flags
            flagPts.Clear();
            //btnFlag.Enabled = false;

            //workswitch stuff
            mc.isWorkSwitchEnabled = Settings.Default.setF_IsWorkSwitchEnabled;
            mc.isWorkSwitchActiveLow = Settings.Default.setF_IsWorkSwitchActiveLow;
            vehicle.minSlope = Vehicle.Default.setVehicle_minSlope;

            minFixStepDist = Settings.Default.setF_minFixStep;

            pitchZero = Settings.Default.setIMU_pitchZero;
            rollZero = Settings.Default.setIMU_rollZero;

            //sim.latitude = Settings.Default.setSim_lastLat;
            //sim.longitude = Settings.Default.setSim_lastLong;

            // load all the gui elements in gui.designer.cs
            LoadGUI();
            //SendUDPMessage(RESET_HEADER + "," + 0);
            //SendAntennaUDPMessage(RESET_HEADER + "," + 0);
        }

        private void lblCutDelta_Click(object sender, EventArgs e)
        {
            int cnnt = ct.ptList.Count;
            //if (cnnt > 0)
            //{
            //    for (int i = 0; i < cnnt; i++) ct.ptList[i].lastPassAltitude = -1;
            //}
            if (cnnt > 0)
            {
                for (int i = 0; i < cnnt; i++) ct.ptList[i].currentPassAltitude = -1;
            }
        }
        public void ToggleFullscreen()
        {
            
            if (FormBorderStyle == FormBorderStyle.None) //&& this.WindowState != FormWindowState.Normal
            {
                FormBorderStyle = FormBorderStyle.Sizable;
                WindowState = FormWindowState.Normal;
                Padding = new Padding(5);
                isFullScreen = false;
            }
            else
            {
                FormBorderStyle = FormBorderStyle.None;
                WindowState = FormWindowState.Maximized;
                Padding = new Padding(15);
                //PanelDisplays.Height = this.Height - 200;
                isFullScreen = true;

                PanelDisplays.Height = this.Height - 200;
                PanelDisplays.Width = this.Width - 115;

                //openGLControl.Height = PanelDisplays.Height - 250  ;
                Point pbarL = new Point(0, 0);
                Point pbarR = new Point(0, 0);
                pbarCutAboveL.Height = ((PanelDisplays.Height - 24) / 2);
                pbarCutBelowL.Height = ((PanelDisplays.Height - 24) / 2);
                pbarCutAboveR.Height = ((PanelDisplays.Height - 24) / 2);
                pbarCutBelowR.Height = ((PanelDisplays.Height - 24) / 2);


                pbarL.X = 30;
                pbarL.Y = (PanelDisplays.Height) / 2;
                pbarCutBelowL.Location = (pbarL);


                pbarR.X = voltageBar2.Location.X - 29 - voltageBar2.Width;
                pbarR.Y = (PanelDisplays.Height) / 2;
                pbarCutBelowR.Location = (pbarR);



                //pbarCutBelowL.Height = (PanelDisplays.Height / 2);

                // Adjust pBar





            }

        }

        public bool ToggleSim()
        {

            if (!isSimOn)
            {
                panelSimControls.Visible = true;
                nudElevation.Visible = true;
                timerSim.Enabled = true;
                isSimOn = true;
                Settings.Default.setMenu_isSimulatorOn = isSimOn;
                Settings.Default.Save();

                return true;
            }
            else
            {
                panelSimControls.Visible = false;
                nudElevation.Visible = false;
                timerSim.Enabled = false;
                isSimOn = false;

                Settings.Default.setMenu_isSimulatorOn = isSimOn;
                Settings.Default.Save();
                return false;
            }

            


        }






        private void remoteConfigurationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormRemote(this);
            form.Show();
        }


        private void btnZeroIMU_Click(object sender, EventArgs e)
        {
            SendUDPMessage(FormGPS.IMU_HEADER, epAntennaModule);

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void resetModulesToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void resetAntennaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendUDPMessage(FormGPS.RESET_HEADER, epAntennaModule);

        }

        private void resetGradeControlToolStripMenuItem_Click(object sender, EventArgs e)
        {

            SendUDPMessage(FormGPS.RESET_HEADER, epGradeControl);

        }

        private void btnAutoCut_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                if (!isAutoCutOn)
                {
                    isAutoCutOn = true;
                    //btnAutoCut.BackColor = Color.Green;
                    //btnAutoCut.ForeColor = Color.Black;
                    
                    //lblAutoCutDepth.Visible = true;
                    //lblPassDepth.Visible = true;

                }
                else
                {
                    isAutoCutOn = false;
                    //btnAutoCut.BackColor = Color.Black;
                    //btnAutoCut.Text = "Auto\nCut";
                    //btnAutoCut.ForeColor = Color.White;
                    
                    //lblAutoCutDepth.Visible = false;
                    //lblPassDepth.Visible = false;

                }



            }

        }
        private void btnAutoShore_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                if (!isAutoShoreOn)
                {
                    isAutoShoreOn = true;
                    //btnAutoShore.BackColor = Color.Green;
                    //btnAutoShore.Text = "Auto\nShore";
                    //btnAutoShore.ForeColor = Color.Black;
                    //btnIncCut.Visible = true;
                    //btnDecCut.Visible = true;
                    //lblAutoCutDepth.Visible = true;
                    //lblPassDepth.Visible = true;
                }
                else
                {
                    isAutoShoreOn = false;
                    //btnAutoShore.BackColor = Color.Black;
                    //btnAutoShore.Text = "Auto\nShore";
                    //btnAutoShore.ForeColor = Color.White;
                    //btnIncCut.Visible = false;
                    //btnDecCut.Visible = false;
                    //lblAutoCutDepth.Visible = false;
                    //lblPassDepth.Visible = false;
                }

                

            }

        }
        private void zeroIMUToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendUDPMessage(FormGPS.IMU_HEADER, epAntennaModule);

        }

        private void btnIncCut_Click(object sender, EventArgs e)
        {
            //lblAutoCutDepth.Text = autoCutDepth++.ToString();
            rem.IncreaseBladeOffset();
        }

        private void btnDecCut_Click(object sender, EventArgs e)
        {
            //lblAutoCutDepth.Text = autoCutDepth--.ToString();
            rem.DecreaseBladeOffset();
        }

        private void toolStripDropDownBtnFuncs_Click(object sender, EventArgs e)
        {

        }

        private void openGLControl_Load(object sender, EventArgs e)
        {

        }

        private void stripEqWidth_Click(object sender, EventArgs e)
        {
            

            HideTabControl();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //FullScreenElevation();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            //rem.ResetBladeOffset();
        }

        private void lblBladeOffset_Click(object sender, EventArgs e)
        {

        }

        

        private void toolstripNTripConfig_Click(object sender, EventArgs e)
        {
            SettingsNtrip();
        }

        private void resetAllToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SendUDPMessage(FormGPS.RESET_HEADER, epGradeControl);
            SendUDPMessage(FormGPS.RESET_HEADER, epAntennaModule);

        }

        private void fullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.FormBorderStyle == FormBorderStyle.None && this.WindowState != FormWindowState.Normal)
            {
                this.FormBorderStyle = FormBorderStyle.Sizable;
                this.WindowState = FormWindowState.Normal;
                this.Padding = new Padding(5);
            }
            else {
                this.FormBorderStyle = FormBorderStyle.None;
                this.Padding = new Padding(5);
                this.WindowState = FormWindowState.Maximized;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void stripTopoLocation_Click(object sender, EventArgs e)
        {
            
        }

        private void ledNTRIP_Click(object sender, EventArgs e)
        {
            //if (tboxNTRIPBuffer.Visible)
            //{
            //    tboxNTRIPBuffer.Visible = false;
            //}
            //else
            //{
            //    tboxNTRIPBuffer.Visible = true;
            //}
        }

        private void openGLControlBack_Load(object sender, EventArgs e)
        {

        }

       
        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void lblFixQuality_Click(object sender, EventArgs e)
        {

        }

        private void lblRTKAge_Click(object sender, EventArgs e)
        {

        }

        private void lblRTKAgeDisplay_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void lblGPSHeading_Click(object sender, EventArgs e)
        {

        }

        private void lblEasting_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void lblNorthing_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void importAGSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                if (ct.ptList.Count < 1)
                    FileOpenAgdDesign();
                else
                {
                    var form = new FormTimedMessage(3000, "Contour.txt already exist", "Delete the Contour.txt or create a new Field");
                    form.Show();
                }
            }
            else
            {
                var form = new FormTimedMessage(3000, "No field open", "Open a field First");
                form.Show();
            }

        }

        private void btnFixQuality_Click(object sender, EventArgs e)
        {
            if (ct.FloatIsOK)
            {
                ct.FloatIsOK = false;
                //btnFixQuality.Text = "RTK fix only";
            }
            else
            {
                ct.FloatIsOK = true;
                //btnFixQuality.Text = "RTK or float";
            }

        }

        private void btnBoundarySide_Click(object sender, EventArgs e)
        {
            if (ct.isBoundarySideRight)
            {
                //btnBoundarySide.Text = "Boundary Left";
                ct.isBoundarySideRight = false;
            }
            else
            {
                //btnBoundarySide.Text = "Boundary Right";
                ct.isBoundarySideRight = true;
            }
        }

        private void btnStartPause_Click(object sender, EventArgs e)
        {
            if (ct.isBtnStartPause)
            {
                //btnStartPause.Text = "START";
                ct.isBtnStartPause = false;
            }
            else
            {
                //btnStartPause.Text = "PAUSE";
                ct.isBtnStartPause = true;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SelectMode();
        }

        private void btnSaveCut_Click_1(object sender, EventArgs e)
        {

            isCutSaved = true;
            ct.SaveToCut();
            //btnSaveCut.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripContainer1_BottomToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip3_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripDropDownButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton3_Click_1(object sender, EventArgs e)
        {
            
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripDropDownButton5_Click_1(object sender, EventArgs e)
        {
            if (panelNavigation.Visible)
            {
                panelNavigation.Visible = false;
            }
            else
            {
                panelNavigation.Visible = true;
                //navPanelCounter = 2;
            }
        }

        private void lblRTKPopupTime_Click(object sender, EventArgs e)
        {

        }

        private void vehicleSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsPageOpen(0);
        }

        private void implementSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsPageOpen(1);

        }

        private void toolStripDropDownButton1_Click_1(object sender, EventArgs e)
        {
            //bring up dialog if no job active, close job if one is
            if (!isJobStarted)
            {
                if (!isFirstFixPositionSet)
                {
                    TimedMessageBox(2500, "No GPS", "You are lost with no GPS, Fix that First");
                    return;
                }

                using (var form = new FormJob(this))
                {
                    var result = form.ShowDialog(this);
                    if (result == DialogResult.Yes)
                    {

                        //new field - ask for a directory name
                        using (var form2 = new FormFieldDir(this))
                        { form2.ShowDialog(this); }

                        
                    }

                    ////load from  KML
                    //else if (result == DialogResult.No)
                    //{
                    //    //ask for a directory name
                    //    using (var form2 = new FormFieldKML(this))
                    //    { form2.ShowDialog(this); }
                    //}
                }

                if (isJobStarted)
                {
                    //panelRight.Enabled = true;
                    ////boundaryToolStripBtn.Enabled = true;
                    //FieldMenuButtonEnableDisable(true);
                }
                else
                {
                    //panelRight.Enabled = false;
                    ////boundaryToolStripBtn.Enabled = false;
                    //FieldMenuButtonEnableDisable(false);
                }
            }
            //JobNewOpenResume();
        }




        
        

        private void toolStripSaveCutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isCutSaved = true;
            ct.SaveToCut();
            //btnSaveCut.Enabled = false;
        }

        private void lblUdpConnected_Click(object sender, EventArgs e)
        {

        }

        private void ledAntenna_Click(object sender, EventArgs e)
        {

        }

        private void ledGradeControl_Click(object sender, EventArgs e)
        {

        }

        private void lblAntennaConnected_Click(object sender, EventArgs e)
        {

        }

        private void modeToolStripMenuItem_Click(object sender, EventArgs e)
        {


            //if (curMode == gradeMode.surface)
            //{
            //    CalculateMinMaxZoom();
            //    curMode = gradeMode.ditch;
            //    //btnSurface.Image = Properties.Resources.ditchBtn;
            //    //btnAutoShore.Visible = false;
            //    //btnAutoCut.Visible = false;
            //    isAutoShoreOn = false;
            //    isAutoCutOn = false;
            //    //GradeControlOutToPort("Ditch Mode Active \n");
            //}
            //else if (curMode == gradeMode.ditch)
            //{
            //    CalculateMinMaxZoom();
            //    curMode = gradeMode.tile;
            //    //btnSurface.Image = Properties.Resources.pipeBtn;
            //    //btnAutoShore.Visible = false;
            //    //GradeControlOutToPort("Pipe Mode Active \n");
            //    //light Blue
            //    sqrMaxDepth.BackColor = Color.Red; //light Blue Max Depth
            //}
            //else if (curMode == gradeMode.tile)
            //{
            //    CalculateMinMaxZoom();
            //    curMode = gradeMode.contour;
            //   // btnSurface.Image = Properties.Resources.surfaceBtn;
            //    //btnAutoShore.Visible = true;
            //    //btnAutoCut.Visible = true;
            //    //GradeControlOutToPort("Surface Mode Active \n");
            //}
            //else if (curMode == gradeMode.contour)
            //{
            //    CalculateMinMaxZoom();
            //    curMode = gradeMode.surface;
            //    //btnSurface.Image = Properties.Resources.boundaryStop;
            //    //btnAutoShore.Visible = false;
            //    //btnAutoCut.Visible = false;
            //    //GradeControlOutToPort("Surface Mode Active \n");
            //}
        }

        private void toolStrip3DSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                //DialogResult diaRes = DialogResult.None;

                var form = new Form3dSurvey(this);
                form.Show(this);

                //using (var form = new Form3dSurvey(this))
                //{
                //    if (form.ShowDialog(this) == DialogResult.OK)
                //    {
                //        //Form form2 = new Form3dSurvey(this);
                //        //form2.Show(this);
                //    }
                //    diaRes = form.DialogResult;
                //}
                //if (diaRes == DialogResult.Yes)
                //{
                //    var form3 = new FormMap(this);
                //    form3.Show(this);
                //}
            }
            else
            {
                TimedMessageBox(3000, gStr.gsFieldNotOpen, gStr.gsStartNewField);
            }
        }

        private void toolStrip2DSurveyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                //DialogResult diaRes = DialogResult.None;

                //using (var form = new Form2dSurvey(this))
                //{
                //    if (form.ShowDialog(this) == DialogResult.OK)
                //    {
                //        //Form form2 = new Form2dSurvey(this);
                //        //form2.Show(this);
                //    }
                //    diaRes = form.DialogResult;
                //}

                var form = new Form2dSurvey(this);
                form.Show(this);


            }
            else
            {
                TimedMessageBox(3000, gStr.gsFieldNotOpen, gStr.gsStartNewField);
            }

        }

        private void zeroTripToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userDistance = 0;
        }

        private void nTRIPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsNtrip();
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsUDP();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (mc.isImuCorrection)
            {
                mc.isImuCorrection = false;
                //pictureBox1.BackColor = Color.Tomato;
            }
            else
            {
                mc.isImuCorrection = true;
                //pictureBox1.BackColor = Color.Lime;
            }
        }

        private void panelDrag_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void lblAutoCutDepth_Click(object sender, EventArgs e)
        {

        }

        private void lblFixQuality_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void lblCutDelta2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {


           


            
            
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            //if (panelpBar.Visible)
            //{
            //    panelpBar.Visible = false;

            //}
            //else
            //{
            //    panelpBar.Visible = true;
            //}


        }

        private void voltageBar_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnHideTab_Click(object sender, EventArgs e)
        {
            HideTabControl();
        }

        private void btnMode_Click(object sender, EventArgs e)
        {

        }

        private void toolStripBoundaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobClose();
        }

        private void loadCutToolStripMenuItem_Click(object sender, EventArgs e)
        {




            using (var form = new FormJob(this))
            {
                var result = form.ShowDialog(this);
                if (result == DialogResult.Yes)
                {
                    
                    //new field - ask for a directory name
                    using (var form2 = new FormFieldDir(this))
                    { form2.ShowDialog(this); }
                }

            }

           }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_2(object sender, EventArgs e)
        {
            SelectMode();
        }

        private void dModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectMode();
        }

        private void surfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            CalculateMinMaxZoom();
            curMode = gradeMode.surface;

            
        }

        private void tileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateMinMaxZoom();
            curMode = gradeMode.tile;

        }

        private void ditchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateMinMaxZoom();
            curMode = gradeMode.ditch;
        }

        private void contourToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CalculateMinMaxZoom();
            curMode = gradeMode.contour;
        }

        private void btnpTiltUp_Click(object sender, EventArgs e)
        {
            camera.camPitch -= ((camera.camPitch* 0.03) - 1);
            if (camera.camPitch > 0) camera.camPitch = 0;
            
        }

        private void btnpTiltDown_Click(object sender, EventArgs e)
        {
            camera.camPitch += ((camera.camPitch * 0.03) - 1);
            if (camera.camPitch < -80) camera.camPitch = -80;
        }

        private void repeatButton1_Click(object sender, EventArgs e)
        {

            if (zoomValue <= 20)
            { if ((zoomValue -= zoomValue * 0.1) < 1.5) zoomValue = 1.5; }
            else { if ((zoomValue -= zoomValue * 0.05) < 1.5) zoomValue = 1.5; }

            camera.camSetDistance = zoomValue * zoomValue * -1;
            SetZoom();


        }

        private void repeatButton2_Click(object sender, EventArgs e)
        {
            
            if (zoomValue <= 20) zoomValue += zoomValue * 0.1;
            else zoomValue += zoomValue * 0.05;
            camera.camSetDistance = zoomValue * zoomValue * -1;
            SetZoom();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            HideTabControl();   
        }

        private void btnSimGoTo_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.setSim_lastLat = (double)nudLatitude.Value;
            Properties.Settings.Default.setSim_lastLong = (double)nudLongitude.Value;
            Properties.Settings.Default.Save();
            sim.ResetSim();
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_3(object sender, EventArgs e)
        {
            //if (panelStats.Visible)
            //{
            //    panelStats.Visible = false;

            //}
            //else
            //{
            //    panelStats.Visible = true;
            //}
        }

        private void pbarCutAbove_Load(object sender, EventArgs e)
        {

        }

        private void pbarCutBelow_Load(object sender, EventArgs e)
        {

        }



        private void stripDepth_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }

        private void statusStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void stripMinMax_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel27_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel3_Click(object sender, EventArgs e)
        {
            rem.IncreaseBladeOffset();
        }

        private void toolStripStatusLabel4_Click(object sender, EventArgs e)
        {
            rem.DecreaseBladeOffset();
        }

        private void cOLOURSToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnVertAuto_Click(object sender, EventArgs e)
        {
            if (isAutoVertOn)
            {
                isAutoVertOn = false;
                btnVertAuto.Image = Properties.Resources.Toggle_Vert_MANUAL;
                mc.GradeControlData[mc.gcisAutoActive] = 0;
                section[1].TurnMappingOff();

            }
            else
            {
                isAutoVertOn = true;
                btnVertAuto.Image = Properties.Resources.Toggle_Vert_AUTO;
                mc.GradeControlData[mc.gcisAutoActive] = 1;
                section[1].TurnMappingOn();


            }





        }

        private void btnTiltAuto_Click(object sender, EventArgs e)
        {
            if (isAutoTiltOn)
            {
                isAutoTiltOn = false;
                btnTiltAuto.Image = Properties.Resources.Toggle_Tilt_MANUAL;
                mc.GradeControlData[mc.gcisAutoActive] = 0;
                section[1].TurnMappingOff();

            }
            else
            {
                isAutoTiltOn = true;
                btnTiltAuto.Image = Properties.Resources.Toggle_Tilt_AUTO;
                mc.GradeControlData[mc.gcisAutoActive] = 1;
                section[1].TurnMappingOn();

            }

        }

        private void gPSDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormGPSData(this);
            form.Show();
        }

        private void tStripVerticalOffset_Click(object sender, EventArgs e)
        {
            rem.ResetBladeOffset();
        }

        private void eXITToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mAPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (panelNavigation.Visible)
            {
                panelNavigation.Visible = false;
            }
            else
            {
                panelNavigation.Visible = true;
                //navPanelCounter = 2;
            }
        }

        private void rEMOTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormRemote(this);
            form.Show();
        }

        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rEADOUTSToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
            
            //if (!toolStripMenuItem1.Checked)
            //{

            //    if (f == null)
            //    {
            //        f = new FormAltSet(this);
            //        f.Show();
            //    }
            //    toolStripMenuItem1.Checked = true;
            //}
            //else
            //{

            //    if (f != null)
            //    {
            //        f.Close();

            //        f = null;
            //    }
            //    toolStripMenuItem1.Checked = false;

            //}
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                if (ct.ptList.Count < 1)
                    FileOpenAgdDesign();
                else
                {
                    var form = new FormTimedMessage(3000, "Contour.txt already exist", "Delete the Contour.txt or create a new Field");
                    form.Show();
                }
            }
            else
            {
                var form = new FormTimedMessage(3000, "No field open", "Open a field First");
                form.Show();
            }
        }

        private void btnABLine_Click_1(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void flagsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                //save new copy of flags
                FileSaveFlagsKML();

                //Process.Start(@"C:\Program Files (x86)\Google\Google Earth\client\googleearth", workingDirectory + currentFieldDirectory + "\\Flags.KML");
                Process.Start(fieldsDirectory + currentFieldDirectory + "\\Flags.KML");
            }
            else
            {
                var form = new FormTimedMessage(1500, gStr.gsFieldNotOpen, gStr.gsStartNewField);
                form.Show();
            }
        }

        private void webCamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new FormWebCam();
            form.Show();
        }

        private void windowsExplorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                var form = new FormTimedMessage(2000, gStr.gsFieldIsOpen, gStr.gsCloseFieldFirst);
                form.Show();
                return;
            }

            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.ShowNewFolderButton = true;
            fbd.Description = "Currently: " + Settings.Default.setF_workingDirectory;

            if (Settings.Default.setF_workingDirectory == "Default") fbd.SelectedPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            else fbd.SelectedPath = Settings.Default.setF_workingDirectory;

            if (fbd.ShowDialog() == DialogResult.OK)
            {
                RegistryKey regKey = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\OpenGrade", true);

                if (fbd.SelectedPath != Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
                {
                    //save the user set directory in Registry
                    regKey.SetValue("Directory", fbd.SelectedPath);
                    regKey.Close();
                    Settings.Default.setF_workingDirectory = fbd.SelectedPath;
                    Settings.Default.Save();
                }
                else
                {
                    regKey.SetValue("Directory", "Default");
                    regKey.Close();
                    Settings.Default.setF_workingDirectory = "Default";
                    Settings.Default.Save();
                }

                //restart program
                MessageBox.Show(gStr.gsProgramExitAndRestart);
                Close();
            }
        }

        private void fORCECLOSEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblHz_Click(object sender, EventArgs e)
        {
            ToggleSim();
        }

        private void lOGNMEAToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void rESETALLToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void dSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnLaserToggle_Click(object sender, EventArgs e)
        {
            
                
                ToggleLaserMode();
               


        }

        private void toolStripStatusLabel22_Click(object sender, EventArgs e)
        {
            mc.ToggleIMUCorrection();
        }

        private void toolStripStatusLabel28_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel17_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel14_Click(object sender, EventArgs e)
        {
            mc.ToggleIMUCorrection();
        }

        private void PanelDisplays_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripProgressBar1_Click(object sender, EventArgs e)
        {
            SelectMode();
        }

        private void btnLaserSettings_Click(object sender, EventArgs e)
        {
            ct.LaserSetAltitude = pn.altitude;
        }

        private void fORCERESETALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                MessageBox.Show(gStr.gsCloseFieldFirst);
            }
            else
            {
                DialogResult result2 = MessageBox.Show("Really Reset Everything?", "Reset settings",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (result2 == DialogResult.Yes)
                {
                    Settings.Default.Reset();
                    Settings.Default.Save();
                    Vehicle.Default.Reset();
                    Vehicle.Default.Save();
                    MessageBox.Show(gStr.gsProgramExitAndRestart);
                    //Application.Exit();
                }
            }
        }

        private void btnDayNightMode_Click(object sender, EventArgs e)
        {
            ToggleFullscreen();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_3(object sender, EventArgs e)
        {
            //if (panelDirectory.Visible)
            //{
            //    panelDirectory.Visible = false;

            //}
            //else
            //{
            //    panelDirectory.Visible = true;
            //}
        }

        private void btnAutoDrain_Click(object sender, EventArgs e)
        {
            ct.AutoDrain();
        }

        private void labelDiagnostics_TextChanged(object sender, EventArgs e)
        {

        }

        private void smoothLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }

        private void ApplySmoothContour(object sender, EventArgs e)
        {

            int ptCnt = ct.ptList.Count;
            for (int k = 0; k < ptCnt; k++)
            {
                ct.ptList[k].altitude = ct.autoList[k].northing;

            }
            ct.autoList.Clear();

        }


        private void SmoothContour(object sender, EventArgs e)
        {
            //if (tStripSmootingCB.SelectedIndex != null)
            //{
            //    int choice = tStripSmootingCB.SelectedIndex + 1;
            //    ct.SmoothLine(choice);
            //}
            //else
            //{
            //    int choice = 1;
            //    ct.SmoothLine(choice);
            //}    


        }

        //private void applyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    int ptCnt = ct.ptList.Count;
        //    for (int k = 0; k < ptCnt; k++)
        //    {
        //        ct.ptList[k].altitude = ct.autoList[k].northing;

        //    }
        //    ct.autoList.Clear();
        //    applyToolStripMenuItem.Enabled = false;
        //    applyToolStripMenuItem.BackColor = Color.LightGray;



        //}


        //private void verifyToolStripMenuItem_Click(object sender, EventArgs e)
        //{
        //    if (tStripSmootingCB.SelectedIndex != null)
        //    {
        //        int choice = tStripSmootingCB.SelectedIndex + 1;
        //        ct.SmoothLine(choice);
        //    }
        //    else
        //    {
        //        int choice = 1;
        //        ct.SmoothLine(choice);
        //    }

        //    applyToolStripMenuItem.Enabled = true;
        //    applyToolStripMenuItem.BackColor = Color.Lime;



        //}


        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnSurface_Click_1(object sender, EventArgs e)
        {


            //CheckMaxCut();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void ToggleLaserMode()
        {
            if (isLevelOn)
            {
                isLevelOn = false;
                btnLaserSettings.Visible = false;
                //btnSurface.Enabled = true;
                
                btnLaserToggle.Image = Properties.Resources.Toggle_Laser_MANUAL;
                lblMaxDepth.Visible = false;
                sqrMaxDepth.Visible = false;
                lblMinCover.Visible = false;
                sqrMinCover.Visible = false;
                lblCutLine.Visible = false;
                sqrCutLine1.Visible = false;
                lblDitchCutLine.Visible = false;
                sqrDitchCutLine.Visible = false;

                if (isJobStarted)
                {
                    //btnAutoCut.Visible = true;
                    //if (curMode == gradeMode.surface) btnAutoShore.Visible = true;

                }
                else
                {
                    //btnGradeControl.Enabled = false;
                    btnTiltAuto.Enabled = false;
                    btnVertAuto.Enabled = false;

                }

                openGLControlBack.Visible = true;
                openGLControl.Height = 390;

            //    PanelDisplays.Height = this.Height - 225;
            //    PanelDisplays.Width = this.Width - 115;
            }

            else
            {
                isLevelOn = true;
                lblMaxDepth.Visible = false;
                sqrMaxDepth.Visible = false;
                lblMinCover.Visible = false;
                sqrMinCover.Visible = false;
                lblCutLine.Visible = false;
                sqrCutLine1.Visible = false;
                lblDitchCutLine.Visible = false;
                sqrDitchCutLine.Visible = false;
                btnLaserSettings.Visible = true;


                ///btnAutoCut.Visible = false;
                //btnAutoShore.Visible = false;

                //btnIncCut.Visible = false;
                //btnDecCut.Visible = false;
                //lblAutoCutDepth.Visible = false;
                //lblPassDepth.Visible = false;


                //btnSurface.Enabled = false;
                
                btnLaserToggle.Image = Properties.Resources.Toggle_Laser_AUTO;
                //ct.LaserSetAltitude = pn.altitude;

                //btnGradeControl.Enabled = true;
                btnTiltAuto.Enabled = true;
                btnVertAuto.Enabled = true;

                    openGLControlBack.Visible = false;
                    openGLControl.Height = this.Height - 210 - 24;
               }

        }

       

        //form is closing so tidy up and save settings
        private void FormGPS_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Save, return, cancel save
            if (isJobStarted)
            {
                int choice = SaveOrNot();

                switch (choice)
                {
                    //OK
                    case 0:
                        isSendConnected = false;
                        //sendSocket.Shutdown(SocketShutdown.Both);
                        //recvSocket.Shutdown(SocketShutdown.Both);

                        Settings.Default.setSim_lastLong = pn.longitude;
                        Settings.Default.setSim_lastLat = pn.latitude;
                        Settings.Default.setF_CurrentDir = currentFieldDirectory;
                        Settings.Default.Save();

                        FileSaveEverythingBeforeClosingField();

                        //shutdown and reset all module data
                        mc.ResetAllModuleCommValues();

                        //sendSocket.Disconnect(true);
                        //recvSocket.Disconnect(true);

                        break;

                    //Ignore and return
                    case 1:
                        e.Cancel = true;
                        break;
                }
            }

            //save window settings
            if (WindowState == FormWindowState.Maximized)
            {
                Settings.Default.setWindow_Location = RestoreBounds.Location;
                Settings.Default.setWindow_Size = RestoreBounds.Size;
                Settings.Default.setWindow_Maximized = true;
                Settings.Default.setWindow_Minimized = false;
            }
            else if (WindowState == FormWindowState.Normal)
            {
                Settings.Default.setWindow_Location = Location;
                Settings.Default.setWindow_Size = Size;
                Settings.Default.setWindow_Maximized = false;
                Settings.Default.setWindow_Minimized = false;
            }
            else
            {
                Settings.Default.setWindow_Location = RestoreBounds.Location;
                Settings.Default.setWindow_Size = RestoreBounds.Size;
                Settings.Default.setWindow_Maximized = false;
                Settings.Default.setWindow_Minimized = true;
            }

            Settings.Default.setCam_pitch = camera.camPitch;
            Settings.Default.Save();
        }

        //called everytime window is resized, clean up button positions
        private void FormGPS_Resize(object sender, EventArgs e)
        {

            if (PanelDisplays.Visible)
            {
                PanelDisplays.Height = this.Height - 210;
                PanelDisplays.Width = this.Width - 115;

                //openGLControl.Height = PanelDisplays.Height - 250  ;
                Point pbarL = new Point(0, 0);
                Point pbarR = new Point(0, 0);
                pbarCutAboveL.Height = ((PanelDisplays.Height-24)/2) ;
                pbarCutBelowL.Height = ((PanelDisplays.Height-24)/2) ;
                pbarCutAboveR.Height = ((PanelDisplays.Height - 24) / 2);
                pbarCutBelowR.Height = ((PanelDisplays.Height - 24) / 2);

                
                pbarL.X = 30;
                pbarL.Y = (PanelDisplays.Height ) / 2;
                pbarCutBelowL.Location = (pbarL);


                pbarR.X = voltageBar2.Location.X - 29 - voltageBar2.Width;
                pbarR.Y = (PanelDisplays.Height) / 2;
                pbarCutBelowR.Location = (pbarR);



                //pbarCutBelowL.Height = (PanelDisplays.Height / 2);

                // Adjust pBar



            }


            //if (openGLControlBack.Visible)
            //{
            //    openGLControl.Height = 390;
            //    //pbarCutAbove.Height = openGLControlBack.Height / 2;
            //    //pbarCutBelow.Height = pbarCutAbove.Height;
            //    //pbarCutBelow.Top = pbarCutAbove.Top + pbarCutAbove.Height;
            //}
            //else
            //{
            //    openGLControl.Height = this.Height - 210;
            //}
        }

        // Select between Grade Mode and Survey Mode
        public void SelectMode()
        {
            if (ct.surveyMode)
            {
              
                if (!ct.isSurveyOn)
                {
                    //ledSurvey.BackColor = Color.Red;
                    ct.surveyMode = false;
                    
                    //button3.Text = "Grade Mode";
                    //stripSelectMode.Text = "Grade Mode";
                   // btnManualOffOn.Visible = false;
                    //btnCutFillElev.Visible = true;
                    //btnPropExist.Visible = true;
                    //btnStartPause.Visible = false;
                    //btnFixQuality.Visible = false;
                   // btnBoundarySide.Visible = false;
                }
                        

            }
            else
            {
                
                //ledSurvey.BackColor = Color.CornflowerBlue;
                ct.surveyMode = true;
                //button3.Text = "Survey Mode";
                //stripSelectMode.Text = "Survey Mode";
                //btnManualOffOn.Visible = true;
                //btnCutFillElev.Visible = false;
                //btnPropExist.Visible = false;
               // btnFixQuality.Visible = true;
            }
        }

        // Procedures and Functions ---------------------------------------
        public uint LoadGLTextures()
        {
            OpenGL gl = openGLControlBack.OpenGL;

            try
            {
                //  Background
                ParticleTexture = new Texture();
                ParticleTexture.Create(gl, @".\Dependencies\landscape.png");
                texture[0] = ParticleTexture.TextureName;
            }
            catch (Exception e)
            {
                MessageBox.Show("Texture File LANDSCAPE.PNG is Missing", e.Message);
            }

            try
            {
                //  Floor
                ParticleTexture = new Texture();
                ParticleTexture.Create(gl, @".\Dependencies\Floor.png");
                texture[1] = ParticleTexture.TextureName;
            }
            catch (Exception e)
            {
                MessageBox.Show("Texture File FLOOR.PNG is Missing", e.Message);
            }

            return texture[0];
        }

        //start the UDP server
        private void StartUDPServer()
        {
            try
            {
                // Initialise the delegate which updates the message received
                updateRecvMessageDelegate = UpdateRecvMessage;

                // Initialise the socket
                sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
                recvSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Initialise the IPEndPoint for the server and listen on port 9999
                //IPEndPoint recv = new IPEndPoint(new IPAddress(ipAddress), Properties.Settings.Default.setIP_thisPort);
                IPEndPoint recv = new IPEndPoint(IPAddress.Any, Properties.Settings.Default.setIP_thisPort);

                // Associate the socket with this IP address and port
                recvSocket.Bind(recv);

                // Initialise the send socket
                sendSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

                // Initialise the IPEndPoint for the server to send on port 9998
                IPEndPoint server = new IPEndPoint(IPAddress.Any, 9998);
                sendSocket.Bind(server);

                //IP address and port of Antenna server
                IPAddress epIP = IPAddress.Parse(Properties.Settings.Default.setIP_AntennaIP);
                epAntennaModule = new IPEndPoint(epIP, Properties.Settings.Default.setIP_AntennaPort);


                //IP address and port of GradeControl server
                IPAddress gcIP = IPAddress.Parse(Properties.Settings.Default.setIP_gradeControlIP);
                epGradeControl = new IPEndPoint(gcIP, Properties.Settings.Default.setIP_gradeControlPort);

                // Initialise the IPEndPoint for the client - async listner client only!
                EndPoint client = new IPEndPoint(IPAddress.Any, 0);

                // Start listening for incoming data
                recvSocket.BeginReceiveFrom(buffer, 0, buffer.Length, SocketFlags.None,
                                                ref client, ReceiveData, recvSocket);
                isSendConnected = true;
            }
            catch (Exception e)
            {
                WriteErrorLog("UDP Server" + e);
                MessageBox.Show("Load Error: " + e.Message, "UDP Server", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //dialog for requesting user to save or cancel
        public int SaveOrNot()
        {
            using (var form = new FormSaveOrNot())
            {
                var result = form.ShowDialog();

                if (result == DialogResult.OK) return 0;
                if (result == DialogResult.Ignore) return 1;
                if (result == DialogResult.Cancel) return 2;
                return 3;
            }
        }

        //show the communications window
        private void SettingsCommunications()
        {

        }

        //show the UDP ethernet settings page
        private void SettingsUDP()
        {
            using (var form = new FormUDP(this))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Clicked Save
                }
                else
                {
                    //Clicked X - No Save
                }
            }
        }

        private void SettingsNtrip()
        {
            using (var form = new FormNtrip(this))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    //Clicked Save
                }
                else
                {
                    //Clicked X - No Save
                }
            }
        }




        //request a new job
        public void JobNew()
        {

            isJobStarted = true;
            startCounter = 0;
            //btnManualOffOn.Enabled = true;
            //btnManualOffOn.Image = Properties.Resources.SurveyStart;
            //btnABLine.Enabled = true;
            //btnContour.Enabled = true;
            //btnGradeControl.Enabled = true;

            btnTiltAuto.Enabled = true;
            btnVertAuto.Enabled = true;
            ABLine.abHeading = 0.00;
            //btnFlag.Enabled = true;
            ct.isContourBtnOn = false;
            ct.isContourOn = false;
            ct.ptList.Clear();
            ct.drawList.Clear();
            //lblCut.Text = "*";
            //lblFill.Text = "*";
            //lblCutFillRatio.Text = "*";
            //lblDrawSlope.Text = "*";
            curFieldName = currentFieldDirectory;



            if (!isLevelOn)
            {
                //btnAutoCut.Visible = true;
                //btnAutoShore.Visible = true;
            }

            //update the menu
            //fieldToolStripMenuItem.Text = gStr.gsCloseField;
        }

        //close the current job
        public void JobClose()
        {
            //turn manual button off
            manualBtnState = btnStates.Off;
            //btnManualOffOn.Image = Properties.Resources.SurveyStart;


            //job is closed
            isJobStarted = false;

            //clear out the contour Lists
            ct.ResetContour();

            //clear the flags
            flagPts.Clear();
            //btnFlag.Enabled = false;

            //reset the buttons
            //btnABLine.Enabled = false;
            //btnContour.Enabled = false;
            //btnGradeControl.Enabled = false;
            isGradeControlBtnOn = false;


            btnTiltAuto.Enabled = false;
            isAutoTiltOn = false;       

            btnVertAuto.Enabled = false;
            isAutoVertOn = false;





            //btnAutoCut.Visible = false;
            //btnAutoShore.Visible = false;
            //btnIncCut.Visible = false;
            //btnDecCut.Visible = false;
            //lblAutoCutDepth.Visible = false;
            //lblPassDepth.Visible = false;

            curFieldName = "";
            
            //lblField.Text = "";


            ct.isContourBtnOn = false;
            ct.isContourOn = false;
            ct.ptList.Clear();
            ct.drawList.Clear();
            //lblCut.Text = "*";
            //lblFill.Text = "*";
            //lblCutFillRatio.Text = "*";
            //lblDrawSlope.Text = "*";
            Text = "OpenGradeX - Press Start To Begin";


            //change images to reflect on off
            //btnABLine.Image = Properties.Resources.ABLineOff;
            //btnContour.Image = Properties.Resources.ContourOff;
            //btnGradeControl.Image = Properties.Resources.GradeControlOff1;

            //fix ManualOffOnAuto buttons
           // btnManualOffOn.Enabled = false;
           // btnManualOffOn.Image = Properties.Resources.SurveyStop1;

            //reset all the ABLine stuff
            ABLine.ResetABLine();

            //update the menu
            //fieldToolStripMenuItem.Text = gStr.gsStartNewField;

            //reset all Port Module values
            mc.ResetAllModuleCommValues();
        }

        //bring up field dialog for new/open/resume
        public void JobNewOpenResume()
        {
            if (!isJobStarted)
            {
                if (stripOnlineGPS.Value == 1)
                {
                    var form = new FormTimedMessage(3000, gStr.gsNoGPS, gStr.gsIsGPSOff);
                    form.Show();
                    return;
                }

                using (var form = new FormJob(this))
                {
                    var result = form.ShowDialog();
                    if (result == DialogResult.Yes)
                    {
                        //ask for a directory name
                        using (var form2 = new FormFieldDir(this))
                        { form2.ShowDialog(); }
                    }
                }
                Text = "OpenGradeX - " + currentFieldDirectory;

            }
            else
            {
                using (var form = new FormJob(this))
                {
                    var result = form.ShowDialog();
                }


            }
        }

        private void ProcessSectionOnOffRequests()
        {
            {

                //MAPPING - 
                for (int j = 0; j < 2; j++)
                {
                    //easy just turn it on
                    if (section[1].mappingOnRequest)
                    {
                        if (!section[1].isMappingOn && isMapping) section[1].TurnMappingOn(); //**************************************** un comment to enable mappping again
                    }

                    //turn off
                    double sped = 1 / ((pn.speed + 5) * 0.2);
                    if (sped < 0.2) sped = 0.2;

                }


                //if Off mapping timer is zero, turn off the section, reset everything
                if (section[1].mappingOffRequest)
                {
                    if (section[1].isMappingOn) section[1].TurnMappingOff();
                    section[1].mappingOffRequest = false;
                }

            }
        }
    



        //take the distance from object and convert to camera data
        private void SetZoom()
        {
            //match grid to cam distance and redo perspective
            if (camera.camSetDistance <= -20000) gridZoom = 2000;
            if (camera.camSetDistance >= -20000 && camera.camSetDistance < -10000) gridZoom = 2000;
            if (camera.camSetDistance >= -10000 && camera.camSetDistance < -5000) gridZoom = 1000;
            if (camera.camSetDistance >= -5000 && camera.camSetDistance < -2000) gridZoom = 503;
            if (camera.camSetDistance >= -2000 && camera.camSetDistance < -1000) gridZoom = 201.2;
            if (camera.camSetDistance >= -1000 && camera.camSetDistance < -500) gridZoom = 100.6;
            if (camera.camSetDistance >= -500 && camera.camSetDistance < -250) gridZoom = 50.3;
            if (camera.camSetDistance >= -250 && camera.camSetDistance < -150) gridZoom = 25.15;
            if (camera.camSetDistance >= -150 && camera.camSetDistance < -50) gridZoom = 10.06;
            if (camera.camSetDistance >= -50 && camera.camSetDistance < -1) gridZoom = 5.03;
            //1.216 2.532

            //  Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;

            //  Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gl.LoadIdentity();

            //  Create a perspective transformation.
            gl.Perspective(fovy, openGLControl.Width / (double)openGLControl.Height, 1, camDistanceFactor * camera.camSetDistance);

            //  Set the modelview matrix.
            gl.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        //All the files that need to be saved when closing field or app
        public void FileSaveEverythingBeforeClosingField()
        {
            //turn off contour line if on
            if (ct.isContourOn) ct.StopContourLine();

            //turn off all the sections
            for (int j = 0; j < 1 + 1; j++)
            {
                if (section[j].isMappingOn) section[j].TurnMappingOff();
                section[j].sectionOnOffCycle = false;
                section[j].sectionOffRequest = false;
            }

            FileSaveField();
            FileSaveSections();
            FileSaveContour();
            FileSaveFlagsKML();

            JobClose();
            Text = "OpenGradeX";
        }

        //function called by menu items to delete a selected flag
        private void DeleteSelectedFlag()
        {
            //delete selected flag and set selected to none
            flagPts.RemoveAt(flagNumberPicked - 1);
            flagNumberPicked = 0;

            // re-sort the id's based on how many flags left
            int flagCnt = flagPts.Count;
            if (flagCnt > 0)
            {
                for (int i = 0; i < flagCnt; i++) flagPts[i].ID = i + 1;
            }
        }



        //an error log called by all try catches
        public void WriteErrorLog(string strErrorText)
        {
            try
            {
                //set up file and folder if it doesn't exist
                const string strFileName = "Error Log.txt";
                string strPath = System.Windows.Forms.Application.StartupPath;
                //if (!File.Exists(strPath + "\\" + strFileName))
                //{
                //    File.Create(strPath + "\\" + strFileName);
                //}


                //Write out the error appending to existing
                File.AppendAllText(strPath + "\\" + strFileName, strErrorText + " - " +
                    DateTime.Now.ToString() + "\r\n\r\n");
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Error in WriteErrorLog: " + ex.Message, "Error Logging", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        //message box pops up with info then goes away
        public void TimedMessageBox(int timeout, string s1, string s2)
        {
            var form = new FormTimedMessage(timeout, s1, s2);
            form.Size = new Size(400, 200);
            form.Show();
        }

        //public void TimedMessageBox(int timeout, string s1, string s2, bool timer)
        //{
        //    var form = new FormTimedMessage(timeout, s1, s2);
        //    form.Size = new Size(400, 200);
        //    form.Show();
        //}
        //class FormGPS

    }
}
//namespace OpenGrade

/*The order is:
 *
 * The watchdog timer times out and runs this function tmrWatchdog_tick().
 * 50 times per second so statusUpdateCounter counts to 25 and updates strip menu etc at 2 hz
 * it also makes sure there is new sentences showing up otherwise it shows -* No GGA....
 * saveCounter ticks 2 x per second, used at end of draw routine every minute to save a backup of field
 * then ScanForNMEA function checks for a complete sentence if contained in pn.rawbuffer
 * if not it comes right back and waits for next watchdog trigger and starts all over
 * if a new sentence is there, UpdateFix() is called
 * Right away CalculateLookAhead(), no skips, is called to determine lookaheads and trigger distances to save triangles plotted
 * Then UpdateFix() continues.
 * Hitch, pivot, antenna locations etc and directions are figured out if trigDistance is triggered
 * When that is done, DoRender() is called on the visible OpenGL screen and its draw routine _draw is run
 * before triangles are drawn, frustum cull figures out how many of the triangles should be drawn
 * When its all the way thru, it triggers the sectioncontrol Draw, its frustum cull, and determines if sections should be on
 * ProcessSectionOnOffRequests() runs and that does the section on off magic
 * SectionControlToArduino() runs and spits out the port relay control based on sections on or off
 * If field needs saving (1.5 minute since last time) field is saved
 * Now the program is "Done" and waits for the next watchdog trigger, determines if a new sentence is available etc
 * and starts all over from the top.
 */