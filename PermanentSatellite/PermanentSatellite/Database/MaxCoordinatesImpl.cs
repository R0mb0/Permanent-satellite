using PermanentSatellite.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermanentSatellite.Database
{
    class MaxCoordinatesImpl : MaxCoordinates
    {
        /*---------------------------------------------implements abstract methods---------------------------------------------*/
        public override Latitude GetMaxLatitude()
        {
            return this.maxLatitude;
        }

        public override Longitude GetMaxLongitude()
        {
            return this.maxLongitude;
        }

        public override Latitude GetMinLatitude()
        {
            return this.minLatitude;
        }

        public override Longitude GetMinLongitude()
        {
            return this.minLongitude;
        }

        public override void SetMaxLatitude(Latitude maxLatitude)
        {
            this.maxLatitude = maxLatitude;
        }

        public override void SetMaxLongitude(Longitude maxLongitude)
        {
            this.maxLongitude = maxLongitude;
        }

        public override void SetMinLatitude(Latitude minLatitude)
        {
            this.minLatitude = minLatitude;
        }

        public override void SetMinLongitude(Longitude minLongitude)
        {
            this.minLongitude = minLongitude;
        }
    }
}
