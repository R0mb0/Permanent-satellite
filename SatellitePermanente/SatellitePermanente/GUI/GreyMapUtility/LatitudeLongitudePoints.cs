using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace SatellitePermanente.GUI.GreyMapUtility
{
    class LatitudeLongitudePoints
    {
        public List<Point> pointList { get; private set; }

        /*Builder*/
        public LatitudeLongitudePoints(int yMax, int xMax)
        {
            this.pointList = new List<Point>();

            int tempX = 0;
            int tempY = 0;

            /*Generate the latitudes*/
            do
            {
                tempX = tempX + (xMax / 3);

                /*Create the first point*/
                System.Drawing.Point tempPoint1 = new System.Drawing.Point();
                tempPoint1.Y = yMax;
                tempPoint1.X = tempX;
                this.pointList.Add(tempPoint1);

                /*Create the couple of the last pointe create for create a straight from the two points*/
                System.Drawing.Point tempPoint2 = new System.Drawing.Point();
                tempPoint2.Y = 0;
                tempPoint2.X = tempX;
                this.pointList.Add(tempPoint2);

            } while (tempX != xMax);


            /*Generate the longitudes*/
            do
            {
                tempY = tempY + (yMax / 3);

                /*Create the first point*/
                System.Drawing.Point tempPoint1 = new System.Drawing.Point();
                tempPoint1.Y = tempY;
                tempPoint1.X = xMax;
                this.pointList.Add(tempPoint1);

                /*Create the couple of the last pointe create for create a straight from the two points*/
                System.Drawing.Point tempPoint2 = new System.Drawing.Point();
                tempPoint2.Y = tempY;
                tempPoint2.X = 0;
                this.pointList.Add(tempPoint2);

            } while (tempY != yMax);
        }
    }
}
