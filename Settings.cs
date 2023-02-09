using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.OData.Client.ALinq.UriParser;
using System.Collections.Specialized;
using System.Xml.Linq;
using Microsoft.Extensions.Configuration;

namespace SAPB1
{
    public partial class ServiceLayer 
    {
        /*
         * "ServiceLayer": {
         *    "CompanyDB": "...",
         *    "Password": "...",
         *    "UserName": "...",
         *    "Language": "...",
         *    "URL": "...",
         *  }
         */
        public static Settings settings;

        public static void setSettings(IConfigurationSection section)
        {
            settings = new Settings(section);
        }

        public static void setSettings(string companyDB, string password, string userName, string language, string url)
        {
            settings = new Settings(companyDB, password, userName, language, url);
        }

        public class Settings
        {
            public String companyDB { get; set; }
            public String password  { get; set; }
            public String userName  { get; set; }
            public String language  { get; set; }
            public String uri       { get; set; }

            public Settings(IConfigurationSection section)
            {
                companyDB   = section["companyDB"];
                password    = section["password"];
                userName    = section["userName"];
                language    = section["language"];
                uri         = section["url"];
            }
            public Settings(string _companyDB, string _password, string _userName, string _language, string _url)
            {
                companyDB   = _companyDB;
                password    = _password;
                userName    = _userName;
                language    = _language;
                uri         = _url;
            }
        }
    }
}
