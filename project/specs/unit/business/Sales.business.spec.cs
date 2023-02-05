using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using project.domain.model;
using project.presentation.protocols;
using specs.suport.factories.unit.business;
using specs.suport.helpers;
using System;
using System.Collections.Generic;

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

        [TestMethod]
        [Description("Get sales should pass correct params to salesData")]
        public void GetSalesShouldPassCorrectParamsToSalesData()
        {
            SalesFilters filters = new SalesFilters()
            {
                idCompany = "idCompany",
                idClient = "idClient",
                initialDate = new DateTime(2000, 01, 01),
                finalDate = new DateTime(2050, 12, 31),
                posSale = "posSale"
            };

            SalesBusinessFactoryMock.salesDataMock
                .Setup(x => x.getSales(It.IsAny<SalesFilters>()))
                .Callback((SalesFilters filtersReceived) =>
                {
                    AssertObjectAreEqualHelper.verify(filters, filtersReceived);
                });

            SalesBusinessFactoryMock.salesBusiness.getSales(filters);
        }

        [TestMethod]
        [Description("getSales should return correct values")]
        public void GetSalesShouldReturnCorrectValues()
        {
            List<SaleModel> sales = new List<SaleModel>()
            {
                new SaleModel()
                {
                    idCompany = "02",
                    id = "0000300",
                    liquidValue = Convert.ToDecimal(302.43),
                    dateSale = DateTime.Now,
                    client = "00013-JOHN",
                    clientCpfCnpj = "123.123.123-12",
                    posSale = "order",
                    seller = "OZZY"
                },
                new SaleModel()
                {
                    idCompany = "02",
                    id = "0000301",
                    liquidValue = Convert.ToDecimal(302.43),
                    dateSale = new DateTime(2022,12,1),
                    client = "00014-KATE",
                    clientCpfCnpj = "123.123.123-12",
                    posSale = "order",
                    seller = "OZZY"
                }
            };

            SalesBusinessFactoryMock.salesDataMock
                .Setup(x => x.getSales(It.IsAny<SalesFilters>()))
                .Returns(sales);

            var salesReturned = SalesBusinessFactoryMock.salesBusiness.getSales(new SalesFilters());

            AssertObjectAreEqualHelper.verify(sales[0], salesReturned[0]);
            AssertObjectAreEqualHelper.verify(sales[1], salesReturned[1]);
        }
    }
}
