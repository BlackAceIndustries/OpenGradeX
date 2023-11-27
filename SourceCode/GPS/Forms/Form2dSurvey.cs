using OpenGrade.Properties;
using SharpGL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static OpenGrade.FormGPS;

namespace OpenGrade
{
    public partial class Form2dSurvey : Form

    {
        //the point in the real world made from clicked screen coords
        vec2 screen2FieldPt = new vec2();
        
        private double altitudeWindowGain = 10.0;


        //access to the main GPS form and all its variables
        private readonly FormGPS mf = null;
                
        public Form2dSurvey(Form callingForm)
        {
            mf = callingForm as FormGPS;
            InitializeComponent();
            
        }

        public void openGLControlBack_OpenGLInitialized(object sender, EventArgs e)
        {
            //LoadGLTexturesBack();
            OpenGL gls = openGLControlBack.OpenGL;

            //  Set the clear color.
            gls.ClearColor(0.20f, 0.20f, 0.20f, 1.0f);

            // Set The Blending Function For Translucency
            gls.BlendFunc(OpenGL.GL_SRC_ALPHA, OpenGL.GL_ONE_MINUS_SRC_ALPHA);

            gls.Enable(OpenGL.GL_BLEND);
            //gls.Disable(OpenGL.GL_DEPTH_TEST);

            gls.Enable(OpenGL.GL_CULL_FACE);
            gls.CullFace(OpenGL.GL_BACK);
        }

        //Resize is called upn window creation
        public void openGLControlBack_Resized(object sender, EventArgs e)
        {
            //  Get the OpenGL object.
            OpenGL gls = openGLControlBack.OpenGL;

            gls.MatrixMode(OpenGL.GL_PROJECTION);

            //  Load the identity.
            gls.LoadIdentity();

            // change these at your own peril!!!! Very critical
            //  Create a perspective transformation.
            gls.Perspective(53.1, 1, 1, 6000);

            //  Set the modelview matrix.
            gls.MatrixMode(OpenGL.GL_MODELVIEW);
        }

        public void openGLControlBack_OpenGLDraw(object sender, RenderEventArgs args)
        {
            OpenGL gl = openGLControlBack.OpenGL;

            //antialiasing - fastest
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);  // Clear The Screen And The Depth Buffer

            gl.Enable(OpenGL.GL_LINE_SMOOTH);
            //gl.Enable(OpenGL.GL_BLEND);

            gl.Hint(OpenGL.GL_LINE_SMOOTH_HINT, OpenGL.GL_FASTEST);
            gl.Hint(OpenGL.GL_POINT_SMOOTH_HINT, OpenGL.GL_FASTEST);
            gl.Hint(OpenGL.GL_POLYGON_SMOOTH_HINT, OpenGL.GL_FASTEST);

            gl.LoadIdentity();                  // Reset The View

            //if adding new points recalc mins maxes
            if (mf.manualBtnState == FormGPS.btnStates.Rec) CalculateMinMaxZoom();

            //autogain the window
            if ((maxFieldY - minFieldY) != 0)
                altitudeWindowGain = (Math.Abs(cameraDistanceZ / (maxFieldY - minFieldY))) * 0.80;
            else altitudeWindowGain = 10;

            //translate to that spot in the world 
            gl.Translate(0, 0, -cameraDistanceZ);
            gl.Translate(-centerX, -centerY, 0);

            gl.Color(1, 1, 1);

            //reset cut delta for frame
            mf.cutDelta = 9999;
            mf.distToTarget = 9999;
            mf.distFromLastPass = 9999;


            int closestPoint = 0;
            int ptCnt = mf.ct.ptList.Count;
            int autoCnt = mf.ct.autoList.Count;
            int distToClosestPoint = 0;
            gl.LineWidth(4);
            CalculateMinMaxZoom();

