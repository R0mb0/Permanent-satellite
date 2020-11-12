using SatellitePermanente.GUI;
using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SatellitePermanente
{
    public partial class Home : Form
    {
        private DatabaseWithSalvatation database = new DatabaseWithSalvationImpl();

        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddPoint addPoint = new AddPoint();
            addPoint.ShowDialog();

        }

        private void DeletePoint_Click(object sender, EventArgs e)
        {
            DeletePoint deletePoint = new DeletePoint();
            deletePoint.ShowDialog();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            this.database.SaveDatabase();
        }

        private void Load_Click(object sender, EventArgs e)
        {
            this.database.LoadDatabase();
        }

        private void Debug_Click(object sender, EventArgs e)
        {
            Debug debug = new Debug();
            debug.ShowDialog();
        }
    }
}
