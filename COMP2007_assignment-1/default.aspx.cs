using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_assignment_1
{
    public partial class _default1 : BasePage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //Game - Score variables
        private int 
                    intGamesWon = 0,
                    intGamesLost = 0,
                    intPointsScored = 0,
                    intPointsAllowed = 0,
                    intTotalAttendance = 0;

        private decimal     
                        decWinningPercent = 0,
                        decAverageAttendance = 0;

        //Method to calculate & validate 
        private Boolean proceedCalculation()
        {
            //retrieve all base values first... (gamesWon, pointsScored, pointsAllowed & spectators)
            //surrounded in try-catch for handling any errors
            try
            {
                intGamesWon += int.Parse(rblResult_1.SelectedValue);
                intPointsScored += int.Parse(txtPointScore_1.Text);


            } catch (ArgumentNullException)
            { 
                
            }


            return false;
        }
        
        //
        public override Boolean Calculate()
        {

            return proceedCalculation(); 
        }

        //overrides methods, inherited from BasePage, to return total values for fields

        public override String GamesWon()
        {
            return "";
        }

        public override String GamesLost()
        {
            return "";
        }

        public override String WinningPercent()
        {
            return "";
        }

        public override String PointsScored()
        {
            return "";
        }

        public override String PointsAllowed()
        {
            return "";
        }

        public override String PointDifferential()
        {
            return "";
        }

        public override String TotalAttendance()
        {
            return "";
        }

        public override String AverageAttendance()
        {
            return "";
        }
    }
}