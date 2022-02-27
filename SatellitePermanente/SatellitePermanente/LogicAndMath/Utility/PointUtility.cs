
using SatellitePermanente.LogicAndMath;
using System.Collections.Generic;

static class PointUtility 
{ /*This static class permitt to do some operation that semplify the point management*/

    /*This Static method verify the equality of two points (because in some database operation the points can lost it`s track number and for verify the insert 
     * of the same point into the database)*/
public static bool EqualsPoints(Point pointA, Point pointB)
    {

        if(pointA.latitude.GetLatitude() == pointB.latitude.GetLatitude() && pointA.longitude.GetLongitude() == pointB.longitude.GetLongitude()
            || pointA.dateTime.Equals(pointB.dateTime))
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    /*This Static method verify the equality of two nodes, this method was added in way to rendere this class a more generic class */
    public static bool EqualsNodes(Node nodeA, Node nodeB)
    {
        if(EqualsPoints(nodeA.pointA, nodeB.pointA) && EqualsPoints(nodeA.pointB, nodeB.pointB))
        {
            return true;
        }

        if (EqualsPoints(nodeA.pointA, nodeB.pointB) && EqualsPoints(nodeA.pointB, nodeB.pointA))
        {
            return true;
        }

        return false;
    }

    /*This static methos search in a list the corrispettive point, in this way is possible simplify the code in other class.*/
    public static Point GetCorrespondingPoint(List<Point> listPoint, Point point)
    {

        Point? targhet = null; 

        listPoint.ForEach(delegate (Point myPoint) 
        {
            if(EqualsPoints(point, myPoint))
            {
                targhet = myPoint;   
            }
        });

        return targhet;
    }
}
