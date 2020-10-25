using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Interface shape a Point of detection, the associate class work using the Latitude Class, 
     * and the Longitude Class*/
    interface Point
    {
        public Latitude GetPointLatitude();

        public Longitude GetPointLongitude();

        public DateTime GetDateTime();

        public Boolean GetMeetingPoint();

        /*Opzional param to the detection*/

        public int? GetAngle();

        public int? GetAltitude();

    }
}
