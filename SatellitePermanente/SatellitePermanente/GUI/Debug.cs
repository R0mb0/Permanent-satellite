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
            DatabaseWithRescueImpl.GetIstance().GetPointList().ForEach(delegate (LogicAndMath.Point myPoint)
            {
                DataGridPoints.Rows.Add(new String[] {DatabaseWithRescueImpl.GetIstance().GetPointList().IndexOf(myPoint).ToString(), myPoint.name,
                    myPoint.latitude.GetString(), 
                    myPoint.longitude.GetString(), myPoint.dateTime.ToString(), myPoint.GetAngleString(), 
                    myPoint.GetAltitudeString(),myPoint.meetingPoint.ToString()});
            });

            /*add to DataGrid all the database nodes with each propetrties*/
            DatabaseWithRescueImpl.GetIstance().GetNodeList().ForEach(delegate (Node myNode)
            {
                DataGridNodes.Rows.Add(new String[] {DatabaseWithRescueImpl.GetIstance().GetNodeList().IndexOf(myNode).ToString(),

               DatabaseWithRescueImpl.GetIstance().GetPointList().IndexOf(PointUtility.GetCorrespondingPoint(DatabaseWithRescueImpl.GetIstance().GetPointList(),myNode.pointA)).ToString(),
                myNode.pointA.name,
                DatabaseWithRescueImpl.GetIstance().GetPointList().IndexOf(PointUtility.GetCorrespondingPoint(DatabaseWithRescueImpl.GetIstance().GetPointList(),myNode.pointB)).ToString(),
                myNode.pointB.name,

                myNode.GetDistanceString(), myNode.GetDirectionString(),
                myNode.GetTimeDifferenceString(), myNode.GetSpeedString(),
                myNode.GetAltitudeDifferenceString()}) ;
            });

            /*Add to DataGrid the raw Extremes*/
            DataGridCoordinates.Rows.Add(new String[] {"RAW",DatabaseWithRescueImpl.GetIstance().GetMaxLatitude().GetString(), DatabaseWithRescueImpl.GetIstance().GetMinLatitude().GetString(),
            DatabaseWithRescueImpl.GetIstance().GetMaxLongitude().GetString(), DatabaseWithRescueImpl.GetIstance().GetMinLongitude().GetString()});
            
            /*Add to DataGrid the calculated Extremes*/
            DataGridCoordinates.Rows.Add(new String[] {"PROCESSED",GrayMapValues.coordinates.GetMaxLatitude().GetString(), GrayMapValues.coordinates.GetMinLatitude().GetString(),
            GrayMapValues.coordinates.GetMaxLongitude().GetString(), GrayMapValues.coordinates.GetMinLongitude().GetString()});

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
