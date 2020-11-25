using SatellitePermanente.Database;
using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.GUI.GrayMapUtility
{
    class ConvertToGraphic
    {
        /*private fields*/
        private readonly int Y,X;
        private readonly MaxCoordinates coordinates;
        private MaxCoordinates ExtremeCoordinates;

        public ConvertToGraphic(int Y, int X, MaxCoordinates coordinates)
        {
            this.Y = Y;
            this.X = X;
            this.coordinates = coordinates;
            GetExtremes();
        }

        private void GetExtremes()
        {
            
            
        }


        



    }
}
