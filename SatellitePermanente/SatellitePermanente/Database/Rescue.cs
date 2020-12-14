using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    class Rescue
    {
        /*this class is created to permitt the json method to salve and load correctly the dates, because using the decorator pattern it doesn`t work*/
        public List<Point> pointList { get; private set; }
        public List<Node> nodeList { get; private set; }

        public Latitude minLatitude { get; private set; }
        public Latitude maxLatitude { get; private set; }
        public Longitude minLongitude { get; private set; }
        public Longitude maxLongitude { get; private set; }


        /*Builder*/
        public Rescue(List<Point> pointList, List<Node> nodeList, Latitude minLatitude, Latitude maxLatitude, Longitude minLongitude, Longitude maxLongitude)
        {
            this.pointList = new List<Point>();
            this.nodeList = new List<Node>();

            this.pointList = pointList;
            this.nodeList = nodeList;
            this.minLatitude = minLatitude;
            this.maxLatitude = maxLatitude;
            this.minLongitude = minLongitude;
            this.maxLongitude = maxLongitude;
        }
    }
}
