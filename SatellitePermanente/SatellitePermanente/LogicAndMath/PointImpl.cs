using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Class shape a detection Point*/
    class PointImpl : Point
    {
        /*Fields*/
        public Longitude longitude { get; }

        public Latitude latitude { get; }

        public DateTime dateTime { get; }

        public Boolean meetingPoint { get; }

        public int ? angle { get; }

        public int ? altitude { get; }

        public PointImpl(Latitude latitude, Longitude longitude, DateTime dateTime, Boolean meetingPoint)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.dateTime = dateTime;
            this.meetingPoint = meetingPoint;
        }

        /*Builder with optional param*/
        public PointImpl(Latitude latitude, Longitude longitude, DateTime dateTime, Boolean meetingPoint, int ? angle, int ? altitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.dateTime = dateTime;
            this.meetingPoint = meetingPoint;
            this.angle = angle;
            this.altitude = altitude;
        }

        
    }
}
