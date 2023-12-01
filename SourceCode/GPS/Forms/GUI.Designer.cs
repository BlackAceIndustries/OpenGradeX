//Please, if you use this, share the improvements

using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Net.Sockets;
using System.Windows.Forms;
using SharpGL;
using OpenGrade.Properties;
using Microsoft.Win32;

namespace OpenGrade
{
    public partial class FormGPS
    {



        private void LoadGUI()
        {
            //set the flag mark button to red dot
            //btnFlag.Image = Properties.Resources.FlagRed;

            //metric settings
            isMetric = Settings.Default.setMenu_isMetric;


            if (isGPSPositionInitialized)
            {   
                PanelDisplays.BackColor = Color.White;

            }
            else
            {

                PanelDisplays.BackColor = Color.OrangeRed;
            }
            
            if (isMetric)
            {               
                
                //btnUnits.Image = Properties.Resources.Metric;
            }
            else
            {
                
                //btnUnits.Image = Properties.Resources.Imperial;
            }

            //load up colors
            redField = (Settings.Default.setF_FieldColorR);
            grnField = (Settings.Default.setF_FieldColorG);
            bluField = (Settings.Default.setF_FieldColorB);



            redSections = Settings.Default.setF_SectionColorR;
            grnSections = Settings.Default.setF_SectionColorG;
            bluSections = Settings.Default.setF_SectionColorB;

            //set up grid and lightbar
            isGridOn = Settings.Default.setMenu_isGridOn;
            //gridToolStripMenuItem.Checked = isGridOn;

            //log NMEA 
            isLogNMEA = Settings.Default.setMenu_isLogNMEA;
            //logNMEAMenuItem.Checked = isLogNMEA;

            isLightbarOn = Settings.Default.setMenu_isLightbarOn;
            //lightbarToolStripMenuItem.Checked = isLightbarOn;

            isPureDisplayOn = Settings.Default.setMenu_isPureOn;
            //pursuitLineToolStripMenuItem.Checked = isPureDisplayOn;

            isSkyOn = Settings.Default.setMenu_isSkyOn;
            //skyToolStripMenu.Checked = isSkyOn;

            isSimOn = Settings.Default.setMenu_isSimulatorOn;

            if (isSimOn)
            {
                panelSimControls.Visible = true;
                timerSim.Enabled = true;
            }
            else
            {
                panelSimControls.Visible = false;
                timerSim.Enabled = false;

            }

            //btnDoneDraw.Enabled = false;
            //btnDeleteLastPoint.Enabled = false;
            //btnStartDraw.Enabled = true;
            //lblBarGraphMax.Text = (barGraphMax/10).ToString();
        }

        //hide the left panel
        public void HideTabControl()
        {
            if (openGLControlBack.Visible)
            {
                openGLControl.Height = this.Height - 100;
                openGLControlBack.Visible = false;
            }
            else
            {
                openGLControl.Height = 200;
                openGLControlBack.Visible = true;
            }
        }

        //// Em-biggen the map
        //public void FullScreenElevation()
        //{

        //    // openGLControlBack  -- Elevation
        //    // openGLControl -- Map

        //    if (openGLControlBack.Height == 289)
        //    {                
        //        openGLControlBack.Height = this.Height;
        //        openGLControlBack.Width = this.Width;                
        //    }
        //    else
        //    {
        //        openGLControlBack.Height = 289;
        //        openGLControlBack.Width = 1218;               
        //    }
        //}

