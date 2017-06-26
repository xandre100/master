using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace intcom.cloud.services
{
    public class ConfigurationSettings
    {
        public static string  StorageConnectionString
        {
            get
            {
                return ConfigurationManager.AppSettings["StorageConnectionString"].ToString();
            }
        }

        public static string DestBlobContainer
        {
            get {
                return ConfigurationManager.AppSettings["DestBlobContainer"].ToString();
            }
        }
    }
}
