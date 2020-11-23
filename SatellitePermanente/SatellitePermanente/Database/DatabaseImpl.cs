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
    class DatabaseImpl :OriginDatabaseImpl, Database
    {
        private Point? meetingPoint = null;

        private Boolean flag = false; //this field is for register when the points (before at the meeting point) have its meeting point nodes 

        public List<Node> lastNodeAdded { get; }

        public List<Node> lastNodeDelected { get; }

        public Point lastPointDelected { get; private set; }

        /*Builder*/
        public DatabaseImpl() 
        {
            
            this.lastNodeAdded = new List<Node>();
            this.lastNodeDelected = new List<Node>();
        }

        /*This private method try to add Node from allocated point*/
        private void TryToAllocateNode(Point point)
        {
            if (base.pointList.Count >= 1)
            {

                if (this.meetingPoint != null)
                {
                    this.lastNodeAdded.Clear();

                    if (point.meetingPoint && !this.flag)/*First case of adding, when there are in database always normal point and in this moment is setted a meeting point*/
                    {
                        base.pointList.ForEach(delegate (Point myPoint)
                        {
                            base.nodeList.Add(new Node(point, myPoint));
                            this.lastNodeAdded.Add(new Node(point, myPoint));
                        });

                        this.flag = true;
                    }
                    else
                    {
                        if (base.pointList.Last().meetingPoint)/*Second case of adding when the first point added is the meeting point and the new added point is a normal point*/
                        {
                            base.nodeList.Add(new Node(base.pointList.Last(), point));
                            this.lastNodeAdded.Add(new Node(base.pointList.Last(), point));
                        }
                        else/*Thirty case of adding, when the meeting point is setted and le last added points are normal point*/
                        {
                            base.nodeList.Add(new Node(meetingPoint, point));
                            base.nodeList.Add(new Node(base.pointList.Last(), point));
                            this.lastNodeAdded.Add(new Node(meetingPoint, point));
                            this.lastNodeAdded.Add(new Node(base.pointList.Last(), point));
                        }
                        
                    }
                }

                if (this.meetingPoint == null)/*Fourty case of adding, in this case the meeting point is not setted and the points are normal*/
                {
                    this.lastNodeAdded.Clear();

                    if (!base.pointList.Last().meetingPoint)
                    {
                        base.nodeList.Add(new Node(base.pointList.Last(), point));
                        this.lastNodeAdded.Add(new Node(base.pointList.Last(), point));
                    }
                }
            }

            base.pointList.Add(point);
        }

        /*This method return true if the Point is allocated, otherwise return false*/
        public Boolean AddPoint(Point point)
        {
            if (base.pointList.Contains(point))
            {
                throw new Exception("Trying to add a point already added!");
            }

            if (point.meetingPoint)
            {
                if(this.meetingPoint != null)/*Create an exception if the meeting point is arledy setted*/
                {
                    throw new Exception("Trying to set another meeting point!");
                }

                this.meetingPoint = point;

            }

            TryToAllocateNode(point); /*later the adding of the new point, try to create new nodes with the new point added*/

            return base.pointList.Contains(point);/*return the presence of the new point into the database*/
        }

        /*This method return true if the Point is disallocated, otherwise return false*/
        public Boolean DelettePoint(Point point)
        {
            if (!base.pointList.Contains(point))/*fisrt control; is if the point to delete exist*/
            {
                throw new ArgumentException("The point doesn`t exsist!");
            }

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
                    this.flag = false;
                }

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
