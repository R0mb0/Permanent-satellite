using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Class shape a detection Point*/
    class Point
    {
        /*Fields*/
        public Longitude longitude { get; private set; }

        public Latitude latitude { get; private set; }

        public DateTime dateTime { get; private set; }

        public Boolean meetingPoint { get; private set; }

        public int? angle { get; private set; }

        public int? altitude { get; private set; }

        public String? name { get; private set; }

        /*Builder with optional params that are usefull for a more precision, but are unnecessary in the application contest*/
        public Point(Latitude latitude, Longitude longitude, DateTime dateTime, Boolean meetingPoint, int? angle, int? altitude, String? name)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.dateTime = dateTime;
            this.meetingPoint = meetingPoint;
            this.angle = angle;
            this.altitude = altitude;
            this.name = name;
        }

        public string GetAngleString()
        {
            return angle + "°";
        }

        public string GetAltitudeString()
        {
            return altitude + "m";
        }

        
    }
}
