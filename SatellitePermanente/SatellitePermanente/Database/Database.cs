using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Interface shape a Database where is possible salve Points and Nodes, this informaction will be used from GUI*/
    interface Database
    {
        /*This Method return true if the Point is allocated, otherwise return false*/
        public Boolean AddPoint(Point point);

        /*This Method return true if the Point is disallocated, otherwise return false*/
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
