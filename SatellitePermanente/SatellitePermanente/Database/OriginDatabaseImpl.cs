using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    class OriginDatabaseImpl: OriginDatabase
    {
        public List<Point> pointList { get; set; }

        public List<Node> nodeList { get; set; }

        /*Builder*/
        public OriginDatabaseImpl()
        {
            this.pointList = new List<Point>();
            this.nodeList = new List<Node>();
        }
    }
}
