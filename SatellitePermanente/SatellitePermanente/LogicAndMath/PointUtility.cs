
using SatellitePermanente.LogicAndMath;
using System.Collections.Generic;

static class PointUtility 
{ 
public static bool EqualsPoints(Point pointA, Point pointB)
    {
        if(pointA.latitude.GetLatitude() != pointB.latitude.GetLatitude())
        {
            return false;
        }

        if (pointA.longitude.GetLongitude() != pointB.longitude.GetLongitude())
        {
            return false;
        }

        if (!pointA.dateTime.Equals(pointB.dateTime))
        {
            return false;
        }

        if(pointA.altitude != pointB.altitude)
        {
            return false;
        }

        if(pointA.angle != pointB.angle)
        {
            return false;
        }

        return true;
    }

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
