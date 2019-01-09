using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SilvermoonWebsite.Admin
{
    public partial class AdminMain : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
               if (Session["user"] == null)
               {
                Response.Redirect("~/Home.aspx");
               }
        }
    }
}