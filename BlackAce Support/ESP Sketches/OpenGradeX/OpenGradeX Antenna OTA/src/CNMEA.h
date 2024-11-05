
#include <string.h>
#include "vector.h"
#include <cmath>

    class CNMEA
    {

        public:        

        //WGS84 Lat Long
        double latitude, longitude;
        double latDegSec, lonDegSec;
        double northing, easting;
        double prevLatitude, prevLongitude;
        double fixHeading = 0.0, gpsHeading = 10.0;
        double timeSliceOfLastFix = 0;
        double lastfixTime=0;
        double nowHz = 0;
        int headingFromSource = fixHead; // 
        enum headingSources {ggaHead, fixHead};
        
        
        bool isFirstFixPositionSet = false, isGPSPositionInitialized = false, isFirstHeadingSet = false, 
            isReverse = false, isSuperSlow = false;


        #define PI_180 0.01745329251994329576923690768489
        const double magicNumTest =  200.0;


        //local plane geometry
        double latStart, lonStart;
        double northingStart, eastingStart;
        double mPerDegreeLat, mPerDegreeLon;



        //other GIS Info
        double altitude = 0, speed = 0, newSpeed = 0;
        double avgSpeed = 0.0;
        double knots;

        double headingTrueDual, headingTrue, hdop, age, headingTrueDualOffset;

        int fixQuality, ageAlarm;
        int satellitesTracked;
        //String fixQualitystr;

        

        CNMEA()
        {
            //constructor, grab the main form reference
            //mf = f;
            latStart = 0;
            lonStart = 0;
            //ageAlarm = Properties.Settings.Default.setGPS_ageAlarm;
        }


     
        void AverageTheSpeed()
        {            
            avgSpeed = (avgSpeed * .7) + (speed * 0.3);          
            
        }

        void SetLocalMetersPerDegree()
        {
            mPerDegreeLat = 111132.92 - 559.82 * cos(2.0 * latStart * PI_180) + 1.175
            * cos(4.0 * latStart * PI_180) - 0.0023
            * cos(6.0 * latStart * PI_180);

            mPerDegreeLon = 111412.84 * cos(latStart * PI_180) - 93.5
            * cos(3.0 * latStart * PI_180) + 0.118
            * cos(5.0 * latStart * PI_180);

            //ConvertWGS84ToLocal(latitude, longitude, &fix.northing, &fix.easting);
            //ConvertWGS84ToLocal(latitude, longitude, fix.northing, fix.easting);
        }
        
        void ConvertWGS84ToLocal(double Lat, double Lon, double* Northing, double* Easting)
        {
            mPerDegreeLon = 111412.84 * cos(Lat * PI_180) - 93.5 * cos(3.0 * Lat * PI_180) + 0.118 * cos(5.0 * Lat * PI_180);
            
            *Northing = (Lat - latStart) * mPerDegreeLat;
            *Easting = (Lon - lonStart) * mPerDegreeLon;

            //Northing += mf.RandomNumber(-0.02, 0.02);
            //Easting += mf.RandomNumber(-0.02, 0.02);
        }

        void ConvertWGS84ToLocal2(double Lat, double Lon, double* Northing, double* Easting)
        {    
            mPerDegreeLon = 111412.84 * cos(abs(Lat)) - 93.5 * cos(3.0 *abs(Lat)) + 0.118 * cos(5.0 * abs(Lat));
            mPerDegreeLat = 111132.92 - 559.82 * cos(2.0 * abs(Lat)) + 1.175 * cos(4.0 * abs(Lat)) - 0.0023 * cos(6.0 * abs(Lat));

            //mPerDegreeLon = 111412.84 * cos(Lat * magicNum) - 93.5 * cos(3.0 * Lat * magicNum) + 0.118 * cos(5.0 * Lat * magicNum);
            //mPerDegreeLat = 111132.92 - 559.82 * cos(2.0 * Lat * magicNumTest) + 1.175 * cos(4.0 * Lat * magicNumTest) - 0.0023 * cos(6.0 * Lat * magicNumTest);
            
            *Northing = (Lat - latStart) * mPerDegreeLat;// * 0.01764156739461736708981959482642;
            *Easting = (Lon - lonStart) * mPerDegreeLon;// * 0.0689747591795550930962178219918


            //*Northing = (Lat - latStart) * mPerDegreeLat * 0.01764156739461736708981959482642;//;
            //*Easting = (Lon - lonStart) * mPerDegreeLon * 0.0689747591795550930962178219918;//
            
        }

        double conv_coords(double in_coords, char dir[3])
        {
            //Initialize the location.
            double f = in_coords;
            // Get the first two digits by turning f into an integer, then doing an integer divide by 100;
            // firsttowdigits should be 77 at this point.
            int firsttwodigits = ((int)f)/100; //This assumes that f < 10000.
            double nexttwodigits = f - (double)(firsttwodigits*100);
            double theFinalAnswer = (double)(firsttwodigits + nexttwodigits/60.0);

            if(strcmp(dir, "S") == 0)
            { 
                theFinalAnswer = -theFinalAnswer;
                //Serial.print("SOUTH");
            }
            if(strcmp(dir, "W") == 0){
                theFinalAnswer = -theFinalAnswer;
                //Serial.print("WEST");
            }

         return theFinalAnswer;
        }

        double conv_coords_dir(double in_coords, char dir[3])
        {
            if(strcmp(dir, "S") == 0)
            { 
                in_coords = -in_coords;
                //Serial.print("SOUTH");
            }
            if(strcmp(dir, "W") == 0){
                in_coords = -in_coords;
                //Serial.print("WEST");
            }

         return in_coords;
        }
    };
    