            if (!mf.isLevelOn)
            {
                if (ptCnt > 0)
                {
                    mf.minDist = 8000;
                    int ptCount = mf.ct.ptList.Count - 1;//

                    //find the closest point to current fix
                    for (int t = 0; t < ptCount; t++)
                    {
                        double dist = ((mf.pn.lookaheadCenter.easting - mf.ct.ptList[t].easting) * (mf.pn.lookaheadCenter.easting - mf.ct.ptList[t].easting))
                                        + ((mf.pn.lookaheadCenter.northing - mf.ct.ptList[t].northing) * (mf.pn.lookaheadCenter.northing - mf.ct.ptList[t].northing));

                        //double dist = ((pn.easting - ct.ptList[t].easting) * (pn.easting - ct.ptList[t].easting))
                        //                + ((pn.northing - ct.ptList[t].northing) * (pn.northing - ct.ptList[t].northing));


                        if (dist < mf.minDist)
                        {
                            mf.minDist = dist; closestPoint = t;
                        }

                        //mf.tStrip3.Text = mf.minDist.ToString("f2");

                    }



                    //Black Ace Industries 

                    switch (mf.curMode)
                    {
                        case FormGPS.gradeMode.surface:
                            //draw the ground profile
                            gl.Color(.35f, .35f, .35f);
                            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);

                            if (ptCnt > 0)
                            {
                                for (int i = 0; i < ptCnt; i++)
                                {
                                    if (mf.ct.ptList[i].cutAltitude > mf.ct.ptList[i].altitude)
                                    {
                                        gl.Vertex(i, (((mf.ct.ptList[i].altitude - centerY) * altitudeWindowGain) + centerY), 0);
                                        gl.Vertex(i, -10000, 0);
                                    }
                                    else
                                    {
                                        gl.Vertex(i, (((mf.ct.ptList[i].cutAltitude - centerY) * altitudeWindowGain) + centerY), 0);
                                        gl.Vertex(i, -10000, 0);


                                    }


                                }

                            }

                            gl.End();

                            gl.Color(.0f, .0f, 1.0f);
                            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);

                            if (ptCnt > 0)
                            {
                                for (int i = 0; i < ptCnt; i++)
                                {
                                    if (mf.ct.ptList[i].cutAltitude > mf.ct.ptList[i].altitude)
                                    {
                                        gl.Color(.0f, .0f, 1.0f);
                                        gl.Vertex(i, (((mf.ct.ptList[i].cutAltitude - centerY) * altitudeWindowGain) + centerY), 0);
                                        gl.Vertex(i, (((mf.ct.ptList[i].altitude - centerY) * altitudeWindowGain) + centerY), 0);


                                    }
                                    else
                                    {
                                        gl.Color(1.0f, .0f, .0f);
                                        gl.Vertex(i, (((mf.ct.ptList[i].altitude - centerY) * altitudeWindowGain) + centerY), 0);
                                        gl.Vertex(i, (((mf.ct.ptList[i].cutAltitude - centerY) * altitudeWindowGain) + centerY), 0);


                                    }


                                }

                            }

                            gl.End();


                            gl.Color(0.0f, 0.99f, .0f);
                            gl.LineWidth(2);
                            gl.Begin(OpenGL.GL_LINE_STRIP);
                            if (ptCnt > 0)
                            {
                                for (int i = 0; i < ptCnt; i++)
                                {

                                    gl.Vertex(i, (((mf.ct.ptList[i].altitude - centerY) * altitudeWindowGain) + centerY), 0);
                                    //gl.Vertex(i, -10000, 0);

                                }
                                //gl.Disable(OpenGL.GL_LINE_STIPPLE);


                            }
                            gl.End();











                            //gl.Color(0.22f, 0.22f, 0.22f);
                            //gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
                            //for (int i = 0; i < ptCnt; i++)
                            //{
                            //    gl.Vertex(i,
                            //      (((mf.ct.ptList[i].altitude - centerY) * altitudeWindowGain) + centerY), 0);
                            //    gl.Vertex(i, -10000, 0);
                            //}
                            //gl.End();
                            break;

                        case FormGPS.gradeMode.ditch:
                            //draw the ground profile
                            gl.Color(0.22f, 0.22f, 0.22f);
                            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
                            for (int i = 0; i < ptCnt; i++)
                            {
                                gl.Vertex(i,
                                  (((mf.ct.ptList[i].altitude - centerY) * altitudeWindowGain) + centerY), 0);
                                gl.Vertex(i, -10000, 0);
                            }
                            gl.End();

                            gl.LineWidth(3);
                            gl.Begin(OpenGL.GL_LINE_STRIP);
                            gl.Color(1.0f, 0.2f, 0.2f); // MaxDepth
                            for (int i = 0; i < ptCnt; i++)
                            {
                                gl.Vertex(i, ((((mf.ct.ptList[i].altitude - mf.vehicle.maxDitchCut) - centerY) * altitudeWindowGain) + centerY), 0);
                            }
                            gl.End();
                            break;

                        case FormGPS.gradeMode.tile:
                            //draw the ground profile
                            gl.Color(0.22f, 0.22f, 0.22f);
                            gl.Begin(OpenGL.GL_TRIANGLE_STRIP);
                            for (int i = 0; i < ptCnt; i++)
                            {
                                gl.Vertex(i,
                                  (((mf.ct.ptList[i].altitude - centerY) * altitudeWindowGain) + centerY), 0);
                                gl.Vertex(i, -10000, 0);
                            }
                            gl.End();

                            gl.LineWidth(3);
                            gl.Begin(OpenGL.GL_LINE_STRIP);

                            gl.Color(1.0f, 0.2f, 0.2f); // MaxDepth 
                            for (int i = 0; i < ptCnt; i++)
                            {
                                gl.Vertex(i, ((((mf.ct.ptList[i].altitude - mf.vehicle.maxTileCut) - centerY) * altitudeWindowGain) + centerY), 0);
                            }
                            gl.End();

                            gl.LineWidth(3);
                            gl.Begin(OpenGL.GL_LINE_STRIP);
                            gl.Color(0.88f, 0.83f, 0.15f);  // MinCover
                            for (int i = 0; i < ptCnt; i++)
                            {
                                gl.Vertex(i, ((((mf.ct.ptList[i].altitude - mf.vehicle.minTileCover) - centerY) * altitudeWindowGain) + centerY), 0);
                            }
                            gl.End();
                            break;

                        default:

                            break;

                    }


