using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SilvermoonWebsite.Code;

namespace SilvermoonWebsite
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ConfigObject systemConfigObject = new ConfigObject();
            Page.Title = systemConfigObject.ApplicationName;
        }
    }
}