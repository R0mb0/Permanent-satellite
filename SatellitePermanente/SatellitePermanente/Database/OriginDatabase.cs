using SatellitePermanente.Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    class OriginDatabase: MaxCoordinates
    {
        public List<Point> pointList { get; set; }

        public List<Node> nodeList { get; set; }

        /*Builder*/
        public OriginDatabase()
        {
            this.pointList = new List<Point>();
            this.nodeList = new List<Node>();
        }
    }
}
