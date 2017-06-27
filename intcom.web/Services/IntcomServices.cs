using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web;

namespace intcom.web.Services
{
    public class IntcomServices : IIntcomServices
    {
        cloud.services.ICloudServices proxy;
        
        public IntcomServices()
        {
            proxy = new cloud.services.CloudServices();
        }

        public object getAll()
        {
            object files = proxy.getAll();
            return files;
        }

        public void upload(string[] files)
        {
            proxy.ulpload(files);
        }

        public void download(string key, string destination)
        {
            proxy.download(key, destination);
        }
    }
}