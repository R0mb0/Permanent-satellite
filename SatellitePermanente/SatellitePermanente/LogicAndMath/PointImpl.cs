using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    class PointImpl : Point
    {
        private readonly Longitude longitude;
        private readonly Latitude latitude;
        private readonly DateTime dateTime;
        private readonly Boolean meetingPoint;
        private readonly int ? angle;
        private readonly int ? altitude;

        public PointImpl(Longitude longitude, Latitude latitude, DateTime dateTime, Boolean meetingPoint)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.dateTime = dateTime;
            this.meetingPoint = meetingPoint;
        }

        public PointImpl(Longitude longitude, Latitude latitude, DateTime dateTime, Boolean meetingPoint, int ? angle, int ? altitude)
        {
            this.longitude = longitude;
            this.latitude = latitude;
            this.dateTime = dateTime;
            this.meetingPoint = meetingPoint;
            this.angle = angle;
            this.altitude = altitude;
        }

        public Longitude GetPointLongitude()
        {
            return this.longitude;
        }

        public Latitude GetPointLatitude()
        {
            return this.latitude;
        }

        public DateTime GetDateTime()
        {
            return this.dateTime;
        }

        public Boolean GetMeetingPoint()
        {
            return this.meetingPoint;
        }

        public int? GetAngle()
        {
            if (this.angle != null)
            {
                return this.angle;
            }

            return null;
        }

        public int? GetAltitude()
        {
            if(this.altitude != null)
            {
                return this.altitude;
            }
           
                return null;
           

        }
    }
}
