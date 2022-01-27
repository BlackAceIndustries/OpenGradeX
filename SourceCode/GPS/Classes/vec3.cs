﻿//Please, if you use this, share the improvements

using System;

namespace OpenGrade
{
    /// <summary>
    /// Represents a three dimensional vector.
    /// </summary>
    public struct vec3
    {
        public double easting;
        public double northing;
        public double heading;

        public vec3(double easting, double northing, double heading)
        {
            this.easting = easting;
            this.northing = northing;
            this.heading = heading;
        }

       public vec3(vec3 v)
        {
            easting = v.easting;
            northing = v.northing;
            heading = v.heading;
         }

        public double HeadingXZ()
        {
            return Math.Atan2(easting, northing);
        }

        public void Normalize()
        {
            double length = GetLength();
            if (Math.Abs(length) < 0.0000000000001)
            {
                throw new DivideByZeroException("Trying to normalize a vector with length of zero.");
            }

            easting /= length;
            northing /= length;
            heading /= length;
        }

        //Returns the length of the vector
        public double GetLength()
        {
            return Math.Sqrt(easting * easting + heading * heading + northing * northing);
        }

        // Calculates the squared length of the vector.
        public double GetLengthSquared()
        {
            return (easting * easting + heading * heading + northing * northing);
        }

        public static vec3 operator -(vec3 lhs, vec3 rhs)
        {
            return new vec3(lhs.easting - rhs.easting, lhs.northing - rhs.northing, lhs.heading - rhs.heading);
        }

        //public static bool operator ==(vec3 lhs, vec3 rhs)
        //{
        //    return (lhs.x == rhs.x && lhs.z == rhs.z && lhs.h == rhs.h);
        //}

        //public static bool operator !=(vec3 lhs, vec3 rhs)
        //{
        //    return (lhs.x != rhs.x && lhs.z != rhs.z && lhs.h != rhs.h);
        //}

    }

    //

    /// <summary>
    /// x,y,z,k
    /// </summary>
    public struct vec4
    {
        public double easting; //easting
        public double heading; //heading etc
        public double northing; //northing
        public double altitude;    //altitude

        public vec4(double easting, double heading, double northing, double altitude)
        {
            this.easting = easting;
            this.heading = heading;
            this.northing = northing;
            this.altitude = altitude;
        }
    }

    public struct vec2
    {
        public double easting; //easting
        public double northing; //northing

        public vec2(double easting, double northing)
        {
            this.easting = easting;
            this.northing = northing;
       }

        public static vec2 operator -(vec2 lhs, vec2 rhs)
        {
            return new vec2(lhs.easting - rhs.easting, lhs.northing - rhs.northing);
        }

        //public static bool operator ==(vec2 lhs, vec2 rhs)
        //{
        //    return (lhs.x == rhs.x && lhs.z == rhs.z);
        //}

        //public static bool operator !=(vec2 lhs, vec2 rhs)
        //{
        //    return (lhs.x != rhs.x && lhs.z != rhs.z);
        //}

        //calculate the heading of dirction pointx to pointz
        public double HeadingXZ()
        {
            return Math.Atan2(easting, northing);
        }

        //normalize to 1
        public void Normalize()
        {
            double length = GetLength();
            if (Math.Abs(length) < 0.000000000001)
            {
                throw new DivideByZeroException("Trying to normalize a vector with length of zero.");
            }

            easting /= length;
            northing /= length;
        }

        //Returns the length of the vector
        public double GetLength()
        {
            return Math.Sqrt(easting * easting + northing * northing);
        }

        // Calculates the squared length of the vector.
        public double GetLengthSquared()
        {
            return (easting * easting + northing * northing);
        }
    }

    //strucutre for contour guidance
    public struct cvec
    {
        public double x;
        public double z;
        public double h;
        public int strip;
        public int pt;

        //specialized contour vector
         public cvec(double x, double z, double h, int s, int p)
        {
            this.x = x;
            this.z = z;
            this.h = h;
            strip = s;
            pt = p;
        }

         public cvec(vec3 v)
         {
             x = v.easting;
             z = v.northing;
             h = v.heading;
             strip = 99999;
             pt = 99999;
         }
    }
}

//public double this[int index]
//{
//    get
//    {
//        if (index == 0) return x;
//        else if (index == 1) return z;
//        else throw new Exception("Out of range.");
//    }
//    set
//    {
//        if (index == 0) x = value;
//        else if (index == 1) z = value;
//        else throw new Exception("Out of range.");
//    }
//}

//public vec2(double s)
//{
//    x = z = s;
//}

//public vec2(vec2 v)
//{
//    this.x = v.x;
//    this.z = v.z;
//}

//public vec2(vec3 v)
//{
//    this.x = v.x;
//    this.z = v.z;
//}

//public static vec2 operator +(vec2 lhs, vec2 rhs)
//{
//    return new vec2(lhs.x + rhs.x, lhs.z + rhs.z);
//}

//public static vec2 operator +(vec2 lhs, double rhs)
//{
//    return new vec2(lhs.x + rhs, lhs.z + rhs);
//}

//public static vec2 operator -(vec2 lhs, double rhs)
//{
//    return new vec2(lhs.x - rhs, lhs.z - rhs);
//}

//public static vec2 operator *(vec2 self, double s)
//{
//    return new vec2(self.x * s, self.z * s);
//}

//public static vec2 operator *(double lhs, vec2 rhs)
//{
//    return new vec2(rhs.x * lhs, rhs.z * lhs);
//}

//public static vec2 operator *(vec2 lhs, vec2 rhs)
//{
//    return new vec2(rhs.x * lhs.x, rhs.z * lhs.z);
//}

//public static vec2 operator /(vec2 lhs, double rhs)
//{
//    return new vec2(lhs.x / rhs, lhs.z / rhs);
//}

//public double[] to_array()
//{
//    return new[] { x, z };
//}
