using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    /*this values server to speed up the load process of the database, because this are the last graphical params calculated, in other way the program must 
     lose some time to recalculate this values.*/
    class MaxCoordinates
    {
        public Latitude minLatitude { get; set; }
        public Latitude maxLatitude { get; set; }
        public Longitude minLongitude { get; set; }
        public Longitude maxLongitude { get; set; }

    }
}
