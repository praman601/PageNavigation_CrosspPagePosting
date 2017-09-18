using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageNavigation_CrossPagePosting
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           Page previouspage= Page.PreviousPage;
            if(previouspage!=null && previouspage.IsCrossPagePostBack)
            {
                lblName.Text=((TextBox)previouspage.FindControl("txtName")).Text;
                lblEmail.Text=((TextBox)previouspage.FindControl("txtEmail")).Text;
            }
            else
            {
                lblStatus.Text = "You landed on this page using a technique other than crosspagepostback";
            }
        }
    }
}