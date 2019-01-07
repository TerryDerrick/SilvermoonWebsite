using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace SilvermoonWebsite.Code
{
    public class ConfigObject
    {

        public string ApplicationName { get; set; }

        public string ApplicationTitle { get; set; }

        public ConfigObject()
        {
            ApplicationName = System.Configuration.ConfigurationManager.AppSettings["ApplicationName"];
            ApplicationTitle = System.Configuration.ConfigurationManager.AppSettings["ApplicationTitle"];

        }
    }
}