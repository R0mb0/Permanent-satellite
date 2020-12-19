using Microsoft.VisualBasic.CompilerServices;
using SatellitePermanente.Database;
using SatellitePermanente.Observer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SatellitePermanente.LogicAndMath
{
    /*This Class shape a Database where il possible salve Points and Nodes*/
    class NormalDatabaseImpl : NormalDatabase
    {

        /*salve the status of the primary class*/
        private static OriginDatabaseImpl database;

        /*Private istance*/
        private static NormalDatabaseImpl istance = null;

        /*Builder*/
        private NormalDatabaseImpl(OriginDatabaseImpl d)
        {
            database = d;

            this.meetingPoint = null;
            this.flagMeetingPoint = false;
            this.firstRun = true;

            this.lastNodeAdded = new List<Node>();
            this.lastNodeDelected = new List<Node>();
            
        }

        /*Return the istance*/
        public static NormalDatabaseImpl GetIstance()
        {
            if(istance == null)
            {
                istance = new NormalDatabaseImpl(new OriginDatabaseImpl(new MaxCoordinatesImpl()));
            }

            return istance;
        }

        /*Method for salving the min/max of latitude/longitude*/
        private void MinOrMax(Point point)
        {
            if(this.firstRun || point.latitude.GetLatitude() > database.GetMaxLatitude().GetLatitude())
            {
                database.SetMaxLatitude(point.latitude);
            }

            if (this.firstRun || point.latitude.GetLatitude() < database.GetMinLatitude().GetLatitude())
            {
                database.SetMinLatitude(point.latitude);
            }

            if (this.firstRun || point.longitude.GetLongitude() > database.GetMaxLongitude().GetLongitude())
            {
                database.SetMaxLongitude(point.longitude);
            }

            if (this.firstRun || point.longitude.GetLongitude() < database.GetMinLongitude().GetLongitude())
            {
                database.SetMinLongitude(point.longitude);
            }

            this.firstRun = false;
        }

        /*This private method try to add Node from allocated point*/
        private void TryToAllocateNode(Point point)
        {
            if (database.GetPointList().Count >= 1)
            {

                if (this.meetingPoint != null)
                {
                    this.lastNodeAdded.Clear();

                    if (point.meetingPoint && !this.flagMeetingPoint)/*First case of adding, when there are in database always normal point and in this moment is setted a meeting point*/
                    {
                        database.GetPointList().ForEach(delegate (Point myPoint)/*iterate the list in way to create a node with the other points that don`t have a node with the meeting point*/
                        {
                            database.GetNodeList().Add(new Node(point, myPoint));
                            this.lastNodeAdded.Add(new Node(point, myPoint));
                        });

                        this.flagMeetingPoint = true; /*this is setted true in the time when is registered a meeting point into the databse, in this way (in case of new point to insert) is possible enter into the third case*/
                    }
                    else
                    {
                        if (database.GetPointList().Last().meetingPoint)/*Second case of adding when the first point added is the meeting point and the new added point is a normal point*/
                        {
                            database.GetNodeList().Add(new Node(database.GetPointList().Last(), point));
                            this.lastNodeAdded.Add(new Node(database.GetPointList().Last(), point));

                            database.GetNodeList().Add(new Node(database.GetPointList()[database.GetPointList().IndexOf(database.GetPointList().Last()) - 1], point));
                            this.lastNodeAdded.Add(new Node(database.GetPointList()[database.GetPointList().IndexOf(database.GetPointList().Last()) - 1], point));

                        }
                        else/*Third case of adding, when the meeting point is setted and the last added points are normal point*/
                        {
                            database.GetNodeList().Add(new Node(meetingPoint, point));
                            database.GetNodeList().Add(new Node(database.GetPointList().Last(), point));
                            this.lastNodeAdded.Add(new Node(meetingPoint, point));
                            this.lastNodeAdded.Add(new Node(database.GetPointList().Last(), point));
                        }
                        
                    }
                }

                if (this.meetingPoint == null)/*Fourth case of adding, in this case the meeting point is not setted and the points are normal*/
                {
                    this.lastNodeAdded.Clear();

                    if (!database.GetPointList().Last().meetingPoint)
                    {
                        database.GetNodeList().Add(new Node(database.GetPointList().Last(), point));
                        this.lastNodeAdded.Add(new Node(database.GetPointList().Last(), point));
                    }
                }
            }
            /*Verify if the coordinates of this point are estremes of the geographic plan*/
            MinOrMax(point);
            database.GetPointList().Add(point);
        }

        /*This method return true if the Point is allocated, otherwise return false*/
        public override Boolean AddPoint(Point point)
        {
            /*verify that the new point to insert is not resemble with the insterted points */
            database.GetPointList().ForEach(delegate (Point mypoint) 
            {
                if (PointUtility.EqualsPoints(mypoint, point))
                {
                    throw new Exception("Trying to add a point already added!");
                }
            });
              
            /*in case of a special point*/
            if (point.meetingPoint)
            {
                if(this.meetingPoint != null)/*Create an exception if the meeting point is arledy setted*/
                {
                    throw new Exception("Trying to set another meeting point!");
                }

                this.meetingPoint = point; /*otherwise impost the meeting of the entire database*/

            }

            TryToAllocateNode(point); /*later the adding of the new point, try to create new nodes with the new point added*/

            /*Update the observer*/ //<--------------------------------------------
            DatabaseObserver.Update();

            return database.GetPointList().Contains(point);/*return the presence of the new point into the database*/
        }

        /*This method is usefull to rmove a point form the list (Consequently the corrispettive nodes) and  
         * return true if the Point is disallocated, otherwise return false*/
        public override Boolean DeletePoint(Point point)
        {
            if (!database.GetPointList().Contains(point))/*fisrt control; is if the point to delete exist*/
            {
                throw new ArgumentException("The point doesn`t exsist!");
            }

            /*preparing the reference of this action*/
            this.lastNodeDelected.Clear();

            database.GetNodeList().ForEach(delegate (Node myNode){/*search all nodes created with the point to delette */

                if(PointUtility.EqualsPoints(myNode.pointA, point) || PointUtility.EqualsPoints(myNode.pointB, point))
                {
                    this.lastNodeDelected.Add(myNode);
                }
            });
            
            if (this.lastNodeDelected.Count > 0)/*if the search have finded some nodes, is possible remove thi nodes*/
            {
                this.lastNodeDelected.ForEach(delegate (Node myNode) {/*elimite all nodes finded*/
                    database.GetNodeList().Remove(myNode);
                });

                this.lastPointDelected = point;/*set last point delected*/
                
                if (point.meetingPoint) /*if the point to eliminate ia a meeting point, reimposte the condiction of nodes creation in case of meeting point*/
                {
                    this.meetingPoint = null;
                    this.flagMeetingPoint = false;
                }

                database.GetPointList().Remove(point);/*remove the point*/

                return !database.GetPointList().Contains(point);
            }

            if(database.GetPointList().Count == 1)
            {
                database.GetPointList().Remove(point);/*remove the point*/

                return !database.GetPointList().Contains(point);
            }

            /*Update the observer status */ 
            DatabaseObserver.Update();

            return false;
        }

        /*This method is usefull for delete a node from a index*/
        public override Boolean DeletePointFromIndex(int index)
        {

            /*Update the observer status */ 
            DatabaseObserver.Update();

            return DeletePoint(database.GetPointList()[index]);
        }

        /*-------------------------------------------implements abstract methods-------------------------------------------------------------------------/*/
        public override List<Point> GetPointList()
        {
            return database.GetPointList();
        }


        public override List<Node> GetNodeList()
        {
            return database.GetNodeList();
        }

        public override List<Node> GetLastNodeAdded()
        {
            return this.lastNodeAdded;
        }

        public override List<Node> GetLastNodeDelected()
        {
            return this.lastNodeDelected;
        }

        public override Latitude GetMinLatitude()
        {
            return database.GetMinLatitude();
        }

        public override Latitude GetMaxLatitude()
        {
            return database.GetMaxLatitude();
        }

        public override Longitude GetMinLongitude()
        {
            return database.GetMinLongitude();
        }

        public override Longitude GetMaxLongitude()
        {
            return database.GetMaxLongitude();
        }

        public override void SetPointList(List<Point> pointList)
        {
            database.SetPointList(pointList);
        }

        public override void SetNodeList(List<Node> nodeList)
        {
            database.SetNodeList(nodeList);
        }

        public override void SetMinLatitude(Latitude minLatitude)
        {
            database.SetMinLatitude(minLatitude);
        }

        public override void SetMaxLatitude(Latitude maxLatitude)
        {
            database.SetMaxLatitude(maxLatitude);
        }

        public override void SetMinLongitude(Longitude minLongitude)
        {
            database.SetMinLongitude(minLongitude);
        }

        public override void SetMaxLongitude(Longitude maxLongitude)
        {
            database.SetMaxLongitude(maxLongitude);
        }
    }
}
