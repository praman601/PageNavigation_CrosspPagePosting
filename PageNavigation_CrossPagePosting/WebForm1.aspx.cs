using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PageNavigation_CrossPagePosting
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnTransfer_Click(object sender, EventArgs e)
        {

        }

        protected void btnNotPostBack_Click(object sender, EventArgs e)
        {
            Server.Transfer("webform2.aspx");
        }
    }
}