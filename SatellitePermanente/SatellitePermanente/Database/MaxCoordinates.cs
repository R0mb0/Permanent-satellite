using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    class MaxCoordinates
    {
        public Latitude minLatitude { get; set; }
        public Latitude maxLatitude { get; set; }
        public Longitude minLongitude { get; set; }
        public Longitude maxLongitude { get; set; }

        /*Builder*/
        public MaxCoordinates()
        {
            this.minLatitude = new Latitude("N", 00, 00, 00000); 
            this.maxLatitude = new Latitude("N", 00, 00, 00000); 
            this.minLongitude = new Longitude("E", 00, 00, 00000);
            this.maxLongitude = new Longitude("E", 00, 00, 00000);
        }

    }
}
