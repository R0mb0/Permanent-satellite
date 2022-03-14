using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace PermanentSatellite.LogicAndMath
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

        /*Method that return the values in graphical way*/
        public string GetAngleString()
        {
            return angle + "°";
        }

        public string GetAltitudeString()
        {
            return altitude + "m";
        }

        /*this method return the corect long string deeping on the registred values*/
        public string GetPointString()
        {
            if(this.angle != null && this.altitude != null)
            {
                return this.name + "\n" + this.latitude.GetString() + "\n" + this.longitude.GetString() + "\n" + GetAngleString() + "\n" + GetAltitudeString();
            }

            if(this.angle != null)
            {
                return this.name + "\n" + this.latitude.GetString() + "\n" + this.longitude.GetString() + "\n" + GetAngleString();
            }

            if(this.altitude != null)
            {
                return this.name + "\n" + this.latitude.GetString() + "\n" + this.longitude.GetString() + "\n" + GetAltitudeString();
            }

            return this.name + "\n" + this.latitude.GetString() + "\n" + this.longitude.GetString();


        }
    }
}
