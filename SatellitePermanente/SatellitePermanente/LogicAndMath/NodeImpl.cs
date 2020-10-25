using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    /*This class shape a Node from two Point*/
    class NodeImpl: Node
    {
        private readonly Point pointA;
        private readonly Point pointB;
        private static readonly Utility util = new UtilityImpl();

        public NodeImpl(Point pointA, Point pointB)
        {
            this.pointA = pointA;
            this.pointB = pointB;
        }

        /*Get methods*/

        public Point GetPointA()
        {
            return this.pointA;
        }

        public Point GetPointB()
        {
            return this.pointB;
        }

        /*Get Property of nodes*/

        public decimal GetDistance()
        {
            return util.CalculateDistance(pointA, pointB);
        }

        public decimal GetDirection()
        {
            return util.CalculateDirection(pointA, pointB);
        }

        public TimeSpan GetTimeDiffrence()
        {
            return util.CalculateTimeDifference(pointA, pointB);
        }

        public decimal GetSpeed()
        {
            return util.CalculateSpeed(pointA, pointB);
        }

        public int? GetAltitudeDifference()
        {
            return util.CalculateAltitudeDifference(pointA, pointB);
        }
    }
}
