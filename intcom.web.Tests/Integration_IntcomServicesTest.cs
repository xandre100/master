using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using intcom.web.Services;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;

namespace intcom.web.Tests
{
    [TestClass]
    public class Integration_IntcomServicesTest
    {
        private IntcomServices IntcomServices;
        
        [TestInitialize]
        public void Setup()
        {
            IntcomServices = new IntcomServices();
        }

        [TestMethod]
        public void getAll_integration_Test()
        {
            var dados = IntcomServices.getAll();
            Assert.IsNotNull(dados);
        }

        [TestMethod]
        public void upload_integration_Test()
        {
            string path = System.Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\");
            string[] files = System.IO.Directory.GetFiles(string.Format("{0}arquivos\\", path));
            IntcomServices.upload(files);
        }

        [TestMethod]
        public void download_integration_test()
        {
            string path = System.Environment.CurrentDirectory.Replace("\\bin\\Debug", "\\");
            string[] files = System.IO.Directory.GetFiles(string.Format("{0}arquivos\\", path));
            string destinationDirectory = string.Format("{0}destino\\", path);
            
            foreach (string key in files)
            {
                string _destinationFile = destinationDirectory + System.IO.Path.GetFileName(key);

                if (System.IO.File.Exists(_destinationFile))
                {
                    System.IO.File.Delete(_destinationFile);
                }

                IntcomServices.download(key, _destinationFile);
            }
        }
    }
}
