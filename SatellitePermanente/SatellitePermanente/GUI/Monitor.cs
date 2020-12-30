using SatellitePermanente.Database;
using SatellitePermanente.GUI;
using SatellitePermanente.GUI.GrayMapUtility;
using SatellitePermanente.LogicAndMath;
using SatellitePermanente.Observer;
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
        /*adding the gui*/
        private DeletePoint deletePoint;
        private Debug debug;

        /*Create the observer of this class in way to have the database status without directly read it*/
        private static ObserverImpl status;
              
        /*Builder*/
        public Home()
        {
            InitializeComponent();
            addPoint = new AddPoint();

            /*Show the two image on screen*/
            this.pictureBoxNord.Image = Properties.Resources.Nord_scaled;
            this.pictureBoxPoints.Image = Properties.Resources.Points;

            /*Inizialize status*/
            status = new ObserverImpl();

            /*Add the status*/
            if (!DatabaseObserver.AddObserver(status))
            {
                MessageBox.Show("Status Error");
                return;
            }

            DatabaseObserver.Update();
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

            /*try to corretly add of the new point*/
            try
            {
                DatabaseWithRescueImpl.GetIstance().AddPoint(FormBridge.returnPoint);
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
            if (!status.databaseStatus)
            {
                MessageBox.Show("The database doesn`t exsist, you need to load it!");
                return;
            }

            /*Initialize the gui bridge with the value that are necessary for the gui.*/
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
                if (DatabaseWithRescueImpl.GetIstance().DeletePointFromIndex(Convert.ToInt32(FormBridge.returnInteger)))
                {
                    MessageBox.Show("Point removed successfully!");
                    
                    /*database updete status*/
                    DatabaseObserver.Update();

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
            if (DatabaseWithRescueImpl.GetIstance().SaveDatabase())
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
            if (DatabaseWithRescueImpl.GetIstance().LoadDatabase())
            {
                //this.status = true;
                MessageBox.Show("Successfully loaded!");

                /*database updete status*/
                DatabaseObserver.Update();

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
            if (status.databaseStatus)
            {
                debug = new Debug();
                debug.ShowDialog();
            }
            else
            {
                MessageBox.Show("The database doesn`t exsist, you need to load it!");
            }
        }

        /*----------------------------------------------------------GREYMAP INITIALIZE PLACE--------------------------------------------*/
        private void GreyMap_Paint(object sender, PaintEventArgs e)
        {

            /*Local Fields*/
            Graphics dc = e.Graphics;

            /*Rotate the panel coordinates*/
            /*dc.ScaleTransform(1.0F, -1.0F);
            dc.TranslateTransform(1.0F, -447);*/

            /*pen used to write the axes*/
            Pen pen = Pens.Gray;
                /* With a private method get all the point to print (in graphocal scale)*/
                List<System.Drawing.Point>? pointList = LatitudeLongitudePoints.GetAxes(938, 447);
            
                for(int i=0; i< pointList.Count; i += 2)
                {
                    dc.DrawLine(pen, pointList[i], pointList[i + 1]);
                }

                /*if the program is in the first start don`t exist the database*/
            if(!status.databaseStatus)
            {
                this.TextBoxLatitude1.Text = null;
                this.TextBoxLatitude2.Text = null;
                this.TextBoxLongitude1.Text = null;
                this.TextBoxLongitude2.Text = null;

                return;
            }
            
            /*else get the extreme coordinates and create an objet to pass in other class*/
            MaxCoordinates maxCoordinates = new MaxCoordinatesImpl();
            maxCoordinates.SetMaxLatitude(DatabaseWithRescueImpl.GetIstance().GetMaxLatitude());
            maxCoordinates.SetMinLatitude(DatabaseWithRescueImpl.GetIstance().GetMinLatitude());
            maxCoordinates.SetMaxLongitude(DatabaseWithRescueImpl.GetIstance().GetMaxLongitude());
            maxCoordinates.SetMinLongitude(DatabaseWithRescueImpl.GetIstance().GetMinLongitude());
            
            /*istance anew class that permit to have all scale values (form decimal to pixel)*/
            ConvertToGraphic graphic = new ConvertToGraphic(938, 447, maxCoordinates);

            /*pass the extreme values to the database Form*/
            FormBridge.coordinates = graphic.extremeCoordinates;

            /*call to method that write the axes values on the monitor*/
            WriteAxesValue(graphic);

            /*draw all points from databse with its properties*/
            DatabaseWithRescueImpl.GetIstance().GetPointList().ForEach(delegate (LogicAndMath.Point myPoint) 
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
            DatabaseWithRescueImpl.GetIstance().GetNodeList().ForEach(delegate (Node myNode)
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

        /*private metod for assing the value of the axes, it is only used for initialize the gray map*/
        private void WriteAxesValue(ConvertToGraphic extremes)
        {
            /*find the distance from the axes*/
            decimal latitudeUnit = Math.Abs((extremes.DLat / 3));
            decimal longitudeUnit = Math.Abs((extremes.DLon / 3));

            /*find the start point*/
            decimal latitude = extremes.extremeCoordinates.GetMinLatitude().GetLatitude();
            decimal longitude = extremes.extremeCoordinates.GetMinLongitude().GetLongitude();


            /*Operations for print the values of every axe*/
            latitude = latitude + latitudeUnit;
            decimal latitude2 = latitude + latitudeUnit;
            Origin coordinate1 = Utility.ConvertToSexagesimal(latitude);
            Origin coordinate2 = Utility.ConvertToSexagesimal(latitude2);

            if (latitude < 0 && latitude2 < 0)
            {
                this.TextBoxLatitude1.Text = "W " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
                this.TextBoxLatitude2.Text = "W " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
            }

            if (latitude > 0 && latitude2 > 0)
            {
                this.TextBoxLatitude1.Text = "E " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
                this.TextBoxLatitude2.Text = "E " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
            }

            if (latitude > 0 && latitude2 < 0)
            {
                this.TextBoxLatitude2.Text = "E " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
                this.TextBoxLatitude1.Text = "W " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
            }

            if (latitude < 0 && latitude2 > 0)
            {
                this.TextBoxLatitude2.Text = "E " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
                this.TextBoxLatitude1.Text = "W " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
            }

            
            longitude = longitude + longitudeUnit;
            decimal longitude2 = longitude + longitudeUnit;
            coordinate1 = Utility.ConvertToSexagesimal(longitude);
            coordinate2 = Utility.ConvertToSexagesimal(longitude2);

            if (longitude < 0 && longitude2 < 0)
            {
                this.TextBoxLongitude1.Text = "S " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
                this.TextBoxLongitude2.Text = "S " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
            }

            if (longitude > 0 && longitude2 > 0)
            {
                this.TextBoxLongitude1.Text = "N " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
                this.TextBoxLongitude2.Text = "N " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
            }

            if (longitude > 0 && longitude2 < 0)
            {
                this.TextBoxLongitude1.Text = "N " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
                this.TextBoxLongitude2.Text = "S " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
            }

            if (longitude < 0 && longitude2 > 0)
            {
                this.TextBoxLongitude1.Text = "N " + coordinate2.degrees + "° " + coordinate2.prime + "' " + Math.Round(coordinate2.latter, 3) + "''";
                this.TextBoxLongitude2.Text = "S " + coordinate1.degrees + "° " + coordinate1.prime + "' " + Math.Round(coordinate1.latter, 3) + "''";
            }
            


        }

    }
}
