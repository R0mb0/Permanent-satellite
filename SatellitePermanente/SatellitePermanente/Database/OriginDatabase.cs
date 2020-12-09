using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    abstract class OriginDatabase :MaxCoordinates
    {
        /*Fields*/
        protected List<Point> pointList { get; set; }
        protected List<Node> nodeList { get; set; }

        /*return method*/
        public abstract List<Point> GetPointList();
        public abstract List<Node> GetNodeList();
        public abstract void SetPointList(List<Point> pointList);
        public abstract void SetNodeList(List<Node> nodeList);



    }
}
