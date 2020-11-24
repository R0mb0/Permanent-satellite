using System.Collections.Generic;
using System.Drawing;

public static class LatitudeLongitudePoints 
{
    private static List<System.Drawing.Point>? pointList { get; set; }
    private static int Y { get; set; }
    private static int X { get; set; }

    public static List<System.Drawing.Point>? GetAxes(int yMax, int xMax)
    {
        if(pointList != null)
        {
            return pointList;
        }

        pointList = new List<Point>();
        Y = yMax;
        X = xMax;


        int tempX = 0;
        int tempY = 0;

        /*Generate the latitudes lines*/
        do
        {
            tempX = tempX + (X / 3);

            /*Create the first point*/
            System.Drawing.Point tempPoint1 = new System.Drawing.Point();
            tempPoint1.Y = Y;
            tempPoint1.X = tempX;
            pointList.Add(tempPoint1);

            /*Create the couple of the last pointe create for create a straight from the two points*/
            System.Drawing.Point tempPoint2 = new System.Drawing.Point();
            tempPoint2.Y = 0;
            tempPoint2.X = tempX;
            pointList.Add(tempPoint2);

        } while (tempX != X);


        /*Generate the longitudes lines*/
        do
        {
            tempY = tempY + (Y / 3);

            /*Create the first point*/
            System.Drawing.Point tempPoint1 = new System.Drawing.Point();
            tempPoint1.Y = tempY;
            tempPoint1.X = X;
            pointList.Add(tempPoint1);

            /*Create the couple of the last pointe create for create a straight from the two points*/
            System.Drawing.Point tempPoint2 = new System.Drawing.Point();
            tempPoint2.Y = tempY;
            tempPoint2.X = 0;
            pointList.Add(tempPoint2);

        } while (tempY != Y);

        return pointList;



    }


}
