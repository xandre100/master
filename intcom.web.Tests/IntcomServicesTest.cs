using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using intcom.web.Services;
using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using Moq;

namespace intcom.web.Tests
{
    [TestClass]
    public class IntcomServicesTest
    {
        private Mock<IIntcomServices> IntcomServices;
        private string[] files = new string[] { @"c:\\teste1.txt", @"c:\\teste2.txt" };
        private string key = "teste.txt";
        private string _destinationFile = @"c:\\teste.txt";

        [TestInitialize]
        public void Setup()
        {
            IntcomServices = new Mock<IIntcomServices>();
        }

        [TestMethod]
        public void getAll_Test()
        {
            var dados = IntcomServices.Setup(m => m.getAll());
            Assert.IsNotNull(dados);
        }

        [TestMethod]
        public void upload_Test()
        {            
            IntcomServices.Setup(m => m.upload(files));
        }

        [TestMethod]
        public void download_test()
        {
            IntcomServices.Setup(m => m.download(key, _destinationFile));            
        }
    }
}
