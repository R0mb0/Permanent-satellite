using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
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
