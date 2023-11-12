//Please, if you use this, share the improvements

using OpenGrade.Properties;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace OpenGrade
{
    public partial class FormSettings : Form
    {
       //class variables
        private readonly FormGPS mf = null;

        private double antennaHeight, plowHeight, minSlope, minShoreSlope, toolWidth, maxTileCut, disFromSurvey,
            maxDitchCut, minTileCover, minDitchCut,viewDistAboveGnd, viewDistUnderGnd;
        private byte KpGain, KiGain, KdGain, retDeadband, extDeadband, valveType;
      
        private readonly double metImp2m, m2MetImp;

        //constructor
        public FormSettings(Form callingForm, int page)
        {
            //get copy of the calling main form
            mf = callingForm as FormGPS;
            InitializeComponent();

            if (mf.isMetric)
            {
                metImp2m = 0.01;
                m2MetImp = 100.0;
                lblInchesCm.Text = "Centimeters";
            }
            else
            {
                metImp2m = glm.in2m;
                m2MetImp = glm.m2in;
                lblInchesCm.Text = "Inches";
            }
            //select the page as per calling menu or button from mainGPS form
            tabOpenGrade.SelectedIndex = page;
        }

        //do any field initializing for form here
        private void FormSettings_Load(object sender, EventArgs e)
        {
            //Vehicle settings to what it is in the settings page------------------------------------------------
            antennaHeight = Properties.Vehicle.Default.setVehicle_antennaHeight;
            disFromSurvey = Properties.Vehicle.Default.setVehicle_plowHeight;

            maxTileCut = Properties.Vehicle.Default.setVehicle_maxTileCut;  
            minDitchCut = Properties.Vehicle.Default.setVehicle_minDitchCut;
            maxDitchCut = Properties.Vehicle.Default.setVehicle_maxDitchCut;
            minTileCover = Properties.Vehicle.Default.setVehicle_minTileCover;      
            

            KpGain = Properties.Settings.Default.set_KpGain;
            KiGain = Properties.Settings.Default.set_KiGain; /// 10
            KdGain = Properties.Settings.Default.set_KdGain;//* 100

            retDeadband = Properties.Settings.Default.set_RetDeadband;
            extDeadband = Properties.Settings.Default.set_ExtDeadband;
            valveType = Properties.Settings.Default.set_ValveType;

            valveSelectChoice.Text = Properties.Settings.Default.set_ValveName;
           
            toolWidth = Properties.Vehicle.Default.setVehicle_toolWidth;            
            minSlope = Properties.Vehicle.Default.setVehicle_minSlope*100;
            mf.vehicle.minSlope = minSlope; 

            minShoreSlope = Properties.Vehicle.Default.setVehicle_minShoreSlope;


            nudAntennaHeight.ValueChanged -= nudAntennaHeight_ValueChanged;
            nudAntennaHeight.Value = (decimal)(antennaHeight * m2MetImp);
            nudAntennaHeight.ValueChanged += nudAntennaHeight_ValueChanged;

            nudDistFromSurvey.ValueChanged -= nudPlowHeight_ValueChanged;
            nudDistFromSurvey.Value = (decimal)(disFromSurvey * m2MetImp);
            nudDistFromSurvey.ValueChanged += nudPlowHeight_ValueChanged;

            //Black Ace Industries

            nudMaxTileCut.ValueChanged -= nudMaxTileCut_ValueChanged;
            nudMaxTileCut.Value = (decimal)(maxTileCut * m2MetImp);
            nudMaxTileCut.ValueChanged += nudMaxTileCut_ValueChanged;

            nudMinTileCover.ValueChanged -= nudMinTileCover_ValueChanged;
            nudMinTileCover.Value = (decimal)(minTileCover * m2MetImp);
            nudMinTileCover.ValueChanged += nudMinTileCover_ValueChanged;

            nudMaxDitchCut.ValueChanged -= nudMaxDitchCut_ValueChanged;
            nudMaxDitchCut.Value = (decimal)(maxDitchCut * m2MetImp);
            nudMaxDitchCut.ValueChanged += nudMaxDitchCut_ValueChanged;

            nudMinDitchCut.ValueChanged -= nudMinDitchCut_ValueChanged;
            nudMinDitchCut.Value = (decimal)(minDitchCut * m2MetImp);
            nudMinDitchCut.ValueChanged += nudMinDitchCut_ValueChanged;

            nudKp.ValueChanged -= nudKp_ValueChanged;
            nudKp.Value = KpGain;
            nudKp.ValueChanged += nudKp_ValueChanged;

            nudKi.ValueChanged -= nudKi_ValueChanged;
            nudKi.Value = KiGain;
            nudKi.ValueChanged += nudKi_ValueChanged;

            nudKd.ValueChanged -= nudKd_ValueChanged;
            nudKd.Value = KdGain;
            nudKd.ValueChanged += nudKd_ValueChanged;

            nudExtDeadband.ValueChanged -= nudExtDeadband_ValueChanged;
            nudExtDeadband.Value = extDeadband;
            nudExtDeadband.ValueChanged += nudExtDeadband_ValueChanged;

            nudRetDeadband.ValueChanged -= nudRetDeadband_ValueChanged;
            nudRetDeadband.Value = retDeadband;
            nudRetDeadband.ValueChanged += nudRetDeadband_ValueChanged;

            ///

            nudToolWidth.ValueChanged -= nudToolWidth_ValueChanged;
            nudToolWidth.Value = (decimal)(toolWidth * m2MetImp);
            nudToolWidth.ValueChanged += nudToolWidth_ValueChanged;

            nudMinSlope.ValueChanged -= nudMinSlope_ValueChanged;
            nudMinSlope.Value = (decimal)(minSlope);
            nudMinSlope.ValueChanged += nudMinSlope_ValueChanged;

            nudMinShoreSlope.ValueChanged -= nudMinShoreSlope_ValueChanged;
            nudMinShoreSlope.Value = (decimal)(minShoreSlope);
            nudMinShoreSlope.ValueChanged += nudMinShoreSlope_ValueChanged;




        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            //Vehicle settings -------------------------------------------------------------------------------
            mf.vehicle.minSlope = Math.Abs(minSlope/100);
            Properties.Vehicle.Default.setVehicle_minSlope = mf.vehicle.minSlope;

            mf.vehicle.minShoreSlope = minShoreSlope;
            Properties.Vehicle.Default.setVehicle_minShoreSlope = mf.vehicle.minShoreSlope;

            mf.vehicle.disFromSurvey = disFromSurvey;
            Properties.Vehicle.Default.setVehicle_plowHeight = mf.vehicle.disFromSurvey;
            
            //
            // Black Ace Industries
            //
            mf.vehicle.maxTileCut = maxTileCut;
            Properties.Vehicle.Default.setVehicle_maxTileCut = mf.vehicle.maxTileCut;
            mf.vehicle.minDitchCut = minDitchCut;
            Properties.Vehicle.Default.setVehicle_minDitchCut = mf.vehicle.minDitchCut;
            mf.vehicle.maxDitchCut = maxDitchCut;
            Properties.Vehicle.Default.setVehicle_maxDitchCut = mf.vehicle.maxDitchCut;
            mf.vehicle.minTileCover = minTileCover;
            Properties.Vehicle.Default.setVehicle_minTileCover = mf.vehicle.minTileCover;

            mf.vehicle.KpGain = KpGain;
            Properties.Settings.Default.set_KpGain = mf.vehicle.KpGain;
            mf.vehicle.KiGain = KiGain;
            Properties.Settings.Default.set_KiGain = mf.vehicle.KiGain;
            mf.vehicle.KdGain = KdGain;
            Properties.Settings.Default.set_KdGain = mf.vehicle.KdGain;

            mf.vehicle.retDeadband = retDeadband;
            Properties.Settings.Default.set_RetDeadband = mf.vehicle.retDeadband;
            mf.vehicle.extDeadband = extDeadband;
            Properties.Settings.Default.set_ExtDeadband = mf.vehicle.extDeadband;

            mf.vehicle.valveType = valveType;
            Properties.Settings.Default.set_ValveType = mf.vehicle.valveType;

            mf.mc.gradeControlSettings[mf.mc.gsKpGain] = Properties.Settings.Default.set_KpGain;
            mf.mc.gradeControlSettings[mf.mc.gsKiGain] = Properties.Settings.Default.set_KiGain;
            mf.mc.gradeControlSettings[mf.mc.gsKdGain] = Properties.Settings.Default.set_KdGain;
            mf.mc.gradeControlSettings[mf.mc.gsRetDeadband] = Properties.Settings.Default.set_RetDeadband;
            mf.mc.gradeControlSettings[mf.mc.gsExtDeadband] = Properties.Settings.Default.set_ExtDeadband;
            mf.mc.gradeControlSettings[mf.mc.gsValveType] = Properties.Settings.Default.set_ValveType;
            
            ////
            ////
            ///

            mf.vehicle.antennaHeight = antennaHeight;
            Properties.Vehicle.Default.setVehicle_antennaHeight = mf.vehicle.antennaHeight;

            mf.vehicle.toolWidth = toolWidth;
            Properties.Vehicle.Default.setVehicle_toolWidth = toolWidth;

            //Sections ------------------------------------------------------------------------------------------

            Properties.Settings.Default.Save();
            Properties.Vehicle.Default.Save();

            mf.SendUDPMessage(FormGPS.SETTINGS_HEADER, mf.epGradeControl);

            //back to FormGPS
            DialogResult = DialogResult.OK;

            
            Close();
        }

        //don't save anything, leave the settings as before
        private void btnCancel_Click(object sender, EventArgs e)
        { DialogResult = DialogResult.Cancel; Close(); 
        
        }


        #region Vehicle //----------------------------------------------------------------

        private void nudAntennaHeight_ValueChanged(object sender, EventArgs e)
        {
            antennaHeight = (double)nudAntennaHeight.Value * metImp2m;
        }

        private void valveSelectChoice_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (valveSelectChoice.Text == "CNH")
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 0;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
                

            }
            if (valveSelectChoice.Text == "DEERE")
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 1;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
               

            }
            if (valveSelectChoice.Text == "DANFOSS")
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 2;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
                
            }
            else 
            {
                mf.mc.gradeControlSettings[mf.mc.gsValveType] = 0;
                Properties.Settings.Default.set_ValveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                valveType = mf.mc.gradeControlSettings[mf.mc.gsValveType];
                Properties.Settings.Default.set_ValveName = valveSelectChoice.Text;
                Properties.Settings.Default.Save();
                
            }
        }


        private void nudKp_ValueChanged_1(object sender, EventArgs e)
        {
            KpGain = (byte)nudKp.Value;            
            mf.mc.gradeControlSettings[mf.mc.gsKpGain] = KpGain;
            Properties.Settings.Default.set_KdGain = KdGain;
            KpGain = Properties.Settings.Default.set_KpGain;
            Properties.Settings.Default.Save();
            
        }

        private void nudKi_ValueChanged_1(object sender, EventArgs e)
        {
            KiGain = (byte)nudKi.Value;            
            mf.mc.gradeControlSettings[mf.mc.gsKiGain] = KiGain;
            Properties.Settings.Default.set_KiGain = KiGain;
            KiGain = Properties.Settings.Default.set_KiGain; /// 10
            Properties.Settings.Default.Save();
            

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void nudPlowHeight_ValueChanged_1(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void btnLoadVehicle_Click(object sender, EventArgs e)
        {
            if (mf.isJobStarted)
            {
                var form = new FormTimedMessage(2000, gStr.gsFieldIsOpen, gStr.gsCloseFieldFirst);
                form.Show();
                return;
            }
            mf.FileOpenVehicle();
        }

        private void btnZeroImu_Click(object sender, EventArgs e)
        {
            mf.SendUDPMessage(FormGPS.IMU_HEADER, mf.epAntennaModule);
        }

        private void btnUnits_Click(object sender, EventArgs e)
        {
            
            if (!mf.isMetric)
            {
                //mf.metricToolStrip.Checked = true;
                //mf.imperialToolStrip.Checked = false;
                mf.isMetric = true;
                Settings.Default.setMenu_isMetric = mf.isMetric;
                Settings.Default.Save();
                btnUnits.Image = Properties.Resources.ConD_Metric;

            }
            else
            {
                //mf.metricToolStrip.Checked = false;
                //mf.imperialToolStrip.Checked = true;
                mf.isMetric = false;
                Settings.Default.setMenu_isMetric = mf.isMetric;
                Settings.Default.Save();
                btnUnits.Image = Properties.Resources.ConD_Imperial;


            }
            
            
        }

        private void btnGrid_Click(object sender, EventArgs e)
        {
            
            
            mf.isGridOn = !mf.isGridOn;
            //mf.gridToolStripMenuItem.Checked = isGridOn;
            Settings.Default.setMenu_isGridOn = mf.isGridOn;
            Settings.Default.Save();

        }

        private void btnLightbar_Click(object sender, EventArgs e)
        {
            mf.isLightbarOn = !mf.isLightbarOn;
            //lightbarToolStripMenuItem.Checked = isLightbarOn;
            Settings.Default.setMenu_isLightbarOn = mf.isLightbarOn;
            Settings.Default.Save();
        }

        private void btnPolygons_Click(object sender, EventArgs e)
        {
            mf.isDrawPolygons = !mf.isDrawPolygons;
            //polygonsToolStripMenuItem.Checked = !polygonsToolStripMenuItem.Checked;
        }

        private void btnLogNMEA_Click(object sender, EventArgs e)
        {
            mf.isLogNMEA = !mf.isLogNMEA;
            //logNMEAMenuItem.Checked = isLogNMEA;
            Settings.Default.setMenu_isLogNMEA = mf.isLogNMEA;
            Settings.Default.Save();
        }

        private void btnPursuitLine_Click(object sender, EventArgs e)
        {
            mf.isPureDisplayOn = !mf.isPureDisplayOn;
            //pursuitLineToolStripMenuItem.Checked = isPureDisplayOn;
            Settings.Default.setMenu_isPureOn = mf.isPureDisplayOn;
            Settings.Default.Save();
        }

        private void bntSkyOn_Click(object sender, EventArgs e)
        {
            mf.isSkyOn = !mf.isSkyOn;
            //skyToolStripMenu.Checked = isSkyOn;
            Settings.Default.setMenu_isSkyOn = mf.isSkyOn;
            Settings.Default.Save();
        }

        private void btnFullScreen_Click(object sender, EventArgs e)
        {
            if (mf.FormBorderStyle == FormBorderStyle.None) //&& this.WindowState != FormWindowState.Normal
            {
                mf.FormBorderStyle = FormBorderStyle.Sizable;
                mf.WindowState = FormWindowState.Normal;
                mf.Padding = new Padding(5);
                //fullscreenToolStripMenuItem.Checked = false;
            }
            else
            {
                mf.FormBorderStyle = FormBorderStyle.None;
                mf.WindowState = FormWindowState.Maximized;
                mf.Padding = new Padding(5);
                //fullscreenToolStripMenuItem.Checked = true;
            }
        }

        private void btnSimulator_Click(object sender, EventArgs e)
        {
            if (mf.ToggleSim())
            {
                btnSimulator.BackColor = Color.Green;
                
            }
            else
            {
                btnSimulator.BackColor = Color.Red;

            }
        }

        private void btnSaveVehicle_Click(object sender, EventArgs e)
        {
            mf.FileSaveVehicle();
        }

        private void btnSectionColor_Click(object sender, EventArgs e)
        {
            //color picker for sections
            ColorDialog colorDlg = new ColorDialog
            {
                FullOpen = true,
                AnyColor = true,
                SolidColorOnly = false,
                Color = Color.FromArgb(255, mf.redSections, mf.grnSections, mf.bluSections)
            };

            if (colorDlg.ShowDialog() != DialogResult.OK) return;

            mf.redSections = colorDlg.Color.R;
            if (mf.redSections > 253) mf.redSections = 253;
            mf.grnSections = colorDlg.Color.G;
            if (mf.grnSections > 253) mf.grnSections = 253;
            mf.bluSections = colorDlg.Color.B;
            if (mf.bluSections > 253) mf.bluSections = 253;

            Settings.Default.setF_SectionColorR = mf.redSections;
            Settings.Default.setF_SectionColorG = mf.grnSections;
            Settings.Default.setF_SectionColorB = mf.bluSections;
            Settings.Default.Save();
        }

        private void btnFieldColor_Click(object sender, EventArgs e)
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

            mf.redField = colorDlg.Color.R;
            if (mf.redField > 253) mf.redField = 253;
            mf.grnField = colorDlg.Color.G;
            if (mf.grnField > 253) mf.grnField = 253;
            mf.bluField = colorDlg.Color.B;
            if (mf.bluField > 253) mf.bluField = 253;

            Settings.Default.setF_FieldColorR = mf.redField;
            Settings.Default.setF_FieldColorG = mf.grnField;
            Settings.Default.setF_FieldColorB = mf.bluField;
            Settings.Default.Save();
        }

        private void btnImuOnOff_Click(object sender, EventArgs e)
        {
            mf.mc.ToggleIMUCorrection();
        }

        private void nudPlowHeight_ValueChanged_2(object sender, EventArgs e)
        {
            plowHeight = (double)nudDistFromSurvey.Value;
        }

        private void nudKd_ValueChanged_1(object sender, EventArgs e)
        {
            KdGain = (byte)nudKd.Value;            
            mf.mc.gradeControlSettings[mf.mc.gsKdGain] = KdGain;
            Properties.Settings.Default.set_KdGain = KdGain;
            KdGain = Properties.Settings.Default.set_KdGain;
            Properties.Settings.Default.Save();
            

        }
      

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            extDeadband = (byte)nudExtDeadband.Value;
            mf.mc.gradeControlSettings[mf.mc.gsExtDeadband] = extDeadband;
            Properties.Settings.Default.set_ExtDeadband = extDeadband;            
            extDeadband = Properties.Settings.Default.set_ExtDeadband;
            Properties.Settings.Default.Save();
            

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            retDeadband = (byte)nudRetDeadband.Value;
            mf.mc.gradeControlSettings[mf.mc.gsRetDeadband] = retDeadband;
            Properties.Settings.Default.set_RetDeadband = retDeadband;
            Properties.Settings.Default.Save();


        }






        /// <summary>
        // RESET ALL FUNCTION

        //if (isJobStarted)
        //    {
        //        MessageBox.Show(gStr.gsCloseFieldFirst);
        //    }
        //    else
        //    {
        //        DialogResult result2 = MessageBox.Show("Really Reset Everything?", "Reset settings",
        //            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

        //        if (result2 == DialogResult.Yes)
        //        {
        //            Settings.Default.Reset();
        //            Settings.Default.Save();
        //            Vehicle.Default.Reset();
        //            Vehicle.Default.Save();
        //            MessageBox.Show(gStr.gsProgramExitAndRestart);
        //            Application.Exit();
        //        }
        //    }
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>











        // Black Ace Industries
        private void nudPlowHeight_ValueChanged(object sender, EventArgs e)
        {
            disFromSurvey = (double)nudDistFromSurvey.Value * metImp2m;
        }
        private void nudMinTileCover_ValueChanged(object sender, EventArgs e)
        {
            minTileCover = (double)nudMinTileCover.Value * metImp2m;
        }
        private void nudMaxTileCut_ValueChanged(object sender, EventArgs e)
        {
            maxTileCut = (double)nudMaxTileCut.Value * metImp2m;
        }
        private void nudMinDitchCut_ValueChanged(object sender, EventArgs e)
        {
            minDitchCut = (double)nudMinDitchCut.Value * metImp2m;
        }private void nudMaxDitchCut_ValueChanged(object sender, EventArgs e)
        {
            maxDitchCut = (double)nudMaxDitchCut.Value * metImp2m;
        }        
        private void nudKp_ValueChanged(object sender, EventArgs e)
        {
            KpGain = (byte)nudKp.Value;
            
        }
        private void nudKi_ValueChanged(object sender, EventArgs e)
        {
            KiGain = (byte)nudKi.Value;
            
            
        }
        private void nudKd_ValueChanged(object sender, EventArgs e)
        {
            KdGain = (byte)nudKd.Value;
            
        }

        private void nudRetDeadband_ValueChanged(object sender, EventArgs e)
        {
            retDeadband = (byte)nudRetDeadband.Value;
            
        }
      
        private void nudExtDeadband_ValueChanged(object sender, EventArgs e)
        {
            extDeadband = (byte)nudExtDeadband.Value;            
        }
        
        private void nudMinSlope_ValueChanged(object sender, EventArgs e)
        {
            minSlope = (double)nudMinSlope.Value;
        }

        private void nudMinShoreSlope_ValueChanged(object sender, EventArgs e)
        {
            minShoreSlope = (double)nudMinShoreSlope.Value;
        }


        private void nudToolWidth_ValueChanged(object sender, EventArgs e)
        {
            toolWidth = (double)nudToolWidth.Value * metImp2m;
        }





      #endregion Vehicle
    }
}