                    //cut line drawn in full
                    int cutPts = mf.ct.ptList.Count;
                    if (cutPts > 0)
                    {
                        gl.LineWidth(2);
                        gl.Color(0.35f, 0.92f, 0.92f);
                        gl.Begin(OpenGL.GL_LINE_STRIP);
                        for (int i = 0; i < ptCnt; i++)
                        {
                            if (mf.ct.ptList[i].cutAltitude > 0)
                                gl.Vertex(i, (((mf.ct.ptList[i].cutAltitude - centerY) * altitudeWindowGain) + centerY), 0);
                        }
                        gl.End();
                    }

                    // proposed Smooting line
                    if (autoCnt > 0)
                    {

                        gl.Color(0.25f, 0.75f, 0.92f);
                        gl.Begin(OpenGL.GL_LINE_STRIP);
                        for (int i = 0; i < autoCnt; i++)
                            gl.Vertex(mf.ct.autoList[i].easting, (((mf.ct.autoList[i].northing - centerY) * altitudeWindowGain) + centerY), 0);
                        gl.End();
                    }

                    //crosshairs same spot as mouse - long
                    gl.LineWidth(2);
                    gl.Enable(OpenGL.GL_LINE_STIPPLE);
                    gl.LineStipple(1, 0x0300);

                    gl.Begin(OpenGL.GL_LINES);
                    gl.Color(0.90f, 0.90f, 0.70f);
                    gl.Vertex(screen2FieldPt.easting, 3000, 0);
                    gl.Vertex(screen2FieldPt.easting, -3000, 0);
                    gl.Vertex(-10, (((screen2FieldPt.northing - centerY) * altitudeWindowGain) + centerY), 0);
                    gl.Vertex(1000, (((screen2FieldPt.northing - centerY) * altitudeWindowGain) + centerY), 0);
                    gl.End();
                    gl.Disable(OpenGL.GL_LINE_STIPPLE);

                    //int pnt = (int)screen2FieldPt.easting;
                    //double x = mf.ct.ptList[pnt].altitude - mf.ct.ptList[i].cutAltitude;
                    //double y = screen2FieldPt.northing - mf.ct.ptList[pnt].cutAltitude;
                    
                   
                    if (mf.ct.ptList.Count > 0 && !mf.ct.isContourOn)
                       {
                        gl.LineWidth(3);
                        gl.Begin(OpenGL.GL_LINES);
                        gl.Color(0.00f, 0.90f, 0.90f);
                        gl.Vertex(screen2FieldPt.easting - .5, (((screen2FieldPt.northing - centerY) * altitudeWindowGain) + centerY), 0);
                        gl.Vertex(screen2FieldPt.easting - .5, (((mf.ct.ptList[(int)screen2FieldPt.easting].cutAltitude - centerY)) * altitudeWindowGain) + centerY, 0);
                        gl.End();


                        gl.Begin(OpenGL.GL_LINES);
                        gl.Color(1.0f, 0.0f, 0.00f);
                        gl.Vertex(screen2FieldPt.easting + .5, (((mf.ct.ptList[(int)screen2FieldPt.easting].altitude - centerY) * altitudeWindowGain) + centerY), 0);
                        gl.Vertex(screen2FieldPt.easting + .5, (((mf.ct.ptList[(int)screen2FieldPt.easting].cutAltitude - centerY)) * altitudeWindowGain) + centerY, 0);
                        gl.End();

                    }

                    

                    /////  Black Ace Industries
                    ///


                    //if (ct.distanceFromCurrentLine > minDist)



                    //if (mf.ct.distanceFromCurrentLine != 9999)
                    //{
                    //    if (mf.isMetric)
                    //    {
                    //        mf.tStripHorizontalOffset.Text = (mf.ct.distanceFromCurrentLine).ToString("F2");
                    //    }
                    //    else
                    //    {
                    //        tStripHorizontalOffset.Text = (ct.distanceFromCurrentLine / 25.4).ToString("F2");
                    //    }


                    //}
                    //else
                    //{
                    //    tStripHorizontalOffset.Text = "--";
                    //}




                    // tStripVerticalOffset.Text = (vehicle.disFromSurvey * 100000.0).ToString("F2");




