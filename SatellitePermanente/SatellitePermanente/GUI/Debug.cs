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
        /*This method wrote the two DataGrid of this form, with the database values passed with a bdridge class*/
        private void write()
        {
            
            FormBridge.returnDatabase.pointList.ForEach(delegate (LogicAndMath.Point myPoint)
            {
                DataGridPoints.Rows.Add(new String[] {FormBridge.returnDatabase.pointList.IndexOf(myPoint).ToString(), myPoint.name,
                    myPoint.latitude.GetString(), 
                    myPoint.longitude.GetString(), myPoint.dateTime.ToString(), myPoint.angle.ToString(), 
                    myPoint.altitude.ToString(),myPoint.meetingPoint.ToString()});
            });

            FormBridge.returnDatabase.nodeList.ForEach(delegate (Node myNode)
            {
                DataGridNodes.Rows.Add(new String[] {FormBridge.returnDatabase.nodeList.IndexOf(myNode).ToString(),

                FormBridge.returnDatabase.pointList.IndexOf(PointUtility.GetCorrespondingPoint(FormBridge.returnDatabase.pointList,myNode.pointA)).ToString(),
                myNode.pointA.name,
                FormBridge.returnDatabase.pointList.IndexOf(PointUtility.GetCorrespondingPoint(FormBridge.returnDatabase.pointList,myNode.pointB)).ToString(),
                myNode.pointB.name,

                myNode.GetDistance().ToString(), myNode.GetDirection().ToString(),
                myNode.GetTimeDiffrence().ToString(), myNode.GetSpeed().ToString(),
                myNode.GetAltitudeDifference().ToString()}) ;
            });

            DataGridCoordinates.Rows.Add(new String[] {FormBridge.returnDatabase.maxLatitude.GetString(), FormBridge.returnDatabase.minLatitude.GetString(),
            FormBridge.returnDatabase.maxLongitude.GetString(), FormBridge.returnDatabase.minLongitude.GetString(),});

        }

        /*builder*/
        public Debug()
        {
            InitializeComponent();
            write();
        }

        /*This button is usefull for refresh the Data Grids in way to cerrect some vision errors, when it happened*/
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            DataGridPoints.Rows.Clear();
            DataGridNodes.Rows.Clear();
            DataGridCoordinates.Rows.Clear();
            write();
        }
    }
}
