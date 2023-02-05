using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Moq;
using project.domain.model;
using System.Collections.Generic;
using project.presentation.protocols;
using specs.suport.factories.unit.answers;
using specs.suport.factories.unit.business;

namespace specs.unit.data
{
    [TestClass]
    public class SalesDataSpec
    {
        [TestMethod]
        [Description("getSale should throw if salesRepository throws")]
        public void getSaleDtoShouldThrowIfSalesRepositoryThrows()
        {
            SalesDataFactoryMock.salesRepositoryMock
                .Setup(x => x.getSale(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                SalesDataFactoryMock.salesData.getSale("invalidIdCompany", "invalidIdSale");
            });
        }

        [TestMethod]
        [Description("salesRepository should receive correct params")]
        public void SalesRepositoryShouldReceiveCorrectParams()
        {
            SalesDataFactoryMock.salesRepositoryMock
                .Setup(x => x.getSale(It.IsAny<string>(), It.IsAny<string>()))
                .Callback((string idCompany, string idSale) =>
                {
                    Assert.AreEqual("idCompany", idCompany);
                    Assert.AreEqual("idSale", idSale);
                });

            SalesDataFactoryMock.salesData.getSale("idCompany", "idSale");
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

            SalesDataFactoryMock.salesRepositoryMock
                .Setup(x => x.getSale(It.IsAny<string>(), It.IsAny<string>())).Returns(sale);

            var saleReturned = SalesDataFactoryMock.salesData.getSale("idCompany", "idSale");

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
            SalesDataFactoryMock.salesRepositoryMock
                .Setup(x => x.getSales(It.IsAny<SalesFilters>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                SalesDataFactoryMock.salesData.getSales(new SalesFilters());
            });
        }

        [TestMethod]
        [Description("getSales should pass correct params")]
        public void GetSalesShouldPassCorrectParams()
        {
            var filtersToPass = new SalesFilters()
            {
                initialDate = new DateTime(2000, 01, 01),
                finalDate = new DateTime(2030, 12, 31),
                idClient = "idClient",
                idCompany = "idCompany",
                posSale = "VENDAS"
            };

            SalesDataFactoryMock.salesRepositoryMock
                .Setup(x => x.getSales(It.IsAny<SalesFilters>()))
                .Callback((SalesFilters filters) =>
                {
                    Assert.AreEqual(new DateTime(2000, 01, 01, 0, 0, 0), filters.initialDate);
                    Assert.AreEqual(new DateTime(2030, 12, 31, 23, 59, 59), filters.finalDate);
                    Assert.AreEqual("idClient", filters.idClient);
                    Assert.AreEqual("idCompany", filters.idCompany);
                    Assert.AreEqual("sale", filters.posSale);
                });

            SalesDataFactoryMock.salesData.getSales(filtersToPass);
        }

        [TestMethod]
        [Description("getSales should return correct values")]
        public void GetSalesShouldReturnCorrectValues()
        {
            var filtersToPass = new SalesFilters()
            {
                initialDate = new DateTime(2000, 01, 01),
                finalDate = new DateTime(2030, 12, 31),
                idClient = "idClient",
                idCompany = "idCompany",
                posSale = "VENDAS"
            };

            var sales = new List<SaleModel>()
            {
                new SaleModel()
                {
                    id = "id",
                    idCompany = "idCompany",
                    liquidValue = (decimal)1999.99,
                    dateSale = new DateTime(2000, 01, 01),
                    client = "client",
                    clientCpfCnpj = "clientCpfCnpj",
                    posSale = "posSale",
                    seller = "seller"
                },
                new SaleModel()
                {
                    id = "id2",
                    idCompany = "idCompany2",
                    liquidValue = (decimal)19992.99,
                    dateSale = new DateTime(2002, 01, 01),
                    client = "client2",
                    clientCpfCnpj = "clientCpfCnpj2",
                    posSale = "posSale2",
                    seller = "seller2"
                },
            };

            SalesDataFactoryMock.salesRepositoryMock
                .Setup(x => x.getSales(It.IsAny<SalesFilters>()))
                .Returns(sales);

            var salesReturned = SalesDataFactoryMock.salesData.getSales(filtersToPass);

            Assert.AreEqual(2, salesReturned.Count);
            
            for (int i = 0; i < salesReturned.Count; i++)
            {
                Assert.AreEqual(sales[i].id, salesReturned[i].id);
                Assert.AreEqual(sales[i].idCompany, salesReturned[i].idCompany);
                Assert.AreEqual(sales[i].liquidValue, salesReturned[i].liquidValue);
                Assert.AreEqual(sales[i].dateSale, salesReturned[i].dateSale);
                Assert.AreEqual(sales[i].client, salesReturned[i].client);
                Assert.AreEqual(sales[i].clientCpfCnpj, salesReturned[i].clientCpfCnpj);
                Assert.AreEqual(sales[i].posSale, salesReturned[i].posSale);
                Assert.AreEqual(sales[i].seller, salesReturned[i].seller);
            }
        }
    }
}
