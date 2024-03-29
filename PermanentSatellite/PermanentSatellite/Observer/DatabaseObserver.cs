﻿using PermanentSatellite.LogicAndMath;
using System;
using System.Collections.Generic;
using System.Text;

namespace PermanentSatellite.Observer
{
    /*This class is the subject of the observer into the Observer Pattern*/
    static class DatabaseObserver
    {
        /*List of all Observer*/
        private static List<Observer> observerList = new List<Observer>();

        /*method to read the state of the database*/
        private static bool ReadDatabaseStatus()
        {
            if (NormalDatabaseImpl.GetIstance().GetPointList() != null && NormalDatabaseImpl.GetIstance().GetPointList().Count > 0)
            {
                return true;
            }

            return false;
        }

        /*method to add an observer*/
        public static bool AddObserver(Observer observer)
        {
            observer.SetDatabaseStatus(ReadDatabaseStatus());
            observerList.Add(observer);

            return observerList.Contains(observer);
        }

        /*method to delette an observer*/
        public static bool DeleteObserver(Observer observer)
        {
            observerList.Remove(observer);

            return !observerList.Contains(observer);
        }

        /*method for update all observer state*/
        public static void Update()
        {
            bool status1 = ReadDatabaseStatus();

            observerList.ForEach(delegate(Observer observer) 
            {
                observer.SetDatabaseStatus(status1);
            });
        }


    }
}