                    if (Math.Abs(mf.ct.distanceFromCurrentLine) < mf.vehicle.disFromSurvey * 100000.0)
                    {      //(vehicle.disFromSurvey*10000 )                                
                        if (mf.minDist < mf.vehicle.disFromSurvey * 100.0)
                        {// record current pass 

                            //draw the actual elevation lines and blade
                            gl.LineWidth(8);
                            gl.Begin(OpenGL.GL_LINES);
                            gl.Color(0.95f, 0.90f, 0.0f);
                            gl.Vertex(closestPoint, (((mf.pn.altitude - centerY) * altitudeWindowGain) + centerY), 0);
                            gl.Vertex(closestPoint, 10000, 0);
                            gl.End();

                            //the skinny actual elevation lines
                            gl.LineWidth(1);
                            gl.Begin(OpenGL.GL_LINES);
                            gl.Color(0.57f, 0.80f, 0.00f);
                            gl.Vertex(-5000, (((mf.pn.altitude - centerY) * altitudeWindowGain) + centerY), 0);
                            gl.Vertex(5000, (((mf.pn.altitude - centerY) * altitudeWindowGain) + centerY), 0);
                            gl.Vertex(closestPoint, -10000, 0);
                            gl.Vertex(closestPoint, 10000, 0);
                            gl.End();

                            //little point at cutting edge of blade
                            gl.Color(0.0f, 0.0f, 0.0f);
                            gl.PointSize(8);
                            gl.Begin(OpenGL.GL_POINTS);
                            gl.Vertex(closestPoint, (((mf.pn.altitude - centerY) * altitudeWindowGain) + centerY), 0);
                            gl.End();

                            //rge



                            //calculate blade to guideline delta
                            //double temp = (double)closestPoint / (double)count2;
                            if (mf.ct.ptList[closestPoint].cutAltitude > 0)
                            {
                                //in cm                            
                                mf.distFromLastPass = ((mf.pn.altitude - mf.ct.ptList[closestPoint].lastPassAltitude) * 100) - mf.bladeOffset;
                                mf.distToTarget = ((mf.pn.altitude - mf.ct.ptList[closestPoint].cutAltitude) * 100) - mf.bladeOffset;

                                //AutoCut Active
                                if (mf.isAutoCutOn)
                                {
                                    if (mf.distToTarget < 0)//  && cutDepth < -5
                                    {
                                        mf.cutDelta = mf.distToTarget;
                                    }
                                    else
                                    {
                                        mf.cutDelta = mf.distFromLastPass - mf.autoCutDepth;
                                    }

                                }
                                else
                                {
                                    mf.cutDelta = mf.distToTarget;
                                }


                            }

                            //AutoShore Active
                            if (mf.isAutoShoreOn)
                            {
                                double xy = (Math.Tan(glm.toRadians(mf.vehicle.minShoreSlope)) * mf.ct.distanceFromCurrentLine);
                                mf.cutDelta += xy;
                            }


                            if (mf.ct.ptList[closestPoint].cutAltitude > 0)
                            {
                                mf.ct.ptList[closestPoint].currentPassAltitude = mf.pn.altitude;
                                mf.ct.isOnPass = true;
                                mf.ct.isDoneCopy = false;
                            }
                            else
                            {
                                mf.ct.isOnPass = false;
                            }

                            // light up isOnPass Indicator
                            if (mf.ct.isOnPass)
                            {
                                //stripOnlineAutoSteer.Value = 100;

                                mf.ct.isContourBtnOn = true;
                            }
                            else
                            {
                                //stripOnlineAutoSteer.Value = 0;

                                mf.ct.isContourBtnOn = false;

                            }


                            //draw current Antenna path as it is driven on ALL MODES
                            //

                            gl.LineWidth(3);
                            gl.Begin(OpenGL.GL_LINE_STRIP);

                            gl.Color(1.0f, 0.62f, 0.18f);  // orange
                            for (int i = 0; i < ptCnt; i++)
                            {
                                if (mf.ct.ptList[i].cutAltitude > 0 & mf.ct.ptList[i].currentPassAltitude > 0)
                                    gl.Vertex(i, (((mf.ct.ptList[i].currentPassAltitude - centerY) * altitudeWindowGain) + centerY), 0);
                            }
                            gl.End();

                        }
                    }



