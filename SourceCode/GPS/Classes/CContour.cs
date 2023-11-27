using OpenGrade.Properties;
using SharpGL;
using System;
using System.Collections.Generic;
using System.Drawing;
using static OpenGrade.FormGPS;

namespace OpenGrade
{
    public class CContour
    {
        //copy of the mainform address
        private readonly FormGPS mf;
        private readonly OpenGL gl;


        private double minDist, minDist2;
        private double minDistMap;
        private double mappingDist;


        public bool isContourOn, isContourBtnOn = false;
        public bool surveyMode;
        public bool isSurveyOn;
        public bool markBM;
        public bool clearSurveyList;
        public bool recBoundary;
        public bool recSurveyPt;
        public bool isBtnStartPause;
        public bool isBoundarySideRight = true;
        public bool isOpenGLControlBackVisible = true;
        public bool FloatIsOK;
        public bool isOKtoSurvey = true;
        public bool drawTheMap = true;
        //public bool isSimulatorOn;


        //for the diferent maps views
        public bool isElevation;
        public bool isExistingElevation;
        public bool isActualCut;
        public bool isActualFill;

        //
        public int eleViewListCount = 300;
        public int eleViewListCount2 = 300;

        public double maxAltitude = -9999, minAltitude = 9999, maxCut = 0, maxFill = 0, midAltitude;

        public double slope = 0.002;
        public double LaserSetAltitude = 100.0;

        //All the stuff for the height averaging
        private double distanceFromNline;
        private double distanceFromSline;
        private double distanceFromEline;
        private double distanceFromWline;

        private double eastingNpt;
        private double northingNpt;
        private double altitudeNpt;
        private double cutAltNpt;

        private double eastingSpt;
        private double northingSpt;
        private double altitudeSpt;
        private double cutAltSpt;

        private double eastingEpt;
        private double northingEpt;
        private double altitudeEpt;
        private double cutAltEpt;

        private double eastingWpt;
        private double northingWpt;
        private double altitudeWpt;
        private double cutAltWpt;

        //------------------------------------------------------
        public bool stopTheProgram;

        public bool averagePts = Properties.Settings.Default.set_isAvgPt; // average four near design pts or not
        public double noAvgDist = Properties.Settings.Default.set_noAvgDist; // distance from a point that will not be averaged
        public double levelDistFactor = Properties.Settings.Default.set_levelDistFactor; //A factor to set the influance of a design pt according his dist from the blade

        private double minDistMapDist = 400; // how far from a survey point it will draw the map 400 is 20 meters
        private double drawPtWidth = 1; // the size of the map pixel in meter







        public double nearestSurveyEasting;
        public double nearestSurveyNorthing;

        public List<CContourPt> ptList = new List<CContourPt>();

        public List<mapListPt> mapList = new List<mapListPt>();

        public List<SurveyPt> surveyList = new List<SurveyPt>();

        public List<designPt> designList = new List<designPt>();

        public List<ViewPt> eleViewList = new List<ViewPt>();

        public List<ViewPt> eleViewList2 = new List<ViewPt>();

        public List<UsedPt> usedPtList = new List<UsedPt>();

        public List<BoundaryPt> boundaryList = new List<BoundaryPt>();

        //public bool isContourOn, isContourBtnOn;
        //public double slope = 0.002;
        //public double zeroAltitude = 0;

        //public List<CContourPt> ptList = new List<CContourPt>();
        public List<CCutPt> cutList = new List<CCutPt>();

        public int cutNum = 0;

        //used to determine if section was off and now is on or vice versa
        public bool wasSectionOn;

        //generated box for finding closest point
        public vec2 boxA = new vec2(0, 0), boxB = new vec2(0, 2);

        public vec2 boxC = new vec2(1, 1), boxD = new vec2(2, 3);

        //angle to path line closest point and fix
        public double refHeading, ref2;

        // for closest line point to current fix
        public double minDistance = 99999.0, refX, refZ;

        //generated reference line
        public double refLineSide = 1.0;

        public vec2 refPoint1 = new vec2(1, 1), refPoint2 = new vec2(2, 2);

        public double distanceFromRefLine;
        public double distanceFromCurrentLine;

        private int A, B, C;
        public double abFixHeadingDelta, abHeading;

        public bool isABSameAsFixHeading = true;
        public bool isOnRightSideCurrentLine = true;

        public bool isDrawingRefLine;
        public bool isAutoDraw;



        public double bladeAngle = 0;

        public double surveyHeight;

        //
        // Black Ace Industries
        //
        public bool isOnPass;
        public bool isDoneCopy;
        public bool isAutoCutDepthActive;



        //pure pursuit values
        public vec2 goalPointCT = new vec2(0, 0);

        public vec2 radiusPointCT = new vec2(0, 0);
        public double steerAngleCT;
        public double rEastCT, rNorthCT;
        public double ppRadiusCT;

        //list of contour data from GPS
        //public List<vec4> ptList = new List<vec4>();

        //the manually picked list
        public List<vec2> drawList = new List<vec2>();

        //the autmatically picked list       
        public List<vec2> autoList = new List<vec2>();


        //converted from drawn line to all points cut line
        //public List<vec4> cutList = new List<vec4>();

        //list of the list of individual Lines for entire field
        //public List<CContourPt> topoList = new List<CContourPt>();

        //constructor
        public CContour(OpenGL _gl, FormGPS _f)
        {
            mf = _f;
            if (mf != null)
            {
                gl = _gl;
            }
        }



        //
        // Black Ace Industries
        //




        //start stop and add points to list
        public void StartContourLine()
        {
            isContourOn = true;
            //reuse ptList
            ptList.Clear();

            CContourPt point = new CContourPt(mf.pn.easting, mf.fixHeading, mf.pn.northing, (mf.pn.altitude - surveyHeight), mf.pn.latitude, mf.pn.longitude);
            ptList.Add(point);
        }

        //Add current position to ptList
        public void AddPoint()
        {
            CContourPt point = new CContourPt(mf.pn.easting, mf.fixHeading, mf.pn.northing, (mf.pn.altitude - surveyHeight), mf.pn.latitude, mf.pn.longitude);
            ptList.Add(point);
        }

        //End the strip
        public void StopContourLine()
        {
            CContourPt point = new CContourPt(mf.pn.easting, mf.fixHeading, mf.pn.northing, (mf.pn.altitude - surveyHeight), mf.pn.latitude, mf.pn.longitude);
            ptList.Add(point);
            surveyHeight = 0;
            //turn it off
            isContourOn = false;

        }

        public void snapSurvey()
        {
            List<CContourPt> temp = new List<CContourPt>();
            int ptCnt = ptList.Count;
            int startPt = 0;
            int cnt = 0;
            int endPt = ptCnt - 1;

            double minDist = 0;
            int closestPoint = 0;
            int distToClosestPoint = 0;

            if (ptCnt > 0)
            {
                minDist = 8000;

                //find the closest point to current fix
                for (int t = 0; t < ptCnt - 1; t++)
                {
                    double dist = ((mf.pn.easting - ptList[t].easting) * (mf.pn.easting - ptList[t].easting))
                                    + ((mf.pn.northing - ptList[t].northing) * (mf.pn.northing - ptList[t].northing));
                    if (dist < minDist)
                    {
                        minDist = dist; closestPoint = t;
                    }

                }

            }

            double altitudeDifference = 0;

            altitudeDifference = mf.pn.altitude - ptList[closestPoint].altitude;

            for (int i = 0; i < ptCnt - 1; i++)
            {
                CContourPt point = new CContourPt(ptList[i].easting, ptList[i].heading,
                    ptList[i].northing, ptList[i].altitude + altitudeDifference, ptList[i].latitude, ptList[i].longitude,
                    ptList[i].cutAltitude + altitudeDifference, ptList[i].currentPassAltitude, ptList[i].lastPassAltitude,
                    ptList[i].distance);
                temp.Add(point);

            }
            ptList.Clear();
            ptList.AddRange(temp);




        }

        public void CheckSurveyDir()
        {

            List<CContourPt> temp = new List<CContourPt>();
            int ptCnt = ptList.Count;
            int startPt = 0;
            int cnt = 0;
            int endPt = ptCnt - 1;
            double startElev = ptList[startPt].altitude;
            double endElev = ptList[endPt].altitude;

            if (startElev < endElev && ptCnt > 0) // reverse the whole pt list
            {
                for (int i = ptCnt - 1; i > 0; i--)
                {
                    CContourPt point = new CContourPt(ptList[i].easting, ptList[i].heading,
                        ptList[i].northing, ptList[i].altitude, ptList[i].latitude, ptList[i].longitude,
                        ptList[i].cutAltitude, ptList[i].currentPassAltitude, ptList[i].lastPassAltitude,
                        ptList[i].distance);
                    temp.Add(point);

                }
                ptList.Clear();
                ptList.AddRange(temp);
            }

        }

        public void SaveToCut()
        {
            if (ptList.Count > 1)
            {
                int count = ptList.Count;
                for (int h = 0; h < count; h++)
                {
                    CCutPt point = new CCutPt(ptList[h].easting, ptList[h].heading, ptList[h].northing, ptList[h].altitude, ptList[h].latitude,
                        ptList[h].longitude, ptList[h].cutAltitude, ptList[h].currentPassAltitude, ptList[h].lastPassAltitude, ptList[h].distance);
                    cutList.Add(point);
                }
                //cutNum++;                
                mf.FileSaveCut();
            }
            cutList.Clear();

        }

        //determine distance from contour guidance line
        public void DistanceFromContourLine()
        {
            double minDistA = 1000000, minDistB = 1000000;
            int ptCount = ptList.Count;
            distanceFromCurrentLine = 9999;
            if (ptCount > 0)
            {
                //find the closest 2 points to current fix
                for (int t = 0; t < ptCount; t++)
                {
                    double dist = ((mf.pn.easting - ptList[t].easting) * (mf.pn.easting - ptList[t].easting))
                                    + ((mf.pn.northing - ptList[t].northing) * (mf.pn.northing - ptList[t].northing));
                    if (dist < minDistA)
                    {
                        minDistB = minDistA;
                        B = A;
                        minDistA = dist;
                        A = t;
                    }
                    else if (dist < minDistB)
                    {
                        minDistB = dist;
                        B = t;
                    }
                }

                //just need to make sure the points continue ascending or heading switches all over the place
                if (A > B) { C = A; A = B; B = C; }

                //get the distance from currently active AB line
                //x2-x1
                double dx = ptList[B].easting - ptList[A].easting;
                //z2-z1
                double dz = ptList[B].northing - ptList[A].northing;

                if (Math.Abs(dx) < Double.Epsilon && Math.Abs(dz) < Double.Epsilon) return;

                //abHeading = Math.Atan2(dz, dx);
                abHeading = ptList[A].heading;

                //how far from current AB Line is fix
                distanceFromCurrentLine = ((dz * mf.pn.easting) - (dx * mf.pn.northing)
                    + (ptList[B].easting * ptList[A].northing) - (ptList[B].northing * ptList[A].easting))
                                / Math.Sqrt((dz * dz) + (dx * dx));

                //are we on the right side or not
                isOnRightSideCurrentLine = distanceFromCurrentLine > 0;

                //absolute the distance
                distanceFromCurrentLine = Math.Abs(distanceFromCurrentLine);

                // ** Pure pursuit ** - calc point on ABLine closest to current position
                double U = (((mf.pn.easting - ptList[A].easting) * (dx))
                            + ((mf.pn.northing - ptList[A].northing) * (dz)))
                            / ((dx * dx) + (dz * dz));

                rEastCT = ptList[A].easting + (U * (dx));
                rNorthCT = ptList[A].northing + (U * (dz));

                //Subtract the two headings, if > 1.57 its going the opposite heading as refAB
                abFixHeadingDelta = (Math.Abs(mf.fixHeading - abHeading));
                if (abFixHeadingDelta >= Math.PI) abFixHeadingDelta = Math.Abs(abFixHeadingDelta - glm.twoPI);

                //used for accumulating distance to find goal point
                double distSoFar;

                //how far should goal point be away  - speed * seconds * kmph -> m/s + min value
                double goalPointDistance = mf.pn.speed * mf.vehicle.goalPointLookAhead * 0.27777777;

                //minimum of 4.0 meters look ahead
                if (goalPointDistance < 3.0) goalPointDistance = 3.0;

                // used for calculating the length squared of next segment.
                double tempDist = 0.0;

                if (abFixHeadingDelta >= glm.PIBy2)
                {
                    //counting down
                    isABSameAsFixHeading = false;
                    distSoFar = mf.pn.Distance(ptList[A].northing, ptList[A].easting, rNorthCT, rEastCT);
                    //Is this segment long enough to contain the full lookahead distance?
                    if (distSoFar > goalPointDistance)
                    {
                        //treat current segment like an AB Line
                        goalPointCT.easting = rEastCT - (Math.Sin(ptList[A].heading) * goalPointDistance);
                        goalPointCT.northing = rNorthCT - (Math.Cos(ptList[A].heading) * goalPointDistance);
                    }

                    //multiple segments required
                    else
                    {
                        //cycle thru segments and keep adding lengths. check if start and break if so.
                        while (A > 0)
                        {
                            B--; A--;
                            tempDist = mf.pn.Distance(ptList[B].northing, ptList[B].easting, ptList[A].northing, ptList[A].easting);

                            //will we go too far?
                            if ((tempDist + distSoFar) > goalPointDistance)
                            {
                                //A++; B++;
                                break; //tempDist contains the full length of next segment
                            }
                            else
                            {
                                distSoFar += tempDist;
                            }
                        }

                        double t = (goalPointDistance - distSoFar); // the remainder to yet travel
                        t /= tempDist;

                        goalPointCT.easting = (((1 - t) * ptList[B].easting) + (t * ptList[A].easting));
                        goalPointCT.northing = (((1 - t) * ptList[B].northing) + (t * ptList[A].northing));
                    }
                }
                else
                {
                    //counting up
                    isABSameAsFixHeading = true;
                    distSoFar = mf.pn.Distance(ptList[B].northing, ptList[B].easting, rNorthCT, rEastCT);

                    //Is this segment long enough to contain the full lookahead distance?
                    if (distSoFar > goalPointDistance)
                    {
                        //treat current segment like an AB Line
                        goalPointCT.easting = rEastCT + (Math.Sin(ptList[A].heading) * goalPointDistance);
                        goalPointCT.northing = rNorthCT + (Math.Cos(ptList[A].heading) * goalPointDistance);
                    }

                    //multiple segments required
                    else
                    {
                        //cycle thru segments and keep adding lengths. check if end and break if so.
                        // ReSharper disable once LoopVariableIsNeverChangedInsideLoop
                        while (B < ptCount - 1)
                        {
                            B++; A++;
                            tempDist = mf.pn.Distance(ptList[B].northing, ptList[B].easting, ptList[A].northing, ptList[A].easting);

                            //will we go too far?
                            if ((tempDist + distSoFar) > goalPointDistance)
                            {
                                //A--; B--;
                                break; //tempDist contains the full length of next segment
                            }

                            distSoFar += tempDist;
                        }

                        //xt = (((1 - t) * x0 + t * x1)
                        //yt = ((1 - t) * y0 + t * y1))

                        double t = (goalPointDistance - distSoFar); // the remainder to yet travel
                        t /= tempDist;

                        goalPointCT.easting = (((1 - t) * ptList[A].easting) + (t * ptList[B].easting));
                        goalPointCT.northing = (((1 - t) * ptList[A].northing) + (t * ptList[B].northing));
                    }
                }

                //calc "D" the distance from pivot axle to lookahead point
                double goalPointDistanceSquared = mf.pn.DistanceSquared(goalPointCT.northing, goalPointCT.easting, mf.pn.northing, mf.pn.easting);

                //calculate the the delta x in local coordinates and steering angle degrees based on wheelbase
                double localHeading = glm.twoPI - mf.fixHeading;
                ppRadiusCT = goalPointDistanceSquared / (2 * (((goalPointCT.easting - mf.pn.easting) * Math.Cos(localHeading)) + ((goalPointCT.northing - mf.pn.northing) * Math.Sin(localHeading))));

                steerAngleCT = glm.toDegrees(Math.Atan(2 * (((goalPointCT.easting - mf.pn.easting) * Math.Cos(localHeading))
                    + ((goalPointCT.easting - mf.pn.northing) * Math.Sin(localHeading))) * mf.vehicle.wheelbase / goalPointDistanceSquared));

                if (steerAngleCT < -mf.vehicle.maxSteerAngle) steerAngleCT = -mf.vehicle.maxSteerAngle;
                if (steerAngleCT > mf.vehicle.maxSteerAngle) steerAngleCT = mf.vehicle.maxSteerAngle;

                if (ppRadiusCT < -500) ppRadiusCT = -500;
                if (ppRadiusCT > 500) ppRadiusCT = 500;

                goalPointCT.easting = mf.pn.easting + (ppRadiusCT * Math.Cos(localHeading));
                goalPointCT.northing = mf.pn.northing + (ppRadiusCT * Math.Sin(localHeading));

                //angular velocity in rads/sec  = 2PI * m/sec * radians/meters
                double angVel = glm.twoPI * 0.277777 * mf.pn.speed * (Math.Tan(glm.toRadians(steerAngleCT))) / mf.vehicle.wheelbase;

                //clamp the steering angle to not exceed safe angular velocity
                if (Math.Abs(angVel) > mf.vehicle.maxAngularVelocity)
                {
                    steerAngleCT = glm.toDegrees(steerAngleCT > 0 ?
                            (Math.Atan((mf.vehicle.wheelbase * mf.vehicle.maxAngularVelocity) / (glm.twoPI * mf.pn.speed * 0.277777)))
                        : (Math.Atan((mf.vehicle.wheelbase * -mf.vehicle.maxAngularVelocity) / (glm.twoPI * mf.pn.speed * 0.277777))));
                }
                //Convert to centimeters
                distanceFromCurrentLine = Math.Round(distanceFromCurrentLine * 1000.0, MidpointRounding.AwayFromZero);

                //distance is negative if on left, positive if on right
                //if you're going the opposite direction left is right and right is left
                //double temp;
                if (isABSameAsFixHeading)
                {
                    //temp = (abHeading);
                    if (!isOnRightSideCurrentLine) distanceFromCurrentLine *= -1.0;
                }

                //opposite way so right is left
                else
                {
                    //temp = (abHeading - Math.PI);
                    //if (temp < 0) temp = (temp + glm.twoPI);
                    //temp = glm.toDegrees(temp);
                    if (isOnRightSideCurrentLine) distanceFromCurrentLine *= -1.0;
                }

                mf.guidanceLineDistanceOff = (Int16)distanceFromCurrentLine;
                mf.guidanceLineSteerAngle = (Int16)(steerAngleCT * 10);
                //mf.guidanceLineHeadingDelta = (Int16)((Math.Atan2(Math.Sin(temp - mf.fixHeading),
                //                                    Math.Cos(temp - mf.fixHeading))) * 10000);
            }
            else
            {
                //invalid distance so tell AS module
                distanceFromCurrentLine = 32000;
                mf.guidanceLineDistanceOff = 32000;
            }
        }




