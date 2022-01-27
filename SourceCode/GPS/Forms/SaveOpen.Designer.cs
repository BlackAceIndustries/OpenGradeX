﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Globalization;
using System.Drawing;
using System.Xml;
using System.Text;

namespace OpenGrade
{
    
    public partial class FormGPS
    {
        //list of the list of patch data individual triangles for field sections
        public List<List<vec2>> patchSaveList = new List<List<vec2>>();

        //function that save vehicle and section settings
        public void FileSaveVehicle()
        {
            //in the current application directory
            //string dir = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            //string fieldDir = dir + "\\fields\\";

            string dirVehicle = vehiclesDirectory;

            string directoryName = Path.GetDirectoryName(dirVehicle).ToString(CultureInfo.InvariantCulture);

            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.Title = "Save Vehicle";
            saveDialog.Filter = "Text Files (*.txt)|*.txt";
            saveDialog.InitialDirectory = directoryName;

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                vehiclefileName = Path.GetFileNameWithoutExtension(saveDialog.FileName) + " - ";
                Properties.Vehicle.Default.setVehicle_Name = vehiclefileName;
                Properties.Vehicle.Default.Save();

                using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                {
                    writer.WriteLine("Version," + Application.ProductVersion.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("Wheelbase," + Properties.Vehicle.Default.setVehicle_wheelbase.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("AntennaHeight," + Properties.Vehicle.Default.setVehicle_antennaHeight.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("PlowHeight," + Properties.Vehicle.Default.setVehicle_plowHeight.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("MaxDitchCut," + Properties.Vehicle.Default.setVehicle_maxDitchCut.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("MaxTileCut," + Properties.Vehicle.Default.setVehicle_maxTileCut.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("MinTileCover," + Properties.Vehicle.Default.setVehicle_minTileCover.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("KpGain," + Properties.Settings.Default.set_KpGain.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("KiGain," + Properties.Settings.Default.set_KiGain.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("KdGain," + Properties.Settings.Default.set_KdGain.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("ToolWidth," + Properties.Vehicle.Default.setVehicle_toolWidth.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("MinimumSlope," + Properties.Vehicle.Default.setVehicle_minSlope.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("IsMetric," + Properties.Settings.Default.setMenu_isMetric.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("IsGridOn," + Properties.Settings.Default.setMenu_isGridOn.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("IsLightBarOn," + Properties.Settings.Default.setMenu_isLightbarOn.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("IsPurePursuitLineOn," + Properties.Settings.Default.setMenu_isPureOn.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("FieldColorR," + Properties.Settings.Default.setF_FieldColorR.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("FieldColorG," + Properties.Settings.Default.setF_FieldColorG.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("FieldColorB," + Properties.Settings.Default.setF_FieldColorB.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("SectionColorR," + Properties.Settings.Default.setF_SectionColorR.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("SectionColorG," + Properties.Settings.Default.setF_SectionColorG.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("SectionColorB," + Properties.Settings.Default.setF_SectionColorB.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("IMUPitchZero," + Properties.Settings.Default.setIMU_pitchZero.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("IMURollZero," + Properties.Settings.Default.setIMU_rollZero.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("IsLogNMEA," + Properties.Settings.Default.setMenu_isLogNMEA.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("MinFixStep," + Properties.Settings.Default.setF_minFixStep.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("pidP," + Properties.Settings.Default.setAS_Kp.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("pidI," + Properties.Settings.Default.setAS_Ki.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("pidD," + Properties.Settings.Default.setAS_Kd.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("pidO," + Properties.Settings.Default.setAS_Ko.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("SteerAngleOffset," + Properties.Settings.Default.setAS_steerAngleOffset.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("minPWM," + Properties.Settings.Default.setAS_minSteerPWM.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("MaxIntegral," + Properties.Settings.Default.setAS_maxIntegral.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("CountsPerDegree," + Properties.Settings.Default.setAS_countsPerDegree.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("GoalPointLookAhead," + Properties.Vehicle.Default.setVehicle_goalPointLookAhead.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("MaxSteerAngle," + Properties.Vehicle.Default.setVehicle_maxSteerAngle.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("MaxAngularVelocity," + Properties.Vehicle.Default.setVehicle_maxAngularVelocity.ToString(CultureInfo.InvariantCulture));

                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                    writer.WriteLine("Empty," + "10");
                }

                //little show to say saved and where
                var form = new FormTimedMessage(3000, "Saved in Folder: ", dirVehicle);
                form.Show();
            }

        }

        //function to open a previously saved field
        public void FileOpenVehicle()
        {
            OpenFileDialog ofd = new OpenFileDialog();

            //get the directory where the fields are stored
            string directoryName = vehiclesDirectory;

            //make sure the directory exists, if not, create it
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            //the initial directory, fields, for the open dialog
            ofd.InitialDirectory = directoryName;

            //When leaving dialog put windows back where it was
            ofd.RestoreDirectory = true;

            //set the filter to text files only
            ofd.Filter = "txt files (*.txt)|*.txt";

            //was a file selected
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //if job started close it
                if (isJobStarted) JobClose();

                //make sure the file if fully valid and vehicle matches sections
                using (StreamReader reader = new StreamReader(ofd.FileName))
                {
                    try
                    {
                        string line;
                        Properties.Vehicle.Default.setVehicle_Name = ofd.FileName;
                        string[] words;
                        line = reader.ReadLine(); words = line.Split(',');

                        //if (words[0] != "Version")

                        //{
                        //    var form = new FormTimedMessage(5000, "Vehicle File is Wrong Version", "Must be Version 2.16 or higher");
                        //    form.Show();
                        //    return;
                        //}

                        //double test = double.Parse(words[1], CultureInfo.InvariantCulture);

                        //if (test < 2.16)
                        //{
                        //    var form = new FormTimedMessage(5000, "Vehicle File is Wrong Version", "Must be Version 2.16 or higher");
                        //    form.Show();
                        //    return;
                        //}

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_wheelbase = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_plowHeight = double.Parse(words[1], CultureInfo.InvariantCulture);

                        // Black Ace Industries
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_maxDitchCut = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_maxTileCut = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_minTileCover = double.Parse(words[1], CultureInfo.InvariantCulture);

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.set_KpGain = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.set_KiGain = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.set_KdGain = byte.Parse(words[1], CultureInfo.InvariantCulture);





                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_antennaHeight = double.Parse(words[1], CultureInfo.InvariantCulture);
                        
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_toolWidth = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_minSlope = double.Parse(words[1], CultureInfo.InvariantCulture);

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setMenu_isMetric = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setMenu_isGridOn = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setMenu_isLightbarOn = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setMenu_isPureOn = bool.Parse(words[1]);

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_FieldColorR = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_FieldColorG = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_FieldColorB = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_SectionColorR = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_SectionColorG = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_SectionColorB = byte.Parse(words[1], CultureInfo.InvariantCulture);

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setIMU_pitchZero = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setIMU_rollZero = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setMenu_isLogNMEA = bool.Parse(words[1]);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setF_minFixStep = double.Parse(words[1], CultureInfo.InvariantCulture);

                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setAS_Kp = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setAS_Ki = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setAS_Kd = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setAS_Ko = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setAS_steerAngleOffset = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setAS_minSteerPWM = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Settings.Default.setAS_maxIntegral = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine();words = line.Split(',');
                        Properties.Settings.Default.setAS_countsPerDegree = byte.Parse(words[1], CultureInfo.InvariantCulture);
                        
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_maxSteerAngle = double.Parse(words[1], CultureInfo.InvariantCulture);
                        line = reader.ReadLine(); words = line.Split(',');
                        Properties.Vehicle.Default.setVehicle_maxAngularVelocity = double.Parse(words[1], CultureInfo.InvariantCulture);

                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();

                        //fill in the current variables with restored data
                        vehiclefileName = Path.GetFileNameWithoutExtension(ofd.FileName) + " - ";
                        Properties.Vehicle.Default.setVehicle_Name = vehiclefileName;

                        Properties.Settings.Default.Save();
                        Properties.Vehicle.Default.Save();

                        //from settings grab the vehicle specifics
                        vehicle.antennaHeight = Properties.Vehicle.Default.setVehicle_antennaHeight;
                        vehicle.wheelbase = Properties.Vehicle.Default.setVehicle_wheelbase;
                        vehicle.plowHeight = Properties.Vehicle.Default.setVehicle_plowHeight;

                        //Black Ace Industries
                        vehicle.maxDitchCut = Properties.Vehicle.Default.setVehicle_maxDitchCut;
                        vehicle.maxTileCut = Properties.Vehicle.Default.setVehicle_maxTileCut;
                        vehicle.minTileCover = Properties.Vehicle.Default.setVehicle_minTileCover;
                        
                        
                        vehicle.KpGain = Properties.Settings.Default.set_KpGain;
                        vehicle.KiGain = Properties.Settings.Default.set_KiGain;  
                        vehicle.KdGain = Properties.Settings.Default.set_KdGain;

                        vehicle.retDeadband = Properties.Settings.Default.set_RetDeadband;
                        vehicle.extDeadband = Properties.Settings.Default.set_ExtDeadband;
                        vehicle.valveType = Properties.Settings.Default.set_ValveType;


                        mc.gradeControlSettings[mc.gsKpGain] = Properties.Settings.Default.set_KpGain;
                        mc.gradeControlSettings[mc.gsKiGain] = Properties.Settings.Default.set_KiGain;
                        mc.gradeControlSettings[mc.gsKdGain] = Properties.Settings.Default.set_KdGain;
                        mc.gradeControlSettings[mc.gsRetDeadband] = Properties.Settings.Default.set_RetDeadband;
                        mc.gradeControlSettings[mc.gsExtDeadband] = Properties.Settings.Default.set_ExtDeadband;
                        mc.gradeControlSettings[mc.gsValveType] = Properties.Settings.Default.set_ValveType;



                        vehicle.toolWidth = Properties.Vehicle.Default.setVehicle_toolWidth;
                        vehicle.minSlope = Properties.Vehicle.Default.setVehicle_minSlope;

                        vehicle.maxAngularVelocity = Properties.Vehicle.Default.setVehicle_maxAngularVelocity;
                        vehicle.maxSteerAngle = Properties.Vehicle.Default.setVehicle_maxSteerAngle;

                        mc.autoSteerSettings[mc.ssKp] = Properties.Settings.Default.setAS_Kp;
                        mc.autoSteerSettings[mc.ssKi] = Properties.Settings.Default.setAS_Ki;
                        mc.autoSteerSettings[mc.ssKd] = Properties.Settings.Default.setAS_Kd;
                        mc.autoSteerSettings[mc.ssKo] = Properties.Settings.Default.setAS_Ko;
                        mc.autoSteerSettings[mc.ssSteerOffset] = Properties.Settings.Default.setAS_steerAngleOffset;
                        mc.autoSteerSettings[mc.ssMinPWM] = Properties.Settings.Default.setAS_minSteerPWM;
                        mc.autoSteerSettings[mc.ssMaxIntegral] = Properties.Settings.Default.setAS_maxIntegral;
                        mc.autoSteerSettings[mc.ssCountsPerDegree] = Properties.Settings.Default.setAS_countsPerDegree;

                        mc.isWorkSwitchEnabled = Properties.Settings.Default.setF_IsWorkSwitchEnabled;
                        mc.isWorkSwitchActiveLow = Properties.Settings.Default.setF_IsWorkSwitchActiveLow;

                        camera.camPitch = Properties.Settings.Default.setCam_pitch;

                        isMetric = Properties.Settings.Default.setMenu_isMetric;
                        metricToolStrip.Checked = isMetric;
                        imperialToolStrip.Checked = isMetric;

                        isGridOn = Properties.Settings.Default.setMenu_isGridOn;
                        gridToolStripMenuItem.Checked = (isGridOn);

                        isLightbarOn = Properties.Settings.Default.setMenu_isLightbarOn;
                        lightbarToolStripMenuItem.Checked = isLightbarOn;

                        isPureDisplayOn = Properties.Settings.Default.setMenu_isPureOn;
                        pursuitLineToolStripMenuItem.Checked = isPureDisplayOn;

                        redSections = Properties.Settings.Default.setF_SectionColorR;
                        grnSections = Properties.Settings.Default.setF_SectionColorG;
                        bluSections = Properties.Settings.Default.setF_SectionColorB;
                        redField = Properties.Settings.Default.setF_FieldColorR;
                        grnField = Properties.Settings.Default.setF_FieldColorG;
                        bluField = Properties.Settings.Default.setF_FieldColorB;

                        pitchZero = Properties.Settings.Default.setIMU_pitchZero;
                        rollZero = Properties.Settings.Default.setIMU_rollZero;
                        isLogNMEA = Properties.Settings.Default.setMenu_isLogNMEA;
                        minFixStepDist = Properties.Settings.Default.setF_minFixStep;
                        
                        //Application.Exit();
                    }
                    catch (Exception e) //FormatException e || IndexOutOfRangeException e2)
                    {
                        WriteErrorLog("Open Vehicle" + e.ToString());

                        //vehicle is corrupt, reload with all default information
                        Properties.Settings.Default.Reset();
                        Properties.Settings.Default.Save();
                        MessageBox.Show("Program will Reset to Recover. Please Restart", "Vehicle file is Corrupt", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        Application.Exit();
                    }
                }
            }      //cancelled out of open file
        }//end of open file

        //function to open a previously saved field, Contour, Flags, Boundary
        public void FileOpenField(string _openType)
        {
            string fileAndDirectory;
            //get the directory where the fields are stored
            //string directoryName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+ "\\fields\\";

            if (_openType == "Resume")
            {
                //Either exit or update running save
                fileAndDirectory = fieldsDirectory + currentFieldDirectory + "\\Field.txt";
                if (!File.Exists(fileAndDirectory)) return;
            }

            //open file dialog instead
            else
            {
                //create the dialog instance
                OpenFileDialog ofd = new OpenFileDialog();

                //the initial directory, fields, for the open dialog
                ofd.InitialDirectory = fieldsDirectory;

                //When leaving dialog put windows back where it was
                ofd.RestoreDirectory = true;

                //set the filter to text files only
                ofd.Filter = "Field files (Field.txt)|Field.txt";

                //was a file selected
                if (ofd.ShowDialog() == DialogResult.Cancel) return;
                else fileAndDirectory = ofd.FileName;
            }

            //close the existing job and reset everything
            this.JobClose();

            //and open a new job
            this.JobNew();

            //Saturday, February 11, 2017  -->  7:26:52 AM
            //$FieldDir
            //Bob_Feb11
            //$Offsets
            //533172,5927719,12 - offset easting, northing, zone
            //$Sections
            //10 - points in this patch
            //10.1728031317344,0.723157039771303 -easting, northing

            //start to read the file
            string line;
            using (StreamReader reader = new StreamReader(fileAndDirectory))
            {
                try
                {
                    //Date time line
                    line = reader.ReadLine();

                    //dir header $FieldDir
                    line = reader.ReadLine();

                    //read field directory
                    line = reader.ReadLine();

                    currentFieldDirectory = line.Trim();

                    //Offset header
                    line = reader.ReadLine();

                    //read the Offsets 
                    line = reader.ReadLine();
                    string[] offs = line.Split(',');
                    pn.utmEast = int.Parse(offs[0]);
                    pn.utmNorth = int.Parse(offs[1]);
                    pn.zone = int.Parse(offs[2]);

                    //create a new grid
                    worldGrid.CreateWorldGrid(pn.actualNorthing - pn.utmNorth, pn.actualEasting - pn.utmEast);
                }

                catch (Exception e)
                {
                    WriteErrorLog("While Opening Field" + e.ToString());

                    var form = new FormTimedMessage(4000, "Field File is Corrupt", "Choose a different field");
                    form.Show();
                    JobClose();
                    return;
                }
            }

            // Contour points ----------------------------------------------------------------------------

            fileAndDirectory = fieldsDirectory + currentFieldDirectory + "\\CurrentCut.txt";
            if (!File.Exists(fileAndDirectory))
            {
                var form = new FormTimedMessage(4000, "Missing Contour File", "But Field is Loaded");
                form.Show();
                //return;
            }

            /*
                May-14-17  -->  7:42:47 PM
                Points in Patch followed by easting, heading, northing, altitude
                $ContourDir
                cdert_May14
                $Offsets
                533631,5927279,12
                19
                2.866,2.575,-4.07,0             
             */
            else
            {
                using (StreamReader reader = new StreamReader(fileAndDirectory))
                {
                    try
                    {
                        //read the lines and skip them
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            //read how many vertices in the following patch
                            line = reader.ReadLine();
                            int verts = int.Parse(line);
                            //CContourPt vecFix = new vec4(0, 0, 0, 0);

                            for (int v = 0; v < verts; v++)
                            {
                                line = reader.ReadLine();
                                string[] words = line.Split(',');

                                CContourPt point = new CContourPt(
                                    double.Parse(words[0], CultureInfo.InvariantCulture),
                                    double.Parse(words[1], CultureInfo.InvariantCulture),
                                    double.Parse(words[2], CultureInfo.InvariantCulture),
                                    double.Parse(words[3], CultureInfo.InvariantCulture),
                                    double.Parse(words[4], CultureInfo.InvariantCulture),
                                    double.Parse(words[5], CultureInfo.InvariantCulture),
                                    double.Parse(words[6], CultureInfo.InvariantCulture),
                                    double.Parse(words[7], CultureInfo.InvariantCulture),
                                    double.Parse(words[8], CultureInfo.InvariantCulture),
                                    double.Parse(words[9], CultureInfo.InvariantCulture));

                            ct.ptList.Add(point);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        WriteErrorLog("Loading Contour file" + e.ToString());

                        var form = new FormTimedMessage(4000, "Contour File is Corrupt", "But Field is Loaded");
                        form.Show();
                    }

                    //calc mins maxes
                    CalculateMinMaxZoom();
                    CalculateTotalCutFillLabels();
                }
            }


            // Flags -------------------------------------------------------------------------------------------------

            //Either exit or update running save
            fileAndDirectory = fieldsDirectory + currentFieldDirectory + "\\Flags.txt";
            if (!File.Exists(fileAndDirectory))
            {
                var form = new FormTimedMessage(4000, "Missing Flags File", "But Field is Loaded");
                form.Show();
            }

            else
            {
                using (StreamReader reader = new StreamReader(fileAndDirectory))
                {
                    try
                    {
                        //read the lines and skip them
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();

                        line = reader.ReadLine();
                        int points = int.Parse(line);

                        if (points > 0)
                        {
                            double lat;
                            double longi;
                            double east;
                            double nort;
                            int color, ID;

                            for (int v = 0; v < points; v++)
                            {

                                line = reader.ReadLine();
                                string[] words = line.Split(',');

                                lat = double.Parse(words[0], CultureInfo.InvariantCulture);
                                longi = double.Parse(words[1], CultureInfo.InvariantCulture);
                                east = double.Parse(words[2], CultureInfo.InvariantCulture);
                                nort = double.Parse(words[3], CultureInfo.InvariantCulture);
                                color = int.Parse(words[4]);
                                ID = int.Parse(words[5]);

                                CFlag flagPt = new CFlag(lat, longi, east, nort, color, ID);
                                flagPts.Add(flagPt);
                            }

                        }
                    }

                    catch (Exception e)
                    {
                        var form = new FormTimedMessage(4000, "Flag File is Corrupt", "But Field is Loaded");
                        form.Show();
                        WriteErrorLog("FieldOpen, Loading Flags, Corrupt Flag File" + e.ToString());
                    }
                }
            }


            // ABLine -------------------------------------------------------------------------------------------------

            //Either exit or update running save
            fileAndDirectory = fieldsDirectory + currentFieldDirectory + "\\ABLine.txt";
            if (!File.Exists(fileAndDirectory))
            {
                var form = new FormTimedMessage(4000, "Missing ABLine File", "But Field is Loaded");
                form.Show();
            }

            else
            {
                using (StreamReader reader = new StreamReader(fileAndDirectory))
                {
                    try
                    {
                        //read the lines and skip them
                        line = reader.ReadLine();
                        line = reader.ReadLine();

                        line = reader.ReadLine();
                        bool isAB = bool.Parse(line);

                        if (isAB)
                        {
                            //set gui image button on
                            btnABLine.Image = global::OpenGrade.Properties.Resources.ABLineOn;

                            //Heading  , ,refPoint2x,z                    
                            line = reader.ReadLine();
                            ABLine.abHeading = double.Parse(line, CultureInfo.InvariantCulture);

                            //refPoint1x,z
                            line = reader.ReadLine();
                            string[] words = line.Split(',');
                            ABLine.refPoint1.easting = double.Parse(words[0], CultureInfo.InvariantCulture);
                            ABLine.refPoint1.northing = double.Parse(words[1], CultureInfo.InvariantCulture);

                            //refPoint2x,z
                            line = reader.ReadLine();
                            words = line.Split(',');
                            ABLine.refPoint2.easting = double.Parse(words[0], CultureInfo.InvariantCulture);
                            ABLine.refPoint2.northing = double.Parse(words[1], CultureInfo.InvariantCulture);

                            //Tramline
                            line = reader.ReadLine();
                            words = line.Split(',');
                            ABLine.tramPassEvery = int.Parse(words[0]);
                            ABLine.passBasedOn = int.Parse(words[1]);

                            ABLine.refABLineP1.easting = ABLine.refPoint1.easting - Math.Sin(ABLine.abHeading) * 10000.0;
                            ABLine.refABLineP1.northing = ABLine.refPoint1.northing - Math.Cos(ABLine.abHeading) * 10000.0;

                            ABLine.refABLineP2.easting = ABLine.refPoint1.easting + Math.Sin(ABLine.abHeading) * 10000.0;
                            ABLine.refABLineP2.northing = ABLine.refPoint1.northing + Math.Cos(ABLine.abHeading) * 10000.0;

                            ABLine.isABLineSet = true;
                        }
                    }

                    catch (Exception e)
                    {
                        var form = new FormTimedMessage(4000, "AB Line File is Corrupt", "But Field is Loaded");
                        form.Show();
                        WriteErrorLog("Load AB Line" + e.ToString());

                    }
                }
            }
        }//end of open file

        public void FileLoadCut(string _openType)
        {
            string fileAndDirectory;
            //get the directory where the fields are stored
            //string directoryName = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)+ "\\fields\\";

            if (_openType == "Resume")
            {
                //Either exit or update running save
                fileAndDirectory = fieldsDirectory + currentFieldDirectory + "\\CutPaths\\Cut_0.txt";
                if (!File.Exists(fileAndDirectory)) return;
            }

            //open file dialog instead
            else
            {
                //create the dialog instance
                OpenFileDialog ofd = new OpenFileDialog();

                //the initial directory, fields, for the open dialog
                ofd.InitialDirectory = fieldsDirectory + currentFieldDirectory + "\\CutPaths\\" ;

                //When leaving dialog put windows back where it was
                ofd.RestoreDirectory = true;

                //set the filter to text files only
                //ofd.Filter = "Cut files (.txt)|.txt";

                //was a file selected
                if (ofd.ShowDialog() == DialogResult.Cancel) return;
                else fileAndDirectory = ofd.FileName;
            }

            

            //Saturday, February 11, 2017  -->  7:26:52 AM
            //$FieldDir
            //Bob_Feb11
            //$Offsets
            //533172,5927719,12 - offset easting, northing, zone
            //$Sections
            //10 - points in this patch
            //10.1728031317344,0.723157039771303 -easting, northing

            //start to read the file
            string line;
            

            // Cut points ----------------------------------------------------------------------------

            //fileAndDirectory = fieldsDirectory + currentFieldDirectory + "\\CurrentCut.txt";
            if (!File.Exists(fileAndDirectory))
            {
                var form = new FormTimedMessage(4000, "Missing Cut File", "But Field is Loaded");
                form.Show();
                //return;
            }   
            else
            {
                ct.ptList.Clear();
                using (StreamReader reader = new StreamReader(fileAndDirectory))
                {
                    try
                    {
                        //read the lines and skip them
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();
                        line = reader.ReadLine();

                        while (!reader.EndOfStream)
                        {
                            //read how many vertices in the following patch
                            line = reader.ReadLine();
                            int verts = int.Parse(line);
                            //CContourPt vecFix = new vec4(0, 0, 0, 0);

                            for (int v = 0; v < verts; v++)
                            {
                                line = reader.ReadLine();
                                string[] words = line.Split(',');

                                CContourPt point = new CContourPt(
                                    double.Parse(words[0], CultureInfo.InvariantCulture),
                                    double.Parse(words[1], CultureInfo.InvariantCulture),
                                    double.Parse(words[2], CultureInfo.InvariantCulture),
                                    double.Parse(words[3], CultureInfo.InvariantCulture),
                                    double.Parse(words[4], CultureInfo.InvariantCulture),
                                    double.Parse(words[5], CultureInfo.InvariantCulture),
                                    double.Parse(words[6], CultureInfo.InvariantCulture),
                                    double.Parse(words[7], CultureInfo.InvariantCulture),
                                    double.Parse(words[8], CultureInfo.InvariantCulture),
                                    double.Parse(words[9], CultureInfo.InvariantCulture));

                                ct.ptList.Add(point);
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        WriteErrorLog("Loading Cut file" + e.ToString());

                        var form = new FormTimedMessage(4000, "Cut File is Corrupt", "But Field is Loaded");
                        form.Show();
                    }

                    //calc mins maxes
                    CalculateMinMaxZoom();
                    CalculateTotalCutFillLabels();
                }
            }

        }

        //creates the field file when starting new field
        public void FileCreateField()
        {
            //Saturday, February 11, 2017  -->  7:26:52 AM
            //$FieldDir
            //Bob_Feb11
            //$Offsets
            //533172,5927719,12 - offset easting, northing, zone
            //$Sections
            //10 - points in this patch
            //10.1728031317344,0.723157039771303 -easting, northing

            if (!isJobStarted)
            {
                using (var form = new FormTimedMessage(3000, "Ooops, Job Not Started", "Start a Job First"))
                { form.Show(); }
                return;
            }
            string myFileName, dirField;

            //get the directory and make sure it exists, create if not
            dirField = fieldsDirectory + currentFieldDirectory + "\\";
            string directoryName = Path.GetDirectoryName(dirField);

            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            myFileName = "Field.txt";

            using (StreamWriter writer = new StreamWriter(dirField + myFileName))
            {
                //Write out the date
                writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));

                writer.WriteLine("$FieldDir");
                writer.WriteLine(currentFieldDirectory.ToString(CultureInfo.InvariantCulture));

                //write out the easting and northing Offsets
                writer.WriteLine("$Offsets");
                writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) + "," + 
                    pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + 
                    pn.zone.ToString(CultureInfo.InvariantCulture));
            }

        }

        //save field Patches
        public void FileSaveField()
        {
            //make sure there is something to save
            if (patchSaveList.Count() > 0)
            {
                //Append the current list to the field file
                using (StreamWriter writer = new StreamWriter((fieldsDirectory + currentFieldDirectory + "\\Field.txt"), true))
                {
                    //for each patch, write out the list of triangles to the file
                    foreach (var triList in patchSaveList)
                    {
                        int count2 = triList.Count();
                        writer.WriteLine(count2.ToString(CultureInfo.InvariantCulture));

                        for (int i = 0; i < count2; i++)
                            writer.WriteLine(triList[i].easting.ToString(CultureInfo.InvariantCulture) +
                                "," + triList[i].northing.ToString(CultureInfo.InvariantCulture));
                    }
                }

                //clear out that patchList and begin adding new ones for next save
                patchSaveList.Clear();
            }
        }

        //Create contour file
        public void FileCreateContour()
        {
            //Saturday, February 11, 2017  -->  7:26:52 AM
            //12  - points in patch
            //64.697,0.168,-21.654,0 - east, heading, north, altitude
            //$ContourDir
            //Bob_Feb11
            //$Offsets
            //533172,5927719,12

            //get the directory and make sure it exists, create if not
            string dirField = fieldsDirectory + currentFieldDirectory + "\\";

            string directoryName = Path.GetDirectoryName(dirField);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            string myFileName = "CurrentCut.txt";
            string myFileName2 = "CurrentCut.csv";

            //write out the file
            using (StreamWriter writer = new StreamWriter(dirField + myFileName))
            {
                //Write out the date
                writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
                writer.WriteLine("Points in Patch followed by easting, heading, northing, altitude");

                //which field directory
                writer.WriteLine("$ContourDir");
                writer.WriteLine(currentFieldDirectory);

                //write out the easting and northing Offsets
                writer.WriteLine("$Offsets");
                writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) + 
                    "," + pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + pn.zone.ToString(CultureInfo.InvariantCulture));
            }
            
            //write out the file in csv format
            using (StreamWriter writer = new StreamWriter(dirField + myFileName2))
            {
                //Write out the date
                writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
                writer.WriteLine("Points in Patch followed by easting, heading, northing, altitude");

                //which field directory
                writer.WriteLine("$ContourDir");
                writer.WriteLine(currentFieldDirectory);

                //write out the easting and northing Offsets
                writer.WriteLine("$Offsets");
                writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) +
                    "," + pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + pn.zone.ToString(CultureInfo.InvariantCulture));
            }
        }

        //save the contour points which include elevation values
        public void FileSaveContour()
        {
            //1  - points in patch
            //64.697,0.168,-21.654,0 - east, heading, north, altitude
            //Saturday, February 11, 2017  -->  7:26:52 AM
            //12  - points in patch
            //64.697,0.168,-21.654,0 - east, heading, north, altitude
            //$ContourDir
            //Bob_Feb11
            //$Offsets
            //533172,5927719,12

            //get the directory and make sure it exists, create if not
            string dirField = fieldsDirectory + currentFieldDirectory + "\\";

            string directoryName = Path.GetDirectoryName(dirField);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            string myFileName = "CurrentCut.txt";
            string myFileName2 = "CurrentCut.csv";

            //write out the file
            using (StreamWriter writer = new StreamWriter(dirField + myFileName))
            {
                //Write out the date
                writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
                writer.WriteLine("Points in Patch followed by easting, heading, northing, altitude");

                //which field directory
                writer.WriteLine("$ContourDir");
                writer.WriteLine(currentFieldDirectory);

                //write out the easting and northing Offsets
                writer.WriteLine("$Offsets");
                writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) +
                    "," + pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + pn.zone.ToString(CultureInfo.InvariantCulture));


                //make sure there is something to save
                if (ct.ptList.Count() > 0)
                {
                    int count2 = ct.ptList.Count;

                    //for every new chunk of patch in the whole section

                    writer.WriteLine(count2.ToString(CultureInfo.InvariantCulture));

                    for (int i = 0; i < count2; i++)
                    {
                        writer.WriteLine(Math.Round((ct.ptList[i].easting), 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].heading, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].northing, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].altitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].latitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].longitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].cutAltitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].lastPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].currentPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].distance, 3).ToString(CultureInfo.InvariantCulture));
                    }
                }
            }

            //write out the csv file
            using (StreamWriter writer = new StreamWriter(dirField + myFileName2))
            {
                //Write out the date
                writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
                writer.WriteLine("Points in Patch followed by easting, heading, northing, altitude");

                //which field directory
                writer.WriteLine("$ContourDir");
                writer.WriteLine(currentFieldDirectory);

                //write out the easting and northing Offsets
                writer.WriteLine("$Offsets");
                writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) +
                    "," + pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + pn.zone.ToString(CultureInfo.InvariantCulture));


                //make sure there is something to save
                if (ct.ptList.Count() > 0)
                {
                    int count2 = ct.ptList.Count;

                    //for every new chunk of patch in the whole section

                    writer.WriteLine(count2.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("easting, heading, northing, altitude, latitude, longitude, cutAltitude, currentPassAltitude, lastPassAltitude, distance");

                    for (int i = 0; i < count2; i++)
                    {
                        writer.WriteLine(Math.Round((ct.ptList[i].easting), 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].heading, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].northing, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].altitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].latitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].longitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].cutAltitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].lastPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].currentPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.ptList[i].distance, 3).ToString(CultureInfo.InvariantCulture));
                    }
                }
            }
            //set saving flag off
            isSavingFile = false;
        }

        public void FileSaveCut()
        {
            //1  - points in patch
            //64.697,0.168,-21.654,0 - east, heading, north, altitude
            //Saturday, February 11, 2017  -->  7:26:52 AM
            //12  - points in patch
            //64.697,0.168,-21.654,0 - east, heading, north, altitude
            //$ContourDir
            //Bob_Feb11
            //$Offsets
            //533172,5927719,12

            //get the directory and make sure it exists, create if not
            string dirCut = fieldsDirectory + currentFieldDirectory + "\\CutPaths\\";
            string csvCut = dirCut + "\\CSV Files\\";
            string kmlCut = dirCut + "\\KML Files\\";
            
            string directoryName = Path.GetDirectoryName(dirCut);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            string directoryName2 = Path.GetDirectoryName(csvCut);
            if ((directoryName2.Length > 0) && (!Directory.Exists(directoryName2)))
            { Directory.CreateDirectory(directoryName2); }

            string directoryName3 = Path.GetDirectoryName(kmlCut);
            if ((directoryName3.Length > 0) && (!Directory.Exists(directoryName3)))
            { Directory.CreateDirectory(directoryName3); }

            using (var form2 = new FormCutDir(this))
            { form2.ShowDialog(); }


            string myFileName = cutName + ".kml";
            string myFileName1 = cutName + ".txt";
            string myFileName2 = cutName + ".csv";

            if (File.Exists(dirCut + myFileName))
            {
                ct.cutNum++;
                myFileName1 = cutName + " " + "(" + ct.cutNum + ")" + ".txt";
                myFileName2 = cutName + " " + "(" + ct.cutNum + ")"+".csv";
                myFileName = cutName + " " + "(" + ct.cutNum + ")" + ".kml";
            }

            //Write Out KML File

            int cnt = ct.ptList.Count;

            using (StreamWriter sw = new StreamWriter(kmlCut + myFileName))
            {
                sw.WriteLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>");
                sw.WriteLine(@"<kml xsi:schemaLocation=""http://earth.google.com/kml/2.1 http://earth.google.com/kml2.1.xsd"" xmlns=""http://earth.google.com/kml/2.1"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">");
                sw.WriteLine(@"  <Placemark>");
                sw.Write(@"    <name>");
                sw.Write(currentFieldDirectory);
                sw.WriteLine(@" </name> ");
                sw.WriteLine(@"    <Style><LineStyle><color>FFFF00FF</color><width>3.0</width></LineStyle></Style>");
                sw.WriteLine(@"    <LineString><extrude>false</extrude><tessellate>true</tessellate><altitudeMode>clampToGround</altitudeMode>");
                sw.WriteLine(@"       <coordinates>");

                if (cnt > 0)
                {
                    for (int i = 0; i < cnt; i++)
                        sw.Write(Convert.ToString(ct.ptList[i].longitude) + ',' + Convert.ToString(ct.ptList[i].latitude) + ",0 ");
                }
                else sw.Write(Convert.ToString(pn.longitude) + ',' + Convert.ToString(pn.latitude) + ",0 ");

                sw.WriteLine(@"       </coordinates>");
                sw.WriteLine(@"    </LineString>");
                sw.WriteLine(@"</Placemark>");
                sw.WriteLine(@"</kml>");
            }

            //write out txt the file
                        
            using (StreamWriter writer = new StreamWriter(dirCut + myFileName1))
            {
                //Write out the date
                writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
                writer.WriteLine("Points in Patch followed by easting, heading, northing, altitude");

                //which field directory
                writer.WriteLine("$ContourDir");
                writer.WriteLine(currentFieldDirectory);

                //write out the easting and northing Offsets
                writer.WriteLine("$Offsets");
                writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) +
                    "," + pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + pn.zone.ToString(CultureInfo.InvariantCulture));


                //make sure there is something to save
                if (ct.cutList.Count() > 0)
                {
                    int count2 = ct.cutList.Count;

                    writer.WriteLine(count2.ToString(CultureInfo.InvariantCulture));

                    
                    for (int i = 0; i < count2; i++)
                    {
                        writer.WriteLine(Math.Round((ct.cutList[i].easting), 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].heading, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].northing, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].altitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].latitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].longitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].cutAltitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].lastPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].currentPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].distance, 3).ToString(CultureInfo.InvariantCulture));
                    }
                    
                }
            }

