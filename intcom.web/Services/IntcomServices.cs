using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace intcom.web.Services
{
    public class IntcomServices
    {
        CloudServices.ServicesClient proxy;
        
        public IntcomServices()
        {
            
        }

        public object getAll()
        {
            proxy = new CloudServices.ServicesClient();
            return proxy.getAll();
        }

        public void upload(string[] files)
        {
            proxy = new CloudServices.ServicesClient();
            proxy.ulpload(files);            
        }

        public void download(string key, string destination)
        {
            proxy = new CloudServices.ServicesClient();
            proxy.download(key, destination);
        }
    }
}