                    switch (mf.curMode)
                    {
                        case FormGPS.gradeMode.surface:

                            //lblMaxDepth.Visible = false;
                            //sqrMaxDepth.Visible = false;
                            //lblMinCover.Visible = false;
                            //sqrMinCover.Visible = false;
                            //lblCutLine.Visible = true;
                            //sqrCutLine1.Visible = true;
                            //lblDitchCutLine.Visible = false;
                            //sqrDitchCutLine.Visible = false;

                            gl.LineWidth(3);
                            gl.Begin(OpenGL.GL_LINE_STRIP);

                            gl.Color(0.2f, 0.1f, 0.75f);  //Blue
                            for (int i = 0; i < ptCnt; i++)
                            {
                                if (mf.ct.ptList[i].cutAltitude > 0 & mf.ct.ptList[i].lastPassAltitude > 0)
                                    gl.Vertex(i, (((mf.ct.ptList[i].lastPassAltitude - centerY) * altitudeWindowGain) + centerY), 0);
                            }
                            gl.End();

                            break;

                        case FormGPS.gradeMode.ditch:
                            //sqrMaxDepth.Visible = true;
                            //sqrMinCover.Visible = false;
                            //lblMaxDepth.Visible = true;
                            //lblMinCover.Visible = false;
                            //lblCutLine.Visible = true;
                            //sqrCutLine1.Visible = true;
                            //lblDitchCutLine.Visible = true;
                            //sqrDitchCutLine.Visible = true;

                            gl.LineWidth(5);
                            gl.Begin(OpenGL.GL_LINE_STRIP);

                            gl.Color(0.46f, 0.60f, 0.20f);// Green 
                            for (int i = 0; i < ptCnt; i++)
                            {
                                if (mf.ct.ptList[i].cutAltitude > 0 & mf.ct.ptList[i].currentPassAltitude > 0)
                                    gl.Vertex(i, ((((mf.ct.ptList[i].currentPassAltitude - mf.vehicle.maxDitchCut) - centerY) * altitudeWindowGain) + centerY), 0);
                            }
                            gl.End();

                            break;

                        case FormGPS.gradeMode.tile:
                            //mf.sqrMaxDepth.Visible = true;
                            //mf.sqrMinCover.Visible = true;
                            //mf.lblMaxDepth.Visible = true;
                            //mf.lblMinCover.Visible = true;
                            //mf.lblCutLine.Visible = true;
                            //mf.sqrCutLine1.Visible = true;
                            //mf.lblDitchCutLine.Visible = true;
                            //mf.sqrDitchCutLine.Visible = true;

                            gl.LineWidth(5);
                            gl.Begin(OpenGL.GL_LINE_STRIP);

                            gl.Color(0.46f, 0.60f, 0.20f);// Green 
                            for (int i = 0; i < ptCnt; i++)
                            {
                                if (mf.ct.ptList[i].cutAltitude > 0 & mf.ct.ptList[i].currentPassAltitude > 0)
                                    gl.Vertex(i, ((((mf.ct.ptList[i].currentPassAltitude) - centerY) * altitudeWindowGain) + centerY), 0);
                            }
                            gl.End();

                            break;

                        default:

                            break;
                    }

                    mf.UpdateLastPass(ptCnt);

