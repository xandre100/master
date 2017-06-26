using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intcom.cloud.services
{
    public class CloudBlobExceptions : Exception 
    {
        public CloudBlobExceptions(string message):base(message)
        {                
        }
    }
}
