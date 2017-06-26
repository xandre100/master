using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace intcom.cloud.services
{
    public interface ICloudServices
    {
        CloudStorageAccount CreateStorageAccountFromConnectionString();
        void CreateProxy();        
        void setAccessCondition(long filesize);
        AccessCondition getAccessCondition();
        void ulpload(string[] files);
        void download(string key, string destination);
        Object getAll();
    }
}
