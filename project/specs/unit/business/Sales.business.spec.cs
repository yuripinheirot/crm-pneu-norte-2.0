using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Collections.Generic;
using project.domain.model;
using specs.suport.factories.unit.business;

namespace specs
{
    [TestClass]
    public class SalesBusinessSpec
    {
        [TestMethod]
        [Description("getSale should throw if salesData throws")]
        public void getSaleShouldThrowIfSaleDataThrows()
        {
            SalesBusinessFactoryMock.salesDataMock
                .Setup(x => x.getSale(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             SalesBusinessFactoryMock.salesBusiness.getSale("invalidIdCompany", "invalidIdSale")
            );
        }

        [TestMethod]
        [Description("SalesData should receive correct params")]
        public void SalesDataShouldReceiveCorrectParams()
        {
            SalesBusinessFactoryMock.salesDataMock
                .Setup(x => x.getSale(It.IsAny<string>(), It.IsAny<string>()))
                .Callback((string idCompany, string idSale) =>
                {
                    Assert.AreEqual("idCompany", idCompany);
                    Assert.AreEqual("idSale", idSale);
                });

            SalesBusinessFactoryMock.salesBusiness.getSale("idCompany", "idSale");
        }
    }
}
