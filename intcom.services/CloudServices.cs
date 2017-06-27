using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.Storage;
using Microsoft.WindowsAzure.Storage.Blob;
using System.IO;
using System.Xml.Linq;

namespace intcom.cloud.services
{
    public class CloudServices : ICloudServices
    {
        string _StorageConnectionString = ConfigurationSettings.StorageConnectionString;
        CloudStorageAccount storageAccount;
        CloudBlobClient blobClient;

        public CloudServices()
        {
            CreateProxy();
        }
        
        public void download(string key, string destination)
        {
            CloudBlobContainer container = blobClient.GetContainerReference(ConfigurationSettings.DestBlobContainer);
            CloudBlockBlob blockBlob = container.GetBlockBlobReference(key);
            blockBlob.DownloadToFileAsync(destination, FileMode.Create);
        }

        public AccessCondition getAccessCondition()
        {
            AccessCondition ac = new AccessCondition();
            ac.IfMaxSizeLessThanOrEqual = (long)100.00;
            return ac;
        }

        public object getAll()
        {
            CloudBlobContainer container = blobClient.GetContainerReference(ConfigurationSettings.DestBlobContainer);
            object files = new object();

            try
            {
                files = container.ListBlobs(null, true, BlobListingDetails.All);
            }
            catch (Exception)
            {

                throw;
            }
            
            return files;
        }       

        public void setAccessCondition(long filesize)
        {
            throw new NotImplementedException();
        }

        public async void ulpload(string[] files)
        {
            try
            {
                CloudBlobContainer container = blobClient.GetContainerReference(ConfigurationSettings.DestBlobContainer);

                await createNotExitContainer(container);

                files.ToList().ForEach(async file =>
                {
                    CloudBlockBlob blockBlob = container.GetBlockBlobReference(file);
                    await blockBlob.UploadFromFileAsync(file, getAccessCondition(), getRequestOptions(), new OperationContext());
                });
            }
            catch (StorageException)
            {
                throw; // new StorageException("Dados Incorretos. Entre em contato com o Administrador.");
            }
            catch (AccessViolationException)
            {
                throw new CloudBlobExceptions("O tamanho do arquivo carregado está acima do limite permitido.");
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static async Task createNotExitContainer(CloudBlobContainer container)
        {
            await container.CreateIfNotExistsAsync();
        }

        private static BlobRequestOptions getRequestOptions()
        {
            BlobRequestOptions brop = new BlobRequestOptions();
            brop.ServerTimeout = new TimeSpan((long)1000);
            return brop;
        }

        public void CreateProxy()
        {
            storageAccount = CreateStorageAccountFromConnectionString();
            blobClient = storageAccount.CreateCloudBlobClient();
        }

        public CloudStorageAccount CreateStorageAccountFromConnectionString()
        {
            try
            {
                storageAccount = CloudStorageAccount.Parse(_StorageConnectionString);
            }
            catch (FormatException)
            {
                Console.WriteLine("Dados Incorretos. Entre em contato com o Administrador.");
                Console.ReadLine();
                throw;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Dados Incorretos. Entre em contato com o Administrador.");
                Console.ReadLine();
                throw;
            }

            return storageAccount;
        }
    }
}
