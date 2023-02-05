using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using System.Collections.Generic;
using project.domain.model;
using specs.suport.factories.unit.business;
using project.presentation.protocols;

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

        [TestMethod]
        [Description("getSale should return correct values")]
        public void GetSaleShouldReturnCorrectValues()
        {
            var sale = new SaleModel()
            {
                id = "id",
                idCompany = "idCompany",
                liquidValue = (decimal)1999.99,
                dateSale = new DateTime(2000, 01, 01),
                client = "client",
                clientCpfCnpj = "clientCpfCnpj",
                posSale = "posSale",
                seller = "seller"
            };

            SalesBusinessFactoryMock.salesDataMock
                .Setup(x => x.getSale(It.IsAny<string>(), It.IsAny<string>())).Returns(sale);

            var saleReturned = SalesBusinessFactoryMock.salesBusiness.getSale("idCompany", "idSale");

            Assert.AreEqual(sale.id, saleReturned.id);
            Assert.AreEqual(sale.idCompany, saleReturned.idCompany);
            Assert.AreEqual(sale.liquidValue, saleReturned.liquidValue);
            Assert.AreEqual(sale.dateSale, saleReturned.dateSale);
            Assert.AreEqual(sale.client, saleReturned.client);
            Assert.AreEqual(sale.clientCpfCnpj, saleReturned.clientCpfCnpj);
            Assert.AreEqual(sale.posSale, saleReturned.posSale);
            Assert.AreEqual(sale.seller, saleReturned.seller);
        }

        ////////////////

        [TestMethod]
        [Description("getSales should throw if salesRepository throws")]
        public void getSalesDtoShouldThrowIfSalesRepositoryThrows()
        {
            SalesBusinessFactoryMock.salesDataMock
                .Setup(x => x.getSales(It.IsAny<SalesFilters>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                SalesBusinessFactoryMock.salesBusiness.getSales(new SalesFilters());
            });
        }
    }
}
