//Please, if you use this, share the improvements

using System;
using SharpGL;

namespace OpenGrade
{
    public class CVehicle
    {
        private readonly OpenGL gl;
        private readonly FormGPS mf;

        //vehicle specific
        public bool isPivotBehindAntenna;
        public double antennaPivot;
        public double wheelbase;
        public double minSlope, minShoreSlope;

        // Black Ace Industries
        public double antennaHeight, plowHeight, maxDitchCut, minDitchCut, maxTileCut, minTileCover;

        public byte KpGain, KiGain, KdGain, retDeadband, extDeadband, valveType;

        public double temp = 1;

        //width of cutting tool
        public double toolWidth;



        //autosteer values
        public double goalPointLookAhead;
        public double maxSteerAngle;
        public double maxAngularVelocity;

        public CVehicle(OpenGL _gl, FormGPS _f)
        {
            //constructor
            gl = _gl;
            mf = _f;

            //from settings grab the vehicle specifics
            antennaHeight = Properties.Vehicle.Default.setVehicle_antennaHeight;
            plowHeight = Properties.Vehicle.Default.setVehicle_plowHeight;
            toolWidth = Properties.Vehicle.Default.setVehicle_toolWidth;
            
            // Black Ace Industries
            maxDitchCut = Properties.Vehicle.Default.setVehicle_maxDitchCut;
            minDitchCut = Properties.Vehicle.Default.setVehicle_minDitchCut;
            maxTileCut = Properties.Vehicle.Default.setVehicle_maxTileCut;
            minTileCover = Properties.Vehicle.Default.setVehicle_minTileCover;
            

            wheelbase = Properties.Vehicle.Default.setVehicle_wheelbase;
            goalPointLookAhead = Properties.Vehicle.Default.setVehicle_goalPointLookAhead;

            maxAngularVelocity = Properties.Vehicle.Default.setVehicle_maxAngularVelocity;
            maxSteerAngle = Properties.Vehicle.Default.setVehicle_maxSteerAngle;
            minSlope = -Properties.Vehicle.Default.setVehicle_minSlope;
            minShoreSlope = Properties.Vehicle.Default.setVehicle_minShoreSlope;
        }
        
        public void DrawVehicle()        {
                 
            //translate and rotate at pivot axle            
            gl.Translate(mf.pn.easting, mf.pn.northing, 0);
            gl.Rotate(glm.toDegrees(-mf.fixHeading), 0.0, 0.0, 1.0);
            

            //draw the vehicle Body
            gl.Color(0.25, 0.25, 0.25);
            gl.Begin(OpenGL.GL_TRIANGLE_FAN);            
            gl.Vertex(0.75, -antennaPivot, 0.0);
            gl.Vertex(0, -antennaPivot + 2.5, 0.0);
            gl.Color(0.45, 0.45, 0.45);
            gl.Vertex(-0.75, -antennaPivot, 0.0);
            gl.Vertex(1.0, -antennaPivot, 0.0);
            gl.End();

           
            if (mf.isTurningRight && mf.isTurning) // Vehicle is turning to the right
            {
                //gl.Rotate(glm.toDegrees(-mf.fixHeading), 0.0, 0.0, 1.0);
                temp =  mf.gpsHeading;
                //gl.Rotate(glm.toDegrees(temp), 0.0, 0.0, 1.0);
                //gl.Rotate(mf.camHeading, 0.0, 0.0, 1.0);
            }
            if (!mf.isTurningRight && mf.isTurning) // Vehicle is turning to the Left
            {
                temp = mf.gpsHeading;
                //gl.Rotate(glm.toDegrees(temp), 0.0, 0.0, 1.0);
                //gl.Rotate(mf.camHeading, 0.0, 0.0, 1.0);
            }            
            if (!mf.isTurning) // Vehicle is going straight
            {
                //gl.Rotate(glm.toDegrees(mf.prevPrevGPSHeading), 0.0, 0.0, 1.0);
                //gl.Rotate(mf.camHeading, 0.0, 0.0, 1.0);
            }            

            //Hitch
            gl.Color(0.0f, 0.99f, 0.0f, 0.99f);            
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(antennaPivot - .075, 0, 0);
            gl.Vertex(antennaPivot + .075, 0, 0);
            gl.Vertex(antennaPivot + .15, -3, 0);
            gl.Vertex(antennaPivot - .15, -3, 0);
            gl.End();

            //Scraper front 
            gl.Color(0.0f, 0.99f, 0.0f, 0.65f);
            gl.LineWidth(5);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(-toolWidth /1.5, -3);
            gl.Vertex(toolWidth /1.5, -3);
            gl.End();

            /*//Scraper left edge 
            gl.Color(0.95f, 0.95f, 0.02f);
            gl.LineWidth(3);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(-toolWidth / 1.5, -4, 0);
            gl.Vertex(-toolWidth / 1.5, -9.25, 0);
            gl.End();

            //Scraper right edge 
            gl.Color(0.95f, 0.95f, 0.02f);
            gl.LineWidth(3);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(toolWidth / 1.5, -4, 0);
            gl.Vertex(toolWidth / 1.5, -9.25, 0);
            gl.End();

            //Scraper bowl 
            gl.Color(0.60f, 0.45f, 0.15f);
            //gl.LineWidth(3);
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(-toolWidth / 1.6, -5, 0);                 
            gl.Vertex(toolWidth / 1.6, -5, 0);             
            gl.Vertex(toolWidth / 1.6, -8.25, 0);
            gl.Vertex(-toolWidth / 1.6, -8.25, 0);
            gl.End();

            //Scraper rear 
            gl.Color(0.95f, 0.95f, 0.02f);            
            gl.Begin(OpenGL.GL_POLYGON); 
            gl.Vertex(-toolWidth / 1.5, -8.25, 0);
            gl.Vertex(toolWidth / 1.5, -8.25, 0);
            gl.Vertex(toolWidth / 1.5, -9.25, 0);  
            gl.Vertex(-toolWidth / 1.5, -9.25, 0);            
            gl.End();
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(-toolWidth / 4, -9.25, 0);
            gl.Vertex(toolWidth / 4, -9.25, 0);        
            gl.Vertex(toolWidth / 4, -13, 0);
            gl.Vertex(-toolWidth / 4, -13, 0);
            gl.End();

            //Left Scraper Tire
            gl.Color(0.01f, 0.01f, 0.01f);
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(-toolWidth / 1.5, -9.5, 0);
            gl.Vertex(-toolWidth / 3.25, -9.5, 0);
            gl.Vertex(-toolWidth / 3.25, -12.75, 0);
            gl.Vertex(-toolWidth / 1.5, -12.75, 0);
            gl.End();

            //Right Scraper Tire
            gl.Color(0.01f, 0.01f, 0.01f);
            gl.Begin(OpenGL.GL_POLYGON);
            gl.Vertex(toolWidth / 1.5, -9.5, 0);
            gl.Vertex(toolWidth / 3.25, -9.5, 0);
            gl.Vertex(toolWidth / 3.25, -12.75, 0);
            gl.Vertex(toolWidth / 1.5, -12.75, 0);
            gl.End();



            //Cutting Edge
            gl.Color(0.95f, 0.1f, 0.2f);
            gl.LineWidth(5);
            gl.Begin(OpenGL.GL_LINES);
            gl.Vertex(-toolWidth/2, -5, 0);
            gl.Vertex(toolWidth/2, -5, 0);
            gl.End();


            gl.LineWidth(1);           
            */

        }

    }
}

