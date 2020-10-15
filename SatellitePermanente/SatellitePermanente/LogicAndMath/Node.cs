using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    interface Node
    {
        public decimal GetDistance();

        public DateTime GetTimeDiffrence();

        public decimal GetSpeed();

        public int? GetAltitudeDifference();
    }
}
