using SatellitePermanente.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace SatellitePermanente.Observer
{
    /*This class is the subject of the observer into the Observer Pattern*/
    static class DatabaseObserver
    {
        private static bool status;

        /*List of all Observer*/
        private static List<Observer> observerList = new List<Observer>();

        /*method to read the state of the database*/
        private static bool ReadStatusOfDatabase()
        {
            if (NormalDatabaseImpl.GetIstance().GetPointList() != null && NormalDatabaseImpl.GetIstance().GetPointList().Count > 0)
            {
                return true;
            }

            return false;
        }

        /*method to add an observer*/
        public static void AddObserver(Observer observer)
        {
            observer.SetStatus(ReadStatusOfDatabase());
            observerList.Add(observer);
        }

        /*method to delette an observer*/
        public static void DeletteObserver(Observer observer)
        {
            observerList.Remove(observer);
        }

        /*method for update all observer state*/
        public static void Update()
        {
            status = ReadStatusOfDatabase();

            observerList.ForEach(delegate(Observer observer) 
            {
                observer.SetStatus(status);
            });
        }


    }
}
