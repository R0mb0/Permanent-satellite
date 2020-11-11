using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    interface OriginDatabase
    {
        public List<Point> pointList { get; set; }

        public List<Node> nodeList { get; set; }

    }
}
