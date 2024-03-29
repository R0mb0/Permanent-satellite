﻿using PermanentSatellite.LogicAndMath;
using PermanentSatellite.Observer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PermanentSatellite.GUI
{
    public partial class Debug : Form
    {
        /*Fileds*/
        private static ObserverImpl status;

        /*This method wrote the two DataGrid of this form, with the database values passed with a bdridge class*/
        private void Write()
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
                
                myNode.GetDistanceString(), myNode.GetDirection1String(), myNode.GetDirection2String(),
                myNode.GetTimeDifferenceString(), myNode.GetSpeedString(),
                myNode.GetAltitudeDifferenceString()}) ;

                
            });

            //DatabaseObserver.Update();
            if (status.databaseStatus)
            {

                DataGridCoordinates.Rows.Add(new String[] {"RAW",DatabaseWithRescueImpl.GetIstance().GetMaxLatitude().GetString(), DatabaseWithRescueImpl.GetIstance().GetMinLatitude().GetString(),
                DatabaseWithRescueImpl.GetIstance().GetMaxLongitude().GetString(), DatabaseWithRescueImpl.GetIstance().GetMinLongitude().GetString()});

                /*Add to DataGrid the calculated Extremes*/
                DataGridCoordinates.Rows.Add(new String[] {"PROCESSED",FormBridge.coordinates.GetMaxLatitude().GetString(), FormBridge.coordinates.GetMinLatitude().GetString(),
                FormBridge.coordinates.GetMaxLongitude().GetString(), FormBridge.coordinates.GetMinLongitude().GetString()});
            }

        }

        /*builder*/
        public Debug()
        {
            InitializeComponent();

            status = new ObserverImpl();
            /*Add the status*/

            if (!DatabaseObserver.AddObserver(status))
            {
                MessageBox.Show("Status Error");
                return;
            }
            Write();
        }

        /*This button is usefull for refresh the Data Grids in way to cerrect some vision errors, when it happened*/
        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            /*Clear all the data grid*/
            DataGridPoints.Rows.Clear();
            DataGridNodes.Rows.Clear();
            DataGridCoordinates.Rows.Clear();

            /*Rewrite the dataGrid*/
            Write();
        }
    }
}
