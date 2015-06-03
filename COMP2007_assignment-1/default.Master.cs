using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COMP2007_assignment_1
{
    public partial class _default : System.Web.UI.MasterPage
    {
        //BasePage variable for returning values in order to calculate
        BasePage CurrentPage = null;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCalculate_Click(object sender, EventArgs e)
        {
            CurrentPage = this.Page as BasePage;
            if (CurrentPage != null)
            {
                Label1.Text = "yes";
            }
        }
    }
}