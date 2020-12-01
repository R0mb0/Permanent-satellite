using SatellitePermanente.Database;
using SatellitePermanente.GUI;
using SatellitePermanente.GUI.GrayMapUtility;
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
        private AddPoint addPoint; /*addPoint fieds, in this way the values wroted into the gui, in this way is possible to correct the values of the last point 
                                    inserted , conversely the user must write all values of the point any time*/
        private DeletePoint deletePoint;
        private Debug debug;
        private bool status = false; /*This is the status of the current database is it exsit or not*/

        /*this is the database of the entire program*/
        private DatabaseWithRescue database; 
       
        /*Builder*/
        public Home()
        {
            InitializeComponent();
            addPoint = new AddPoint();
            database = new DatabaseWithRescue();
        }

        /*In this method is launched the "AddPoint gui", and is the part of code where the point created in AddPoint gui is added to database*/
        private void AddPoint_Click(object sender, EventArgs e)
        {
            /*set the sate of the bridge in way to do a controll if appen something into the gui.*/
            FormBridge.returnPoint = null;
           
            addPoint.ShowDialog();

            /*In case of the gui is closed without any action from the user*/
            if (FormBridge.returnPoint == null)
            {
                return;
            }

            /*set the status that the database is inizialized*/
            this.status = true;

            /*try to corretly add of the new point*/
            try
            {
                this.database.AddPoint(FormBridge.returnPoint);
                /*in case that the add point operation worked, refresh the GrayMap*/
                this.GrayMap.Refresh();
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
            /*control if the database is initialized, because is ompossible remove something that not exist*/
            if (!status)
            {
                MessageBox.Show("The database dosn`t exsist, you need to load it!");
                return;
            }
            
            /*Initialize the gui bridge with the value that are necessary for the gui.*/
            FormBridge.returnDatabase = this.database;
            FormBridge.returnInteger = null; /*This is the index of the point to delete*/
            deletePoint = new DeletePoint();
            deletePoint.ShowDialog();

            /*In case of the gui is closed without any action from the user*/
            if (FormBridge.returnInteger == null)
            {
                return;
            }
            
            /*Try to delete point from index*/
            try
            {
                /*verify the status of the elimination of the point*/
                if (this.database.DeletePointFromIndex(Convert.ToInt32(FormBridge.returnInteger)))
                {
                    MessageBox.Show("Point removed successfully!");

                    /*refresh the graphics*/
                    this.GrayMap.Refresh();
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
            /*Verify if the database is correctly salved*/
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
            /*control if the database il correctly loaded*/
            if (this.database.LoadDatabase())
            {
                this.status = true;
                MessageBox.Show("Successfully loaded!");

                /*refresh the graphics*/
                this.GrayMap.Refresh();
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
                /*is exist a current databse load the entire form*/
                FormBridge.returnDatabase = this.database;
                debug = new Debug();
                debug.ShowDialog();
            }
            else
            {
                MessageBox.Show("The database dosn`t exsist, you need to load it!");
            }
        }

        /*----------------------------------------------------------GREYMAP INITIALIZE--------------------------------------------*/
        private void GreyMap_Paint(object sender, PaintEventArgs e)
        {
            /*Local Fields*/
            Graphics dc = e.Graphics;

                /*pen used for write the axes*/
                Pen pen = Pens.Gray;
                /* With a private method get all the point to print (in graphocal scale)*/
                List<System.Drawing.Point>? pointList = LatitudeLongitudePoints.GetAxes(456, 942);
            
                for(int i=0; i< pointList.Count; i += 2)
                {
                    dc.DrawLine(pen, pointList[i], pointList[i + 1]);
                }
               
            
                /*if the program is in the first start don`t exist the databse*/
            if(database.pointList.Count == 0)
            {
                return;
            }
            
            /*else get the extreme coordinates and create an objet to pass in other class*/
            MaxCoordinates maxCoordinates = new MaxCoordinates();
            maxCoordinates.maxLatitude = database.maxLatitude;
            maxCoordinates.minLatitude = database.minLatitude;
            maxCoordinates.maxLongitude = database.maxLongitude;
            maxCoordinates.minLongitude = database.minLongitude;
            
            /*istance anew class that permit to have all scale values (form decimal to pixel)*/
            ConvertToGraphic graphic = new ConvertToGraphic(456, 942, maxCoordinates);

            /*pass the extreme values to the database Form*/
            GrayMapValues.coordinates = graphic.extremeCoordinates;

            /*call to method that write the axes values on the monitor*/
            WriteAxesValue(graphic);

            /*draw all points from databse with its properties*/
            this.database.pointList.ForEach(delegate (LogicAndMath.Point myPoint) 
            {

                if (myPoint.meetingPoint)
                {
                    /*this is the point used for set the posiction of the text*/
                    System.Drawing.Point stringPoint = new System.Drawing.Point();
                    stringPoint.X = graphic.GetDrawingPoint(myPoint).X + 10;
                    stringPoint.Y = graphic.GetDrawingPoint(myPoint).Y + 10;
                    /*draw the points*/
                    dc.DrawEllipse(Pens.DarkGreen, graphic.GetDrawingPoint(myPoint).X -7, graphic.GetDrawingPoint(myPoint).Y -7, 14, 14);
                    dc.FillEllipse(Brushes.DarkGreen, graphic.GetDrawingPoint(myPoint).X -7, graphic.GetDrawingPoint(myPoint).Y-7, 14, 14);
                    /*draw the point properties*/
                    dc.DrawString(myPoint.GetPointString(), new Font(this.Font.FontFamily, this.Font.Size - 2), Brushes.Black, stringPoint);
                }
                else
                {
                    /*this is the point used for set the posiction of the text*/
                    System.Drawing.Point stringPoint = new System.Drawing.Point();
                    stringPoint.X = graphic.GetDrawingPoint(myPoint).X + 10;
                    stringPoint.Y = graphic.GetDrawingPoint(myPoint).Y + 10;
                    /*draw the points*/
                    dc.DrawEllipse(Pens.DarkRed, graphic.GetDrawingPoint(myPoint).X -7, graphic.GetDrawingPoint(myPoint).Y -7, 14, 14);
                    dc.FillEllipse(Brushes.DarkRed, graphic.GetDrawingPoint(myPoint).X -7, graphic.GetDrawingPoint(myPoint).Y-7, 14, 14);
                    /*draw the point properties*/
                    dc.DrawString(myPoint.GetPointString(), new Font(this.Font.FontFamily, this.Font.Size -2), Brushes.Black, stringPoint);
                    
                }
            });

            /*draw all nodes from databse with it`s properties*/
            this.database.nodeList.ForEach(delegate (Node myNode)
            { /*this is the point used for set the posiction of the text*/
                System.Drawing.Point medPoint = new System.Drawing.Point();
                medPoint.X = (graphic.GetDrawingPoint(myNode.pointB).X  + graphic.GetDrawingPoint(myNode.pointA).X) /2;
                medPoint.Y = (graphic.GetDrawingPoint(myNode.pointB).Y  + graphic.GetDrawingPoint(myNode.pointA).Y) /2;
                /*draw the node*/
                dc.DrawLine(Pens.Black, graphic.GetDrawingPoint(myNode.pointA), graphic.GetDrawingPoint(myNode.pointB));
                /*draw the node proterties*/
                dc.DrawString(myNode.GetDistanceString(), new Font(this.Font.FontFamily, this.Font.Size - 2), Brushes.Black, medPoint);


            });
            
        }

        /*private metod for assing the value of the axes*/
        private void WriteAxesValue(ConvertToGraphic extremes)
        {
            /*find the distance from the axes*/
            decimal latitudeUnit = (extremes.DLat /3);
            decimal longitudeUnit = (extremes.DLon /3);

            /*find the start point*/
            decimal latitude = extremes.extremeCoordinates.minLatitude.GetLatitude();
            decimal longitude = extremes.extremeCoordinates.minLongitude.GetLongitude();


            /*Operations for print the values of every axe*/
            latitude = latitude + latitudeUnit;
            Origin coordinate = Utility.ConvertToSexagesimal(latitude);
            if (latitude > 0)
            {
                this.TextBoxLatutude1.Text = "N " + coordinate.degrees +"° " + coordinate.prime +"' " + Math.Round(coordinate.latter, 3) + "''";
            }
            else
            {
                this.TextBoxLatutude1.Text = "S " + coordinate.degrees + "° " + coordinate.prime + "' " + Math.Round(coordinate.latter, 3) + "''";
            }

            latitude = latitude + latitudeUnit;
            coordinate = Utility.ConvertToSexagesimal(latitude);
            if (latitude > 0)
            {
                this.TextBoxLatitude2.Text = "N " + coordinate.degrees + "° " + coordinate.prime + "' " + Math.Round(coordinate.latter, 3) + "''";
            }
            else
            {
                this.TextBoxLatitude2.Text = "S " + coordinate.degrees + "° " + coordinate.prime + "' " + Math.Round(coordinate.latter, 3) + "''";
            }

            longitude = longitude + longitudeUnit;
            coordinate = Utility.ConvertToSexagesimal(longitude);
            if(longitude > 0)
            {
                this.TextBoxLongitude1.Text = "E " + coordinate.degrees + "° " + coordinate.prime + "' " + Math.Round(coordinate.latter, 3) + "''";
            }
            else
            {
                this.TextBoxLongitude1.Text = "W " + coordinate.degrees + "° " + coordinate.prime + "' " + Math.Round(coordinate.latter, 3) + "''";
            }

            longitude = longitude + longitudeUnit;
            coordinate = Utility.ConvertToSexagesimal(longitude);
            if (longitude > 0)
            {
                this.TextBoxLongitude2.Text = "E " + coordinate.degrees + "° " + coordinate.prime + "' " + Math.Round(coordinate.latter, 3) + "''";
            }
            else
            {
                this.TextBoxLongitude2.Text = "W " + coordinate.degrees + "° " + coordinate.prime + "' " + Math.Round(coordinate.latter, 3) + "''";
            }


        }

    }
}
