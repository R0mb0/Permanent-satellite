using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    interface Database
    {
        public Boolean AddPoint(Point point);

        public Boolean DelettePoint(Point point);

        public Point GetLastPointAdded();

        public Point GetLastPointDelected();

        public Point GetSpecificPoint(int index);

        public List<Point> GetAllPoints();

        public List<Node> GetLastNodeInserted();

        public List<Node> GetLastNodeRemoved();

        public List<Node> GetAllNodes();
    }
}
