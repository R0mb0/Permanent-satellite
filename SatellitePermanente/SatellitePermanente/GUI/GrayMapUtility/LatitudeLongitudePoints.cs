using System.Collections.Generic;
using System.Drawing;

/*This static class is usefull for determinate the posiction of the axes */
public static class LatitudeLongitudePoints 
{
    /*returned list with the points ready to be drawed*/
    private static List<System.Drawing.Point>? pointList;

    public static List<System.Drawing.Point>? GetAxes(int yMax, int xMax)
    {
        /*if the point list was present, return it without do other work*/
        if(pointList != null)
        {
            return pointList;
        }

        /*else calculate the graphical point*/
        pointList = new List<Point>();
        
        int tempX = 0;
        int tempY = 0;

        /*Generate the latitudes lines*/
        do
        {
            tempX = tempX + (xMax / 3);

            /*Create the first point*/
            System.Drawing.Point tempPoint1 = new System.Drawing.Point();
            tempPoint1.Y = yMax;
            tempPoint1.X = tempX;
            pointList.Add(tempPoint1);

            /*Create the couple of the last pointe create for create a straight from the two points*/
            System.Drawing.Point tempPoint2 = new System.Drawing.Point();
            tempPoint2.Y = 0;
            tempPoint2.X = tempX;
            pointList.Add(tempPoint2);

        } while (tempX != xMax);


        /*Generate the longitudes lines*/
        do
        {
            tempY = tempY + (yMax / 3);

            /*Create the first point*/
            System.Drawing.Point tempPoint1 = new System.Drawing.Point();
            tempPoint1.Y = tempY;
            tempPoint1.X = xMax;
            pointList.Add(tempPoint1);

            /*Create the couple of the last pointe create for create a straight from the two points*/
            System.Drawing.Point tempPoint2 = new System.Drawing.Point();
            tempPoint2.Y = tempY;
            tempPoint2.X = 0;
            pointList.Add(tempPoint2);

        } while (tempY != yMax);

        return pointList;



    }


}