                    //draw the guide line being built
                    if (mf.ct.isDrawingRefLine)
                    {
                        gl.LineWidth(2);
                        gl.Color(0.15f, 0.950f, 0.150f); // darking green while in process of drawing
                        int cutCnt = mf.ct.drawList.Count;


                        if (cutCnt > 0)
                        {
                            gl.Begin(OpenGL.GL_LINE_STRIP);
                            for (int i = 0; i < cutCnt; i++)
                                gl.Vertex(mf.ct.drawList[i].easting, (((mf.ct.drawList[i].northing - centerY) * altitudeWindowGain) + centerY), 0);
                            gl.End();

                            if (mf.slopeDraw < -mf.vehicle.minSlope) gl.Color(0.25f, 0.970f, 0.350f); // lighter green when slope is clicked 
                            else gl.Color(0.915f, 0.0f, 0.970f); // purple when above slope line


                            gl.Begin(OpenGL.GL_LINES);
                            //for (int i = 0; i < cutCnt; i++)
                            gl.Vertex(mf.ct.drawList[cutCnt - 1].easting, (((mf.ct.drawList[cutCnt - 1].northing - centerY) * altitudeWindowGain) + centerY), 0);

                            gl.Vertex(screen2FieldPt.easting, (((screen2FieldPt.northing - centerY) * altitudeWindowGain) + centerY), 0);

                            gl.End();

                            gl.Color(1.0f, 1.0f, 0.0f); // yellow
                            gl.PointSize(4);
                            gl.Begin(OpenGL.GL_POINTS);
                            for (int i = 0; i < cutCnt; i++)
                                gl.Vertex(mf.ct.drawList[i].easting, (((mf.ct.drawList[i].northing - centerY) * altitudeWindowGain) + centerY), 0);
                            gl.End();
                        }
                    }

                }


            }
            else // LEVEL MODE
            {
                mf.cutDelta = ((mf.pn.altitude - mf.ct.LaserSetAltitude) * 100) - mf.bladeOffset;
                mf.distToTarget = ((mf.pn.altitude - mf.ct.LaserSetAltitude) * 100) - mf.bladeOffset;

            }
        }


        private double maxFieldX, maxFieldY, minFieldX, minFieldY, centerX, centerY, cameraDistanceZ;

        private void openGLControlBack_MouseClick(object sender, MouseEventArgs e)
        {
            Point fixPt = new Point();
            vec2 plotPt = new vec2();
            if (mf.ct.isDrawingRefLine)
            {
                //OpenGL has line 0 at bottom, Windows at top, so convert
                Point pt = openGLControlBack.PointToClient(Cursor.Position);

                ////Convert to Origin in the center of window, 700 pixels
                fixPt.X = pt.X;
                fixPt.Y = ((openGLControlBack.Height - pt.Y) - openGLControlBack.Height / 2);

                //convert screen coordinates to field coordinates
                plotPt.easting = (int)(((double)fixPt.X) * (double)cameraDistanceZ / openGLControlBack.Width);
                plotPt.northing = ((double)fixPt.Y) * (double)cameraDistanceZ / (openGLControlBack.Height * altitudeWindowGain);
                plotPt.northing += centerY;

                //make sure not going backwards
                int cnt = mf.ct.drawList.Count;
                if (cnt > 0)
                {
                    if (mf.ct.drawList[cnt - 1].easting < plotPt.easting)
                        mf.ct.drawList.Add(plotPt);
                    else mf.TimedMessageBox(1500, "Point Invalid", "Ahead of Last Point Only");
                }
                //is first point
                else
                {

                    mf.ct.drawList.Add(plotPt);
                }
            }
        }

        private void openGLControlBack_MouseMove(object sender, MouseEventArgs e)
        {
            Point screenPt = new Point();
            screenPt.X = e.Location.X;
            screenPt.Y = ((openGLControlBack.Height - e.Location.Y) - openGLControlBack.Height / 2);

            //convert screen coordinates to field coordinates
            screen2FieldPt.easting = ((double)screenPt.X) * (double)cameraDistanceZ / openGLControlBack.Width;
            screen2FieldPt.northing = ((double)screenPt.Y) * (double)cameraDistanceZ / (openGLControlBack.Height * altitudeWindowGain);
            screen2FieldPt.northing += centerY;

            //stripTopoLocation.Text = ((int)(screen2FieldPt.easting)).ToString() + ": " + screen2FieldPt.northing.ToString("N3");

            if (mf.ct.ptList.Count > 0 && !mf.ct.isContourOn)
            {
                int pnt = (int)screen2FieldPt.easting;
                double x = mf.ct.ptList[pnt].altitude - mf.ct.ptList[pnt].cutAltitude;
                double y = screen2FieldPt.northing - mf.ct.ptList[pnt].cutAltitude;

                x *= 100;
                y *= 100;

                if (mf.isMetric)
                {
                    tStriptoSurvey.Text = x.ToString("F2");
                    tStripToDesign.Text = y.ToString("F2");

                    //stripDepth.Text = x.ToString("N0") + " CM";
                    //stripDepthtoTarget.Text = y.ToString("N0") + " CM";

                }
                else
                {
                    x *= 0.393701;
                    y *= 0.393701;
                    tStriptoSurvey.Text = x.ToString("F2");
                    tStripToDesign.Text = y.ToString("F2");
                    //stripDepth.Text = x.ToString("N1") + " Inches";
                    //stripDepthtoTarget.Text = y.ToString("N1") + " Inches";
                }

            }
            if (mf.ct.isDrawingRefLine)
            {
                // lblDrawSlope.Visible = true;
                //label2.Visible = true;
                int cnt = mf.ct.drawList.Count;
                if (cnt > 0)
                {
                    mf.slopeDraw = (((screen2FieldPt.northing - mf.ct.drawList[cnt - 1].northing)
                   / (screen2FieldPt.easting - mf.ct.drawList[cnt - 1].easting)));
                    //lblDrawSlope.Text = (slopeDraw*100).ToString("N4");

                    CalculateCutFillWhileMouseMove();
                }
            }
            else
            {
                //lblDrawSlope.Visible = false;
                //label2.Visible = false;


            }
        }

        private void CalculateCutFillWhileMouseMove()
        {
            vec2 temp = new vec2();
            int i = 0;
            double cut = 0; double fill = 0, delta = 0, slope;

            //empty the temp drawList
            tList.Clear();

            //make a line including current cursor position
            int drawPts = mf.ct.drawList.Count;
            for (i = 0; i < drawPts; i++)
            {
                temp.easting = mf.ct.drawList[i].easting;
                temp.northing = mf.ct.drawList[i].northing;
                tList.Add(temp);
            }
            //add current screen point
            tList.Add(screen2FieldPt);

            drawPts = tList.Count - 1;
            int ptCnt = mf.ct.ptList.Count;

            if (drawPts > 0)
            {
                for (i = 0; i < ptCnt; i++)
                {
                    //points before the drawn line
                    if (i < tList[0].easting) continue;

                    //points after drawn line
                    if (i > tList[drawPts].easting) continue;

                    //find out where its between
                    for (int j = 0; j < drawPts; j++)
                    {
                        if (i >= tList[j].easting && i <= tList[j + 1].easting)
                        {
                            slope = (tList[j + 1].northing - tList[j].northing) / (tList[j + 1].easting - tList[j].easting);
                            delta = ((i - tList[j].easting) * slope) + tList[j].northing - mf.ct.ptList[i].altitude;
                            delta *= (mf.ct.ptList[i].distance * mf.vehicle.toolWidth);

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
                            break;
                        }
                    }
                }

                //clean out the list
                tList.Clear();
                delta = (cut - fill);
            }
        }


        private void linkLabelGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void linkLabelCombineForum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.Link.LinkData.ToString());
        }

        private void Form_About_Load(object sender, EventArgs e)
        {
            // Add a link to the LinkLabel.
            LinkLabel.Link link = new LinkLabel.Link { LinkData = "https://github.com/farmerbriantee/OpenGrade" };
            

            // Add a link to the LinkLabel.
            LinkLabel.Link linkCf = new LinkLabel.Link
            {
                LinkData = "http://www.thecombineforum.com/forums/31-technology/278810-OpenGrade.html"
            };
        }

        
        //determine mins maxs of contour and altitude
        public void CalculateMinMaxZoom()
        {
            minFieldX = 9999999; minFieldY = 9999999;
            maxFieldX = -9999999; maxFieldY = -9999999;

            //every time the section turns off and on is a new patch
            int cnt = mf.ct.ptList.Count;

            if (cnt > 0)
            {

                for (int i = 0; i < cnt; i++)
                {
                    double x = i;
                    double y = mf.ct.ptList[i].altitude;

                    //also tally the max/min of Cut x and z
                    if (minFieldX > x) minFieldX = x;
                    if (maxFieldX < x) maxFieldX = x;
                    if (minFieldY > y) minFieldY = y;
                    if (maxFieldY < y) maxFieldY = y;
                }
            }

            //stripMinMax.Text = "MAX " + maxFieldY.ToString("N2") + "m : MIN " + minFieldY.ToString("N2") + "m : " + (maxFieldY - minFieldY).ToString("N2") + "m";

            if (maxFieldX == -9999999 | minFieldX == 9999999 | maxFieldY == -9999999 | minFieldY == 9999999)
            {
                maxFieldX = 0; minFieldX = 0; maxFieldY = 0; minFieldY = 0;
                cameraDistanceZ = 10;
            }
            else
            {
                //Max horizontal
                cameraDistanceZ = Math.Abs(minFieldX - maxFieldX);

                if (cameraDistanceZ < 10) cameraDistanceZ = 10;
                if (cameraDistanceZ > 6000) cameraDistanceZ = 6000;


                // Black Ace Industries
                switch (mf.curMode)
                {
                    case gradeMode.surface:
                        maxFieldY = (maxFieldY + .3); // vehicle.viewDistAboveGnd
                        minFieldY = (minFieldY - .3);    //  vehicle.viewDistUnderGnd
                        break;

                    case gradeMode.ditch:
                        maxFieldY = (maxFieldY + 1);
                        minFieldY = (minFieldY - mf.vehicle.maxDitchCut);
                        break;

                    case gradeMode.tile:
                        maxFieldY = (maxFieldY + 1);
                        minFieldY = (minFieldY - mf.vehicle.maxTileCut);
                        break;

                    default:

                        break;
                }

                centerX = (maxFieldX + minFieldX) / 2.0;
                centerY = (maxFieldY + minFieldY) / 2.0;



            }
        }

        public List<vec2> tList = new List<vec2>();
        public double slopeDraw = 0.0;




        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (mf.manualBtnState)
            {

                case FormGPS.btnStates.Off:
                    {



                        var form = new FormSurveyStart(mf, 2000, "", "");
                        form.Show();

                        if (mf.ct.ptList.Count > 0 && !mf.isCutSaved)// && mf.btnSaveCut.Enabled == true
                        {
                            DialogResult result3 = MessageBox.Show("Do you wish to start a new survey Line? \nThis will erase Your current cut if it has not been saved \n \n Do you wish to Continue?", "Do you wish to start a new survey Line?",
                                                 MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);

                            if (result3 == DialogResult.Yes)
                            {

                                button2.Image = Properties.Resources.SurveyStop1;
                               mf.userDistance = 0;
                               //mf.lblCut.Text = "*";
                               //mf.lblFill.Text = "*";
                               //mf.lblCutFillRatio.Text = "*";
                               // mf.lblDrawSlope.Text = "*";

                                btnDoneDraw.Enabled = false;
                                btnDeleteLastPoint.Enabled = false;
                                btnStartDraw.Enabled = false;

                            }
                        }



                        else
                        {

                            button2.Image = Properties.Resources.SurveyStop1;
                            mf.userDistance = 0;
                            //mf.lblCut.Text = "*";
                            //mf.lblFill.Text = "*";
                            //mf.lblCutFillRatio.Text = "*";
                            //mf.lblDrawSlope.Text = "*";

                            btnDoneDraw.Enabled = false;
                            btnDeleteLastPoint.Enabled = false;
                            btnStartDraw.Enabled = false;

                        }

                        break;
                    }



                case FormGPS.btnStates.Rec:
                    {
                        mf.manualBtnState = FormGPS.btnStates.Off;
                        button2.Image = Properties.Resources.SurveyStart;
                        mf.CalculateContourPointDistances();                    
                        mf.FileSaveContour();
                        btnDoneDraw.Enabled = false;
                        btnDeleteLastPoint.Enabled = false;
                        btnStartDraw.Enabled = true;

                        //mf.btnSaveCut.Enabled = true;
                        mf.isCutSaved = false;

                        break;

                    }

                case FormGPS.btnStates.Stdby:
                    mf.manualBtnState = FormGPS.btnStates.RecBnd;
                    button2.Image = null;
                    button2.Text = "Recording Boundary";
                    mf.userDistance = 0;
                    //btnStartPause.Visible = true;
                    // btnBoundarySide.Visible = true;
                    mf.ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";


                    //cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    mf.ct.isSurveyOn = true;
                    mf.ct.markBM = true;



                    break;

                case FormGPS.btnStates.RecBnd:
                    mf.manualBtnState = FormGPS.btnStates.Rec;
                    button2.Image = Properties.Resources.ManualOn;
                    button2.Text = null;
                    mf.userDistance = 0;
                    // btnBoundarySide.Visible = false;
                    mf.ct.isBtnStartPause = false;
                    //btnStartPause.Text = "START";

                    //cboxLastPass.Checked = false;
                    //cboxRecLastOnOff.Checked = false;
                    //cboxLaserModeOnOff.Checked = false;
                    //btnDoneDraw.Enabled = false;
                    //btnDeleteLastPoint.Enabled = false;
                    //btnStartDraw.Enabled = false;
                    mf.ct.isSurveyOn = true;
                    mf.ct.recBoundary = false;
                    mf.ct.recSurveyPt = true;


                    break;

            }
        }

        private void btnSerialCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            openGLControlBack.DoRender();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            btnAutoDrain.Enabled = false;
            btnDoneDraw.Enabled = false;
            btnDeleteLastPoint.Enabled = false;
            btnStartDraw.Enabled = true;

            mf.ct.isDrawingRefLine = false;
            int cnt = mf.ct.ptList.Count;
            int drawPts = mf.ct.drawList.Count - 1;
            double slope = 0.5;

            if (drawPts > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    //points before the drawn line are -1
                    if (i < mf.ct.drawList[0].easting)
                    {
                        mf.ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //points after drawn line are -1
                    if (i > mf.ct.drawList[drawPts].easting)
                    {
                        mf.ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //find out where its between
                    for (int j = 0; j < drawPts; j++)
                    {
                        if (i >= mf.ct.drawList[j].easting && i <= mf.ct.drawList[j + 1].easting)
                        {
                            slope = (mf.ct.drawList[j + 1].northing - mf.ct.drawList[j].northing) / (mf.ct.drawList[j + 1].easting - mf.ct.drawList[j].easting);
                            mf.ct.ptList[i].cutAltitude = ((i - mf.ct.drawList[j].easting) * slope) + mf.ct.drawList[j].northing;
                            break;
                        }
                    }
                }

                //Fill in cut and fill
                //mf.CalculateTotalCutFillLabels();
            }
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnStartDraw_Click(object sender, EventArgs e)
        {
            if (mf.ct.ptList.Count > 5)
            {
                btnAutoDrain.Enabled = true;
                mf.ct.drawList.Clear();
                mf.ct.isDrawingRefLine = true;
                //lblCut.Text = "-";
                //lblFill.Text = "-";
                //lblCutFillRatio.Text = "-";

                btnDoneDraw.Enabled = true;
                btnDeleteLastPoint.Enabled = true;
                btnStartDraw.Enabled = false;
            }
            else mf.TimedMessageBox(1500, "No Surveyed Points", "Survey a Contour First");
        }

        private void btnDoneDraw_Click(object sender, EventArgs e)
        {
            //btnSaveCut.Enabled = true;
            btnAutoDrain.Enabled = false;
            btnDoneDraw.Enabled = false;
            btnDeleteLastPoint.Enabled = false;
            btnStartDraw.Enabled = true;

            mf.ct.isDrawingRefLine = false;
            int cnt = mf.ct.ptList.Count;
            int drawPts = mf.ct.drawList.Count - 1;
            double slope = 0.5;

            if (drawPts > 0)
            {
                for (int i = 0; i < cnt; i++)
                {
                    //points before the drawn line are -1
                    if (i < mf.ct.drawList[0].easting)
                    {
                        mf.ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //points after drawn line are -1
                    if (i > mf.ct.drawList[drawPts].easting)
                    {
                        mf.ct.ptList[i].cutAltitude = -1;
                        continue;
                    }

                    //find out where its between
                    for (int j = 0; j < drawPts; j++)
                    {
                        if (i >= mf.ct.drawList[j].easting && i <= mf.ct.drawList[j + 1].easting)
                        {
                            slope = (mf.ct.drawList[j + 1].northing - mf.ct.drawList[j].northing) / (mf.ct.drawList[j + 1].easting - mf.ct.drawList[j].easting);
                            mf.ct.ptList[i].cutAltitude = ((i - mf.ct.drawList[j].easting) * slope) + mf.ct.drawList[j].northing;
                            break;
                        }
                    }
                }

                //Fill in cut and fill
                //mf.CalculateTotalCutFillLabels();
            }
            //mf.isCutSaved = true;
            //mf.ct.SaveToCut();
            //this.Close();

            //CheckMaxCut();
        }

        private void btnDeleteLastPoint_Click(object sender, EventArgs e)
        {
            int ptCnt = mf.ct.drawList.Count;
            if (ptCnt > 0) mf.ct.drawList.RemoveAt(ptCnt - 1);
        }

        private void btnAutoDrain_Click(object sender, EventArgs e)
        {
            mf.ct.AutoDrain();
        }

        private void vrbSave_Click(object sender, EventArgs e)
        {
            mf.isCutSaved = true;
            mf.ct.SaveToCut();
        }
    }
}
