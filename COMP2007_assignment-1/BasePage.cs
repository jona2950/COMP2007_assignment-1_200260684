using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/**
 * This class, "BasePage" inherits from "System.Web.UI.Page",
 * In which content page s will inherit from
 * allowing values from those panels be transferable 
 * to the Master page
 * 
 */

namespace COMP2007_assignment_1
{
    public class BasePage : System.Web.UI.Page
    {
        //The constructor which will not reqiure any arguments to be passed 
        public BasePage() { }

        //Method is to be overriden so calculations can happen
        public virtual Boolean Calculate()
        {
            return false;
        }

        /**
         *Method returns value of "", (class is meant to be inherited) 
         *Method is to be overriden to return specific field
         */

        public virtual String GamesWon()
        {
            return "";
        }

        public virtual String GamesLost()
        {
            return "";
        }

        public virtual String WinningPercent()
        {
            return "";
        }

        public virtual String PointsScored()
        {
            return "";
        }

        public virtual String PointsAllowed()
        {
            return "";
        }

        public virtual String PointDifferential()
        {
            return "";
        }

        public virtual String TotalAttendance()
        {
            return "";
        }

        public virtual String AverageAttendance()
        {
            return "";
        }
    }
}