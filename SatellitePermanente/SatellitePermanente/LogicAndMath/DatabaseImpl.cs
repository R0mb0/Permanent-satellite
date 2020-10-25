using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace SatellitePermanente.LogicAndMath
{
    class DatabaseImpl: Database
    {
        private Point? meetingPoint = null;
        private Boolean flag = true;
        
        private List<Point> pointList = new List<Point>();
        private List<Node> nodeList = new List<Node>();
        private List<Node> lastNodeAdded = new List<Node>();
        private List<Node> lastNodeDelected = new List<Node>();
        private Point lastPointDelected;


        public DatabaseImpl() { }

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

        public Boolean AddPoint(Point point)
        {
            if (this.pointList.Contains(point))
            {
                throw new Exception("Trying to add a point already added!");
            }

            if (point.GetMeetingPoint())
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

        public Boolean DelettePoint(Point point)
        {
            if (!this.pointList.Contains(point))
            {
                return false;
            }

            this.lastNodeDelected.Clear();

            this.nodeList.ForEach(delegate (Node myNode){

                if(myNode.GetPointA() == point || myNode.GetPointB() == point)
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

        public Point GetLastPointAdded()
        {
            return this.pointList.Last();
        }

        public Point GetLastPointDelected()
        {
            return this.lastPointDelected;
        }

        public Point GetSpecificPoint(int index)
        {
            return this.pointList[index];
        }

        public List<Point> GetAllPoints()
        {
            return this.pointList;
        }

        public List<Node> GetLastNodeInserted()
        {
            return this.lastNodeAdded;
        }

        public List<Node> GetLastNodeRemoved()
        {
            return this.lastNodeDelected;
        }

        public List<Node> GetAllNodes()
        {
            return this.nodeList;
        }

        
    }
}
