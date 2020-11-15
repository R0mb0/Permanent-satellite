using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SatellitePermanente.GUI
{
    public partial class Debug : Form
    {

        private void write()
        {
            DatabaseWithRescue database = FormBridge.returnDatabase;

            database.pointList.ForEach(delegate (LogicAndMath.Point myPoint)
            {
                DataGridPoints.Rows.Add(new String[] {database.pointList.IndexOf(myPoint).ToString(), myPoint.latitude.GetLatitude().ToString(), 
                    myPoint.longitude.GetLongitude().ToString(), myPoint.dateTime.ToString(), myPoint.angle.ToString(), 
                    myPoint.altitude.ToString(),myPoint.meetingPoint.ToString()});
            });

            database.nodeList.ForEach(delegate (Node myNode)
            {
                DataGridNodes.Rows.Add(new String[] {database.nodeList.IndexOf(myNode).ToString(), database.pointList.IndexOf(myNode.pointA).ToString(),
                database.pointList.IndexOf(myNode.pointB).ToString(), myNode.GetDistance().ToString(), myNode.GetDirection().ToString(), 
                myNode.GetTimeDiffrence().ToString(), myNode.GetSpeed().ToString(), myNode.GetAltitudeDifference().ToString()});
            });

        }

        public Debug()
        {
            InitializeComponent();
            write();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            DataGridPoints.Rows.Clear();
            DataGridNodes.Rows.Clear();
            write();
        }
    }
}
