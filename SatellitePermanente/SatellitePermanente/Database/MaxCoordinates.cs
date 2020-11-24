using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    class MaxCoordinates
    {
        public decimal minLatitude { get; set; }
        public decimal maxLatitude { get; set; }
        public decimal minLongitude { get; set; }
        public decimal maxLongitude { get; set; }

        /*Builder*/
        public MaxCoordinates()
        {
            this.minLatitude = 0;
            this.maxLatitude = 0;
            this.minLongitude = 0;
            this.maxLongitude = 0;
        }
    }
}