        public void clearPTList()
        {

            int cnnt = ptList.Count;
            if (cnnt > 0)
            {
                for (int i = 0; i < cnnt; i++) ptList[i].lastPassAltitude = -1;
            }
            if (cnnt > 0)
            {
                for (int i = 0; i < cnnt; i++) ptList[i].currentPassAltitude = -1;
            }





        }







        //########################################## 2D ###########################################################





        public void DrawContourLine()
        {
            //gl.Color(0.98f, 0.98f, 0.50f);
            //gl.Begin(OpenGL.GL_LINE_STRIP);
            ////for (int h = 0; h < ptCount; h++) gl.Vertex(guideList[h].x, 0, guideList[h].z);
            //gl.Vertex(boxA.easting, boxA.northing, 0);
            //gl.Vertex(boxB.easting, boxB.northing, 0);
            //gl.Vertex(boxC.easting, boxC.northing, 0);
            //gl.Vertex(boxD.easting, boxD.northing, 0);
            //gl.Vertex(boxA.easting, boxA.northing, 0);
            //gl.End();

            DrawShoreLines();
            //GetBladeEndUTM();


            ////draw the guidance line
            int ptCount = ptList.Count;
            gl.LineWidth(3);
            gl.Color(0.30f, 0.31f, 0.77f);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            for (int h = 0; h < ptCount; h++) gl.Vertex(ptList[h].easting, ptList[h].northing, 0);
            gl.End();

            gl.PointSize(4.0f);
            gl.Begin(OpenGL.GL_POINTS);

            gl.Color(0.30f, 0.31f, 0.77f);
            for (int h = 0; h < ptCount; h++) gl.Vertex(ptList[h].easting, ptList[h].northing, 0);

            gl.End();
            gl.PointSize(1.0f);

            //draw the reference line
            gl.PointSize(3.0f);
            //if (isContourBtnOn)
            {
                ptCount = ptList.Count;
                if (ptCount > 0)
                {
                    gl.Begin(OpenGL.GL_POINTS);
                    for (int i = 0; i < ptCount; i++)
                    {
                        gl.Vertex(ptList[i].easting, ptList[i].northing, 0);
                    }
                    gl.End();
                }
            }

            if (mf.isAutoShoreOn)
            {
                gl.LineWidth(2);
                gl.Color(0.98f, 0.2f, 0.0f);
                gl.Begin(OpenGL.GL_LINE_STRIP);
                for (int h = 0; h < ptCount; h++) gl.Vertex(ptList[h].easting + 10, ptList[h].northing + 50, 0);
                gl.End();

                gl.PointSize(4.0f);
                gl.Begin(OpenGL.GL_POINTS);

                gl.Color(0.97f, 0.42f, 0.45f);
                for (int h = 0; h < ptCount; h++) gl.Vertex(ptList[h].easting + 10, ptList[h].northing + 50, 0);

                gl.End();
                gl.PointSize(1.0f);

                //draw the reference line
                gl.PointSize(3.0f);
                //if (isContourBtnOn)
                {
                    ptCount = ptList.Count;
                    if (ptCount > 0)
                    {
                        gl.Begin(OpenGL.GL_POINTS);
                        for (int i = 0; i < ptCount; i++)
                        {
                            gl.Vertex(ptList[i].easting, ptList[i].northing, 0);
                        }
                        gl.End();
                    }
                }




            }

            if (true)//mf.isPureDisplayOn
            {
                const int numSegments = 100;
                {
                    gl.Color(0.95f, 0.30f, 0.950f);

                    double theta = glm.twoPI / (numSegments);
                    double c = Math.Cos(theta);//precalculate the sine and cosine
                    double s = Math.Sin(theta);

                    double x = ppRadiusCT;//we start at angle = 0
                    double y = 0;

                    gl.LineWidth(1);
                    gl.Begin(OpenGL.GL_LINE_LOOP);
                    for (int ii = 0; ii < numSegments; ii++)
                    {
                        //glVertex2f(x + cx, y + cy);//output vertex
                        gl.Vertex(x + radiusPointCT.easting, y + radiusPointCT.northing);//output vertex

                        //apply the rotation matrix
                        double t = x;
                        x = (c * x) - (s * y);
                        y = (s * t) + (c * y);
                    }
                    gl.End();

                    //Draw lookahead Point
                    gl.PointSize(4.0f);
                    gl.Begin(OpenGL.GL_POINTS);

                    //
                    //gl.Vertex(rEast, rNorth, 0.0);

                    //gl.Color(1.0f, 0.5f, 0.95f);
                    gl.Color(1.0f, 1.0f, 0.25f);
                    gl.Vertex(goalPointCT.easting, goalPointCT.northing, 0.0);

                    //mf.lblGoalEasting.Text = goalPointCT.easting.ToString();
                    // mf.lblGoalNorthing.Text = goalPointCT.easting.ToString();

                    gl.End();
                    gl.PointSize(1.0f);
                }
            }
        }

        public void DrawShoreLines()
        {

            ////draw the guidance line
            int ptCount = ptList.Count;
            double diff, y, shoreDist;


            if (mf.isAutoShoreOn)
            {
                gl.LineWidth(4);
                gl.Color(0.01f, 0.7f, 0.01f);
                gl.Begin(OpenGL.GL_LINE_STRIP);
                for (int h = 0; h < ptCount; h++)
                {
                    if (ptList[h].cutAltitude != -1)
                    {
                        diff = (ptList[h].cutAltitude * 100) - (ptList[h].altitude * 100);
                        shoreDist = (diff / Math.Tan(glm.toRadians(mf.vehicle.minShoreSlope)));
                        gl.Vertex(ptList[h].easting + (shoreDist / 100), ptList[h].northing, 0);
                    }


                }
                gl.End();
                gl.LineWidth(4);
                gl.Color(0.01f, 0.7f, 0.01f);
                gl.Begin(OpenGL.GL_LINE_STRIP);
                for (int h = 0; h < ptCount; h++)
                {
                    if (ptList[h].cutAltitude != -1)
                    {
                        diff = (ptList[h].cutAltitude * 100) - (ptList[h].altitude * 100);
                        //if (diff > 50 || diff > -50) diff = 0;
                        shoreDist = (diff / Math.Tan(glm.toRadians(mf.vehicle.minShoreSlope)));
                        gl.Vertex(ptList[h].easting - (shoreDist / 100), ptList[h].northing, 0);

                    }
                }
                gl.End();
            }


        }

        public void AutoDrain()
        {

            vec2 temp = new vec2();

            double distFromLastPlot = 0;
            double minPtDist = 1;
            int drawPts;
            int ptCnt = ptList.Count;
            double minDeltaHt = 0;
            double angle = -mf.vehicle.minSlope * 180;
            int startPt = 0;
            int endPt = -1;
            int lowestPt = 0;
            int lastPt = 0;
            int upCnt = 0;
            bool startFound = false;
            //int maxCnt = 6;
            //int MaxSearch = 30;

            this.drawList.Clear();
            // Find first point
            if (true)  // Add if Find First low Later
            {
                for (int k = 1; k < ptCnt; k++)
                {

                    if (!startFound)
                    {
                        if (ptList[k].altitude <= ptList[k - 1].altitude)
                        {
                            lowestPt = k;
                        }
                        else
                        {
                            upCnt++;
                        }

                        if (upCnt == 2)
                        {
                            startPt = lowestPt;
                            startFound = true;
                            break;
                        }
                    }


                    if (ptList[k].altitude <= ptList[k - 1].altitude)
                    {
                        lowestPt = k;
                    }
                }
                endPt = lowestPt;
            }
            else
            {
                startPt = 5;
                lowestPt = ptCnt - 5;
            }


            switch (mf.curMode)
            {
                case FormGPS.gradeMode.surface:

                    for (int i = startPt; i < ptCnt; i++)
                    {
                        // check to see if drawlist has any points 
                        drawPts = drawList.Count;

                        if (drawPts > 0)
                        {
                            //calculate the distance from point i to last tempPt
                            for (int h = (int)drawList[drawPts - 1].easting; h < i; h++)  // calculate distance from last point if first point is set
                            {
                                distFromLastPlot += ptList[h].distance;  // add distance all distances from lastPt to hPt 
                            }
                        }
                        else
                        {
                            // add first point
                            temp.easting = i;
                            temp.northing = ((double)ptList[i].altitude);
                            drawList.Add(temp);
                            drawPts = drawList.Count;
                        }

                        minDeltaHt = (Math.Tan((angle * (Math.PI / 180))) * distFromLastPlot);     // distFromLastPlot                      

                        temp.easting = i;
                        temp.northing = ((double)ptList[i].altitude);

                        if (ptList[i].altitude < drawList[drawPts - 1].northing + minDeltaHt)
                        {

                            if (distFromLastPlot > minPtDist)
                            {
                                drawList.Add(temp);
                                lastPt = i;
                            }

                        }
                        distFromLastPlot = 0;
                        //endPt = drawPts - 1;
                    }
                    break;


                case FormGPS.gradeMode.ditch:

                    for (int i = startPt; i < ptCnt; i++)
                    {
                        // check to see if drawlist has any points 
                        drawPts = drawList.Count;

                        if (drawPts > 0)
                        {
                            //calculate the distance from point i to last tempPt
                            for (int h = (int)drawList[drawPts - 1].easting; h < i; h++)  // calculate distance from last point if first point is set
                            {
                                distFromLastPlot += ptList[h].distance;  // add distance all distances from lastPt to hPt 
                            }

                        }
                        else
                        {
                            // add first point
                            temp.easting = i;   // (double)ptList[i].easting;                            
                            temp.northing = ((double)ptList[i].altitude);
                            drawList.Add(temp);
                            drawPts = drawList.Count;
                            lastPt = i;

                        }

                        minDeltaHt = (Math.Tan((angle * (Math.PI / 180))) * distFromLastPlot);     // distFromLastPlot                      

                        if (minDeltaHt != 0)
                        {
                            temp.easting = i;  // proposed point number
                            temp.northing = ((double)ptList[i].altitude) - mf.vehicle.minDitchCut;  // proposed altitude
                        }

                        if (temp.northing <= (drawList[drawPts - 1].northing + minDeltaHt))
                        {
                            if (distFromLastPlot > minPtDist)
                            {
                                drawList.Add(temp);
                                lastPt = i;
                            }
                        }

                        distFromLastPlot = 0;
                        endPt = i;
                    }
                    break;

                case FormGPS.gradeMode.tile:

                    for (int i = startPt; i < ptCnt; i++)
                    {
                        // check to see if drawlist has any points 
                        drawPts = drawList.Count;

                        if (drawPts > 0)
                        {
                            //calculate the distance from point i to last tempPt
                            for (int h = (int)drawList[drawPts - 1].easting; h < i; h++)  // calculate distance from last point if first point is set
                            {
                                distFromLastPlot += ptList[h].distance;  // add distance all distances from lastPt to hPt 
                            }
                        }
                        else
                        {
                            // add first point
                            temp.easting = i;   // (double)ptList[i].easting;                            
                            temp.northing = ((double)ptList[i].altitude) - mf.vehicle.minTileCover;
                            drawList.Add(temp);
                            drawPts = drawList.Count;
                        }
                        //calculate min Delta
                        minDeltaHt = (Math.Tan((angle * (Math.PI / 180))) * distFromLastPlot);     // distFromLastPlot        

                        // set temp point and altitude
                        temp.easting = i;
                        temp.northing = ((double)ptList[i].altitude) - mf.vehicle.minTileCover;


                        if (temp.northing <= (drawList[drawPts - 1].northing + minDeltaHt))
                        {
                            if (distFromLastPlot > minPtDist)
                            {
                                drawList.Add(temp);
                                lastPt = i;
                            }
                        }

                        distFromLastPlot = 0;
                        endPt = i;
                    }
                    break;

                default:



                    break;

            }
        }

        public class SimpleMovingAverage
        {
            private readonly int _k;
            private double[] _values;

            private int _index = 0;
            private double _sum = 0;

            public SimpleMovingAverage(int k, double val)
            {
                if (k <= 0) throw new ArgumentOutOfRangeException(nameof(k), "Must be greater than 0");

                _k = k;
                _values = new double[k];


            }

            public double Update(double nextInput)
            {
                // calculate the new sum
                _sum = _sum - _values[_index] + nextInput;

                // overwrite the old value with the new one
                _values[_index] = nextInput;

                // increment the index (wrapping back to 0)
                _index = (_index + 1) % _k;

                // calculate the average
                return ((double)_sum) / _k;

            }
        }

        public void SmoothLine(int times)
        {

            int ptCnt = ptList.Count;
            var movingAvg = new SimpleMovingAverage(times, ptList[0].altitude);
            vec2 Temp = new vec2();
            autoList.Clear();


            for (int j = 0; j < times - 1; j++)
            {
                movingAvg.Update(ptList[0].altitude);
            }

            for (int k = 0; k < ptCnt; k++)
            {
                double sma = movingAvg.Update(ptList[k].altitude);


                Temp.easting = k;
                Temp.northing = sma;
                autoList.Add(Temp);


                //ptList[k].altitude = sma;

            }




        }

