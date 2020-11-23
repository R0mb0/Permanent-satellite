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
        /*Fields*/
        private AddPoint addPoint;
        private DeletePoint deletePoint;
        private Debug debug;
        private bool status = false; /*This is the status of the current database is it exsit or not*/
        private DatabaseWithRescue database; 
       
        /*Builder*/
        public Home()
        {
            InitializeComponent();
            addPoint = new AddPoint();
            
            database = new DatabaseWithRescueImpl();
        }

        /*In this method is launched the "AddPoint gui", and is the part of code where the point created in AddPoint gui is added to database*/
        private void AddPoint_Click(object sender, EventArgs e)
        {
            FormBridge.returnPoint = null;
           
            addPoint.ShowDialog();

            /*In case of the gui is closed without any action from the user*/
            if (FormBridge.returnPoint == null)
            {
                return;
            }

            this.status = true;

            /*Verify the corretly add of the new point*/
            try
            {
                this.database.AddPoint(FormBridge.returnPoint);
            }
            catch (Exception error) 
            {
                MessageBox.Show("DATABASE ERROR!\n"+"Error message:" + error.Message);
                return;
            }
        }

        /*This method launch the "DeletePoint" gui and eliminate the returned point*/
        private void DeletePoint_Click(object sender, EventArgs e)
        {
            if (!status)
            {
                MessageBox.Show("The database dosn`t exsist, you need to load it!");
                return;
            }
            FormBridge.returnDatabase = this.database;
            FormBridge.returnInteger = null; /*This is the index of the point to delete*/
            deletePoint = new DeletePoint();
            deletePoint.ShowDialog();

            /*In case of the gui is closed without any action from the user*/
            if (FormBridge.returnInteger == null)
            {
                return;
            }
            
            /*Try ti delete point from index*/
            try
            {

                if (this.database.DeletePointFromIndex(Convert.ToInt32(FormBridge.returnInteger)))
                {
                    MessageBox.Show("Point removed successfully!");
                }
                else
                {
                    MessageBox.Show("Error while removing!");
                }
            }
            catch (ArgumentException error)
            {
                MessageBox.Show(error.Message);
            }
        }

        /*This method invokes the procedure for save the current database*/
        private void Save_Click(object sender, EventArgs e)
        {
            if (this.database.SaveDatabase())
            {
                MessageBox.Show("Successfully saved!");
            }
            else
            {
                MessageBox.Show("Error while saving!");
            }
        }

        /*this method invokes the procedure for load the last database salved*/
        private void Load_Click(object sender, EventArgs e)
        {
            if (this.database.LoadDatabase())
            {
                this.status = true;
                MessageBox.Show("Successfully loaded!");
            }
            else
            {
                MessageBox.Show("Error while loading!");
            }
        }

        /*This is a method of debug; where is possible to look the state of the current database*/
        private void Debug_Click(object sender, EventArgs e)
        {
            /*If doesn`t exsist a current database in memory, the user must be unable to acces the debug page*/
            if (this.status)
            {
                FormBridge.returnDatabase = this.database;
                debug = new Debug();
                debug.ShowDialog();
            }
            else
            {
                MessageBox.Show("The database dosn`t exsist, you need to load it!");
            }
        }
    }
}
