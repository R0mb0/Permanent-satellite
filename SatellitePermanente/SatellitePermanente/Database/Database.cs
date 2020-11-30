using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace SatellitePermanente.LogicAndMath
{
    /*This Class shape a Database where il possible salve Points and Nodes*/
    class Database :OriginDatabase
    {
        /*Fieds and utility values*/
        protected Point? meetingPoint = null; /*this field register the meeting point of the entire database, becausa could be exist only one meeting point*/

        protected bool flagMeetingPoint = false; //this field is for register when the points (before at the meeting point) have its meeting point nodes 

        /*this fileds is protected in way to be setted in other class, for exaple when the database is loaded this fields is false*/
        protected bool firstRun = true;//this filed is for register the state of the prgram, in way to that the MaxCoordinates going to be initialize correctly

        /*this three fieds are unused during the program, but permit to have a generic database*/
        public List<Node> lastNodeAdded { get; }

        public List<Node> lastNodeDelected { get; }

        public Point lastPointDelected { get; private set; }

        /*Builder*/
        public Database()
        { 
            this.lastNodeAdded = new List<Node>();
            this.lastNodeDelected = new List<Node>();
        }

        /*Method for salving the min/max of latitude/longitude*/
        private void MinOrMax(Point point)
        {
            if(this.firstRun || point.latitude.GetLatitude() > base.maxLatitude.GetLatitude())
            {
                base.maxLatitude = point.latitude;
            }

            if (this.firstRun || point.latitude.GetLatitude() < base.minLatitude.GetLatitude())
            {
                base.minLatitude = point.latitude;
            }

            if (this.firstRun || point.longitude.GetLongitude() > base.maxLongitude.GetLongitude())
            {
                base.maxLongitude = point.longitude;
            }

            if (this.firstRun || point.longitude.GetLongitude() < base.minLongitude.GetLongitude())
            {
                base.minLongitude = point.longitude;
            }

            this.firstRun = false;
        }

        /*This private method try to add Node from allocated point*/
        private void TryToAllocateNode(Point point)
        {
            if (base.pointList.Count >= 1)
            {

                if (this.meetingPoint != null)
                {
                    this.lastNodeAdded.Clear();

                    if (point.meetingPoint && !this.flagMeetingPoint)/*First case of adding, when there are in database always normal point and in this moment is setted a meeting point*/
                    {
                        base.pointList.ForEach(delegate (Point myPoint)/*iterate the list in way to create a node with the other points that don`t have a node with the meeting point*/
                        {
                            base.nodeList.Add(new Node(point, myPoint));
                            this.lastNodeAdded.Add(new Node(point, myPoint));
                        });

                        this.flagMeetingPoint = true; /*this is setted true in the time when is registered a meeting point into the databse, in this way (in case of new point to insert) is possible enter into the third case*/
                    }
                    else
                    {
                        if (base.pointList.Last().meetingPoint)/*Second case of adding when the first point added is the meeting point and the new added point is a normal point*/
                        {
                            base.nodeList.Add(new Node(base.pointList.Last(), point));
                            this.lastNodeAdded.Add(new Node(base.pointList.Last(), point));

                            base.nodeList.Add(new Node(base.pointList[base.pointList.IndexOf(base.pointList.Last()) - 1], point));
                            this.lastNodeAdded.Add(new Node(base.pointList[base.pointList.IndexOf(base.pointList.Last()) - 1], point));

                        }
                        else/*Third case of adding, when the meeting point is setted and the last added points are normal point*/
                        {
                            base.nodeList.Add(new Node(meetingPoint, point));
                            base.nodeList.Add(new Node(base.pointList.Last(), point));
                            this.lastNodeAdded.Add(new Node(meetingPoint, point));
                            this.lastNodeAdded.Add(new Node(base.pointList.Last(), point));
                        }
                        
                    }
                }

                if (this.meetingPoint == null)/*Fourth case of adding, in this case the meeting point is not setted and the points are normal*/
                {
                    this.lastNodeAdded.Clear();

                    if (!base.pointList.Last().meetingPoint)
                    {
                        base.nodeList.Add(new Node(base.pointList.Last(), point));
                        this.lastNodeAdded.Add(new Node(base.pointList.Last(), point));
                    }
                }
            }
            /*Verify if the coordinates of this point are estremes of the geographic plan*/
            MinOrMax(point);
            base.pointList.Add(point);
        }

        /*This method return true if the Point is allocated, otherwise return false*/
        public Boolean AddPoint(Point point)
        {
            /*verify that the new point to insert is not resemble with the insterted points */
            base.pointList.ForEach(delegate (Point mypoint) 
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

            return base.pointList.Contains(point);/*return the presence of the new point into the database*/
        }

        /*This method is usefull to rmove a point form the list (Consequently the corrispettive nodes) and  
         * return true if the Point is disallocated, otherwise return false*/
        public Boolean DelettePoint(Point point)
        {
            if (!base.pointList.Contains(point))/*fisrt control; is if the point to delete exist*/
            {
                throw new ArgumentException("The point doesn`t exsist!");
            }

            /*preparing the reference of this action*/
            this.lastNodeDelected.Clear();

            base.nodeList.ForEach(delegate (Node myNode){/*search all nodes created with the point to delette */

                if(PointUtility.EqualsPoints(myNode.pointA, point) || PointUtility.EqualsPoints(myNode.pointB, point))
                {
                    this.lastNodeDelected.Add(myNode);
                }
            });
            
            if (this.lastNodeDelected.Count > 0)/*if the search have finded some nodes, is possible remove thi nodes*/
            {
                this.lastNodeDelected.ForEach(delegate (Node myNode) {/*elimite all nodes finded*/
                    base.nodeList.Remove(myNode);
                });

                this.lastPointDelected = point;/*set last point delected*/
                
                if (point.meetingPoint) /*if the point to eliminate ia a meeting point, reimposte the condiction of nodes creation in case of meeting point*/
                {
                    this.meetingPoint = null;
                    this.flagMeetingPoint = false;
                }

                base.pointList.Remove(point);/*remove the point*/

                return !base.pointList.Contains(point);
            }

            if(this.pointList.Count == 1)
            {
                base.pointList.Remove(point);/*remove the point*/

                return !base.pointList.Contains(point);
            }

            return false;
        }

        /*This method is usefull for delete a node from a index*/
        public Boolean DeletePointFromIndex(int index)
        {
            return DelettePoint(base.pointList[index]);
        }
        
    }
}