            //write out the csv file
            using (StreamWriter writer = new StreamWriter(csvCut + myFileName2))
            {
                //Write out the date
                writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));
                writer.WriteLine("Points in Patch followed by easting, heading, northing, altitude");

                //which field directory
                writer.WriteLine("$ContourDir");
                writer.WriteLine(currentFieldDirectory);

                //write out the easting and northing Offsets
                writer.WriteLine("$Offsets");
                writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) +
                    "," + pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + pn.zone.ToString(CultureInfo.InvariantCulture));


                //make sure there is something to save
                if (ct.cutList.Count() > 0)
                {
                    int count2 = ct.cutList.Count;

                    //for every new chunk of patch in the whole section

                    writer.WriteLine(count2.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine("easting, heading, northing, altitude, latitude, longitude, cutAltitude, currentPassAltitude, lastPassAltitude, distance");

                    for (int i = 0; i < count2; i++)
                    {
                        writer.WriteLine(Math.Round((ct.cutList[i].easting), 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].heading, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].northing, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].altitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].latitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].longitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].cutAltitude, 7).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].lastPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].currentPassAltitude, 3).ToString(CultureInfo.InvariantCulture) + "," +
                            Math.Round(ct.cutList[i].distance, 3).ToString(CultureInfo.InvariantCulture));
                    }
                }
            }
            //set saving flag off
            isSavingFile = false;
            
        }

        //save all the flag markers
        public void FileSaveFlags()
        {
            //Saturday, February 11, 2017  -->  7:26:52 AM
            //$FlagsDir
            //Bob_Feb11
            //$Offsets
            //533172,5927719,12 - offset easting, northing, zone

            //get the directory and make sure it exists, create if not
            string dirField = fieldsDirectory + currentFieldDirectory + "\\";

            string directoryName = Path.GetDirectoryName(dirField);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            //use Streamwriter to create and overwrite existing flag file
            using (StreamWriter writer = new StreamWriter(dirField + "Flags.txt"))
            {
                try
                {
                    //Write out the date time
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));

                    //which field directory
                    writer.WriteLine("$FlagsDir");
                    writer.WriteLine(currentFieldDirectory);

                    //write out the easting and northing Offsets
                    writer.WriteLine("$Offsets");
                    writer.WriteLine(pn.utmEast.ToString(CultureInfo.InvariantCulture) + "," +
                                pn.utmNorth.ToString(CultureInfo.InvariantCulture) + "," + pn.zone.ToString(CultureInfo.InvariantCulture));

                    int count2 = flagPts.Count;

                    writer.WriteLine(count2);

                    for (int i = 0; i < count2; i++)
                    {
                        writer.WriteLine(
                            flagPts[i].latitude.ToString(CultureInfo.InvariantCulture) + "," +
                            flagPts[i].longitude.ToString(CultureInfo.InvariantCulture) + "," +
                            flagPts[i].easting.ToString(CultureInfo.InvariantCulture) + "," +
                            flagPts[i].northing.ToString(CultureInfo.InvariantCulture) + "," +
                            flagPts[i].color.ToString(CultureInfo.InvariantCulture) + "," +
                            flagPts[i].ID.ToString(CultureInfo.InvariantCulture));
                    }
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n Cannot write to file.");
                    WriteErrorLog("Saving Flags" + e.ToString());

                    return;
                }

            }
        }

        //save all the flag markers
        public void FileSaveABLine()
        {
            //Saturday, February 11, 2017  -->  7:26:52 AM

            //get the directory and make sure it exists, create if not
            string dirField = fieldsDirectory + currentFieldDirectory + "\\";

            string directoryName = Path.GetDirectoryName(dirField);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            //use Streamwriter to create and overwrite existing ABLine file
            using (StreamWriter writer = new StreamWriter(dirField + "ABLine.txt"))
            {
                try
                {
                    //Write out the date time
                    writer.WriteLine(DateTime.Now.ToString("yyyy-MMMM-dd hh:mm:ss tt", CultureInfo.InvariantCulture));

                    //write out the ABLine
                    writer.WriteLine("$Heading");

                    //true or false if ABLine is set
                    if (ABLine.isABLineSet) writer.WriteLine(true);
                    else writer.WriteLine(false);

                    writer.WriteLine(ABLine.abHeading.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine(ABLine.refPoint1.easting.ToString(CultureInfo.InvariantCulture) + "," + ABLine.refPoint1.northing.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine(ABLine.refPoint2.easting.ToString(CultureInfo.InvariantCulture) + "," + ABLine.refPoint2.northing.ToString(CultureInfo.InvariantCulture));
                    writer.WriteLine(ABLine.tramPassEvery.ToString(CultureInfo.InvariantCulture) + "," + ABLine.passBasedOn.ToString(CultureInfo.InvariantCulture));
                }

                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n Cannot write to file.");
                    WriteErrorLog("Saving AB Line" + e.ToString());

                    return;
                }

            }
        }

        //save nmea sentences
        public void FileSaveNMEA()
        {
            using (StreamWriter writer =  new StreamWriter((fieldsDirectory + currentFieldDirectory + "\\NMEA_log.txt"), true))
            {
                writer.Write(pn.logNMEASentence.ToString());
            }
            pn.logNMEASentence.Clear();
        }

        //generate KML file from flags
        public void FileSaveFlagsKML()
        {

            //get the directory and make sure it exists, create if not
            string dirField = fieldsDirectory + currentFieldDirectory + "\\";

            string directoryName = Path.GetDirectoryName(dirField);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            string myFileName;
            myFileName = "Flags.kml";

            using (StreamWriter writer = new StreamWriter(dirField + myFileName))
            {

                writer.WriteLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>     ");
                writer.WriteLine(@"<kml xmlns=""http://www.opengis.net/kml/2.2""> ");

                int count2 = flagPts.Count;

                writer.WriteLine(@"<Document>");

                for (int i = 0; i < count2; i++)
                {
                    writer.WriteLine(@"  <Placemark>                                  ");
                    writer.WriteLine(@"<Style> <IconStyle>");
                    if (flagPts[i].color == 0)  //red - xbgr
                        writer.WriteLine(@"<color>ff4400ff</color>");
                    if (flagPts[i].color == 1)  //grn - xbgr
                        writer.WriteLine(@"<color>ff44ff00</color>");
                    if (flagPts[i].color == 2)  //yel - xbgr
                        writer.WriteLine(@"<color>ff44ffff</color>");

                    writer.WriteLine(@"</IconStyle> </Style>");
                    writer.WriteLine(@" <name> " + (i + 1) + @"</name>");
                    writer.WriteLine(@"<Point><coordinates> " +
                                    flagPts[i].longitude.ToString(CultureInfo.InvariantCulture) + "," + flagPts[i].latitude.ToString(CultureInfo.InvariantCulture) + ",0" +
                                    @"</coordinates> </Point> ");
                    writer.WriteLine(@"  </Placemark>                                 ");

                }

                writer.WriteLine(@"</Document>");

                writer.WriteLine(@"</kml>                                         ");
            }

        }

        public void FileSaveCutKML()
        {
            //get the directory and make sure it exists, create if not
            string dirCut = fieldsDirectory + currentFieldDirectory + "\\CutPaths\\";
            string kmlCut = dirCut + "\\KML Files\\";

            string directoryName = Path.GetDirectoryName(dirCut);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            string directoryName2 = Path.GetDirectoryName(kmlCut);
            if ((directoryName2.Length > 0) && (!Directory.Exists(directoryName2)))
            { Directory.CreateDirectory(directoryName2); }

            using (var form2 = new FormCutDir(this))
            { form2.ShowDialog(); }


            string myFileName = cutName + ".kml";
           

            if (File.Exists(dirCut + myFileName))
            {
                ct.cutNum++;
                myFileName = cutName + " " + "(" + ct.cutNum + ")" + ".kml";                
            }           

            int cnt = ct.ptList.Count;
            
            using (StreamWriter sw = new StreamWriter(kmlCut + myFileName))
            {
                sw.WriteLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>");
                sw.WriteLine(@"<kml xsi:schemaLocation=""http://earth.google.com/kml/2.1 http://earth.google.com/kml2.1.xsd"" xmlns=""http://earth.google.com/kml/2.1"" xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance"">");
                sw.WriteLine(@"  <Placemark>");
                sw.Write(@"    <name>");
                sw.Write(currentFieldDirectory);
                sw.WriteLine(@" </name> ");
                sw.WriteLine(@"    <Style><LineStyle><color>FFFF00FF</color><width>3.0</width></LineStyle></Style>");
                sw.WriteLine(@"    <LineString><extrude>false</extrude><tessellate>true</tessellate><altitudeMode>clampToGround</altitudeMode>");
                sw.WriteLine(@"       <coordinates>");

                if (cnt > 0)
                {
                    for (int i = 0; i < cnt; i++)
                        sw.Write(Convert.ToString(ct.ptList[i].longitude) + ',' + Convert.ToString(ct.ptList[i].latitude) + ",0 ");
                }
                else sw.Write(Convert.ToString(pn.longitude) + ',' + Convert.ToString(pn.latitude) + ",0 ");

                sw.WriteLine(@"       </coordinates>");
                sw.WriteLine(@"    </LineString>");
                sw.WriteLine(@"</Placemark>");
                sw.WriteLine(@"</kml>");
            }
        }

        //generate KML file from flag
        public void FileSaveSingleFlagKML(int flagNumber)
        {
            //get the directory and make sure it exists, create if not
            string dirField = fieldsDirectory + currentFieldDirectory + "\\";

            string directoryName = Path.GetDirectoryName(dirField);
            if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
            { Directory.CreateDirectory(directoryName); }

            string myFileName;
            myFileName = "Flag.kml";

            using (StreamWriter writer = new StreamWriter(dirField + myFileName))
            {

                writer.WriteLine(@"<?xml version=""1.0"" encoding=""UTF-8""?>     ");
                writer.WriteLine(@"<kml xmlns=""http://www.opengis.net/kml/2.2""> ");

                int count2 = flagPts.Count;

                writer.WriteLine(@"<Document>");

                    writer.WriteLine(@"  <Placemark>                                  ");
                    writer.WriteLine(@"<Style> <IconStyle>");
                    if (flagPts[flagNumber - 1].color == 0)  //red - xbgr
                        writer.WriteLine(@"<color>ff4400ff</color>");
                    if (flagPts[flagNumber - 1].color == 1)  //grn - xbgr
                        writer.WriteLine(@"<color>ff44ff00</color>");
                    if (flagPts[flagNumber - 1].color == 2)  //yel - xbgr
                        writer.WriteLine(@"<color>ff44ffff</color>");
                    writer.WriteLine(@"</IconStyle> </Style>");
                    writer.WriteLine(@" <name> " + flagNumber.ToString(CultureInfo.InvariantCulture) + @"</name>");
                    writer.WriteLine(@"<Point><coordinates> " +
                                    flagPts[flagNumber-1].longitude.ToString(CultureInfo.InvariantCulture) + "," + flagPts[flagNumber-1].latitude.ToString(CultureInfo.InvariantCulture) + ",0" +
                                    @"</coordinates> </Point> ");
                    writer.WriteLine(@"  </Placemark>                                 ");
                writer.WriteLine(@"</Document>");
                writer.WriteLine(@"</kml>                                         ");

            }
        }

    //    //generate KML file from Cuts
    //    public void FileSaveCutKML()
    //    {
    //        //get the directory and make sure it exists, create if not
    //        string dirCut = fieldsDirectory + currentFieldDirectory + "\\CutPaths\\";
    //        string kmlCut = dirCut + "\\KML Files\\";

    //        string directoryName = Path.GetDirectoryName(dirCut);
    //        if ((directoryName.Length > 0) && (!Directory.Exists(directoryName)))
    //        { Directory.CreateDirectory(directoryName); }

    //        string directoryName2 = Path.GetDirectoryName(kmlCut);
    //        if ((directoryName2.Length > 0) && (!Directory.Exists(directoryName2)))
    //        { Directory.CreateDirectory(directoryName2); }

    //        string myFileName = "Cut_" + ct.cutNum + ".kml";

    //        while (File.Exists(kmlCut + myFileName))
    //        {
    //            ct.cutNum++;
    //            myFileName = "Cut_" + ct.cutNum + ".kml";

    //        }

    //        int cutCnt = ct.cutList.Count();
            
    //        XmlTextWriter kml = new XmlTextWriter(kmlCut + myFileName, Encoding.UTF8);

    //        kml.Formatting = Formatting.Indented;
    //        kml.Indentation = 3;

    //        kml.WriteStartDocument();
    //        kml.WriteStartElement("kml", "http://www.opengis.net/kml/2.2");
    //        kml.WriteStartElement("Document");

            
    //        // Each Point
    //        if (cutCnt > 0)
    //        {
    //            kml.WriteStartElement("Folder");
    //            kml.WriteElementString("name", "Swath Pts");
    //            string Balloon = "\r<Style id=\"balloon\">";
    //            Balloon += "\r\t<BalloonStyle>";
    //            Balloon += "\r\t\t<text>";

    //            Balloon += "\r\t\t\t<![CDATA[<b><font size=5>Field:</font><br>" + currentFieldDirectory + "</b><br><hr><table border=\"0\"";
    //            Balloon += "\r\t\t\t\t<tr><td><b>Swath:</b><td><td>$[Numb]</td></tr>";
    //            Balloon += "\r\t\t\t\t<tr><td><b>Point:</b><td><td>$[PtNbr]</td></tr>";
    //            Balloon += "\r\t\t\t\t<tr><td><b>Altitude:</b><td><td>$[alt]</td></tr>";
    //            Balloon += "\r\t\t\t\t<tr><td><b>Cut Altitude:</b><td><td>$[Calt]</td></tr>";
    //            Balloon += "\r\t\t\t\t<tr><td><b>Pass Altitude:</b><td><td>$[Palt]</td></tr>";
    //            Balloon += "\r\t\t\t\t<tr><td><b>Latitude:</b><td><td>$[lat]</td></tr>";
    //            Balloon += "\r\t\t\t\t<tr><td><b>Longitude:</b><td><td>$[lon]</td></tr>";
    //            Balloon += "\r\t\t\t</table>]]>";

    //            Balloon += "\r\t\t</text>";
    //            Balloon += "\r\t</BalloonStyle>";
    //            Balloon += "\r</Style>\r";
    //            kml.WriteRaw(Balloon);

                

    //            for (int i = 0; i < cutCnt; i++)
    //            {
    //                kml.WriteStartElement("Placemark");
    //                kml.WriteElementString("name", "Tree_" + i.ToString());

    //                Balloon = "\r\t\t<styleUrl>#balloon</styleUrl>";
    //                Balloon += "\r\t<ExtendedData>";
    //                //Balloon += "\r\t\t<Data name= \"Numb\">";
    //                //Balloon += "\r\t\t\t<value>" + ct.cutList[i].swathNbr + "</value>";
    //                //Balloon += "\r\t\t</Data>";
    //                Balloon += "\r\t\t<Data name= \"PtNbr\">";
    //                Balloon += "\r\t\t\t<value>" + i + "</value>";
    //                Balloon += "\r\t\t</Data>";
    //                Balloon += "\r\t\t<Data name= \"alt\">";
    //                Balloon += "\r\t\t\t<value>" + ct.cutList[i].altitude + "</value>";
    //                Balloon += "\r\t\t</Data>";
    //                Balloon += "\r\t\t<Data name= \"Calt\">";
    //                Balloon += "\r\t\t\t<value>" + ct.cutList[i].cutAltitude + "</value>";
    //                Balloon += "\r\t\t</Data>";
    //                Balloon += "\r\t\t<Data name= \"Palt\">";
    //                Balloon += "\r\t\t\t<value>" + ct.cutList[i].lastPassAltitude + "</value>";
    //                Balloon += "\r\t\t</Data>";
    //                Balloon += "\r\t\t<Data name= \"lat\">";
    //                Balloon += "\r\t\t\t<value>" + ct.cutList[i].latitude + "</value>";
    //                Balloon += "\r\t\t</Data>";
    //                Balloon += "\r\t\t<Data name= \"lon\">";
    //                Balloon += "\r\t\t\t<value>" + ct.cutList[i].longitude + "</value>";
    //                Balloon += "\r\t\t</Data>";

    //                Balloon += "\r\t</ExtendedData>";
    //                kml.WriteRaw(Balloon);

    //                kml.WriteStartElement("Style");
    //                kml.WriteStartElement("IconStyle");


    //                kml.WriteElementString("color", "ff44ff00");
    //                kml.WriteStartElement("Icon");
    //                kml.WriteElementString("href", "http://maps.google.com/mapfiles/kml/shapes/placemark_circle.png");
    //                kml.WriteEndElement();//Icon
    //                kml.WriteEndElement(); //IconStyle
    //                kml.WriteEndElement(); //Style

    //                //Turn this on to write number of swath for GE
    //                //kml.WriteElementString("name", oldSwathNbr.ToString(CultureInfo.InvariantCulture) + "," + swathPtCnt.ToString(CultureInfo.InvariantCulture));
    //                kml.WriteElementString("name", " ");
    //                kml.WriteStartElement("Point");
    //                kml.WriteElementString("coordinates", ct.cutList[i].longitude.ToString(CultureInfo.InvariantCulture) +
    //                    "," + ct.cutList[i].latitude.ToString(CultureInfo.InvariantCulture) + ",0");
    //                kml.WriteEndElement(); //Point
    //                kml.WriteEndElement(); // <Placemark>
    //            }
    //            kml.WriteEndElement(); // <Folder>   

    //        }
    //        //End of Swath Point

    //        // Swath on the Surface
    //        kml.WriteStartElement("Folder");
    //        kml.WriteElementString("name", "Swath_Path");
    //        kml.WriteElementString("visibility", "0");

    //        string linePts = "";

            

    //        if (cutCnt >= 0)
    //        {


    //            for (int i = 0; i <= cutCnt; i++)
    //            {
    //                linePts = "";
    //                kml.WriteStartElement("Placemark");
    //                kml.WriteElementString("visibility", "0");

    //                kml.WriteElementString("name", "Swath " + i);
    //                kml.WriteStartElement("Style");

    //                kml.WriteStartElement("LineStyle");
    //                kml.WriteElementString("color", "ff6699ff");
    //                kml.WriteElementString("width", "2");
    //                kml.WriteEndElement(); // <LineStyle>
    //                kml.WriteEndElement(); //Style

    //                kml.WriteStartElement("LineString");
    //                kml.WriteElementString("extrude", "1");
    //                kml.WriteElementString("tessellate", "1");
    //                kml.WriteElementString("altitudeMode", "absolute");
    //                kml.WriteStartElement("coordinates");

    //                for (int j = 0; j < ct.cutList.Count; j++)
    //                {                       
    //                    linePts += ct.cutList[j].longitude.ToString("N9", CultureInfo.InvariantCulture) + ',' + ct.cutList[j].latitude.ToString("N9", CultureInfo.InvariantCulture) + ',' + ct.cutList[j].altitude.ToString("N3", CultureInfo.InvariantCulture) + ' ';
    //                    //(utmLon.ToString("N7", CultureInfo.InvariantCulture) + ',' + utmLat.ToString("N7", CultureInfo.InvariantCulture) + ",0 ");
                       
    //                }
    //                kml.WriteRaw(linePts);

    //                kml.WriteEndElement(); // <coordinates>
    //                kml.WriteEndElement(); // <LineString>

    //                kml.WriteEndElement(); // <Placemark>
    //            }
    //        }
    //        kml.WriteEndElement(); // <Folder>



    //        //Swath tool Height
    //        kml.WriteStartElement("Folder");
    //        kml.WriteElementString("name", "Swath_Tool_Height");
    //        kml.WriteElementString("visibility", "0");

    //        //string linePts = "";


    //        if (true)
    //        {

    //            for (int i = 0; i <= cutCnt; i++)
    //            {
    //                linePts = "";
    //                kml.WriteStartElement("Placemark");
    //                kml.WriteElementString("visibility", "0");

    //                kml.WriteElementString("name", "Tool Height " + i);
    //                kml.WriteStartElement("Style");

    //                kml.WriteStartElement("LineStyle");
    //                kml.WriteElementString("color", "ff6699ff");
    //                kml.WriteElementString("width", "2");
    //                kml.WriteEndElement(); // <LineStyle>
    //                kml.WriteEndElement(); //Style

    //                kml.WriteStartElement("LineString");
    //                kml.WriteElementString("extrude", "1");
    //                //kml.WriteElementString("tessellate", "1");
    //                kml.WriteElementString("altitudeMode", "absolute");
    //                kml.WriteStartElement("coordinates");

    //                for (int j = 0; j < cutCnt; j++)
    //                {
                                             
    //                   linePts += ct.cutList[j].longitude.ToString("N9", CultureInfo.InvariantCulture) + ',' + ct.cutList[j].latitude.ToString("N9", CultureInfo.InvariantCulture) + ',' + ct.cutList[j].lastPassAltitude.ToString("N3", CultureInfo.InvariantCulture) + ' ';
    //                   //(utmLon.ToString("N7", CultureInfo.InvariantCulture) + ',' + utmLat.ToString("N7", CultureInfo.InvariantCulture) + ",0 ");
                       
    //                }
    //                kml.WriteRaw(linePts);

    //                kml.WriteEndElement(); // <coordinates>
    //                kml.WriteEndElement(); // <LineString>

    //                kml.WriteEndElement(); // <Placemark>
    //            }
    //        }
    //        kml.WriteEndElement(); // <Folder>             

    //        //end of document
    //        kml.WriteEndElement(); // <Document>
    //        kml.WriteEndElement(); // <kml>

    //        //The end
    //        kml.WriteEndDocument();

    //        kml.Flush();

    //        //Write the XML to file and close the kml
    //        kml.Close();
    //    }
    }
}