        private bool CheckMaxCut()
        {
            int ptCnt = ptList.Count;
            bool isOverMax = false;

            switch (mf.curMode)
            {
                case FormGPS.gradeMode.surface:
                    break;

                case FormGPS.gradeMode.ditch:

                    for (int i = 0; i < ptCnt - 1; i++)
                    {
                        if (ptList[i].cutAltitude < (ptList[i].altitude - mf.vehicle.maxDitchCut))//
                        {
                            string message = "Cut Plane exceeds maximum cut depth \n Increase Max Ditch Cut or Re-survey";
                            string title = "Maxiumum Exceeded";
                            mf.TimedMessageBox(1000, message, title);
                            isOverMax = true;
                            break;
                        }
                    }
                    break;

                case FormGPS.gradeMode.tile:

                    for (int i = 0; i < ptCnt - 1; i++)
                    {
                        if (ptList[i].cutAltitude < (ptList[i].altitude - mf.vehicle.maxTileCut))
                        {
                            string message = "Cut Plane exceeds maximum cut depth \n Increase Max Tile Cut or Re-survey";
                            string title = "Maxiumum Exceeded";
                            mf.TimedMessageBox(1000, message, title);
                            isOverMax = true;
                            break;
                        }
                        else if (ptList[i].cutAltitude > (ptList[i].altitude - mf.vehicle.minTileCover))
                        {
                            string message = "Cut Plane exceeds minimum cover depth \n Increase min cover Cut or Re-survey";
                            string title = "Minumum Exceeded";
                            mf.TimedMessageBox(1000, message, title);
                            isOverMax = true;
                            break;

                        }
                    }
                    break;

                default:

                    break;


            }
            return isOverMax;
        }


        private void radiusTile()
        {
            int x0 = 0;
            int y0 = 0;
            int x1 = 0;
            int y1 = 0;
            int x2 = 0;
            int y2 = 0;


            int r = (int)Math.Sqrt((x1 - x0) * (x1 - x0) + (y1 - y0) * (y1 - y0));

            int x = x0 - r;
            int y = y0 - r;
            int width = 2 * r;
            int height = 2 * r;
            int startAngle = (int)(180 / Math.PI * Math.Atan2(y1 - y0, x1 - x0));
            int endAngle = (int)(180 / Math.PI * Math.Atan2(y2 - y0, x2 - x0));
            //
            //graphics.drawArc(x, y, width, height, startAngle, endAngle);


        }
        //Reset the contour to zip
        public void ResetContour()
        {
            if (ptList != null) ptList.Clear();
        }



        public double averageDualHead(double head1, double head2)
        {
            double avg = (head1 + head2) / 2;
            return avg;
        }

        public void GetBladeEndUTM()
        {


            double halfToolWidth = (Properties.Vehicle.Default.setVehicle_toolWidth) / 2;


            // translate the survey pt to the side of the tool
            double sideEasting;
            double sideNorthing;

            if (isBoundarySideRight)
            {
                sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
                sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
            }
            else
            {
                sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * halfToolWidth;
                sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * halfToolWidth;
            }

            //check dist from last point 

            double surveyDistance = ((nearestSurveyEasting - sideEasting) * (nearestSurveyEasting - sideEasting) +
            (nearestSurveyNorthing - sideNorthing) * (nearestSurveyNorthing - sideNorthing));

            if (surveyDistance > 9)
            {
                // convert the utm from the side of the blade to lat long
                double actualEasting = sideEasting + mf.pn.utmEast;
                double actualNorthing = sideNorthing + mf.pn.utmNorth;

                mf.UTMToLatLon(actualEasting, actualNorthing);

                SurveyPt point = new SurveyPt(sideEasting, sideNorthing, mf.utmLat, mf.utmLon, mf.pn.altitude, 2, mf.pn.fixQuality);
                surveyList.Add(point);

                nearestSurveyEasting = mf.pn.easting;
                nearestSurveyNorthing = mf.pn.northing;

            }

        } 



        public void RecordBoundary()
        {

            if (recBoundary)
            {
                double halfToolWidth = (Properties.Vehicle.Default.setVehicle_toolWidth) / 2;

                if (isBtnStartPause)
                {
                    // translate the survey pt to the side of the tool

                    double sideEasting;
                    double sideNorthing;

                    if (isBoundarySideRight)
                    {
                        sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
                        sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
                    }
                    else
                    {
                        sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * halfToolWidth;
                        sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * halfToolWidth;
                    }

                    //check dist from last point 

                    double surveyDistance = ((nearestSurveyEasting - sideEasting) * (nearestSurveyEasting - sideEasting) +
                    (nearestSurveyNorthing - sideNorthing) * (nearestSurveyNorthing - sideNorthing));

                    if (surveyDistance > 9)
                    {
                        // convert the utm from the side of the blade to lat long
                        double actualEasting = sideEasting + mf.pn.utmEast;
                        double actualNorthing = sideNorthing + mf.pn.utmNorth;

                        mf.UTMToLatLon(actualEasting, actualNorthing);

                        SurveyPt point = new SurveyPt(sideEasting, sideNorthing, mf.utmLat, mf.utmLon, mf.pn.altitude, 2, mf.pn.fixQuality);
                        surveyList.Add(point);

                        nearestSurveyEasting = mf.pn.easting;
                        nearestSurveyNorthing = mf.pn.northing;

                    }

                }

            }


        }




        //########################################## 3D ###########################################################


        public void DrawContourLine3D(int num)
        {





        }



