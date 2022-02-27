using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    /*this values server to speed up the load process of the database, because this are the last graphical params calculated, in other way the program must 
     lose some time to recalculate this values.*/
    abstract class MaxCoordinates
    {
        /*private fields of the class*/
        protected Latitude minLatitude { get; set; }
        protected Latitude maxLatitude { get; set; }
        protected Longitude minLongitude { get; set; }
        protected Longitude maxLongitude { get; set; }

        /*Get methods*/
        public abstract Latitude GetMinLatitude();
        public abstract Latitude GetMaxLatitude();
        public abstract Longitude GetMinLongitude();
        public abstract Longitude GetMaxLongitude();

        /*Set mthods*/
        public abstract void SetMinLatitude(Latitude minLatitude);
        public abstract void SetMaxLatitude(Latitude maxLatitude);
        public abstract void SetMinLongitude(Longitude minLongitude);
        public abstract void SetMaxLongitude(Longitude maxLongitude);

    }
}
