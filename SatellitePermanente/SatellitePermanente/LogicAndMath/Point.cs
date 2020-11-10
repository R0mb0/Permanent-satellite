using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Interface shape a Point of detection, the associate class work using the Latitude Class, 
     * and the Longitude Class*/
    interface Point
    {
        public Longitude longitude { get; }

        public Latitude latitude { get; }

        public DateTime dateTime { get; }

        public Boolean meetingPoint { get; }

        public int? angle { get; }

        public int? altitude { get; }

    }
}