        public void DrawContourLine3D()
        {

            //#region Survey ----------------------------------------------------------------------------------------------------------------
            //mf.textBox1.Text = "BM_REC";
            if (isSurveyOn)
            {
                double halfToolWidth2 = (Properties.Vehicle.Default.setVehicle_toolWidth) / 2;
                //mf.textBox1.Text = "SURVEY_1";
                if (clearSurveyList)
                {
                    surveyList.Clear();
                    clearSurveyList = false;
                    //mf.textBox1.Text = "SURVEY_CLEAR";
                }

                // Check the fix Quality before saving the point


                //if (mf.pn.fixQuality == 4 | mf.pn.fixQuality == 8) isOKtoSurvey = true;
                //else if (mf.pn.fixQuality == 5 && FloatIsOK) isOKtoSurvey = true;
               
                //else isOKtoSurvey = false;

                if (isOKtoSurvey)
                {
                    //mf.textBox1.Text = "SURVEY_OKAY_1";
                    
                    if (markBM)
                    {
                        //mf.textBox1.Text = "BM_REC";

                        SurveyPt point = new SurveyPt(mf.pn.easting, mf.pn.northing, mf.pn.latitude, mf.pn.longitude, mf.pn.altitude, 0, mf.pn.fixQuality);
                        surveyList.Add(point);

                        nearestSurveyEasting = mf.pn.easting;
                        nearestSurveyNorthing = mf.pn.northing;

                        markBM = false;
                        recBoundary = true;

                    }

                    // Start recording contour

                    if (recBoundary)
                    {
                        //mf.textBox1.Text = "BND_REC";
                        //

                        if (isBtnStartPause)
                        {
                            // translate the survey pt to the side of the tool

                            double sideEasting;
                            double sideNorthing;

                            if (isBoundarySideRight)
                            {
                                sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * -halfToolWidth2;
                                sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * -halfToolWidth2;
                            }
                            else
                            {
                                sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * halfToolWidth2;
                                sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * halfToolWidth2;
                            }

                            //check dist from last point 

                            double surveyDistance = ((nearestSurveyEasting - sideEasting) * (nearestSurveyEasting - sideEasting) +
                            (nearestSurveyNorthing - sideNorthing) * (nearestSurveyNorthing - sideNorthing));

                            if (surveyDistance > 9)
                            {
                                // convert the utm from the side of the blade to lat long
                                double actualEasting = sideEasting + mf.pn.utmEast;
                                double actualNorthing = sideNorthing + mf.pn.utmNorth;

                                mf.UTMToLatLon(actualEasting, actualNorthing);

                                SurveyPt point = new SurveyPt(sideEasting, sideNorthing, mf.utmLat, mf.utmLon, mf.pn.altitude, 2, mf.pn.fixQuality);
                                surveyList.Add(point);

                                nearestSurveyEasting = mf.pn.easting;
                                nearestSurveyNorthing = mf.pn.northing;

                            }

                        }

                    }

                    if (recSurveyPt)
                    {
                        if (isBtnStartPause)
                        {
                            // check for the nearest point in the surveyList
                           // mf.textBox1.Text = "SRVY_REC";
                            int surveyCount = surveyList.Count;
                            double minSurveyDistance = 1000000;

                            for (int i = 0; i < surveyCount; i++)
                            {
                                double surveyDistance = ((surveyList[i].easting - mf.pn.easting) * (surveyList[i].easting - mf.pn.easting) +
                                    (surveyList[i].northing - mf.pn.northing) * (surveyList[i].northing - mf.pn.northing));

                                if (surveyDistance < minSurveyDistance) minSurveyDistance = surveyDistance;
                            }

                            // if there is no point 3 metre around add a point
                            if (minSurveyDistance > 9)
                            {
                                SurveyPt point = new SurveyPt(mf.pn.easting, mf.pn.northing, mf.pn.latitude, mf.pn.longitude, mf.pn.altitude, 3, mf.pn.fixQuality);
                                surveyList.Add(point);

                                nearestSurveyEasting = mf.pn.easting;
                                nearestSurveyNorthing = mf.pn.northing;

                            }

                        }


                    }

                }

            }
            else
            {
                // finish the survey
                if (recSurveyPt)
                {
                   // mf.textBox1.Text = "SRVY_DONE";
                    mf.FileSaveSurveyPt();

                    recSurveyPt = false;
                }
            }

            //int ptCount = surveyList.Count;
            //gl.LineWidth(2);
            //gl.Color(0.98f, 0.2f, 0.0f);
            //gl.Begin(OpenGL.GL_LINE_STRIP);
            //for (int h = 0; h < ptCount; h++)
            //{
            //    if (surveyList[h].code == 2)
            //        gl.Vertex(surveyList[h].easting, surveyList[h].northing, 0);

            //}
            //gl.End();


            if (surveyMode)
            {
                int ptCount = surveyList.Count;
                //mf.textBox1.Text = ptCount.ToString();
                if (ptCount > 0)
                {
                    gl.PointSize(4.0f);
                    gl.Begin(OpenGL.GL_POINTS);

                    gl.Color(0.97f, 0.42f, 0.80f);
                    for (int h = 0; h < ptCount; h++)
                    {
                        gl.Color(0.97f, 0.42f, 0.80f);

                        if (surveyList[h].code == 0) gl.Color(0.97f, 0.82f, 0.95f);
                        if (surveyList[h].code == 2) gl.Color(0.5f, 0.82f, 0.95f);

                        gl.Vertex(surveyList[h].easting, surveyList[h].northing, 0);

                    }

                    gl.End();
                }

                //Draw a contour line




                gl.LineWidth(2);
                gl.Color(0.98f, 0.2f, 0.0f);
                gl.Begin(OpenGL.GL_LINE_STRIP);
                for (int h = 0; h < ptCount; h++)
                {
                    //if (surveyList[h].code == 2)
                        gl.Vertex(surveyList[h].easting, surveyList[h].northing, 0);

                }
                gl.End();


            }
            else
            {



                //now paint the map, by Pat
                int ptCount = mapList.Count;
                if (maxAltitude == -9999 | minAltitude == 9999 | maxCut == -9999 | maxFill == 9999) drawTheMap = true;

                if (ptCount > 0)
                {


                    if (drawTheMap)
                    {
                        // Search for the max min painting values


                        maxAltitude = -9999; minAltitude = 9999; maxCut = 0; maxFill = 0;
                        for (int h = 0; h < ptCount; h++)
                        {
                            if (mapList[h].cutAltitudeMap != -1)
                            {
                                if (mapList[h].cutAltitudeMap < minAltitude) minAltitude = mapList[h].cutAltitudeMap;
                            }

                            if (mapList[h].cutAltitudeMap > maxAltitude) maxAltitude = mapList[h].cutAltitudeMap;

                            if (mapList[h].cutDeltaMap < maxCut) maxCut = mapList[h].cutDeltaMap;

                            if (mapList[h].cutDeltaMap != 9999)
                            {
                                if (mapList[h].cutDeltaMap > maxFill) maxFill = mapList[h].cutDeltaMap;
                            }
                        }

                        //if (maxCut == 9999) maxCut = 0;
                        //if (maxFill == -9999) maxFill = 0;

                        midAltitude = ((maxAltitude + minAltitude) / 2);

                        // to not mess up with colors when min and max altutudes are to close
                        if ((maxAltitude - minAltitude) < 0.1)
                        {
                            maxAltitude = midAltitude + 0.05;
                            minAltitude = midAltitude - 0.05;
                        }

                        //mf.fillCutFillLbl();
                    }
                    // begin painting

                    double red = 0, green = 0, blue = 0;
                    double drawPtWidth;
                    double easting;
                    double northing;

                    //set the width of painting

                    double zoom = mf.zoomValue;
                    double camPitch = mf.camera.camPitch;

                    if (camPitch > -20) camPitch = -20;

                    double paintEastingMax = mf.pn.easting + zoom * -camPitch / 2;
                    double paintEastingMin = mf.pn.easting - zoom * -camPitch / 2;
                    double paintNorthingMax = mf.pn.northing + zoom * -camPitch / 2;
                    double paintNorthingMin = mf.pn.northing - zoom * -camPitch / 2;

                    gl.Begin(OpenGL.GL_QUADS);

                    for (int h = 0; h < ptCount; h++)
                    {
                        if (mapList[h].eastingMap < paintEastingMax && mapList[h].eastingMap > paintEastingMin && mapList[h].northingMap < paintNorthingMax && mapList[h].northingMap > paintNorthingMin)
                        {


                            // paint the cut fill value
                            if (!isElevation)
                            {


                                if (mapList[h].cutDeltaMap != 9999)
                                {
                                    if (mapList[h].cutDeltaMap == 0)
                                    {
                                        red = mf.redCenter;
                                        green = mf.redCenter;
                                        blue = mf.bluCenter;
                                    }
                                    else if (isActualCut && mapList[h].lastPassRealAltitudeMap > 0 && mapList[h].cutDeltaMap > 0)
                                    {
                                        double toCut = mapList[h].lastPassRealAltitudeMap - mapList[h].cutAltitudeMap;

                                        red = (1 + (toCut / maxCut)) * mf.redCenter + -(toCut / maxCut) * mf.redCut;
                                        green = (1 + (toCut / maxCut)) * mf.grnCenter + -(toCut / maxCut) * mf.grnCut;
                                        blue = (1 + (toCut / maxCut)) * mf.bluCenter + -(toCut / maxCut) * mf.bluCut;
                                    }
                                    else if (isActualFill && mapList[h].lastPassRealAltitudeMap > 0)
                                    {
                                        double toCut = mapList[h].lastPassRealAltitudeMap - mapList[h].cutAltitudeMap;

                                        red = (1 + (toCut / maxCut)) * mf.redCenter + -(toCut / maxCut) * mf.redCut;
                                        green = (1 + (toCut / maxCut)) * mf.grnCenter + -(toCut / maxCut) * mf.grnCut;
                                        blue = (1 + (toCut / maxCut)) * mf.bluCenter + -(toCut / maxCut) * mf.bluCut;
                                    }
                                    else
                                    {
                                        //to fill

                                        if (mapList[h].cutDeltaMap > 0)
                                        {
                                            red = (1 - (mapList[h].cutDeltaMap / maxFill)) * mf.redCenter + (mapList[h].cutDeltaMap / maxFill) * mf.redFill;
                                            green = (1 - (mapList[h].cutDeltaMap / maxFill)) * mf.grnCenter + (mapList[h].cutDeltaMap / maxFill) * mf.grnFill;
                                            blue = (1 - (mapList[h].cutDeltaMap / maxFill)) * mf.bluCenter + (mapList[h].cutDeltaMap / maxFill) * mf.bluFill;
                                        }
                                        //to cut


                                        if (mapList[h].cutDeltaMap < 0)
                                        {
                                            red = (1 - (mapList[h].cutDeltaMap / maxCut)) * mf.redCenter + (mapList[h].cutDeltaMap / maxCut) * mf.redCut;
                                            green = (1 - (mapList[h].cutDeltaMap / maxCut)) * mf.grnCenter + (mapList[h].cutDeltaMap / maxCut) * mf.grnCut;
                                            blue = (1 - (mapList[h].cutDeltaMap / maxCut)) * mf.bluCenter + (mapList[h].cutDeltaMap / maxCut) * mf.bluCut;
                                        }
                                    }

                                }
                                else
                                {
                                    red = 0;
                                    green = 0;
                                    blue = 0;
                                }



                            }
                            else
                            // paint the desired altutude
                            {
                                if (isExistingElevation)
                                {
                                    if (mapList[h].altitudeMap > 0)
                                    {
                                        if (mapList[h].altitudeMap == midAltitude)
                                        {
                                            red = mf.redCenter;
                                            green = mf.redCenter;
                                            blue = mf.bluCenter;
                                        }

                                        if (mapList[h].altitudeMap < midAltitude)
                                        {
                                            red = (1 - (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.redCenter + (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.redFill;
                                            green = (1 - (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.grnCenter + (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.grnFill;
                                            blue = (1 - (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.bluCenter + (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.bluFill;
                                        }

                                        if (mapList[h].altitudeMap > midAltitude)
                                        {
                                            red = (1 - (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.redCenter + (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.redCut;
                                            green = (1 - (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.grnCenter + (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.grnCut;
                                            blue = (1 - (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.bluCenter + (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.bluCut;
                                        }

                                    }
                                    else
                                    {
                                        red = 0;
                                        green = 0;
                                        blue = 0;
                                    }
                                }
                                else
                                {


                                    if (mapList[h].cutAltitudeMap != -1)
                                    {
                                        if (mapList[h].cutAltitudeMap == midAltitude)
                                        {
                                            red = mf.redCenter;
                                            green = mf.redCenter;
                                            blue = mf.bluCenter;
                                        }

                                        if (mapList[h].cutAltitudeMap < midAltitude)
                                        {
                                            red = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.redCenter + (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.redFill;
                                            green = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.grnCenter + (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.grnFill;
                                            blue = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.bluCenter + (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.bluFill;
                                        }

                                        if (mapList[h].cutAltitudeMap > midAltitude)
                                        {
                                            red = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.redCenter + (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.redCut;
                                            green = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.grnCenter + (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.grnCut;
                                            blue = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.bluCenter + (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.bluCut;
                                        }
                                    }
                                    else
                                    {
                                        red = 0;
                                        green = 0;
                                        blue = 0;
                                    }
                                }

                            }
                            if (red < 0) red = 0;
                            if (red > 255) red = 255;
                            if (green < 0) green = 0;
                            if (green > 255) green = 255;
                            if (blue < 0) blue = 0;
                            if (blue > 255) blue = 255;

                            gl.Color((byte)red, (byte)green, (byte)blue);

                            /*/test
                            if (mapList[h].cutDeltaMap != 9999)
                            {
                                if (mapList[h].cutDeltaMap == 0)
                                    gl.Color(0.75f, 0.75f, 0.75f);

                                if (mapList[h].cutDeltaMap < 0)
                                    gl.Color(.35f, 0.75f, .35f);

                                if (mapList[h].cutDeltaMap > 0)
                                    gl.Color(0.75f, .35f, .35f);

                            }
                            else gl.Color(0.0f, 0.0f, 0.0f);
                            *///end test

                            drawPtWidth = (mapList[h].drawPtWidthMap / 2);
                            easting = mapList[h].eastingMap;
                            northing = mapList[h].northingMap;


                            gl.Vertex(easting - drawPtWidth, northing - drawPtWidth, 0);
                            gl.Vertex(easting - drawPtWidth, northing + drawPtWidth, 0);
                            gl.Vertex(easting + drawPtWidth, northing + drawPtWidth, 0);
                            gl.Vertex(easting + drawPtWidth, northing - drawPtWidth, 0);
                        }
                    }

                    gl.End();
                }
                drawTheMap = false;


                // Paint the elevation view line and Look Ahead Lines 

                if (isOpenGLControlBackVisible)
                {

                    if (eleViewList.Count > 10)
                    {



                        gl.LineWidth(5);
                        //gl.Color(Color.Blue);
                        gl.Color(0.01f, 0.01f, 0.99f);
                        gl.Begin(OpenGL.GL_LINE_STRIP);


                        for (int h = 0; h < 300; h++)
                        {
                            if (eleViewList[h].easting != 0 && eleViewList[h].northing != 0)
                                gl.Vertex(eleViewList[h].easting + (mf.vehicle.toolWidth / 2), eleViewList[h].northing + (mf.vehicle.toolWidth / 2), 0);


                        }
                        gl.End();
                        gl.Begin(OpenGL.GL_LINE_STRIP);
                        for (int h = 0; h < 300; h++)
                        {

                            if (eleViewList[h].easting != 0 && eleViewList[h].northing != 0)
                                gl.Vertex(eleViewList[h].easting - (mf.vehicle.toolWidth / 2), eleViewList[h].northing, 0);

                        }
                        gl.End();



                        gl.Vertex(0, 0, 0);
                        for (int h = 0; h < 300; h++)
                        {
                            if (eleViewList2[h].easting != 0 && eleViewList2[h].northing != 0)
                                gl.Vertex(eleViewList2[h].easting, eleViewList2[h].northing, 0);

                        }
                        gl.End();
                    }
                }

                // Paint the 2D design pts
                if (mf.isLightbarOn)
                {
                    int count = ptList.Count;

                    if (count > 0)
                    {
                        gl.PointSize(5.0f);
                        gl.Begin(OpenGL.GL_POINTS);
                        gl.Color(.05f, 0.05f, 0.05f);
                        calc3DContour();
                        for (int j = 0; j < count; j++) {

                            
                            gl.Vertex(ptList[j].easting, ptList[j].northing, 0); 
                        }
                        gl.End();
                    }

                    if (count > 0)
                    {
                        gl.Begin(OpenGL.GL_LINE_STRIP);
                        gl.LineWidth(3.0f);
                        
                        gl.Color(.10f, 0.10f, 0.10f);
                        //calc3DContour();
                        for (int j = 0; j < count; j++)
                        {


                            gl.Vertex(ptList[j].easting, ptList[j].northing, 0);
                        }
                        gl.End();
                    }
                }

                // Paint the dots for the contour pts used for cut fill calculation
                int usedPtcnt = usedPtList.Count;

                if (usedPtcnt > 0)
                {
                    gl.PointSize(10.0f);
                    gl.Begin(OpenGL.GL_POINTS);

                    if (usedPtcnt > 1)
                    {

                        for (int h = 1; h < usedPtcnt; h++)
                        {
                            if (usedPtList[h].used == 1) gl.Color(1.0f, 0.0f, 0.0f);
                            else gl.Color(0.0f, 0.0f, 1.0f);
                            gl.Vertex(usedPtList[h].easting, usedPtList[h].northing, 0);

                        }
                        
                    }
                    //PAINT the closeset pt
                    
                    gl.Color(0.0f, 0.0f, 0.0f);
                    gl.Vertex(usedPtList[0].easting, usedPtList[0].northing, 0);

                    gl.End();
                }

                //Paint the boundary and subzones

                int boundaryPtCnt = boundaryList.Count;

                if (boundaryPtCnt > 0)
                {
                    if (boundaryList[0].code == 0)
                    {
                        gl.PointSize(6.0f);
                        gl.Begin(OpenGL.GL_POINTS);
                        gl.Color(0.0f, 0.0f, 1.0f);
                        gl.Vertex(boundaryList[0].easting, boundaryList[0].northing, 0);
                        gl.End();
                    }

                    double lastCode = 2;

                    gl.LineWidth(2);
                    gl.Color(0.73f, 0.27f, 0.69f);
                    gl.Begin(OpenGL.GL_LINE_STRIP);

                    for (int t = (boundaryPtCnt - 1); t > 0; t--)
                    {


                        if (boundaryList[t].code == lastCode)
                        {
                            gl.Vertex(boundaryList[t].easting, boundaryList[t].northing, 0);
                        }
                        else
                        {
                            gl.End();
                            gl.LineWidth(1);
                            gl.Color(0.0f, 0.0f, 0.0f);
                            gl.Begin(OpenGL.GL_LINE_STRIP);
                            gl.Vertex(boundaryList[t].easting, boundaryList[t].northing, 0);
                        }


                        lastCode = boundaryList[t].code;

                    }
                    gl.End();
                }


            }

            //mf.curBlade = FormGPS.BladePoint.center;


            if (mf.curBlade == FormGPS.BladePoint.left)
            {
                BuildGuideCross(mf.pn.bladeLeft.easting, mf.pn.bladeLeft.northing, 50.0);

            }
            if (mf.curBlade == FormGPS.BladePoint.center)
            {
                BuildGuideCross(mf.pn.bladeCenter.easting, mf.pn.bladeCenter.northing, 50.0);

            }
            if (mf.curBlade == FormGPS.BladePoint.right)
            {
                BuildGuideCross(mf.pn.bladeRight.easting, mf.pn.bladeRight.northing, 50.0);

            }


            //BuildGuideCross(mf.pn.bladeCenter.easting, mf.pn.bladeCenter.northing, 50.0);
            
            
            
            // DRAWLOOK AHEAD POINT
            double lookAheadDistance = 10;
            lookAheadDistance = mf.pn.speed * .01 * lookAheadDistance;
            double halfToolWidth = (Properties.Vehicle.Default.setVehicle_toolWidth) / 2;
            CalcLookaheadPoints(lookAheadDistance);






            //Draw lookahead Point
            //gl.PointSize(8.0f);
            //gl.Begin(OpenGL.GL_LINE);
            //gl.Color(1.0f, 1.0f, 0.25f);

            //gl.Vertex(mf.pn.lookaheadCenter.easting, mf.pn.lookaheadCenter.northing, 0.0);

            // Draw Lookahead Line
            gl.LineWidth(2);
            gl.Color(0.73f, 0.27f, 0.69f);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Vertex(mf.pn.lookaheadRight.easting, mf.pn.lookaheadRight.northing, 0.0);
            gl.Vertex(mf.pn.lookaheadLeft.easting, mf.pn.lookaheadLeft.northing, 0.0);
            gl.End();
            gl.PointSize(1.0f);

            gl.PointSize(5.0f);
            gl.Begin(OpenGL.GL_POINTS);
            gl.Color(1.0f, 1.0f, 1.0f);
            gl.Vertex(mf.pn.lookaheadCenter.easting, mf.pn.lookaheadCenter.northing, 0);
            gl.Vertex(mf.pn.lookaheadRight.easting, mf.pn.lookaheadRight.northing, 0.0);
            gl.Vertex(mf.pn.lookaheadLeft.easting, mf.pn.lookaheadLeft.northing, 0.0);
            gl.End();



            gl.LineWidth(2);
            gl.Color(0.01f, 0.99f, 0.01f, .75f);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Vertex(mf.pn.GuideLine1.easting, mf.pn.GuideLine1.northing, 0.0);
            gl.Vertex(mf.pn.GuideLine2.easting, mf.pn.GuideLine2.northing, 0.0);
            gl.End();
            gl.PointSize(1.0f);
            //Draw HeadingLine

            gl.LineWidth(2);
            //gl.Color(0.15f, 0.15f, 0.15f);
            gl.Begin(OpenGL.GL_LINE_STRIP);
            gl.Vertex(mf.pn.GuideLine3.easting, mf.pn.GuideLine3.northing, 0.0);
            gl.Vertex(mf.pn.GuideLine4.easting, mf.pn.GuideLine4.northing, 0.0);
            gl.End();
            gl.PointSize(1.0f);



            //*---------  end paste
            if (mf.isPureDisplayOn)//
            {
                const int numSegments = 100;
                {
                    gl.Color(0.95f, 0.30f, 0.950f);

                    double theta = glm.twoPI / (numSegments);
                    double c = Math.Cos(theta);//precalculate the sine and cosine
                    double s = Math.Sin(theta);

                    double x = ppRadiusCT;//we start at angle = 0
                    double y = 0;

                    gl.LineWidth(20);
                    gl.Begin(OpenGL.GL_LINE_LOOP);
                    for (int ii = 0; ii < numSegments; ii++)
                    {
                        //glVertex2f(x + cx, y + cy);//output vertex
                        gl.Vertex(x + radiusPointCT.easting, y + radiusPointCT.northing);//output vertex

                        //apply the rotation matrix
                        double t = x;
                        x = (c * x) - (s * y);
                        y = (s * t) + (c * y);
                    }
                    gl.End();

                    //Draw lookahead Point
                    gl.PointSize(4.0f);
                    gl.Begin(OpenGL.GL_POINTS);

                    //
                    //gl.Vertex(rEast, rNorth, 0.0);

                    //gl.Color(1.0f, 0.5f, 0.95f);
                    gl.Color(1.0f, 1.0f, 0.25f);
                    gl.Vertex(goalPointCT.easting, goalPointCT.northing, 0.0);

                    gl.End();
                    gl.PointSize(1.0f);

                    
                }
            }
        }


        //public void start3DSurvey()
        //    {




        //    }


        public void validate3DSurvey()
        {
            if (isSurveyOn)
            {
                if (clearSurveyList)
                {
                    surveyList.Clear();
                    clearSurveyList = false;
                }
                // Check the fix Quality before saving the point

                if (mf.pn.fixQuality == 4 | mf.pn.fixQuality == 8) isOKtoSurvey = true;
                else if (mf.pn.fixQuality == 5 && FloatIsOK) isOKtoSurvey = true;
                else isOKtoSurvey = false;


            }
        
            else
            {
                // finish the survey
                if (recSurveyPt)
                {
                    mf.FileSaveSurveyPt();

                    recSurveyPt = false;
                }
            }

        }


        public void tick3DSurvey()
        {
            validate3DSurvey();
            rec3DBm();
            rec3DBnd();
            rec3DPnt();


        }


        private void BuildGuideCross(double easting, double northing, double CrossLength)
        {
            // GUIDE CROSS
            mf.pn.GuideLine1.easting = easting + Math.Cos(mf.fixHeading + glm.PIBy2) * -CrossLength;
            mf.pn.GuideLine1.northing = northing + Math.Sin(mf.fixHeading - glm.PIBy2) * -CrossLength;
            mf.pn.GuideLine2.easting = easting + Math.Cos(mf.fixHeading + glm.PIBy2) * CrossLength;
            mf.pn.GuideLine2.northing = northing + Math.Sin(mf.fixHeading - glm.PIBy2) * CrossLength;
            mf.pn.GuideLine3.easting = easting + Math.Sin(mf.fixHeading - glm.PIBy2) * -CrossLength;
            mf.pn.GuideLine3.northing = northing + Math.Cos(mf.fixHeading - glm.PIBy2) * -CrossLength;
            mf.pn.GuideLine4.easting = easting + Math.Sin(mf.fixHeading - glm.PIBy2) * CrossLength;
            mf.pn.GuideLine4.northing = northing + Math.Cos(mf.fixHeading - glm.PIBy2) * CrossLength;


        }

        public void CalcLookaheadPoints(double lookahead)
        {
            mf.pn.lookaheadCenter.easting = mf.pn.easting + Math.Cos(mf.fixHeading + glm.PIBy2) * -lookahead;
            mf.pn.lookaheadCenter.northing = mf.pn.northing + Math.Sin(mf.fixHeading - glm.PIBy2) * -lookahead;
            mf.pn.lookaheadRight.easting = mf.pn.bladeRight.easting + Math.Cos(mf.fixHeading + glm.PIBy2) * -lookahead;
            mf.pn.lookaheadRight.northing = mf.pn.bladeRight.northing + Math.Sin(mf.fixHeading - glm.PIBy2) * -lookahead;
            mf.pn.lookaheadLeft.easting = mf.pn.bladeLeft.easting + Math.Cos(mf.fixHeading + glm.PIBy2) * -lookahead;
            mf.pn.lookaheadLeft.northing = mf.pn.bladeLeft.northing + Math.Sin(mf.fixHeading - glm.PIBy2) * -lookahead;

        }

        public void calc3DContour()
        {
            int ptCnt = ptList.Count;


            if (ptCnt > 0)
            {
                //to change for ptList whit 4 points avreage
                int closestPoint = 0;
                double minDist = 1000000; //original is 1000000
                //int ptCount = mapList.Count - 1;

                //find the closest point to current fix
                /*for (int t = 0; t < ptCount; t++)
                {
                    double dist = ((pn.easting - mapList[t].eastingMap) * (pn.easting - mapList[t].eastingMap))
                                    + ((pn.northing - mapList[t].northingMap) * (pn.northing - mapList[t].northingMap));
                    if (dist < minDist) { minDist = dist; closestPoint = t; }
                }
                */
                // end to change


                //int closestPointMap = 0;
                int closestPointMapSE = -1;
                int closestPointMapSW = -1;
                int closestPointMapNE = -1;
                int closestPointMapNW = -1;

                int ptCount = ptList.Count - 1;

                double minDistSE = 900; // if the point is further than 30 meters we forget it
                double minDistSW = 900;
                double minDistNE = 900;
                double minDistNW = 900;

                //find the closest point to current fix
                for (int t = 0; t < ptCount; t++)
                {
                    double distMap = ((mf.pn.easting - ptList[t].easting) * (mf.pn.easting - ptList[t].easting))
                                    + ((mf.pn.northing - ptList[t].northing) * (mf.pn.northing - ptList[t].northing));
                    if (distMap < minDist)
                    {
                        minDist = distMap;
                        closestPoint = t;
                    }

                    //Search closest point South West
                    if (mf.pn.easting >= ptList[t].easting && mf.pn.northing >= ptList[t].northing)
                    {

                        if (distMap < minDistSW)
                        {
                            minDistSW = distMap;
                            closestPointMapSW = t;
                        }
                    }

                    //Search closest point South East
                    if (mf.pn.easting <= ptList[t].easting && mf.pn.northing >= ptList[t].northing)
                    {

                        if (distMap < minDistSE)
                        {
                            minDistSE = distMap;
                            closestPointMapSE = t;
                        }
                    }

                    //Search closest point North West
                    if (mf.pn.easting >= ptList[t].easting && mf.pn.northing <= ptList[t].northing)
                    {

                        if (distMap < minDistNW)
                        {
                            minDistNW = distMap;
                            closestPointMapNW = t;
                        }
                    }

                    //Search closest point North East
                    if (mf.pn.easting <= ptList[t].easting && mf.pn.northing <= ptList[t].northing)
                    {

                        if (distMap < minDistNE)
                        {
                            minDistNE = distMap;
                            closestPointMapNE = t;
                        }
                    }


                }
                //here calculate the closest point on each line

                distanceFromNline = 1000;
                distanceFromSline = 1000;
                distanceFromEline = 1000;
                distanceFromWline = 1000;

                double NoLineAverageAlt = 0;
                double NoLineAverageCutAlt = 0;
                double NoLineCount = 0;
                double NoLineCutCount = 0;

                //Calculate the North line
                if (minDistNE < 900 && minDistNW < 900)
                {
                    double dxN = ptList[closestPointMapNE].easting - ptList[closestPointMapNW].easting;
                    double dyN = ptList[closestPointMapNE].northing - ptList[closestPointMapNW].northing;

                    //how far from Line is fix
                    distanceFromNline = ((dyN * mf.pn.easting) - (dxN * mf.pn.northing) + (ptList[closestPointMapNE].easting
                                * ptList[closestPointMapNW].northing) - (ptList[closestPointMapNE].northing * ptList[closestPointMapNW].easting))
                                / Math.Sqrt((dyN * dyN) + (dxN * dxN));

                    //absolute the distance
                    distanceFromNline = Math.Abs(distanceFromNline);


                    //calc point onLine closest to current blade position
                    double UN = (((mf.pn.easting - ptList[closestPointMapNW].easting) * dxN)
                            + ((mf.pn.northing - ptList[closestPointMapNW].northing) * dyN))
                            / ((dxN * dxN) + (dyN * dyN));

                    //point on line closest to blade center
                    eastingNpt = ptList[closestPointMapNW].easting + (UN * dxN);
                    northingNpt = ptList[closestPointMapNW].northing + (UN * dyN);

                    //calc altitude for that point
                    altitudeNpt = ptList[closestPointMapNW].altitude + (UN * (ptList[closestPointMapNE].altitude - ptList[closestPointMapNW].altitude));
                    if (ptList[closestPointMapNE].cutAltitude > 0 && ptList[closestPointMapNW].cutAltitude > 0)
                    {
                        cutAltNpt = ptList[closestPointMapNW].cutAltitude + (UN * (ptList[closestPointMapNE].cutAltitude - ptList[closestPointMapNW].cutAltitude));
                        NoLineAverageCutAlt += cutAltNpt;
                        NoLineCutCount++;
                    }
                    else cutAltNpt = -1;

                    NoLineAverageAlt += altitudeNpt;
                    NoLineCount++;
                }

                //Calculate the South line
                if (minDistSE < 900 && minDistSW < 900)
                {
                    double dxS = ptList[closestPointMapSE].easting - ptList[closestPointMapSW].easting;
                    double dyS = ptList[closestPointMapSE].northing - ptList[closestPointMapSW].northing;

                    //how far from Line is fix
                    distanceFromSline = ((dyS * mf.pn.easting) - (dxS * mf.pn.northing) + (ptList[closestPointMapSE].easting
                                * ptList[closestPointMapSW].northing) - (ptList[closestPointMapSE].northing * ptList[closestPointMapSW].easting))
                                / Math.Sqrt((dyS * dyS) + (dxS * dxS));

                    //absolute the distance
                    distanceFromSline = Math.Abs(distanceFromSline);


                    //calc point onLine closest to current blade position
                    double US = (((mf.pn.easting - ptList[closestPointMapSW].easting) * dxS)
                            + ((mf.pn.northing - ptList[closestPointMapSW].northing) * dyS))
                            / ((dxS * dxS) + (dyS * dyS));

                    //point on line closest to blade center
                    eastingSpt = ptList[closestPointMapSW].easting + (US * dxS);
                    northingSpt = ptList[closestPointMapSW].northing + (US * dyS);

                    //calc altitude for that point
                    altitudeSpt = ptList[closestPointMapSW].altitude + (US * (ptList[closestPointMapSE].altitude - ptList[closestPointMapSW].altitude));
                    if (ptList[closestPointMapSE].cutAltitude > 0 && ptList[closestPointMapSW].cutAltitude > 0)
                    {
                        cutAltSpt = ptList[closestPointMapSW].cutAltitude + (US * (ptList[closestPointMapSE].cutAltitude - ptList[closestPointMapSW].cutAltitude));
                        NoLineAverageCutAlt += cutAltSpt;
                        NoLineCutCount++;
                    }
                    else cutAltSpt = -1;

                    NoLineAverageAlt += altitudeSpt;
                    NoLineCount++;
                }

                //Calculate the West line
                if (minDistSW < 900 && minDistNW < 900)
                {
                    double dxW = ptList[closestPointMapNW].easting - ptList[closestPointMapSW].easting;
                    double dyW = ptList[closestPointMapNW].northing - ptList[closestPointMapSW].northing;

                    //how far from Line is fix
                    distanceFromWline = ((dyW * mf.pn.easting) - (dxW * mf.pn.northing) + (ptList[closestPointMapNW].easting
                                * ptList[closestPointMapSW].northing) - (ptList[closestPointMapNW].northing * ptList[closestPointMapSW].easting))
                                / Math.Sqrt((dyW * dyW) + (dxW * dxW));

                    //absolute the distance
                    distanceFromWline = Math.Abs(distanceFromWline);


                    //calc point onLine closest to current blade position
                    double UW = (((mf.pn.easting - ptList[closestPointMapSW].easting) * dxW)
                            + ((mf.pn.northing - ptList[closestPointMapSW].northing) * dyW))
                            / ((dxW * dxW) + (dyW * dyW));

                    //point on line closest to blade center
                    eastingWpt = ptList[closestPointMapSW].easting + (UW * dxW);
                    northingWpt = ptList[closestPointMapSW].northing + (UW * dyW);

                    //calc altitude for that point
                    altitudeWpt = ptList[closestPointMapSW].altitude + (UW * (ptList[closestPointMapNW].altitude - ptList[closestPointMapSW].altitude));
                    if (ptList[closestPointMapNW].cutAltitude > 0 && ptList[closestPointMapSW].cutAltitude > 0)
                    {
                        cutAltWpt = ptList[closestPointMapSW].cutAltitude + (UW * (ptList[closestPointMapNW].cutAltitude - ptList[closestPointMapSW].cutAltitude));
                        NoLineAverageCutAlt += cutAltWpt;
                        NoLineCutCount++;
                    }
                    else cutAltWpt = -1;

                    NoLineAverageAlt += altitudeWpt;
                    NoLineCount++;
                }

                //Calculate the East line
                if (minDistSE < 900 && minDistNE < 900)
                {
                    double dxE = ptList[closestPointMapNE].easting - ptList[closestPointMapSE].easting;
                    double dyE = ptList[closestPointMapNE].northing - ptList[closestPointMapSE].northing;

                    //how far from Line is fix
                    distanceFromEline = ((dyE * mf.pn.easting) - (dxE * mf.pn.northing) + (ptList[closestPointMapNE].easting
                                * ptList[closestPointMapSE].northing) - (ptList[closestPointMapNE].northing * ptList[closestPointMapSE].easting))
                                / Math.Sqrt((dyE * dyE) + (dxE * dxE));

                    //absolute the distance
                    distanceFromEline = Math.Abs(distanceFromEline);


                    //calc point onLine closest to current blade position
                    double UE = (((mf.pn.easting - ptList[closestPointMapSE].easting) * dxE)
                            + ((mf.pn.northing - ptList[closestPointMapSE].northing) * dyE))
                            / ((dxE * dxE) + (dyE * dyE));

                    //point on line closest to blade center
                    eastingEpt = ptList[closestPointMapSE].easting + (UE * dxE);
                    northingEpt = ptList[closestPointMapSE].northing + (UE * dyE);

                    //calc altitude for that point
                    altitudeEpt = ptList[closestPointMapSE].altitude + (UE * (ptList[closestPointMapNE].altitude - ptList[closestPointMapSE].altitude));
                    if (ptList[closestPointMapNE].cutAltitude > 0 && ptList[closestPointMapSE].cutAltitude > 0)
                    {
                        cutAltEpt = ptList[closestPointMapSE].cutAltitude + (UE * (ptList[closestPointMapNE].cutAltitude - ptList[closestPointMapSE].cutAltitude));
                        NoLineAverageCutAlt += cutAltEpt;
                        NoLineCutCount++;
                    }
                    else
                        cutAltEpt = -1;

                    NoLineAverageAlt += altitudeEpt;
                    NoLineCount++;
                }

                // Give a value to the lines witout values
                if (NoLineCount > 0)
                {
                    NoLineAverageAlt = NoLineAverageAlt / NoLineCount;
                    if (NoLineCutCount > 0)
                        NoLineAverageCutAlt = NoLineAverageCutAlt / NoLineCutCount;
                    else NoLineAverageCutAlt = -1;

                    if (distanceFromNline == 1000)
                    {
                        altitudeNpt = NoLineAverageAlt;
                        cutAltNpt = NoLineAverageCutAlt;
                    }

                    if (distanceFromSline == 1000)
                    {
                        altitudeSpt = NoLineAverageAlt;
                        cutAltSpt = NoLineAverageCutAlt;
                    }

                    if (distanceFromWline == 1000)
                    {
                        altitudeWpt = NoLineAverageAlt;
                        cutAltWpt = NoLineAverageCutAlt;
                    }

                    if (distanceFromEline == 1000)
                    {
                        altitudeEpt = NoLineAverageAlt;
                        cutAltEpt = NoLineAverageCutAlt;
                    }
                }

                // check if the blade is close from a line
                double mindistFromLine = distanceFromNline;
                double eastingLine = eastingNpt;
                double northingLine = northingNpt;
                double altitudeLine = altitudeNpt;
                double cutAltLine = cutAltNpt;

                if (distanceFromSline < mindistFromLine)
                {
                    mindistFromLine = distanceFromSline;
                    eastingLine = eastingSpt;
                    northingLine = northingSpt;
                    altitudeLine = altitudeSpt;
                    cutAltLine = cutAltSpt;
                }

                if (distanceFromEline < mindistFromLine)
                {
                    mindistFromLine = distanceFromEline;
                    eastingLine = eastingEpt;
                    northingLine = northingEpt;
                    altitudeLine = altitudeEpt;
                    cutAltLine = cutAltEpt;
                }

                if (distanceFromWline < mindistFromLine)
                {
                    mindistFromLine = distanceFromWline;
                    eastingLine = eastingWpt;
                    northingLine = northingWpt;
                    altitudeLine = altitudeWpt;
                    cutAltLine = cutAltWpt;
                }


                // Calulate the closest point alitude and cutAltitude

                //double cutFillMap;
                double avgAltitude = -1;
                double avgCutAltitude = -1;

                usedPtList.Clear();
                UsedPt point = new UsedPt(ptList[closestPoint].easting, ptList[closestPoint].northing, 1);
                usedPtList.Add(point);

                // if the pt is near the closest pt or No Average is selected or there is only one survey pt
                int nbrofPt = 4;
                if (minDistNE == 900) nbrofPt--;
                if (minDistNW == 900) nbrofPt--;
                if (minDistSE == 900) nbrofPt--;
                if (minDistSW == 900) nbrofPt--;

                if (minDist < (noAvgDist * noAvgDist) | !averagePts | nbrofPt < 2)
                {
                    // if the closest point is under the center of the blade
                    avgAltitude = ptList[closestPoint].altitude;
                    avgCutAltitude = ptList[closestPoint].cutAltitude;
                }
                else if (mindistFromLine < noAvgDist)
                // if the blade is near a line
                {
                    avgAltitude = altitudeLine;
                    avgCutAltitude = cutAltLine;

                    if (minDistNE < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapNE].easting, ptList[closestPointMapNE].northing, 1);
                        usedPtList.Add(point2);
                    }

                    if (minDistSE < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapSE].easting, ptList[closestPointMapSE].northing, 1);
                        usedPtList.Add(point2);
                    }

                    if (minDistNW < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapNW].easting, ptList[closestPointMapNW].northing, 1);
                        usedPtList.Add(point2);
                    }

                    if (minDistSW < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapSW].easting, ptList[closestPointMapSW].northing, 1);
                        usedPtList.Add(point2);
                    }

                    UsedPt point6 = new UsedPt(eastingLine, northingLine, 2);
                    usedPtList.Add(point6);
                }
                else
                {
                    if (distanceFromEline < 1000 | distanceFromNline < 1000 | distanceFromSline < 1000 | distanceFromWline < 1000)
                    {
                        //if there is a line on at least one side
                        double sumofCloseDist = 1 / distanceFromNline + 1 / distanceFromSline + 1 / distanceFromEline + 1 / distanceFromWline;

                        avgAltitude = ((altitudeNpt / distanceFromNline) + (altitudeSpt / distanceFromSline) +
                        (altitudeEpt / distanceFromEline) + (altitudeWpt / distanceFromWline)) / sumofCloseDist;

                        if (cutAltNpt == -1 | cutAltSpt == -1 | cutAltWpt == -1 | cutAltEpt == -1)
                        {
                            avgCutAltitude = ptList[closestPoint].cutAltitude;
                        }
                        else
                        {
                            avgCutAltitude = (cutAltNpt / distanceFromNline + cutAltSpt / distanceFromSline +
                        cutAltEpt / distanceFromEline + cutAltWpt / distanceFromWline) / sumofCloseDist;

                        }
                    }
                    else
                    // if there are no lines but 2 pt build the diag
                    {
                        double eastingDiaPt;
                        double northingDiaPt;

                        //Calculate the diag line SE to NW
                        if (minDistSE < 900 && minDistNW < 900)
                        {
                            double dx = ptList[closestPointMapNW].easting - ptList[closestPointMapSE].easting;
                            double dy = ptList[closestPointMapNW].northing - ptList[closestPointMapSE].northing;

                            //how far from Line is fix
                            //double distanceFromline = ((dy * mf.pn.easting) - (dx * mf.pn.northing) + (ptList[closestPointMapNW].easting
                            //            * ptList[closestPointMapSE].northing) - (ptList[closestPointMapNW].northing * ptList[closestPointMapSE].easting))
                            //            / Math.Sqrt((dy * dy) + (dx * dx));

                            //absolute the distance
                            //distanceFromline = Math.Abs(distanceFromline);


                            //calc point onLine closest to current blade position
                            double U = (((mf.pn.easting - ptList[closestPointMapSE].easting) * dx)
                                    + ((mf.pn.northing - ptList[closestPointMapSE].northing) * dy))
                                    / ((dx * dx) + (dy * dy));

                            //point on line closest to blade center
                            eastingDiaPt = ptList[closestPointMapSE].easting + (U * dx);
                            northingDiaPt = ptList[closestPointMapSE].northing + (U * dy);

                            //calc altitude for that point
                            avgAltitude = ptList[closestPointMapSE].altitude + (U * (ptList[closestPointMapNW].altitude - ptList[closestPointMapSE].altitude));
                            if (ptList[closestPointMapNW].cutAltitude > 0 && ptList[closestPointMapSE].cutAltitude > 0)
                            {
                                avgCutAltitude = ptList[closestPointMapSE].cutAltitude + (U * (ptList[closestPointMapNW].cutAltitude - ptList[closestPointMapSE].cutAltitude));
                            }
                            else
                                avgCutAltitude = -1;

                            UsedPt point2 = new UsedPt(eastingDiaPt, northingDiaPt, 2);
                            usedPtList.Add(point2);
                        }
                        //Calculate the diag line SW to NE
                        else if (minDistSW < 900 && minDistNE < 900)
                        {
                            double dx = ptList[closestPointMapNE].easting - ptList[closestPointMapSW].easting;
                            double dy = ptList[closestPointMapNE].northing - ptList[closestPointMapSW].northing;

                            //how far from Line is fix
                            //double distanceFromline = ((dy * mf.pn.easting) - (dx * mf.pn.northing) + (ptList[closestPointMapNE].easting
                            //            * ptList[closestPointMapSW].northing) - (ptList[closestPointMapNE].northing * ptList[closestPointMapSW].easting))
                            //            / Math.Sqrt((dy * dy) + (dx * dx));

                            //absolute the distance
                            //distanceFromline = Math.Abs(distanceFromline);


                            //calc point onLine closest to current blade position
                            double U = (((mf.pn.easting - ptList[closestPointMapSW].easting) * dx)
                                    + ((mf.pn.northing - ptList[closestPointMapSW].northing) * dy))
                                    / ((dx * dx) + (dy * dy));

                            //point on line closest to blade center
                            eastingDiaPt = ptList[closestPointMapSW].easting + (U * dx);
                            northingDiaPt = ptList[closestPointMapSW].northing + (U * dy);

                            //calc altitude for that point
                            avgAltitude = ptList[closestPointMapSW].altitude + (U * (ptList[closestPointMapNE].altitude - ptList[closestPointMapSW].altitude));
                            if (ptList[closestPointMapNE].cutAltitude > 0 && ptList[closestPointMapSW].cutAltitude > 0)
                            {
                                avgCutAltitude = ptList[closestPointMapSW].cutAltitude + (U * (ptList[closestPointMapNE].cutAltitude - ptList[closestPointMapSW].cutAltitude));
                            }
                            else
                                avgCutAltitude = -1;

                            UsedPt point2 = new UsedPt(eastingDiaPt, northingDiaPt, 2);
                            usedPtList.Add(point2);
                        }

                    }

                    // build the list to view the points in the map
                    if (minDistNE < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapNE].easting, ptList[closestPointMapNE].northing, 1);
                        usedPtList.Add(point2);
                    }

                    if (minDistSE < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapSE].easting, ptList[closestPointMapSE].northing, 1);
                        usedPtList.Add(point2);
                    }

                    if (minDistNW < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapNW].easting, ptList[closestPointMapNW].northing, 1);
                        usedPtList.Add(point2);
                    }

                    if (minDistSW < 900)
                    {
                        UsedPt point2 = new UsedPt(ptList[closestPointMapSW].easting, ptList[closestPointMapSW].northing, 1);
                        usedPtList.Add(point2);
                    }

                    if (distanceFromNline < 1000)
                    {
                        UsedPt point6 = new UsedPt(eastingNpt, northingNpt, 2);
                        usedPtList.Add(point6);
                    }

                    if (distanceFromSline < 1000)
                    {
                        UsedPt point6 = new UsedPt(eastingSpt, northingSpt, 2);
                        usedPtList.Add(point6);
                    }

                    if (distanceFromWline < 1000)
                    {
                        UsedPt point6 = new UsedPt(eastingWpt, northingWpt, 2);
                        usedPtList.Add(point6);
                    }

                    if (distanceFromEline < 1000)
                    {
                        UsedPt point6 = new UsedPt(eastingEpt, northingEpt, 2);
                        usedPtList.Add(point6);
                    }

                }
                //if (avgCutAltitude == -1) cutFillMap = 9999;
                //else cutFillMap = avgCutAltitude - avgAltitude;


                if (surveyMode && eleViewList.Count > 0)
                {
                    //fill in the latest distance and fix



                    double fixDist = ((eleViewList[101].easting - mf.pn.easting) * (eleViewList[101].easting - mf.pn.easting) + (eleViewList[101].northing - mf.pn.northing) * (eleViewList[101].northing - mf.pn.northing));
                    // if the dist is more than 0.5m
                    if (fixDist > 0.25)
                    {

                        //copy each point one count back: 0 take 1, 1 take 2 etc.

                        for (int i = 0; i < 101; i++)
                        {


                            eleViewList[i].lastPassAltitude = eleViewList[i + 1].lastPassAltitude;
                            eleViewList[i].easting = eleViewList[i + 1].easting;
                            eleViewList[i].northing = eleViewList[i + 1].northing;
                            eleViewList[i].heading = eleViewList[i + 1].heading;
                            eleViewList[i].altitude = eleViewList[i + 1].altitude;
                            eleViewList[i].cutAltitude = eleViewList[i + 1].cutAltitude;

                        }

                        //for (int i = 0; i < 101; i++) eleViewList[i] = eleViewList[i + 1]; this is not working

                        // fill the current point (101)
                        eleViewList[101].lastPassAltitude = mf.pn.altitude;
                        eleViewList[101].easting = mf.pn.easting;
                        eleViewList[101].northing = mf.pn.northing;
                        eleViewList[101].heading = mf.fixHeading;

                        if (minDist < 900)
                        {
                            eleViewList[101].altitude = avgAltitude;
                            eleViewList[101].cutAltitude = avgCutAltitude;
                        }
                        else
                        {
                            eleViewList[101].altitude = -1;
                            eleViewList[101].cutAltitude = -1;
                        }


                        double fixDist2 = ((eleViewList2[101].easting - mf.pn.easting) * (eleViewList2[101].easting - 1.0 - mf.pn.easting) + (eleViewList2[101].northing - mf.pn.northing) * (eleViewList[101].northing - mf.pn.northing - 1.0));
                        // if the dist is more than 0.5m
                        if (fixDist2 > 0.25)
                        {

                            //copy each point one count back: 0 take 1, 1 take 2 etc.

                            for (int i = 0; i < 101; i++)
                            {


                                eleViewList2[i].lastPassAltitude = eleViewList[i + 1].lastPassAltitude;
                                eleViewList2[i].easting = eleViewList2[i + 1].easting;
                                eleViewList2[i].northing = eleViewList2[i + 1].northing;
                                eleViewList2[i].heading = eleViewList2[i + 1].heading;
                                eleViewList2[i].altitude = eleViewList2[i + 1].altitude;
                                eleViewList2[i].cutAltitude = eleViewList2[i + 1].cutAltitude;

                            }

                            //for (int i = 0; i < 101; i++) eleViewList[i] = eleViewList[i + 1]; this is not working

                            // fill the current point (101)
                            eleViewList2[101].lastPassAltitude = mf.pn.altitude;
                            eleViewList2[101].easting = mf.pn.easting;
                            eleViewList2[101].northing = mf.pn.northing;
                            eleViewList2[101].heading = mf.fixHeading;

                            if (minDist2 < 900)
                            {
                                eleViewList2[101].altitude = avgAltitude;
                                eleViewList2[101].cutAltitude = avgCutAltitude;
                            }
                            else
                            {
                                eleViewList2[101].altitude = -1;
                                eleViewList2[101].cutAltitude = -1;
                            }
                        }


                        // make the look ahead view
                        // 200 points to fill, 102 to 298? 4 * 49 = 196

                        for (int j = 1; j < 50; j++)
                        {

                            double AheadEasting = mf.pn.easting + Math.Cos(mf.fixHeading + glm.PIBy2) * -2 * j;
                            double AheadNorthing = mf.pn.northing + Math.Sin(mf.fixHeading - glm.PIBy2) * -2 * j;


                            double mindist = 1000000;

                            int ClosestLookAheadPt = 999999;
                            int lookPtCt = ptList.Count;

                            if (lookPtCt > 0)
                            {
                                for (int m = 0; m < lookPtCt; m++)
                                {
                                    double distA = (AheadEasting - ptList[m].easting) * (AheadEasting - ptList[m].easting) +
                                        (AheadNorthing - ptList[m].northing) * (AheadNorthing - ptList[m].northing);

                                    if (distA < mindist)
                                    {
                                        mindist = distA;
                                        ClosestLookAheadPt = m;
                                    }
                                }
                            }







                            for (int k = 0; k < 4; k++)
                            {
                                eleViewList[101 + j * 4 - k].easting = AheadEasting;
                                eleViewList[101 + j * 4 - k].northing = AheadNorthing;

                                if (ClosestLookAheadPt != 999999 && mindist < 100)
                                {
                                    //eleViewList[101 + j * 10 - k].lastPassAltitude = mf.pn.altitude;
                                    eleViewList[101 + j * 4 - k].altitude = ptList[ClosestLookAheadPt].altitude;
                                    eleViewList[101 + j * 4 - k].cutAltitude = ptList[ClosestLookAheadPt].cutAltitude;


                                }
                                else
                                {
                                    //eleViewList[101 + j * 10 - k].lastPassAltitude = mf.pn.altitude;
                                    eleViewList[101 + j * 4 - k].altitude = -1;
                                    eleViewList[101 + j * 4 - k].cutAltitude = -1;

                                }

                            }
                        }

                        // the last pass stuff for the map
                        //find the map resolution
                        if (mappingDist < 1) mappingDist = 10;

                        // check the dist from curent pt to paint
                        int ptsBehind = 101 - (int)Math.Round(mappingDist * 1.5 + .9);

                        double paintEasting = eleViewList[ptsBehind].easting;
                        double paintNorting = eleViewList[ptsBehind].northing;
                        double paintHeading = eleViewList[ptsBehind].heading;
                        double paintAltitude = eleViewList[ptsBehind].altitude;
                        double paintCutAlt = eleViewList[ptsBehind].cutAltitude;
                        double paintLastPass = eleViewList[ptsBehind].lastPassAltitude;

                        if (paintAltitude > 0 && paintCutAlt > 0 && paintLastPass > 0)
                        {
                            // calculate the number of pts from to make calculation
                            double paintToolDist = (mf.vehicle.toolWidth - mappingDist) / 2;

                            if (paintToolDist <= 0) paintToolDist = 0;

                            //search for all near pts
                            int ptct = mapList.Count;
                            if (ptct > 5)
                            {
                                mappingDist = mapList[5].drawPtWidthMap;
                                //double paintDist = (mappingDist * .75) * (mappingDist * .75);
                                for (int i = 0; i < ptct; i++)
                                {
                                    //double dist = (paintEasting - mapList[i].eastingMap) * (paintEasting - mapList[i].eastingMap) +
                                    //(paintNorting - mapList[i].northingMap) * (paintNorting - mapList[i].northingMap);
                                    double distEasting = Math.Abs(paintEasting - mapList[i].eastingMap);
                                    double distNorthing = Math.Abs(paintNorting - mapList[i].northingMap);
                                    if (distEasting < mappingDist * .7 && distNorthing < mappingDist * .7)
                                    //if (dist < paintDist)
                                    {
                                        // fill the lastpass value
                                        if (paintLastPass < mapList[i].lastPassAltitudeMap | mapList[i].lastPassAltitudeMap < 1)
                                        {
                                            if (paintLastPass < mapList[i].cutAltitudeMap) mapList[i].lastPassAltitudeMap = mapList[i].cutAltitudeMap;
                                            else mapList[i].lastPassAltitudeMap = paintLastPass;
                                        }
                                        // fill the last real pass
                                        if (mapList[i].cutDeltaMap <= 0)
                                        {
                                            if (paintLastPass <= mapList[i].cutAltitudeMap) mapList[i].lastPassRealAltitudeMap = mapList[i].cutAltitudeMap;
                                            else
                                            {
                                                if (mapList[i].lastPassRealAltitudeMap > paintLastPass | mapList[i].lastPassRealAltitudeMap < 0)
                                                    mapList[i].lastPassRealAltitudeMap = paintLastPass;
                                            }
                                        }
                                        else
                                        {
                                            if (mapList[i].lastPassRealAltitudeMap > paintLastPass | mapList[i].lastPassRealAltitudeMap < 0)
                                            {

                                                if (paintLastPass >= mapList[i].altitudeMap) mapList[i].lastPassRealAltitudeMap = mapList[i].altitudeMap;
                                                else if (paintLastPass <= mapList[i].cutAltitudeMap) mapList[i].lastPassRealAltitudeMap = mapList[i].cutAltitudeMap;
                                                else mapList[i].lastPassRealAltitudeMap = paintLastPass;
                                            }
                                        }
                                    }
                                }


                                if (paintToolDist > 0)
                                {
                                    for (double h = paintToolDist; h > 0; h -= mappingDist)
                                    {

                                    }
                                }
                            }
                        }


                        //gl.CalculateMinMaxZoom();
                    }



                }





            }


        }

        public void rec3DBnd()
        {

            // Start recording contour

            if (recBoundary)
            {
                double halfToolWidth = (Properties.Vehicle.Default.setVehicle_toolWidth) / 2;

                if (isBtnStartPause)
                {
                    // translate the survey pt to the side of the tool

                    double sideEasting;
                    double sideNorthing;

                    if (isBoundarySideRight)
                    {
                        sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
                        sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
                    }
                    else
                    {
                        sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * halfToolWidth;
                        sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * halfToolWidth;
                    }

                    //check dist from last point 

                    double surveyDistance = ((nearestSurveyEasting - sideEasting) * (nearestSurveyEasting - sideEasting) +
                    (nearestSurveyNorthing - sideNorthing) * (nearestSurveyNorthing - sideNorthing));

                    if (surveyDistance > 9)
                    {
                        // convert the utm from the side of the blade to lat long
                        double actualEasting = sideEasting + mf.pn.utmEast;
                        double actualNorthing = sideNorthing + mf.pn.utmNorth;

                        mf.UTMToLatLon(actualEasting, actualNorthing);

                        SurveyPt point = new SurveyPt(sideEasting, sideNorthing, mf.utmLat, mf.utmLon, mf.pn.altitude, 2, mf.pn.fixQuality);
                        surveyList.Add(point);

                        nearestSurveyEasting = mf.pn.easting;
                        nearestSurveyNorthing = mf.pn.northing;

                    }

                }


            }

               


        }

        public void rec3DPnt()

        {
            if (recSurveyPt)
            {
                if (recSurveyPt && isBtnStartPause)
                {
                    // check for the nearest point in the surveyList

                    int surveyCount = surveyList.Count;
                    double minSurveyDistance = 1000000;

                    for (int i = 0; i < surveyCount; i++)
                    {
                        double surveyDistance = ((surveyList[i].easting - mf.pn.easting) * (surveyList[i].easting - mf.pn.easting) +
                            (surveyList[i].northing - mf.pn.northing) * (surveyList[i].northing - mf.pn.northing));

                        if (surveyDistance < minSurveyDistance) minSurveyDistance = surveyDistance;
                    }

                    // if there is no point 3 metre around add a point
                    if (minSurveyDistance > 9)
                    {
                        SurveyPt point = new SurveyPt(mf.pn.easting, mf.pn.northing, mf.pn.latitude, mf.pn.longitude, mf.pn.altitude, 3, mf.pn.fixQuality);
                        surveyList.Add(point);

                        nearestSurveyEasting = mf.pn.easting;
                        nearestSurveyNorthing = mf.pn.northing;

                    }

                }



            }
           


        }

        public void rec3DBm()
        {

            //#region Survey ----------------------------------------------------------------------------------------------------------------

           

                if (isOKtoSurvey)
                {

                    if (markBM)
                    {

                        SurveyPt point = new SurveyPt(mf.pn.easting, mf.pn.northing, mf.pn.latitude, mf.pn.longitude, mf.pn.altitude, 0, mf.pn.fixQuality);
                        surveyList.Add(point);

                        nearestSurveyEasting = mf.pn.easting;
                        nearestSurveyNorthing = mf.pn.northing;

                        markBM = false;
                        recBoundary = true;

                    }

            //        // Start recording contour

            //        if (recBoundary)
            //        {
            //            double halfToolWidth = (Properties.Vehicle.Default.setVehicle_toolWidth) / 2;

            //            if (isBtnStartPause)
            //            {
            //                // translate the survey pt to the side of the tool

            //                double sideEasting;
            //                double sideNorthing;

            //                if (isBoundarySideRight)
            //                {
            //                    sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
            //                    sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * -halfToolWidth;
            //                }
            //                else
            //                {
            //                    sideEasting = mf.pn.easting + Math.Sin(mf.fixHeading - glm.PIBy2) * halfToolWidth;
            //                    sideNorthing = mf.pn.northing + Math.Cos(mf.fixHeading - glm.PIBy2) * halfToolWidth;
            //                }

            //                //check dist from last point 

            //                double surveyDistance = ((nearestSurveyEasting - sideEasting) * (nearestSurveyEasting - sideEasting) +
            //                (nearestSurveyNorthing - sideNorthing) * (nearestSurveyNorthing - sideNorthing));

            //                if (surveyDistance > 9)
            //                {
            //                    // convert the utm from the side of the blade to lat long
            //                    double actualEasting = sideEasting + mf.pn.utmEast;
            //                    double actualNorthing = sideNorthing + mf.pn.utmNorth;

            //                    mf.UTMToLatLon(actualEasting, actualNorthing);

            //                    SurveyPt point = new SurveyPt(sideEasting, sideNorthing, mf.utmLat, mf.utmLon, mf.pn.altitude, 2, mf.pn.fixQuality);
            //                    surveyList.Add(point);

            //                    nearestSurveyEasting = mf.pn.easting;
            //                    nearestSurveyNorthing = mf.pn.northing;

            //                }

            //            }

            //        }

            //        if (recSurveyPt)
            //        {
            //            if (isBtnStartPause)
            //            {
            //                // check for the nearest point in the surveyList

            //                int surveyCount = surveyList.Count;
            //                double minSurveyDistance = 1000000;

            //                for (int i = 0; i < surveyCount; i++)
            //                {
            //                    double surveyDistance = ((surveyList[i].easting - mf.pn.easting) * (surveyList[i].easting - mf.pn.easting) +
            //                        (surveyList[i].northing - mf.pn.northing) * (surveyList[i].northing - mf.pn.northing));

            //                    if (surveyDistance < minSurveyDistance) minSurveyDistance = surveyDistance;
            //                }

            //                // if there is no point 3 metre around add a point
            //                if (minSurveyDistance > 9)
            //                {
            //                    SurveyPt point = new SurveyPt(mf.pn.easting, mf.pn.northing, mf.pn.latitude, mf.pn.longitude, mf.pn.altitude, 3, mf.pn.fixQuality);
            //                    surveyList.Add(point);

            //                    nearestSurveyEasting = mf.pn.easting;
            //                    nearestSurveyNorthing = mf.pn.northing;

            //                }

            //            }


            //        }

            //    }

            }
            else
            {
                // finish the survey
                if (recSurveyPt)
                {
                    mf.FileSaveSurveyPt();

                    recSurveyPt = false;
                }
            }
        }

        public void designList2ptList()
        {
            mf.stopTheProgram = true;
            //if (ptList != null) 
            ptList.Clear();

            //if (boundaryList != null) 
            boundaryList.Clear();

            if (designList != null)
            {
                int ptCount = designList.Count;
                for (int t = 0; t < ptCount; t++)
                {
                    double lat = designList[t].latitude;
                    double lon = designList[t].longitude;
                    mf.pn.ConvertAgd2Utm(lat * 0.01745329251994329576923690766743, lon * 0.01745329251994329576923690766743);


                    if (designList[t].code == 3)
                    {


                        CContourPt point = new CContourPt(mf.pn.eastingAgd,
                                    0,
                                    mf.pn.northingAgd,
                                    designList[t].altitude,
                                    designList[t].latitude,
                                    designList[t].longitude,
                                    designList[t].cutAltitude,
                                    -1,
                                    -1);

                        ptList.Add(point);
                    }
                    else
                    {
                        BoundaryPt point = new BoundaryPt(mf.pn.eastingAgd,
                            0,
                            mf.pn.northingAgd,
                            designList[t].altitude,
                            designList[t].latitude,
                            designList[t].longitude,
                            designList[t].cutAltitude,
                            designList[t].code);

                        boundaryList.Add(point);
                    }
                }
                mf.FileSaveContour();
                mf.FileSaveBoundaryList();
                mapList.Clear();
                mf.CalculateMinMaxEastNorth();
            }
        }

    }


        public class CContourPt
        {
            public double altitude { get; set; }
            public double easting { get; set; }
            public double northing { get; set; }
            public double heading { get; set; }
            public double cutAltitude { get; set; }
            public double lastPassAltitude { get; set; }
            public double currentPassAltitude { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double distance { get; set; }


            //constructor
            public CContourPt(double _easting, double _heading, double _northing,
                                double _altitude, double _lat, double _long,
                                double _cutAltitude = -1, double _currentPassAltitude = -1, double _lastPassAltitude = -1, double _distance = -1)
            {
                easting = _easting;
                northing = _northing;
                heading = _heading;
                altitude = _altitude;
                latitude = _lat;
                longitude = _long;

                //optional parameters            
                cutAltitude = _cutAltitude;
                currentPassAltitude = _currentPassAltitude;
                lastPassAltitude = _lastPassAltitude;
                distance = _distance;

            }
        }

        public class CCutPt
        {
            public double altitude { get; set; }
            public double easting { get; set; }
            public double northing { get; set; }
            public double heading { get; set; }
            public double cutAltitude { get; set; }
            public double lastPassAltitude { get; set; }
            public double currentPassAltitude { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double distance { get; set; }


            //constructor
            public CCutPt(double _easting, double _heading, double _northing,
                                double _altitude, double _lat, double _long,
                                double _cutAltitude = -1, double _currentPassAltitude = -1, double _lastPassAltitude = -1, double _distance = -1)
            {
                easting = _easting;
                northing = _northing;
                heading = _heading;
                altitude = _altitude;
                latitude = _lat;
                longitude = _long;
                cutAltitude = _cutAltitude;
                currentPassAltitude = _currentPassAltitude;
                lastPassAltitude = _lastPassAltitude;
                distance = _distance;
            }
        }
        // A list for the boundary pts in the visual Map
        public class BoundaryPt
        {
            public double easting { get; set; }
            public double northing { get; set; }
            public double heading { get; set; }
            public double altitude { get; set; }
            public double cutAltitude { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double code { get; set; }

            //constructor
            public BoundaryPt(double _easting, double _heading, double _northing,
                                double _altitude, double _lat, double _long,
                                double _cutAltitude = -1, double _code = 0)
            {
                easting = _easting;
                northing = _northing;
                heading = _heading;
                altitude = _altitude;
                latitude = _lat;
                longitude = _long;

                //optional parameters
                cutAltitude = _cutAltitude;
                code = _code;
            }
        }

        public class ViewPt
        {
            public double altitude { get; set; }
            public double easting { get; set; }
            public double northing { get; set; }
            public double heading { get; set; }
            public double cutAltitude { get; set; }
            public double lastPassAltitude { get; set; }
            //public double distance { get; set; }

            //constructor
            public ViewPt(double _easting = 0, double _northing = 0,
                                double _altitude = 0, double _heading = 0,
                                double _cutAltitude = -1, double _lastPassAltitude = -1) // , double _distance = -1
            {
                easting = _easting;
                northing = _northing;
                heading = _heading;
                altitude = _altitude;


                //optional parameters
                cutAltitude = _cutAltitude;
                lastPassAltitude = _lastPassAltitude;
                //distance = _distance;
            }
        }

        // A list to view the survey pt used for cut/fill calulation
        public class UsedPt
        {
            public double easting { get; set; }
            public double northing { get; set; }
            public double used { get; set; }

            //constructor
            public UsedPt(double _easting = 0, double _northing = 0, double _used = 0)
            {
                easting = _easting;
                northing = _northing;
                used = _used;
            }
        }

        //Survey list by Pat
        public class SurveyPt
        {
            public double easting { get; set; }
            public double northing { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double altitude { get; set; }
            public double code { get; set; }
            public int fixQuality { get; set; }


            //constructor
            public SurveyPt(double _easting, double _northing, double _lat, double _long, double _altitude = -1, double _code = -1, int _fixQuality = 0)
            {

                easting = _easting;
                northing = _northing;
                latitude = _lat;
                longitude = _long;
                altitude = _altitude;

                code = _code;
                fixQuality = _fixQuality;

            }
        }

        // by pat
        public class mapListPt
        {
            public double eastingMap { get; set; }
            public double northingMap { get; set; }
            public double drawPtWidthMap { get; set; }
            public double altitudeMap { get; set; }
            public double cutAltitudeMap { get; set; }
            public double cutDeltaMap { get; set; }
            public double lastPassAltitudeMap { get; set; }
            public double lastPassRealAltitudeMap { get; set; }

            //constructor
            public mapListPt(double _eastingMap, double _northingMap, double _drawPtWidthMap,
                                double _altitudeMap,
                                double _cutAltitudeMap = -1,
                                double _cutDeltaMap = 9999,
                                double _lastPassAltitudeMap = -1,
                                double _lastPassRealAltitudeMap = -1)
            {
                eastingMap = _eastingMap;
                northingMap = _northingMap;
                drawPtWidthMap = _drawPtWidthMap;
                altitudeMap = _altitudeMap;
                cutAltitudeMap = _cutAltitudeMap;
                cutDeltaMap = _cutDeltaMap;
                lastPassAltitudeMap = _lastPassAltitudeMap;
                lastPassRealAltitudeMap = _lastPassRealAltitudeMap;

            }
        }

        //  to import Optisurface design points by pat
        public class designPt
        {
            public double altitude { get; set; }
            public double easting { get; set; }
            public double northing { get; set; }

            public double cutAltitude { get; set; }
            public double cutfill { get; set; }
            public double latitude { get; set; }
            public double longitude { get; set; }
            public double code { get; set; }

            //constructor
            public designPt(double _lat, double _long, double _altitude,
                                double _cutAltitude = -1, double _cutfill = 9999,
                                  double _code = -1, double _easting = 0, double _northing = 0)
            {
                easting = _easting;
                northing = _northing;
                //heading = _heading;
                altitude = _altitude;
                latitude = _lat;
                longitude = _long;

                //optional parameters
                cutAltitude = _cutAltitude;
                cutfill = _cutfill;
                code = _code;
            }
        }
    
}





   
 //class
 //namespace










//public void Draw3dContour()
        //{


        //    #region Survey ----------------------------------------------------------------------------------------------------------------

        //    if (mf.curSurveyMode == surveyMode.survey3D)
        //    {
        //        if (clearSurveyList)
        //        {
        //            surveyList.Clear();
        //            clearSurveyList = false;
        //        }

        //        // Check the fix Quality before saving the point


        //        if (mf.pn.fixQuality == 4 | mf.pn.fixQuality == 8) isOKtoSurvey = true;
        //        else if (mf.pn.fixQuality == 5 && FloatIsOK) isOKtoSurvey = true;
        //        else isOKtoSurvey = false;

        //        if (isOKtoSurvey)
        //        {

        //            if (markBM)
        //            {

        //                SurveyPt point = new SurveyPt(mf.pn.easting, mf.pn.northing, mf.pn.latitude, mf.pn.longitude, mf.pn.altitude, 0, mf.pn.fixQuality);
        //                surveyList.Add(point);

        //                nearestSurveyEasting = mf.pn.easting;
        //                nearestSurveyNorthing = mf.pn.northing;

        //                markBM = false;
        //                recBoundary = true;

        //            }




        //        }

        //    }
        //    else
        //    {
        //        // finish the survey
        //        if (recSurveyPt)
        //        {
        //            mf.FileSaveSurveyPt();

        //            recSurveyPt = false;
        //        }
        //    }

        //    #endregion survey ----------------------------------------------------------------------------------------------

        //    if (true)
        //    {
        //        int ptCount = surveyList.Count;

        //        if (ptCount > 0)
        //        {


        //            gl.PointSize(4.0f);
        //            gl.Begin(OpenGL.GL_POINTS);

        //            gl.Color(0.97f, 0.42f, 0.45f);
        //            for (int h = 0; h < ptCount; h++)
        //            {
        //                gl.Color(0.97f, 0.42f, 0.45f);

        //                if (surveyList[h].code == 0) gl.Color(0.97f, 0.82f, 0.05f);
        //                if (surveyList[h].code == 2) gl.Color(0.5f, 0.82f, 0.55f);

        //                gl.Vertex(surveyList[h].easting, surveyList[h].northing, 0);
        //            }

        //            gl.End();
        //        }

        //        //Draw a contour line




        //        gl.LineWidth(2);
        //        gl.Color(0.98f, 0.2f, 0.0f);
        //        gl.Begin(OpenGL.GL_LINE_STRIP);
        //        for (int h = 0; h < ptCount; h++)
        //        {
        //            if (surveyList[h].code == 2)
        //                gl.Vertex(surveyList[h].easting, surveyList[h].northing, 0);

        //        }
        //        gl.End();


        //    }
        //    else
        //    {
        //        //now paint the map, by Pat
        //        int ptCount = mapList.Count;
        //        if (maxAltitude == -9999 | minAltitude == 9999 | maxCut == -9999 | maxFill == 9999) drawTheMap = true;

        //        if (ptCount > 0)
        //        {


        //            if (drawTheMap)
        //            {
        //                // Search for the max min painting values


        //                maxAltitude = -9999; minAltitude = 9999; maxCut = 0; maxFill = 0;
        //                for (int h = 0; h < ptCount; h++)
        //                {
        //                    if (mapList[h].cutAltitudeMap != -1)
        //                    {
        //                        if (mapList[h].cutAltitudeMap < minAltitude) minAltitude = mapList[h].cutAltitudeMap;
        //                    }

        //                    if (mapList[h].cutAltitudeMap > maxAltitude) maxAltitude = mapList[h].cutAltitudeMap;

        //                    if (mapList[h].cutDeltaMap < maxCut) maxCut = mapList[h].cutDeltaMap;

        //                    if (mapList[h].cutDeltaMap != 9999)
        //                    {
        //                        if (mapList[h].cutDeltaMap > maxFill) maxFill = mapList[h].cutDeltaMap;
        //                    }
        //                }

        //                //if (maxCut == 9999) maxCut = 0;
        //                //if (maxFill == -9999) maxFill = 0;

        //                midAltitude = ((maxAltitude + minAltitude) / 2);

        //                // to not mess up with colors when min and max altutudes are to close
        //                if ((maxAltitude - minAltitude) < 0.1)
        //                {
        //                    maxAltitude = midAltitude + 0.05;
        //                    minAltitude = midAltitude - 0.05;
        //                }

        //                mf.fillCutFillLbl();
        //            }
        //            // begin painting

        //            double red = 0, green = 0, blue = 0;
        //            double drawPtWidth;
        //            double easting;
        //            double northing;

        //            //set the width of painting

        //            double zoom = mf.zoomValue;
        //            double camPitch = mf.camera.camPitch;

        //            if (camPitch > -20) camPitch = -20;

        //            double paintEastingMax = mf.pn.easting + zoom * -camPitch / 2;
        //            double paintEastingMin = mf.pn.easting - zoom * -camPitch / 2;
        //            double paintNorthingMax = mf.pn.northing + zoom * -camPitch / 2;
        //            double paintNorthingMin = mf.pn.northing - zoom * -camPitch / 2;

        //            gl.Begin(OpenGL.GL_QUADS);

        //            for (int h = 0; h < ptCount; h++)
        //            {
        //                if (mapList[h].eastingMap < paintEastingMax && mapList[h].eastingMap > paintEastingMin && mapList[h].northingMap < paintNorthingMax && mapList[h].northingMap > paintNorthingMin)
        //                {


        //                    // paint the cut fill value
        //                    if (!isElevation)
        //                    {


        //                        if (mapList[h].cutDeltaMap != 9999)
        //                        {
        //                            if (mapList[h].cutDeltaMap == 0)
        //                            {
        //                                red = mf.redCenter;
        //                                green = mf.redCenter;
        //                                blue = mf.bluCenter;
        //                            }
        //                            else if (isActualCut && mapList[h].lastPassRealAltitudeMap > 0 && mapList[h].cutDeltaMap > 0)
        //                            {
        //                                double toCut = mapList[h].lastPassRealAltitudeMap - mapList[h].cutAltitudeMap;

        //                                red = (1 + (toCut / maxCut)) * mf.redCenter + -(toCut / maxCut) * mf.redCut;
        //                                green = (1 + (toCut / maxCut)) * mf.grnCenter + -(toCut / maxCut) * mf.grnCut;
        //                                blue = (1 + (toCut / maxCut)) * mf.bluCenter + -(toCut / maxCut) * mf.bluCut;
        //                            }
        //                            else if (isActualFill && mapList[h].lastPassRealAltitudeMap > 0)
        //                            {
        //                                double toCut = mapList[h].lastPassRealAltitudeMap - mapList[h].cutAltitudeMap;

        //                                red = (1 + (toCut / maxCut)) * mf.redCenter + -(toCut / maxCut) * mf.redCut;
        //                                green = (1 + (toCut / maxCut)) * mf.grnCenter + -(toCut / maxCut) * mf.grnCut;
        //                                blue = (1 + (toCut / maxCut)) * mf.bluCenter + -(toCut / maxCut) * mf.bluCut;
        //                            }
        //                            else
        //                            {
        //                                //to fill

        //                                if (mapList[h].cutDeltaMap > 0)
        //                                {
        //                                    red = (1 - (mapList[h].cutDeltaMap / maxFill)) * mf.redCenter + (mapList[h].cutDeltaMap / maxFill) * mf.redFill;
        //                                    green = (1 - (mapList[h].cutDeltaMap / maxFill)) * mf.grnCenter + (mapList[h].cutDeltaMap / maxFill) * mf.grnFill;
        //                                    blue = (1 - (mapList[h].cutDeltaMap / maxFill)) * mf.bluCenter + (mapList[h].cutDeltaMap / maxFill) * mf.bluFill;
        //                                }
        //                                //to cut


        //                                if (mapList[h].cutDeltaMap < 0)
        //                                {
        //                                    red = (1 - (mapList[h].cutDeltaMap / maxCut)) * mf.redCenter + (mapList[h].cutDeltaMap / maxCut) * mf.redCut;
        //                                    green = (1 - (mapList[h].cutDeltaMap / maxCut)) * mf.grnCenter + (mapList[h].cutDeltaMap / maxCut) * mf.grnCut;
        //                                    blue = (1 - (mapList[h].cutDeltaMap / maxCut)) * mf.bluCenter + (mapList[h].cutDeltaMap / maxCut) * mf.bluCut;
        //                                }
        //                            }

        //                        }
        //                        else
        //                        {
        //                            red = 0;
        //                            green = 0;
        //                            blue = 0;
        //                        }



        //                    }
        //                    else
        //                    // paint the desired altutude
        //                    {
        //                        if (isExistingElevation)
        //                        {
        //                            if (mapList[h].altitudeMap > 0)
        //                            {
        //                                if (mapList[h].altitudeMap == midAltitude)
        //                                {
        //                                    red = mf.redCenter;
        //                                    green = mf.redCenter;
        //                                    blue = mf.bluCenter;
        //                                }

        //                                if (mapList[h].altitudeMap < midAltitude)
        //                                {
        //                                    red = (1 - (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.redCenter + (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.redFill;
        //                                    green = (1 - (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.grnCenter + (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.grnFill;
        //                                    blue = (1 - (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.bluCenter + (mapList[h].altitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.bluFill;
        //                                }

        //                                if (mapList[h].altitudeMap > midAltitude)
        //                                {
        //                                    red = (1 - (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.redCenter + (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.redCut;
        //                                    green = (1 - (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.grnCenter + (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.grnCut;
        //                                    blue = (1 - (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.bluCenter + (mapList[h].altitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.bluCut;
        //                                }

        //                            }
        //                            else
        //                            {
        //                                red = 0;
        //                                green = 0;
        //                                blue = 0;
        //                            }
        //                        }
        //                        else
        //                        {


        //                            if (mapList[h].cutAltitudeMap != -1)
        //                            {
        //                                if (mapList[h].cutAltitudeMap == midAltitude)
        //                                {
        //                                    red = mf.redCenter;
        //                                    green = mf.redCenter;
        //                                    blue = mf.bluCenter;
        //                                }

        //                                if (mapList[h].cutAltitudeMap < midAltitude)
        //                                {
        //                                    red = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.redCenter + (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.redFill;
        //                                    green = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.grnCenter + (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.grnFill;
        //                                    blue = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude)) * mf.bluCenter + (mapList[h].cutAltitudeMap - midAltitude) / (minAltitude - midAltitude) * mf.bluFill;
        //                                }

        //                                if (mapList[h].cutAltitudeMap > midAltitude)
        //                                {
        //                                    red = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.redCenter + (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.redCut;
        //                                    green = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.grnCenter + (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.grnCut;
        //                                    blue = (1 - (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude)) * mf.bluCenter + (mapList[h].cutAltitudeMap - midAltitude) / (maxAltitude - midAltitude) * mf.bluCut;
        //                                }
        //                            }
        //                            else
        //                            {
        //                                red = 0;
        //                                green = 0;
        //                                blue = 0;
        //                            }
        //                        }

        //                    }
        //                    if (red < 0) red = 0;
        //                    if (red > 255) red = 255;
        //                    if (green < 0) green = 0;
        //                    if (green > 255) green = 255;
        //                    if (blue < 0) blue = 0;
        //                    if (blue > 255) blue = 255;

        //                    gl.Color((byte)red, (byte)green, (byte)blue);

        //                    /*/test
        //                    if (mapList[h].cutDeltaMap != 9999)
        //                    {
        //                        if (mapList[h].cutDeltaMap == 0)
        //                            gl.Color(0.75f, 0.75f, 0.75f);

        //                        if (mapList[h].cutDeltaMap < 0)
        //                            gl.Color(.35f, 0.75f, .35f);

        //                        if (mapList[h].cutDeltaMap > 0)
        //                            gl.Color(0.75f, .35f, .35f);

        //                    }
        //                    else gl.Color(0.0f, 0.0f, 0.0f);
        //                    *///end test

        //                    drawPtWidth = (mapList[h].drawPtWidthMap / 2);
        //                    easting = mapList[h].eastingMap;
        //                    northing = mapList[h].northingMap;


        //                    gl.Vertex(easting - drawPtWidth, northing - drawPtWidth, 0);
        //                    gl.Vertex(easting - drawPtWidth, northing + drawPtWidth, 0);
        //                    gl.Vertex(easting + drawPtWidth, northing + drawPtWidth, 0);
        //                    gl.Vertex(easting + drawPtWidth, northing - drawPtWidth, 0);
        //                }
        //            }

        //            gl.End();
        //        }
        //        drawTheMap = false;


        //        // Paint the elevation view line
        //        if (isOpenGLControlBackVisible)
        //        {


        //            if (eleViewList.Count > 10)
        //            {



        //                gl.LineWidth(5);
        //                //gl.Color(Color.Blue);
        //                gl.Color(0.01f, 0.01f, 0.99f);
        //                gl.Begin(OpenGL.GL_LINE_STRIP);


        //                for (int h = 0; h < 300; h++)
        //                {
        //                    if (eleViewList[h].easting != 0 && eleViewList[h].northing != 0)
        //                        gl.Vertex(eleViewList[h].easting + 2.0, eleViewList[h].northing + 2.0, 0);

        //                }

        //                for (int h = 0; h < 300; h++)
        //                {
        //                    if (eleViewList[h].easting != 0 && eleViewList[h].northing != 0)
        //                        gl.Vertex(eleViewList[h].easting - 2.0, eleViewList[h].northing - 2.0, 0);

        //                }
        //                //for (int h = 0; h < 300; h++)
        //                //{
        //                //    if (eleViewList2[h].easting != 0 && eleViewList2[h].northing != 0)
        //                //        gl.Vertex(eleViewList2[h].easting, eleViewList2[h].northing, 0);

        //                //}
        //                //gl.End();
        //            }
        //        }

        //        // Paint the design pts
        //        if (mf.isLightbarOn)
        //        {
        //            int count = ptList.Count;

        //            if (count > 0)
        //            {
        //                gl.PointSize(3.0f);
        //                gl.Begin(OpenGL.GL_POINTS);
        //                gl.Color(1.0f, 0.5f, 0.0f);

        //                for (int j = 0; j < count; j++) gl.Vertex(ptList[j].easting, ptList[j].northing, 0);

        //                gl.End();
        //            }
        //        }

        //        // Paint the dots for the contour pts used for cut fill calculation
        //        int usedPtcnt = usedPtList.Count;

        //        if (usedPtcnt > 0)
        //        {
        //            gl.PointSize(4.0f);
        //            gl.Begin(OpenGL.GL_POINTS);

        //            if (usedPtcnt > 1)
        //            {

        //                for (int h = 1; h < usedPtcnt; h++)
        //                {
        //                    if (usedPtList[h].used == 1) gl.Color(1.0f, 0.5f, 0.0f);
        //                    else gl.Color(0.0f, 0.0f, 1.0f);
        //                    gl.Vertex(usedPtList[h].easting, usedPtList[h].northing, 0);

        //                }
        //            }
        //            //PAINT the closeset pt
        //            gl.Color(1.0f, 0.0f, 0.0f);
        //            gl.Vertex(usedPtList[0].easting, usedPtList[0].northing, 0);

        //            gl.End();
        //        }

        //        //Paint the boundary and subzones

        //        int boundaryPtCnt = boundaryList.Count;

        //        if (boundaryPtCnt > 0)
        //        {
        //            if (boundaryList[0].code == 0)
        //            {
        //                gl.PointSize(6.0f);
        //                gl.Begin(OpenGL.GL_POINTS);
        //                gl.Color(0.0f, 0.0f, 1.0f);
        //                gl.Vertex(boundaryList[0].easting, boundaryList[0].northing, 0);
        //                gl.End();
        //            }

        //            double lastCode = 2;

        //            gl.LineWidth(2);
        //            gl.Color(0.73f, 0.27f, 0.69f);
        //            gl.Begin(OpenGL.GL_LINE_STRIP);

        //            for (int t = (boundaryPtCnt - 1); t > 0; t--)
        //            {


        //                if (boundaryList[t].code == lastCode)
        //                {
        //                    gl.Vertex(boundaryList[t].easting, boundaryList[t].northing, 0);
        //                }
        //                else
        //                {
        //                    gl.End();
        //                    gl.LineWidth(1);
        //                    gl.Color(0.0f, 0.0f, 0.0f);
        //                    gl.Begin(OpenGL.GL_LINE_STRIP);
        //                    gl.Vertex(boundaryList[t].easting, boundaryList[t].northing, 0);
        //                }


        //                lastCode = boundaryList[t].code;

        //            }
        //            gl.End();
        //        }


        //    }
        //    //else
        //    //{
        //    ////draw the guidance line
        //    //int ptCount = ptList.Count;
        //    //gl.LineWidth(2);
        //    //gl.Color(0.98f, 0.2f, 0.0f);
        //    //gl.Begin(OpenGL.GL_LINE_STRIP);
        //    //for (int h = 0; h < ptCount; h++) gl.Vertex(ptList[h].easting, ptList[h].northing, 0);
        //    //gl.End();

        //    //gl.PointSize(4.0f);
        //    //gl.Begin(OpenGL.GL_POINTS);

        //    //gl.Color(0.97f, 0.42f, 0.45f);
        //    //for (int h = 0; h < ptCount; h++) gl.Vertex(ptList[h].easting, ptList[h].northing, 0);

        //    // gl.End();
        //    //gl.PointSize(1.0f);

        //    //draw the reference line
        //    //gl.PointSize(3.0f);
        //    //if (isContourBtnOn)
        //    //{
        //    //ptCount = ptList.Count;
        //    //if (ptCount > 0)
        //    //{
        //    //gl.Begin(OpenGL.GL_POINTS);
        //    //for (int i = 0; i < ptCount; i++)
        //    //{
        //    // gl.Vertex(ptList[i].easting, ptList[i].northing, 0);
        //    //}
        //    //gl.End();
        //    //}
        //    //}
        //    //}


        //    //*---------  end paste
        //    if (mf.isPureDisplayOn)
        //    {
        //        const int numSegments = 100;
        //        {
        //            gl.Color(0.95f, 0.30f, 0.950f);

        //            double theta = glm.twoPI / (numSegments);
        //            double c = Math.Cos(theta);//precalculate the sine and cosine
        //            double s = Math.Sin(theta);

        //            double x = ppRadiusCT;//we start at angle = 0
        //            double y = 0;

        //            gl.LineWidth(20);
        //            gl.Begin(OpenGL.GL_LINE_LOOP);
        //            for (int ii = 0; ii < numSegments; ii++)
        //            {
        //                //glVertex2f(x + cx, y + cy);//output vertex
        //                gl.Vertex(x + radiusPointeasting, y + radiusPointnorthing);//output vertex

        //                //apply the rotation matrix
        //                double t = x;
        //                x = (c * x) - (s * y);
        //                y = (s * t) + (c * y);
        //            }
        //            gl.End();

        //            //Draw lookahead Point
        //            gl.PointSize(4.0f);
        //            gl.Begin(OpenGL.GL_POINTS);

        //            //gl.Color(1.0f, 1.0f, 0.25f);
        //            //gl.Vertex(rEast, rNorth, 0.0);

        //            gl.Color(1.0f, 0.5f, 0.95f);
        //            gl.Vertex(goalPointeasting, goalPointnorthing, 0.0);

        //            gl.End();
        //            gl.PointSize(1.0f);
        //        }
        //    }
        