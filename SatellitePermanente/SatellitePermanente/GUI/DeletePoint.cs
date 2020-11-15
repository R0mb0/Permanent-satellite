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
    public partial class DeletePoint : Form
    {

        private void write()
        {
            DatabaseWithRescue database = FormBridge.returnDatabase;

            database.pointList.ForEach(delegate (LogicAndMath.Point myPoint)
            {
                DataGridPoints.Rows.Add(database.pointList.IndexOf(myPoint).ToString());
            });
        }
        public DeletePoint()
        {
            InitializeComponent();
            write();
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            DataGridPoints.Rows.Clear();
            write();
        }

        private void ButtonDelette_Click(object sender, EventArgs e)
        {
            FormBridge.retunrBoolean = false;
        }
    }
}
