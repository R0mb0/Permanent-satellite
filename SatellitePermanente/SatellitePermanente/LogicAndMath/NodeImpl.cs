using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    class NodeImpl: Node
    {
        private readonly Point pointA;
        private readonly Point pointB;

        public NodeImpl(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }


    }
}
