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
    class DatabaseImpl : Database
    {
        private Point? meetingPoint = null;
        private Boolean flag = true;

        public List<Point> pointList { get; }

        public List<Node> nodeList { get; }

        public List<Node> lastNodeAdded { get; }

        public List<Node> lastNodeDelected { get; }

        public Point lastPointDelected { get; private set; }

        /*Builder*/
        public DatabaseImpl() 
        {
            this.pointList = new List<Point>();
            this.nodeList = new List<Node>();
            this.lastNodeAdded = new List<Node>();
            this.lastNodeDelected = new List<Node>();
        }

        /*This private method try to add Node from allocated point*/
        private void TryToAllocateNode(Point point)
        {
            if(this.pointList.Count >=2 && this.meetingPoint == null)
            {
                this.lastNodeAdded.Clear();
                this.nodeList.Add(new NodeImpl(this.pointList.Last(), point));
                this.lastNodeAdded.Add(new NodeImpl(this.pointList.Last(), point));
            }

            if(this.pointList.Count >= 2 && this.meetingPoint != null && this.flag)
            {
                this.flag = false;

                this.lastNodeAdded.Clear();
                this.pointList.ForEach(delegate(Point myPoint){
                    this.nodeList.Add(new NodeImpl(this.meetingPoint, myPoint));
                    this.lastNodeAdded.Add(new NodeImpl(this.meetingPoint, myPoint));
                });
            }

            if(this.pointList.Count >= 2 && this.meetingPoint != null && !this.flag)
            {
                this.lastNodeAdded.Clear();
                this.nodeList.Add(new NodeImpl(this.meetingPoint, point));
                this.nodeList.Add(new NodeImpl(this.pointList.Last(), point));
                this.lastNodeAdded.Add(new NodeImpl(this.meetingPoint, point));
                this.lastNodeAdded.Add(new NodeImpl(this.pointList.Last(), point));

            }
        }

        /*This method return true if the Point is allocated, otherwise return false*/
        public Boolean AddPoint(Point point)
        {
            if (this.pointList.Contains(point))
            {
                throw new Exception("Trying to add a point already added!");
            }

            if (point.meetingPoint)
            {
                if(this.meetingPoint != null)
                {
                    throw new Exception("trying to set another meeting point!");
                }

                this.meetingPoint = point;

                return true;
            }

            this.pointList.Add(point);

            TryToAllocateNode(point);

            return this.pointList.Contains(point);
        }

        /*This method return true if the Point is disallocated, otherwise return false*/
        public Boolean DelettePoint(Point point)
        {
            if (!this.pointList.Contains(point))
            {
                return false;
            }

            this.lastNodeDelected.Clear();

            this.nodeList.ForEach(delegate (Node myNode){

                if(myNode.pointA == point || myNode.pointB == point)
                {
                    this.lastNodeDelected.Add(myNode);
                }
            });

            if(this.lastNodeDelected.Count > 0)
            {
                this.lastNodeDelected.ForEach(delegate (Node myNode) {
                    this.nodeList.Remove(myNode);
                });

                this.lastPointDelected = point;
                this.pointList.Remove(point);

                return true;
            }

            return false;
        }
        
    }
}
