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
        private Boolean flag = true;

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
            if(base.pointList.Count >=2 && this.meetingPoint == null)
            {
                this.lastNodeAdded.Clear();
                base.nodeList.Add(new NodeImpl(base.pointList.Last(), point));
                this.lastNodeAdded.Add(new NodeImpl(base.pointList.Last(), point));
            }

            if(base.pointList.Count >= 2 && this.meetingPoint != null && this.flag)
            {
                this.flag = false;

                this.lastNodeAdded.Clear();
                base.pointList.ForEach(delegate(Point myPoint){
                    base.nodeList.Add(new NodeImpl(this.meetingPoint, myPoint));
                    this.lastNodeAdded.Add(new NodeImpl(this.meetingPoint, myPoint));
                });
            }

            if(base.pointList.Count >= 2 && this.meetingPoint != null && !this.flag)
            {
                this.lastNodeAdded.Clear();
                base.nodeList.Add(new NodeImpl(this.meetingPoint, point));
                base.nodeList.Add(new NodeImpl(base.pointList.Last(), point));
                this.lastNodeAdded.Add(new NodeImpl(this.meetingPoint, point));
                this.lastNodeAdded.Add(new NodeImpl(base.pointList.Last(), point));

            }
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
                if(this.meetingPoint != null)
                {
                    throw new Exception("Trying to set another meeting point!");
                }

                this.meetingPoint = point;

                return true;
            }

            base.pointList.Add(point);

            TryToAllocateNode(point);

            return base.pointList.Contains(point);
        }

        /*This method return true if the Point is disallocated, otherwise return false*/
        public Boolean DelettePoint(Point point)
        {
            if (!base.pointList.Contains(point))
            {
                return false;
            }

            this.lastNodeDelected.Clear();

            base.nodeList.ForEach(delegate (Node myNode){

                if(myNode.pointA == point || myNode.pointB == point)
                {
                    this.lastNodeDelected.Add(myNode);
                }
            });

            if(this.lastNodeDelected.Count > 0)
            {
                this.lastNodeDelected.ForEach(delegate (Node myNode) {
                    base.nodeList.Remove(myNode);
                });

                this.lastPointDelected = point;
                base.pointList.Remove(point);

                return true;
            }

            return false;
        }
        
    }
}
