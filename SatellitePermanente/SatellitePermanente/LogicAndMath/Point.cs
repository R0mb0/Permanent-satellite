using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    interface Point
    {
        public Latitude GetPointLatitude();

        public Longitude GetPointLongitude();

        public DateTime GetDateTime();

        public Boolean GetMeetingPoint();

        public int? GetAngle();

        public int? GetAltitude();

    }
}