        //Open the dialog of tabbed settings
        private void SettingsPageOpen(int page)
        {
            using (var form = new FormSettings(this, page))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) { }
            }
        }

        // Buttons //-----------------------------------------------------------------------

        //Grade Control Master on or off
        private void btnGradeControl_Click(object sender, EventArgs e)
        {
            if (isGradeControlBtnOn)
            {
                isGradeControlBtnOn = false;
                //btnGradeControl.Image = Properties.Resources.GradeControlOff1;
                mc.GradeControlData[mc.gcisAutoActive] = 0;
                //section[1].TurnMappingOff();
                
            }
            else
            {
                isGradeControlBtnOn = true;
                //btnGradeControl.Image = Properties.Resources.GradeControlOn1;
                mc.GradeControlData[mc.gcisAutoActive] = 1;
                //section[1].TurnMappingOn();

            }

        }
        //ABLine
        private void btnABLine_Click(object sender, EventArgs e)
        {
            //if contour is on, turn it off
            if (ct.isContourBtnOn)
            {
                ct.isContourBtnOn = !ct.isContourBtnOn;
                //btnContour.Image = Properties.Resources.ContourOff;
            }

            using (var form = new FormABLine(this))
            {
                ABLine.isABLineBeingSet = true;
                //txtDistanceOffABLine.Visible = true;
                var result = form.ShowDialog();

                //Comes back

                //if ABLine isn't set, turn off the YouTurn
                if (!ABLine.isABLineSet)
                {
                    ABLine.isABLineBeingSet = false;
                    //txtDistanceOffABLine.Visible = false;
                    //change image to reflect on off
                    //btnABLine.Image = Properties.Resources.ABLineOff;
                    ABLine.isABLineBeingSet = false;

                   // if (isGradeControlBtnOn) btnGradeControl.PerformClick();



                }
                //ab line is made
                else
                {
                    //change image to reflect on off
                    //btnABLine.Image = Properties.Resources.ABLineOn;
                    ABLine.isABLineBeingSet = false;
                }
            }
        }
        //turn on contour guidance or off
        private void btnContour_Click(object sender, EventArgs e)
        {
            ct.isContourBtnOn = !ct.isContourBtnOn;
            //btnContour.Image = ct.isContourBtnOn ? Properties.Resources.ContourOn : Properties.Resources.ContourOff;
        }

        //zoom up close and far away
        private void btnMinMax_Click(object sender, EventArgs e)
        {
            //keep a copy to go back to previous zoom
            if (zoomValue < 56)
            {
                previousZoom = zoomValue;
                zoomValue = 60;
            }
            else
            {
                zoomValue = previousZoom;
            }
            camera.camSetDistance = zoomValue * zoomValue * -1;
            SetZoom();
        }

        //button for Manual On Off of the sections
        private void btnManualOffOn_Click(object sender, EventArgs e)
        {


            switch (manualBtnState)
            {
                case btnStates.Off:
                    manualBtnState = btnStates.Stdby;
                    //btnManualOffOn.Image = null;
                    //btnManualOffOn.Text = "BenchMark";
                    userDistance = 0;

                    //cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    ct.isSurveyOn = true;
                    ct.clearSurveyList = true;
                    ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";

                    break;

                case btnStates.Stdby:
                    manualBtnState = btnStates.RecBnd;
                    //btnManualOffOn.Image = null;
                   // btnManualOffOn.Text = "Recording Boundary";
                    userDistance = 0;
                    //btnStartPause.Visible = true;
                    //btnBoundarySide.Visible = true;
                    ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";


                    // cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    ct.isSurveyOn = true;
                    ct.markBM = true;



                    break;

                case btnStates.RecBnd:
                    manualBtnState = btnStates.Rec;
                   // btnManualOffOn.Image = Properties.Resources.ManualOn;
                    //btnManualOffOn.Text = null;
                    userDistance = 0;
                    //btnBoundarySide.Visible = false;
                    ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";

                    //cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    ct.isSurveyOn = true;
                    ct.recBoundary = false;
                    ct.recSurveyPt = true;


                    break;

                case btnStates.Rec:
                    manualBtnState = btnStates.Off;
                    //btnManualOffOn.Image = Properties.Resources.ManualOff;
                   // btnManualOffOn.Text = null;
                    //CalculateContourPointDistances();
                    //FileSaveContour();
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = true;
                    ct.isSurveyOn = false;
                    //btnStartPause.Visible = false;



                    break;
            }






            //switch (manualBtnState)
            //{
               
            //    case btnStates.Off:
            //        {



            //            var form = new FormSurveyStart(this, 2000, "", "");
            //            form.Show();

            //            if (ct.ptList.Count > 0 && !isCutSaved && btnSaveCut.Enabled == true)
            //            {
            //                DialogResult result3 = MessageBox.Show("Do you wish to start a new survey Line? \nThis will erase Your current cut if it has not been saved \n \n Do you wish to Continue?", "Do you wish to start a new survey Line?",
            //                                     MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

            //                if (result3 == DialogResult.Yes)
            //                {

            //                    btnManualOffOn.Image = Properties.Resources.SurveyStop1;
            //                    userDistance = 0;
            //                    lblCut.Text = "*";
            //                    lblFill.Text = "*";
            //                    lblCutFillRatio.Text = "*";
            //                    lblDrawSlope.Text = "*";

            //                    btnDoneDraw.Enabled = false;
            //                    btnDeleteLastPoint.Enabled = false;
            //                    btnStartDraw.Enabled = false;

            //                }
            //            }



            //            else
            //            {

            //                btnManualOffOn.Image = Properties.Resources.SurveyStop1;
            //                userDistance = 0;
            //                lblCut.Text = "*";
            //                lblFill.Text = "*";
            //                lblCutFillRatio.Text = "*";
            //                lblDrawSlope.Text = "*";

            //                btnDoneDraw.Enabled = false;
            //                btnDeleteLastPoint.Enabled = false;
            //                btnStartDraw.Enabled = false;

            //            }

            //            break;
            //        }



            //    case btnStates.Rec:
            //        {
            //            manualBtnState = btnStates.Off;
            //            btnManualOffOn.Image = Properties.Resources.SurveyStart;                    
            //            CalculateContourPointDistances();                    
            //            FileSaveContour();
            //            btnDoneDraw.Enabled = false;
            //            btnDeleteLastPoint.Enabled = false;
            //            btnStartDraw.Enabled = true;

            //            btnSaveCut.Enabled = true;
            //            isCutSaved = false;

            //            break;

            //        }

            //    case btnStates.Stdby:
            //        manualBtnState = btnStates.RecBnd;
            //        btnManualOffOn.Image = null;
            //        btnManualOffOn.Text = "Recording Boundary";
            //        userDistance = 0;
            //        //btnStartPause.Visible = true;
            //       // btnBoundarySide.Visible = true;
            //        ct.isBtnStartPause = false;
            //        //btnStartPause.Text = "START";


            //        //cboxLastPass.Checked = false;
            //        //cboxRecLastOnOff.Checked = false;
            //        //cboxLaserModeOnOff.Checked = false;
            //        //btnDoneDraw.Enabled = false;
            //        //btnDeleteLastPoint.Enabled = false;
            //        //btnStartDraw.Enabled = false;
            //        ct.isSurveyOn = true;
            //        ct.markBM = true;



            //        break;

            //    case btnStates.RecBnd:
            //        manualBtnState = btnStates.Rec;
            //        btnManualOffOn.Image = Properties.Resources.ManualOn;
            //        btnManualOffOn.Text = null;
            //        userDistance = 0;
            //       // btnBoundarySide.Visible = false;
            //        ct.isBtnStartPause = false;
            //        //btnStartPause.Text = "START";

            //        //cboxLastPass.Checked = false;
            //        //cboxRecLastOnOff.Checked = false;
            //        //cboxLaserModeOnOff.Checked = false;
            //        //btnDoneDraw.Enabled = false;
            //        //btnDeleteLastPoint.Enabled = false;
            //        //btnStartDraw.Enabled = false;
            //        ct.isSurveyOn = true;
            //        ct.recBoundary = false;
            //        ct.recSurveyPt = true;


            //        break;

            //}
        }

        //The main flag marker button 
        private void btnFlag_Click(object sender, EventArgs e)
        {
            int nextflag = flagPts.Count + 1;
            CFlag flagPt = new CFlag(pn.latitude, pn.longitude, pn.easting, pn.northing, flagColor, nextflag);
            flagPts.Add(flagPt);
            FileSaveFlags();
        }

        //The zoom buttons in out
        private void btnZoomIn_MouseDown(object sender, MouseEventArgs e)
        {
            if (zoomValue <= 20) zoomValue += zoomValue * 0.1;
            else zoomValue += zoomValue * 0.05;
            camera.camSetDistance = zoomValue * zoomValue * -1;
            SetZoom();
        }
        private void btnZoomOut_MouseDown(object sender, MouseEventArgs e)
        {
            if (zoomValue <= 20)
            { if ((zoomValue -= zoomValue * 0.1) < 6.0) zoomValue = 6.0; }
            else { if ((zoomValue -= zoomValue * 0.05) < 6.0) zoomValue = 6.0; }

            camera.camSetDistance = zoomValue * zoomValue * -1;
            SetZoom();
        }

        //view tilt up down and saving in settings
        private void btnTiltUp_MouseDown(object sender, MouseEventArgs e)
        {
            camera.camPitch -= ((camera.camPitch * 0.03) - 1);
            if (camera.camPitch > 0) camera.camPitch = 0;
        }
        private void btnTiltDown_MouseDown(object sender, MouseEventArgs e)
        {
            camera.camPitch += ((camera.camPitch * 0.03) - 1);
            if (camera.camPitch < -80) camera.camPitch = -80;
        }

        private void btnSnap_Click(object sender, EventArgs e)
        {
            //ABLine.SnapABLine();
            ct.snapSurvey();
        }

        //panel buttons
        private void btnSettings_Click(object sender, EventArgs e)
        {
            SettingsPageOpen(0);
        }
        private void btnComm_Click(object sender, EventArgs e)
        {
            SettingsCommunications();
        }
        private void btnUDPSettings_Click(object sender, EventArgs e)
        {
            SettingsUDP();
        }
        private void btnUnits_Click(object sender, EventArgs e)
        {
            
            if (!isMetric)
            {
                isMetric = true;
                //lblSpeedUnits.Text = "kmh";
                //lblAltitudeUnits.Text = "M";
               // lblAltitudeUnits2.Text = "M";
                //metricToolStrip.Checked = true;
                //imperialToolStrip.Checked = false;                
                //btnUnits.Image = Properties.Resources.Metric;
                
            }
            else
            {
                isMetric = false;
                //lblSpeedUnits.Text = "mph";
                //lblAltitudeUnits.Text = "FT";
                //lblAltitudeUnits2.Text = "FT";
                //metricToolStrip.Checked = false;
                //imperialToolStrip.Checked = true;
                //btnUnits.Image = Properties.Resources.Imperial;
            }
            Settings.Default.setMenu_isMetric = isMetric;
            Settings.Default.Save();
        }
        private void btnGPSData_Click(object sender, EventArgs e)
        {
            Form form = new FormGPSData(this);
            form.Show();
        }
        private void btnAutoSteerConfig_Click(object sender, EventArgs e)
        {
            
        }
        private void btnFileExplorer_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                FileSaveFlagsKML();
            }
            Process.Start(fieldsDirectory + currentFieldDirectory);
        }

        private void btnClearLastPass_Click(object sender, EventArgs e)
        {
            int cnnt = ct.ptList.Count;
            if (cnnt > 0)
            {
                for (int i = 0; i < cnnt; i++) ct.ptList[i].lastPassAltitude = -1;
            }
            if (cnnt > 0)
            {
                for (int i = 0; i < cnnt; i++) ct.ptList[i].currentPassAltitude = -1;
            }
        }


        private void btnStartDraw_Click(object sender, EventArgs e)
        {   
            
            if (ct.ptList.Count > 5)
            {
                //btnAutoDrain.Visible = true;
                ct.drawList.Clear();
                ct.isDrawingRefLine = true;
                //lblCut.Text = "-";
                //lblFill.Text = "-";
                //lblCutFillRatio.Text = "-";

                //btnDoneDraw.Enabled = true;
                //btnDeleteLastPoint.Enabled = true;
                //btnStartDraw.Enabled = false;
            }
            else TimedMessageBox(1500, "No Surveyed Points", "Survey a Contour First");
            
        }
        private void btnDoneDraw_Click(object sender, EventArgs e)
        {
            //btnSaveCut.Enabled = true;
            //btnAutoDrain.Visible = false;
            //btnDoneDraw.Enabled = false;
            //btnDeleteLastPoint.Enabled = false;
            //btnStartDraw.Enabled = true;

            ct.isDrawingRefLine = false;
            int cnt = ct.ptList.Count;
            int drawPts = ct.drawList.Count - 1;
            double slope = 0.5;

            if (drawPts > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    //points before the drawn line are -1
                    if (i < ct.drawList[0].easting)
                    {
                        ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //points after drawn line are -1
                    if (i > ct.drawList[drawPts].easting)
                    {
                        ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //find out where its between
                    for (int j = 0; j < drawPts; j++)
                    {
                        if (i >= ct.drawList[j].easting && i <= ct.drawList[j + 1].easting)
                        {
                            slope = (ct.drawList[j + 1].northing - ct.drawList[j].northing) / (ct.drawList[j + 1].easting - ct.drawList[j].easting);
                            ct.ptList[i].cutAltitude = ((i - ct.drawList[j].easting) * slope) + ct.drawList[j].northing;
                            break;
                        }
                    }
                }

                //Fill in cut and fill
                CalculateTotalCutFillLabels();
            }

            //CheckMaxCut();
        }


        private void CalculateTotalCutFillLabels()
        {
            //lblDrawSlope.Text = "-";

            double cut = 0; double fill = 0; double delta;
            int cnt = ct.ptList.Count;

            if (cnt > 0)
            {

                for (int i = 0; i < cnt; i++)
                {
                    if (ct.ptList[i].cutAltitude == -1) continue;

                    delta = ct.ptList[i].cutAltitude - ct.ptList[i].altitude;
                    delta *= (ct.ptList[i].distance * vehicle.toolWidth);

                    if (delta > 0)
                    {
                        fill += delta;
                        delta = 0;
                    }
                    else
                    {
                        delta *= -1;
                        cut += delta;
                        delta = 0;
                    }
                }
                if (isMetric)
                {
                    //lblCut.Text = cut.ToString("N2");
                    //lblFill.Text = fill.ToString("N2");
                }
                else
                {
                    //lblCut.Text = (1.308 * cut).ToString("N2");
                    //lblFill.Text = (1.308 * fill).ToString("N2");
                }

                delta = (cut - fill);
                //lblCutFillRatio.Text = delta.ToString("N2");
            }
            else
            {
                //lblCut.Text = "-";
                //lblFill.Text = "-";
                //lblCutFillRatio.Text = "-";
            }
        }
        private void btnDeleteLastPoint_Click(object sender, EventArgs e)
        {
            int ptCnt = ct.drawList.Count;
            if (ptCnt > 0) ct.drawList.RemoveAt(ptCnt - 1);
        }

        //progress bar "buttons" for gain
        private void pbarCutAbove_Click(object sender, EventArgs e)
        {
            barGraphMax += 10;
            //lblBarGraphMax.Text = (barGraphMax/10).ToString();

        }

        private void pbarCutBelow_Click(object sender, EventArgs e)
        {
            if ((barGraphMax -= 10) < 10) barGraphMax = 10;
            //lblBarGraphMax.Text = ( barGraphMax /10).ToString();
        }

        private void pbarDeltaR_Click(object sender, EventArgs e)
        {
            barGraphMax += 10;
            //lblBarGraphMax.Text = (barGraphMax/10).ToString();

        }

        private void pbarCutBelowL_Click(object sender, EventArgs e)
        {
            if ((barGraphMax -= 10) < 10) barGraphMax = 10;
            //lblBarGraphMax.Text = ( barGraphMax /10).ToString();
        }


        // Menu Items ------------------------------------------------------------------

        //File drop down items
        private void loadVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                var form = new FormTimedMessage(2000, gStr.gsFieldIsOpen, gStr.gsCloseFieldFirst);
                form.Show();
                return;
            }
            FileOpenVehicle();
        }
        private void saveVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileSaveVehicle();
        }
        private void fieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JobNewOpenResume();
        }
        private void setWorkingDirectoryToolStripMenuItem_Click(object sender, EventArgs e)
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

        //Help menu drop down items
        private void aboutToolStripMenuHelpAbout_Click(object sender, EventArgs e)
        {
            using (var form = new Form_About())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK) { }
            }
        }
        private void helpToolStripMenuHelpHelp_Click(object sender, EventArgs e)
        {
            //string appPath = Assembly.GetEntryAssembly().Location;
            //string filename = Path.Combine(Path.GetDirectoryName(appPath), "help.htm");
            //Process.Start("http://OpenGrade.gh-ortner.com/doku.php");
        }

        //Options Drop down menu items
        private void resetALLToolStripMenuItem_Click(object sender, EventArgs e)
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
                    Application.Exit();
                }
            }
        }
        private void logNMEAMenuItem_Click(object sender, EventArgs e)
        {
            isLogNMEA = !isLogNMEA;
            //logNMEAMenuItem.Checked = isLogNMEA;
            Settings.Default.setMenu_isLogNMEA = isLogNMEA;
            Settings.Default.Save();
        }
        private void lightbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isLightbarOn = !isLightbarOn;
            //lightbarToolStripMenuItem.Checked = isLightbarOn;
            Settings.Default.setMenu_isLightbarOn = isLightbarOn;
            Settings.Default.Save();
        }
        private void polygonsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isDrawPolygons = !isDrawPolygons;
            //polygonsToolStripMenuItem.Checked = !polygonsToolStripMenuItem.Checked;
        }
        private void gridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isGridOn = !isGridOn;
            //gridToolStripMenuItem.Checked = isGridOn;
            Settings.Default.setMenu_isGridOn = isGridOn;
            Settings.Default.Save();
        }
        private void pursuitLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isPureDisplayOn = !isPureDisplayOn;
            //pursuitLineToolStripMenuItem.Checked = isPureDisplayOn;
            Settings.Default.setMenu_isPureOn = isPureDisplayOn;
            Settings.Default.Save();
        }
        private void metricToolStrip_Click(object sender, EventArgs e)
        {
            //metricToolStrip.Checked = true;
            //imperialToolStrip.Checked = false;
            //isMetric = true;
            Settings.Default.setMenu_isMetric = isMetric;
            Settings.Default.Save();
            //lblSpeedUnits.Text = "kmh";
        }
        private void skyToolStripMenu_Click(object sender, EventArgs e)
        {
            isSkyOn = !isSkyOn;
            //skyToolStripMenu.Checked = isSkyOn;
            Settings.Default.setMenu_isSkyOn = isSkyOn;
            Settings.Default.Save();
        }
        private void imperialToolStrip_Click(object sender, EventArgs e)
        {
            //metricToolStrip.Checked = false;
            //imperialToolStrip.Checked = true;
            isMetric = false;
            Settings.Default.setMenu_isMetric = isMetric;
            Settings.Default.Save();
            //lblSpeedUnits.Text = "mph";

        }
        private void simulatorOnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (simulatorOnToolStripMenuItem.Checked)
            //{
            //    panelSimControls.Visible = true;
            //    nudElevation.Visible = true;
            //    timerSim.Enabled = true;
            //}
            //else
            //{
            //    panelSimControls.Visible = false;
            //    nudElevation.Visible = false;
            //    timerSim.Enabled = false;
            //}

            //Settings.Default.setMenu_isSimulatorOn = simulatorOnToolStripMenuItem.Checked;
            //Settings.Default.Save();
        }

        //setting color off Options Menu
        private void sectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //color picker for sections
            ColorDialog colorDlg = new ColorDialog
            {
                FullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                Color = Color.FromArgb(255, redSections, grnSections, bluSections)
            };

            if (colorDlg.ShowDialog() != DialogResult.OK) return;

            redSections = colorDlg.Color.R;
            if (redSections > 253) redSections = 253;
            grnSections = colorDlg.Color.G;
            if (grnSections > 253) grnSections = 253;
            bluSections = colorDlg.Color.B;
            if (bluSections > 253) bluSections = 253;

            Settings.Default.setF_SectionColorR = redSections;
            Settings.Default.setF_SectionColorG = grnSections;
            Settings.Default.setF_SectionColorB = bluSections;
            Settings.Default.Save();
        }
        private void fieldToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //color picker for fields

            ColorDialog colorDlg = new ColorDialog
            {
                FullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                Color = Color.FromArgb(255, Settings.Default.setF_FieldColorR,
                Settings.Default.setF_FieldColorG, Settings.Default.setF_FieldColorB)
            };

            if (colorDlg.ShowDialog() != DialogResult.OK) return;

            redField = colorDlg.Color.R;
            if (redField > 253) redField = 253;
            grnField = colorDlg.Color.G;
            if (grnField > 253) grnField = 253;
            bluField = colorDlg.Color.B;
            if (bluField > 253) bluField = 253;

            Settings.Default.setF_FieldColorR = redField;
            Settings.Default.setF_FieldColorG = grnField;
            Settings.Default.setF_FieldColorB = bluField;
            Settings.Default.Save();
        }

        //Tools drop down items
        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                FileSaveFlagsKML();
            }
            Process.Start(fieldsDirectory + currentFieldDirectory);
        }
        private void webCamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form form = new FormWebCam();
            form.Show();
        }
        private void googleEarthToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void btnGoogleEarth_Click(object sender, EventArgs e)
        {
            if (mc.isImuCorrection)
            {
                mc.isImuCorrection = false;
                //btnTogggleImu.BackColor = Color.Tomato;
            }
            else
            {
                mc.isImuCorrection = true;
                //btnTogggleImu.BackColor = Color.Lime;
            }
        }

        private void fieldViewerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //in the current application directory
            //string AOGViewer = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + "\\AOG.exe";
            //Process.Start(AOGViewer);
            {
                var form = new FormTimedMessage(2000, "Not yet Implemented", "But soon....");
                form.Show();
            }
        }
        private void gPSDataToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form form = new FormGPSData(this);
            form.Show();
        }

        //The flag context menus
        private void toolStripMenuItemFlagRed_Click(object sender, EventArgs e)
        {
            flagColor = 0;
            //btnFlag.Image = Properties.Resources.FlagRed;
        }
        private void toolStripMenuGrn_Click(object sender, EventArgs e)
        {
            flagColor = 1;
            //btnFlag.Image = Properties.Resources.FlagGrn;
        }
        private void toolStripMenuYel_Click(object sender, EventArgs e)
        {
            flagColor = 2;
            //btnFlag.Image = Properties.Resources.FlagYel;
        }
        private void toolStripMenuFlagDelete_Click(object sender, EventArgs e)
        {
            //delete selected flag and set selected to none
            DeleteSelectedFlag();
            FileSaveFlags();
        }
        private void toolStripMenuFlagDeleteAll_Click(object sender, EventArgs e)
        {
            flagNumberPicked = 0;
            flagPts.Clear();
            FileSaveFlags();
        }
        private void contextMenuStripFlag_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            toolStripMenuFlagDelete.Enabled = flagNumberPicked != 0;

            toolStripMenuFlagDeleteAll.Enabled = flagPts.Count > 0;
        }

        //OpenGL Window context Menu and functions
        private void deleteFlagToolOpenGLContextMenu_Click(object sender, EventArgs e)
        {
            //delete selected flag and set selected to none
            DeleteSelectedFlag();
        }
        private void contextMenuStripOpenGL_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            //dont bring up menu if no flag selected
            if (flagNumberPicked == 0) e.Cancel = true;
        }
        private void googleEarthOpenGLContextMenu_Click(object sender, EventArgs e)
        {
            if (isJobStarted)
            {
                //save new copy of kml with selected flag and view in GoogleEarth
                FileSaveSingleFlagKML(flagNumberPicked);

                //Process.Start(@"C:\Program Files (x86)\Google\Google Earth\client\googleearth", workingDirectory + currentFieldDirectory + "\\Flags.KML");
                Process.Start(fieldsDirectory + currentFieldDirectory + "\\Flag.KML");
            }
        }

        //function mouse down in window for picking
        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //0 at bottom for opengl, 0 at top for windows, so invert Y value
                Point point = openGLControl.PointToClient(Cursor.Position);
                mouseX = point.X;
                mouseY = openGLControl.Height - point.Y;
                leftMouseDownOnOpenGL = true;
            }
        }

        //taskbar buttons
        private void toolstripAutoSteerConfig_Click(object sender, EventArgs e)
        {
           
        }
        private void toolstripVehicleConfig_Click(object sender, EventArgs e)
        {
            SettingsPageOpen(0);
            CalculateTotalCutFillLabels();
        }
        private void toolstripUSBPortsConfig_Click(object sender, EventArgs e)
        {
            SettingsCommunications();
        }
        private void toolstripUDPConfig_Click(object sender, EventArgs e)
        {
            SettingsUDP();
        }
        private void toolstripResetTrip_Click(object sender, EventArgs e)
        {
            userDistance = 0;
        }
        private void toolstripField_Click(object sender, EventArgs e)
        {
            JobNewOpenResume();
        }

        //batman to maximize GPS mapping - hide tab control
        private void btnHideTabs_Click(object sender, EventArgs e)
        {
            //HideTabControl();
        }

        //Sim controls
        private void timerSim_Tick(object sender, EventArgs e)
        {
            //if a GPS is connected disable sim
            if (antennaModuleTimeout > 10 )  // Need to change this
            {
                if (isGradeControlBtnOn) sim.DoSimTick(guidanceLineSteerAngle / 10.0, cutDelta);
                else sim.DoSimTick(sim.steerAngleScrollBar, cutDelta);//
            }
            else
            {
                //simulatorOnToolStripMenuItem.Checked = false;
                panelSimControls.Visible = false;
                timerSim.Enabled = false;
                timerSim.Enabled = false;

            }
        }
        private void tbarStepDistance_Scroll(object sender, EventArgs e)
        {
            sim.stepDistance = ((double)(tbarStepDistance.Value)) / 10.0 / (double)fixUpdateHz;
        }
        private void tbarSteerAngle_Scroll(object sender, EventArgs e)
        {
            sim.steerAngleScrollBar = (tbarSteerAngle.Value) * 0.1;
            lblSteerAngle.Text = sim.steerAngleScrollBar.ToString("N1");
        }
        private void btnResetSteerAngle_Click(object sender, EventArgs e)
        {
            sim.steerAngleScrollBar = 0;
            tbarSteerAngle.Value = 0;
            lblSteerAngle.Text = sim.steerAngleScrollBar.ToString("N1");
        }
        private void btnResetSim_Click(object sender, EventArgs e)
        {
            sim.ResetSim();
        }

        //simulator altitude
        private void nudElevation_ValueChanged(object sender, EventArgs e)
        {
            sim.altitude = (double)nudElevation.Value + Properties.Vehicle.Default.setVehicle_antennaHeight;
        }

        #region Properties // ---------------------------------------------------------------------

        public string Zone { get { return Convert.ToString(pn.zone); } }
        public string FixNorthing { get { return Convert.ToString(Math.Round(pn.northing + pn.utmNorth, 2)); } }
        public string FixEasting { get { return Convert.ToString(Math.Round(pn.easting + pn.utmEast, 2)); } }
        public string Latitude { get { return Convert.ToString(Math.Round(pn.latitude, 7)); } }
        public string Longitude { get { return Convert.ToString(Math.Round(pn.longitude, 7)); } }

        public string SatsTracked { get { return Convert.ToString(pn.satellitesTracked); } }
        public string HDOP { get { return Convert.ToString(pn.hdop); } }
        public string NMEAHz { get { return Convert.ToString(fixUpdateHz); } }
        public string PassNumber { get { return Convert.ToString(ABLine.passNumber); } }
        public string Heading { get { return Convert.ToString(Math.Round(glm.toDegrees(fixHeading), 1)) + "\u00B0"; } }
        public string GPSHeading { get { return (Math.Round(glm.toDegrees(gpsHeading), 1)) + "\u00B0"; } }
        public string Status { get { if (pn.status == "A") return "Active"; else return "Void"; } }
        public string FixQuality
        {
            get
            {
                if (pn.fixQuality == 0) return "Invalid";
                else if (pn.fixQuality == 1) return "GPS fix";
                else if (pn.fixQuality == 2) return "DGPS fix";
                else if (pn.fixQuality == 3) return "PPS fix";
                else if (pn.fixQuality == 4) return "RTK fix";
                else if (pn.fixQuality == 5) return "Flt RTK";
                else if (pn.fixQuality == 6) return "Estimate";
                else if (pn.fixQuality == 7) return "Man IP";
                else if (pn.fixQuality == 8) return "Sim";
                else return "Unknown";
            }
        }

        public string LastFixQuality
        {
            get
            {
                if (pn.fixQuality == 0) return "Invalid";
                else if (pn.fixQuality == 1) return "GPS fix";
                else if (pn.fixQuality == 2) return "DGPS fix";
                else if (pn.fixQuality == 3) return "PPS fix";
                else if (pn.fixQuality == 4) return "RTK fix";
                else if (pn.fixQuality == 5) return "Flt RTK";
                else if (pn.fixQuality == 6) return "Estimate";
                else if (pn.fixQuality == 7) return "Man IP";
                else if (pn.fixQuality == 8) return "Sim";
                else return "Unknown";
            }
        }

        public string GyroInDegrees
        {
            get
            {
                if (mc.headingIMU != 9999)
                    return Math.Abs(Math.Round(mc.headingIMU, 1)) + "\u00B0";
                else return "-";
            }
        }
        public string RollInDegrees
        {
            get
            {
                if (mc.rollIMU != 9999)
                    return Math.Round(mc.rollIMU, 1) + "\u00B0";
                else return "-";
            }
        }
        public string PitchInDegrees
        {
            get
            {
                if (mc.pitchIMU != 9999)
                    return Math.Round(mc.pitchIMU, 1) + "\u00B0";
                else return "-";
            }
        }

        public string PureSteerAngle { get { return ((double)(guidanceLineSteerAngle) * 0.1) + "\u00B0"; } }

        public string FixHeading { get { return Math.Round(fixHeading, 4).ToString(); } }

        public string StepFixNum { get { return (currentStepFix).ToString(); } }
        public string CurrentStepDistance { get { return Math.Round(distanceCurrentStepFix, 3).ToString(); } }
        public string TotalStepDistance { get { return Math.Round(fixStepDist, 3).ToString(); } }

        public string WorkSwitchValue { get { return mc.workSwitchValue.ToString(); } }
        public string AgeDiff { get { return pn.ageDiff.ToString(); } }

        //Metric and Imperial Properties
        public string SpeedMPH
        {
            get
            {
                double spd = 0;
                for (int c = 0; c < 10; c++) spd += avgSpeed[c];
                spd *= 0.0621371;
                return Convert.ToString(Math.Round(spd, 1));
            }
        }
        public string SpeedKPH
        {
            get
            {
                double spd = 0;
                for (int c = 0; c < 8; c++) spd += avgSpeed[c];
                spd *= 0.1;
                return Convert.ToString(Math.Round(spd, 1));
            }
        }

        public string Altitude { get { return Convert.ToString(Math.Round(pn.altitude, 3)); } }
        public string AltitudeFeet { get { return Convert.ToString((Math.Round((pn.altitude * 3.28084), 3))); } }

        public Texture ParticleTexture { get; set; }

        #endregion properties 

        private void DoNTRIPSecondRoutine()
        {
            //count up the ntrip clock only if everything is alive
            if (startCounter > 50 && recvCounter < 20 && isNTRIP_RequiredOn)
            {
                IncrementNTRIPWatchDog();
            }

            isNTRIP_RequiredOn = Properties.Settings.Default.setNTRIP_isOn;             
            

            //check if we have a connection if not try and start NTRIP
            if (isNTRIP_RequiredOn && !isNTRIP_Connected && !isNTRIP_Connecting)
            {
                if (!isNTRIP_Starting && ntripCounter > 20 && reconnectCounter < 100)
                {
                    StartNTRIP();
                }
            }

            // if currently connecting
            if (isNTRIP_Connecting)
            {
                if (ntripCounter > 50)
                {
                    TimedMessageBox(2000, "nTrip timeout", "nTrip timeout");
                    ReconnectRequest();
                }
                if (clientSocket != null && clientSocket.Connected)
                {
                    //TimedMessageBox(2000, "NTRIP Not Connected", " At the StartNTRIP() ");
                    //ReconnectRequest();
                    //return;                    
                    SendAuthorization();
                }

               
                NTRIP_LED.BackColor = Color.Orange;
            }

            if (isNTRIP_RequiredOn){
                NTRIP_LED.Value = 100;
                //watchdog for Ntrip
                if (isNTRIP_Connecting) NTRIP_LED.BackColor = Color.Purple;
                
                if (NTRIP_Watchdog > 20) NTRIP_LED.BackColor = Color.Yellow;

                if (isNTRIP_Connected) NTRIP_LED.BackColor = Color.Lime;
               
                if (!isNTRIP_Connected && !isNTRIP_Connecting) NTRIP_LED.BackColor = Color.Black;
                
                if (sendGGAInterval > 0 && isNTRIP_Sending) isNTRIP_Sending = false;

            }
            else NTRIP_LED.BackColor = Color.Black;
            
        }

        //Timer triggers at 20 msec, 50 hz, and is THE clock of the whole program//
        private void tmrWatchdog_tick(object sender, EventArgs e)
        {
            //go see if data ready for draw and position updates
            //tmrWatchdog.Enabled = false;
            ScanForNMEA();
            
            statusUpdateCounter++;            
            antennaModuleTimeout++;
            gradeControlTimeout++;               
            
            if (fiveSecondCounter++ > 30)
            {
                //do all the NTRIP routines
                //if (isNTRIPOn)
                //{
                DoNTRIPSecondRoutine(); // Only when gps port is open
                //}
                SendUDPMessage(FormGPS.SYSTEM_HEADER, epGradeControl);
                SendUDPMessage(FormGPS.SYSTEM_HEADER, epAntennaModule);
                fiveSecondCounter = 0;

            }

            


            if (antennaModuleTimeout > 50) {
                ANTENNA1_LED.Value = 0;
                ANTENNA1_LED.BackColor = Color.Black;                
            }
            else
            {
                ANTENNA1_LED.Value = 100;
                ANTENNA1_LED.BackColor = Color.Lime;

            }
            if (gradeControlTimeout > 50) {
                GRADECONTROL_LED.BackColor = Color.Black;
                GRADECONTROL_LED.Value= 0;

                voltageBar.BarColorSolid = Color.Red;
                voltageBar2.BarColorSolid = Color.Red;
                voltageBar.Value = 0;
                voltageBar2.Value = 0;
            }
            else
            {
                GRADECONTROL_LED.BackColor = Color.Lime;
                GRADECONTROL_LED.Value = 100;
                voltageBar.BarColorSolid = Color.White;
                voltageBar2.BarColorSolid = Color.White;
            }


            //every half of a second update all status
            if (statusUpdateCounter > 2)
            {
                //reset the counter
                statusUpdateCounter = 0;

                //counter used for saving field in background
                saveCounter++;

                if (pn.fixQuality != 4 && pn.lastFixQuality == 4 && isGradeControlBtnOn)
                {
                    //btnGradeControl.PerformClick();
                    btnVertAuto.PerformClick();
                    btnTiltAuto.PerformClick();
                }


                if (pn.ageDiff > 10)
                {
                    lblRTKPopup.Visible = true;
                    lblRTKPopupTime.Visible = true;
                    lblRTKPopupTime.Text = AgeDiff;
                }
                else
                {
                    lblRTKPopup.Visible = false;
                    lblRTKPopupTime.Visible = false;

                }

                if (FixQuality == "RTK fix")
                {

                    RTK_LED.Value = 100;
                    RTK_LED.BackColor = Color.LimeGreen;
                    PanelDisplays.BackColor = Color.Green;

                }
                else if (FixQuality == "Flt RTK")
                {

                    //RTK_LED.Value = 100;
                    //RTK_LED.BackColor = Color.Yellow;
                    PanelDisplays.BackColor = Color.DarkGray;
                }
                else if (FixQuality == "PPS fix")
                {
                    //RTK_LED.Value = 100;
                    //RTK_LED.BackColor = Color.Purple;                    
                    PanelDisplays.BackColor = Color.DarkGray;
                }
                else
                {
                    RTK_LED.Value = 0;
                    RTK_LED.BackColor = Color.Black;
                }


                if (FixQuality == "RTK fix" || FixQuality == "Flt RTK")
                {
                    if (!isNTRIP_Connected)
                    {
                        RADIO_LED.Value = 100;
                        RADIO_LED.BackColor = Color.Lime;
                    }

                }
                else
                {
                    RADIO_LED.Value = 0;                        
                    RADIO_LED.BackColor = Color.Lime;
                }



                if (ct.surveyMode == false)
                {

                    SURVEY_LED.Value = 100;
                    SURVEY_LED.BackColor= Color.CornflowerBlue;
                    

                }
                else
                {
                    SURVEY_LED.Value = 0;

                }



                if (curMode == gradeMode.surface)
                {
                    lblMode.Text = "SURFACE";

                }
                else if (curMode == gradeMode.ditch)
                {
                    lblMode.Text = "DITCH";
                }
                else if (curMode == gradeMode.tile)
                {
                    lblMode.Text = "TILE";
                }
                else if (curMode == gradeMode.contour)
                {
                    lblMode.Text = "CONTOUR";
                }



                tStripCurrentJob.Text = "BlackAce : " + curFieldName + " : " + cutName;



                //lblFarm.Text = "Westhill";
                //lblField.Text = curFieldName;
                //lblTask.Text = cutName;



                //lblSpeed.Text = pn.speed.ToString();
                //lblRoll.Text = mc.rollIMU.ToString();
                //lblPitch.Text = mc.pitchIMU.ToString();

                tStripSpeed.Text = pn.speed.ToString();
                tStripRoll.Text = mc.avgrollIMU.ToString("F2");
                tStripPitch.Text = mc.avgpitchIMU.ToString("F2");
                tStripAltitude.Text = pn.altitude.ToString("F3");
                tStripHeading.Text =pn.hdop.ToString("F2");
                //tStripVDOP.Text = pn








                //if (FixQuality == "RTK fix" || FixQuality == "Flt RTK")
                //{
                //    if (!isNTRIP_Connected)
                //    {

                //        ledRadio.BackColor = Color.Lime;
                //    }


                //}               
                //else ledRadio.BackColor = Color.Black;


                //lblSats.Text = SatsTracked;
                //lblRoll.Text = RollInDegrees;
                //lblGyroHeading.Text = GyroInDegrees;
                //lblPitch.Text = PitchInDegrees;
                //lblGPSHeading.Text = GPSHeading;                     

                //up in the menu a few pieces of info
                if (isJobStarted)
                {
                    //lblEasting.Text = "E: " + Math.Round(pn.easting, 1).ToString();
                    //lblNorthing.Text = "N: " + Math.Round(pn.northing, 1).ToString();
                }
                else
                {
                    //lblEasting.Text = "E: " + ((int)pn.actualEasting).ToString();
                    //lblNorthing.Text = "N: " + ((int)pn.actualNorthing).ToString();
                }

                //lblZone.Text = pn.zone.ToString();
                //tboxSentence.Text = pn.rawBuffer;
                
                // }

                //the main formgps window
                if (isMetric)  //metric or imperial
                {
                    //Hectares on the master section soft control and sections
                    //lblSpeed.Text = SpeedKPH;

                    //status strip values
                   // stripDistance.Text = Convert.ToString((UInt16)(userDistance)) + " m";
                    //lblAltitude.Text = Altitude;
                    //lblAltitude2.Text = Altitude;
                    //btnZeroAltitude.Text = (pn.altitude - ct.zeroAltitude).ToString("N2");
                }
                else  //Imperial Measurements
                {
                    //acres on the master section soft control and sections
                    //lblSpeed.Text = SpeedMPH;

                    //status strip values
                    //stripDistance.Text = Convert.ToString((UInt16)(userDistance * 3.28084)) + " ft";
                    //lblAltitude.Text = AltitudeFeet;
                    //lblAltitude2.Text = AltitudeFeet;
                    //btnZeroAltitude.Text = ((pn.altitude - ct.zeroAltitude) * glm.m2ft).ToString("N2");
                }

                //not Metric/Standard units sensitive
                //lblHeading.Text = Heading;
                //btnABLine.Text = PassNumber;
                //sqrCutLine.Text = PureSteerAngle;

               
                voltageBar.Value = ((int)(mc.voltage * 100) +12) ;
                voltageBar2.Value = ((int)(mc.voltage2 * 100) +12);

                //
                // Update all DRO's
                //

                //Check distFromLastPass and Set DRO's
                if (distFromLastPass == 9999 || distFromLastPass > 2000)//
                {
                    //lblCurrentCutDepth.Text = "--";
                    //lblCurrentCutDepth.BackColor = Color.Black;
                    isAutoCutOn = false;
                    //btnAutoCut.Enabled = false;

                }
                else
                {
                    //btnAutoCut.Enabled = true;

                    if (isMetric)  //metric or imperial
                    {
                        //lblCurrentCutDepth.Text = distFromLastPass.ToString("N1");                        
                    }
                    else{
                        //lblCurrentCutDepth.Text = (0.3937 * distFromLastPass).ToString("N2");                            
                    }

                    if (distFromLastPass < 0)
                    {
                        //lblCurrentCutDepth.BackColor = Color.Tomato;
                    }
                    else
                    {                        
                        //lblCurrentCutDepth.BackColor = Color.Lime;
                    }
                }

                //Check distoTaget and Set DRO's
                if (distToTarget == 9999)
                {
                    //lblDistToTarget.Text = "--";
                    //lblDistToTarget.BackColor = Color.Black;

                }
                else
                {
                    if (isMetric)  //metric or imperial
                    {
                       // lblDistToTarget.Text = distToTarget.ToString("N1");
                    }
                    else
                    {
                       // lblDistToTarget.Text = (0.3937 * distToTarget).ToString("N2");
                    }

                    if (distToTarget < 0)
                    {
                       // lblDistToTarget.BackColor = Color.Tomato;
                    }
                    else
                    {
                       // lblDistToTarget.BackColor = Color.Lime;
                    }
                
                }  


                if (isMetric)  //metric or imperial
                {

                    if (cutDelta > 0)
                    {
                        // Black Ace Industries
                        //lblCutDelta.Text = distFromLastPass.ToString("N1");

                        tStripCenterDelta.Text = distFromLastPass.ToString("N1");


                        //lblCutDelta2.Text = distFromLastPass.ToString("N1");
                        mc.GradeControlData[mc.gcDeltaDir] = 1;

                    }
                    else
                    {
                        // Black Ace Industries                           
                       // lblCutDelta.Text = cutDelta.ToString("N1");
                        tStripCenterDelta.Text = cutDelta.ToString("N1");
                        //lblCutDelta2.Text = cutDelta.ToString("N1");
                        mc.GradeControlData[mc.gcDeltaDir] = 0;

                    }

                }
                else
                {
                    if (cutDelta > 0)
                    {
                        mc.GradeControlData[mc.gcCutDelta] = (byte)cutDelta;
                       // lblCutDelta.Text = (0.3937 * cutDelta).ToString("N2");
                        tStripCenterDelta.Text = (0.3937 * cutDelta).ToString("N2");
                        mc.GradeControlData[mc.gcDeltaDir] = 1;
                    }
                    else
                    {
                        //lblCutDelta.Text = (0.3937 * cutDelta).ToString("N2");
                        tStripCenterDelta.Text = (0.3937 * cutDelta).ToString("N2");
                        mc.GradeControlData[mc.gcDeltaDir] = 0;
                    }
                }

                if (cutDelta == 9999)
                {
                   // lblCutDelta.Text = "--";
                    tStripCenterDelta.Text = "--";
                    tStripRightDelta.Text = "--";
                    tStripLeftDelta.Text = "--";

                    //lblCutDelta.BackColor = Color.Black;
                    //tStripBladeCenterCutDelta.BackColor = Color.Black;
                    pbarCutAboveL.Value = 0;
                    pbarCutBelowL.Value = 0;

                    pbarCutAboveR.Value = 0;
                    pbarCutBelowR.Value = 0;
                    mc.GradeControlData[mc.gcDeltaDir] = 3;
                }
                else
                {
                    if (isMetric)  //metric or imperial
                    {
                        int cut = Math.Abs((int)cutDelta);
                        if (cut > 255) cut = 255;
                        byte cut1 = (byte)cut;                        

                        mc.GradeControlData[mc.gcCutDelta] = cut1;
                       

                        if (cutDelta > 0)
                        {
                            // Black Ace Industries
                            //lblCutDelta.Text = cutDelta.ToString("N1");
                            tStripCenterDelta.Text = cutDelta.ToString("N1");
                            tStripRightDelta.Text = cutDelta.ToString("N1");
                            tStripLeftDelta.Text = cutDelta.ToString("N1");
                            mc.GradeControlData[mc.gcDeltaDir] = 1;
                            
                        }
                        else
                        {
                            // Black Ace Industries                           
                           // lblCutDelta.Text = cutDelta.ToString("N1");
                            tStripCenterDelta.Text = cutDelta.ToString("N1");
                            tStripRightDelta.Text = cutDelta.ToString("N1");
                            tStripLeftDelta.Text = cutDelta.ToString("N1");
                            mc.GradeControlData[mc.gcDeltaDir] = 0;
                            
                        }
                        
                    }
                    else
                    {
                        int cut = Math.Abs((int)cutDelta);
                        if (cut > 255) cut = 255;
                        byte cut1 = (byte)cut;
                        
                        mc.GradeControlData[mc.gcCutDelta] = cut1;
                        if (cut1 == 0) mc.GradeControlData[mc.gcDeltaDir] = 3;

                        if (cutDelta > 0)
                        {
                            mc.GradeControlData[mc.gcCutDelta] = (byte)cutDelta;
                            //lblCutDelta.Text = (0.3937 * cutDelta).ToString("N2");
                            tStripCenterDelta.Text = (0.3937 * cutDelta).ToString("N2");
                            tStripRightDelta.Text = (0.3937 * cutDelta).ToString("N2");
                            tStripLeftDelta.Text = (0.3937 * cutDelta).ToString("N2");



                            mc.GradeControlData[mc.gcDeltaDir] = 1;
                        }
                        else 
                        {
                            //lblCutDelta.Text = (0.3937 * cutDelta).ToString("N2");
                            tStripCenterDelta.Text = (0.3937 * cutDelta).ToString("N2");
                            tStripLeftDelta.Text = (0.3937 * cutDelta).ToString("N2");
                            tStripRightDelta.Text = (0.3937 * cutDelta).ToString("N2");




                            mc.GradeControlData[mc.gcDeltaDir] = 0;
                        }
                        
                    }
    
                    //lblCutDelta.BackColor = SystemColors.ControlText;

                    
                    // FILL IN BAR GRAPHS

                    
                    if (cutDelta < 0) // Postive Cut Delta
                    {
                        int val = (int)((cutDelta / barGraphMax) * -100);
                        pbarCutAboveL.Value = 0;
                        pbarCutBelowL.Value = val;
                        pbarCutAboveR.Value = 0;
                        pbarCutBelowR.Value = val;

                        //pbarCutBelow.Value = 50;
                    }                    
                    else if (cutDelta > 0) // Negative Cut Delta
                    {
                        int val = (int)((cutDelta / barGraphMax) * 100 );
                        pbarCutBelowL.Value = 0;
                        pbarCutAboveL.Value = val;
                        pbarCutBelowR.Value = 0;
                        pbarCutAboveR.Value = val;

                       

                        //pbarCutAbove.Value = 50;
                    }
                    else
                    {
                        pbarCutBelowL.Value = 0;
                        pbarCutAboveL.Value = 0;
                        pbarCutBelowR.Value = 0;
                        pbarCutAboveR.Value = 0;
                    }





                    if (cutDelta < 1 && cutDelta > -1 )
                    {  
                        //lblCutDelta.BackColor = Color.Lime;
                        Color.FromArgb(100, 18, 130, 18);

                        pbarCutAboveL.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;
                        pbarCutBelowL.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;
                        pbarCutAboveL.Value = 10;
                        pbarCutBelowL.Value = 10;
                        pbarCutAboveR.Value = 10;
                        pbarCutBelowR.Value = 10;

                        tStripCenterIndicator.Image = Properties.Resources.GradeOK;
                        tStripRightIndicator.Image = Properties.Resources.GradeOK;
                        tStripLeftIndicator.Image = Properties.Resources.GradeOK;

                        pbarCutAboveR.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;
                        pbarCutBelowR.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;

                        //lblCutDelta2.BackColor = Color.Lime;
                    }
                    else if(cutDelta < -1 && cutDelta > - 3)
                    {
                        tStripCenterIndicator.Image = Properties.Resources.GradeLow1;
                        tStripRightIndicator.Image = Properties.Resources.GradeLow1;
                        tStripLeftIndicator.Image = Properties.Resources.GradeLow1;

                        pbarCutAboveL.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;
                        pbarCutBelowL.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;



                    }

                    else if ((cutDelta > 1 && cutDelta < 3))
                    {
                        tStripCenterIndicator.Image = Properties.Resources.GradeHigh1;
                        tStripRightIndicator.Image = Properties.Resources.GradeHigh1;
                        tStripLeftIndicator.Image = Properties.Resources.GradeHigh1;

                        pbarCutAboveL.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;
                        pbarCutBelowL.BarColorSolidB = Color.FromArgb(255, 18, 130, 18); ;


                    }
                    else if (cutDelta < -3)
                    {
                        pbarCutAboveL.BarColorSolidB = Color.Red;
                        pbarCutBelowL.BarColorSolidB = Color.RoyalBlue;
                        pbarCutAboveR.BarColorSolidB = Color.Red;
                        pbarCutBelowR.BarColorSolidB = Color.RoyalBlue;
                        tStripCenterIndicator.Image = Properties.Resources.GradeLow2;
                        tStripRightIndicator.Image = Properties.Resources.GradeLow2;
                        tStripLeftIndicator.Image = Properties.Resources.GradeLow2;


                    }
                        // lblCutDelta.BackColor = Color.Tomato;
                    else if ( cutDelta > 3)
                    {
                        pbarCutAboveL.BarColorSolidB = Color.Red; 
                        pbarCutBelowL.BarColorSolidB = Color.RoyalBlue; 
                        pbarCutAboveR.BarColorSolidB = Color.Red;
                        pbarCutBelowR.BarColorSolidB = Color.RoyalBlue;
                        tStripCenterIndicator.Image = Properties.Resources.GradeHigh2;
                        tStripRightIndicator.Image = Properties.Resources.GradeHigh2;
                        tStripLeftIndicator.Image = Properties.Resources.GradeHigh2;


                    

                      //lblCutDelta2.BackColor = Color.Tomato;
                    }

                }
                //update the online indicator
                if (recvCounter > 50)
                {
                   stripOnlineGPS.Value = 1;
                   ANTENNA1_LED.Value = 1;
                   
                  
                }
                else stripOnlineGPS.Value = 100;
                               
                SendUDPMessage(DATA_HEADER, epGradeControl);
            }
            


            //wait till timer fires again.     
        }
    }
}
//end class
//end namespace