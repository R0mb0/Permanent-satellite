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
            /*add to DataGrid all the database points with each propetrties*/
            DatabaseWithRescue.Istance().pointList.ForEach(delegate (LogicAndMath.Point myPoint)
            {
                DataGridPoints.Rows.Add(new String[] {DatabaseWithRescue.Istance().pointList.IndexOf(myPoint).ToString(), myPoint.name,
                    myPoint.latitude.GetString(), 
                    myPoint.longitude.GetString(), myPoint.dateTime.ToString(), myPoint.GetAngleString(), 
                    myPoint.GetAltitudeString(),myPoint.meetingPoint.ToString()});
            });

            /*add to DataGrid all the database nodes with each propetrties*/
            DatabaseWithRescue.Istance().nodeList.ForEach(delegate (Node myNode)
            {
                DataGridNodes.Rows.Add(new String[] {DatabaseWithRescue.Istance().nodeList.IndexOf(myNode).ToString(),

                DatabaseWithRescue.Istance().pointList.IndexOf(PointUtility.GetCorrespondingPoint(DatabaseWithRescue.Istance().pointList,myNode.pointA)).ToString(),
                myNode.pointA.name,
                DatabaseWithRescue.Istance().pointList.IndexOf(PointUtility.GetCorrespondingPoint(DatabaseWithRescue.Istance().pointList,myNode.pointB)).ToString(),
                myNode.pointB.name,

                myNode.GetDistanceString(), myNode.GetDirectionString(),
                myNode.GetTimeDifferenceString(), myNode.GetSpeedString(),
                myNode.GetAltitudeDifferenceString()}) ;
            });

            /*Add to DataGrid the raw Extremes*/
            DataGridCoordinates.Rows.Add(new String[] {"RAW",DatabaseWithRescue.Istance().maxLatitude.GetString(), DatabaseWithRescue.Istance().minLatitude.GetString(),
            DatabaseWithRescue.Istance().maxLongitude.GetString(), DatabaseWithRescue.Istance().minLongitude.GetString()});
            
            /*Add to DataGrid the calculated Extremes*/
            DataGridCoordinates.Rows.Add(new String[] {"PROCESSED",GrayMapValues.coordinates.maxLatitude.GetString(), GrayMapValues.coordinates.minLatitude.GetString(),
            GrayMapValues.coordinates.maxLongitude.GetString(), GrayMapValues.coordinates.minLongitude.GetString()});

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
            /*Clear all the data grid*/
            DataGridPoints.Rows.Clear();
            DataGridNodes.Rows.Clear();
            DataGridCoordinates.Rows.Clear();

            /*Rewrite the dataGrid*/
            write();
        }
    }
}
