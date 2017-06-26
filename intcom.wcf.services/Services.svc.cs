using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using intcom.cloud.services;


namespace intcom.wcf.services
{
    public class Services : IServices
    {
        CloudServices cloudServices;

        public Services()
        {
            cloudServices = new CloudServices();
        }

        public void download(string key, string destination)
        {
            cloudServices.download(key, destination);
        }

        public object getAll()
        {
            return cloudServices.getAll();
        }

        public void setAccessCondition(long filesize)
        {
            cloudServices.setAccessCondition(filesize);
        }

        public void ulpload(string[] files)
        {
            cloudServices.ulpload(files);
        }
    }
}
