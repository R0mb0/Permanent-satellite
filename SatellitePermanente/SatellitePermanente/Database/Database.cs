using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This Interface shape a Database where is possible salve Points and Nodes, this informaction will be used from GUI*/
    interface Database : OriginDatabase
    {
        public List<Node> lastNodeAdded { get; }

        public List<Node> lastNodeDelected { get; }

        public Point lastPointDelected { get; }

        /*This Method return true if the Point is allocated, otherwise return false*/
        public Boolean AddPoint(Point point);

        /*This Method return true if the Point is disallocated, otherwise return false*/
        public Boolean DelettePoint(Point point);

        public Boolean DeletePointFromIndex(int index);



    }
}
