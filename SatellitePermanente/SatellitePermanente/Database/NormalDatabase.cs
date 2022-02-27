using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Database
{
    abstract class NormalDatabase : OriginDatabase
    {
        /*Fieds and utility values*/
        public Point meetingPoint { get; set; }  /*this field register the meeting point of the entire database, becausa could be exist only one meeting point*/

        public bool flagMeetingPoint { get; set; }  //this field is for register when the points (before at the meeting point) have its meeting point nodes 

        /*this fileds is protected in way to be setted in other class, for exaple when the database is loaded this fields is false*/
        public bool firstRun { get; set; }//this filed is for register the state of the prgram, in way to that the MaxCoordinates going to be initialize correctly

        /*this three fieds are unused during the program, but permit to have a generic database*/
        protected List<Node> lastNodeAdded { get; set; }

        protected List<Node> lastNodeDelected { get; set; }

        protected Point lastPointDelected { get; set; }

        /*Return method*/
        public abstract List<Node> GetLastNodeAdded();

        public abstract List<Node> GetLastNodeDelected();


        /*Operation method*/
        public abstract Boolean AddPoint(Point point);

        public abstract Boolean DeletePoint(Point point);

        public abstract Boolean DeletePointFromIndex(int index);






    }
}
