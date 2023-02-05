using Microsoft.VisualStudio.TestTools.UnitTesting;
using project.domain.model;
using project.infra.db.postgres.repository;
using project.presentation.protocols;
using specs.suport.factories.feature;
using specs.suport.helpers;
using System;
using System.Collections.Generic;

namespace specs.feature.firebird
{
    [TestClass]
    public class SalesFirebirdRepositoryTest
    {
        [TestMethod]
        [Description("Should getSale return correct values")]
        public void ShouldGetSaleReturnCorrectValues()
        {
            var sale = SalesRepositoryFactoryMock.salesRepository.getSale("02", "0000200");

            Assert.IsNotNull(sale);
            Assert.AreEqual("0000200", sale.id);
            Assert.AreEqual("02", sale.idCompany);
            Assert.AreEqual((decimal)399.01, sale.liquidValue);
            Assert.AreEqual(new DateTime(2022, 03, 12), sale.dateSale);
            Assert.AreEqual("20240-JUNIOR BERLANDA E OUTROS", sale.client);
            Assert.AreEqual("95111441115", sale.clientCpfCnpj);
            Assert.AreEqual("sale ", sale.posSale);
            Assert.AreEqual("CRISTIANO", sale.seller);
        }

        [TestMethod]
        [Description("Should getSales return correct values")]
        public void ShouldGetSalesReturnCorrectValues()
        {
            SalesFilters filters = new SalesFilters()
            {
                initialDate = new DateTime(2022, 03, 12),
                finalDate = new DateTime(2050, 03, 12),
                idClient = "20240",
                idCompany = "02",
                posSale = "sale"
            };
            var sales = SalesRepositoryFactoryMock.salesRepository.getSales(filters);

            Assert.AreEqual(3, sales.Count);
            Assert.AreEqual("0000200", sales[0].id);
            Assert.AreEqual((decimal)399.01, sales[0].liquidValue);
            Assert.AreEqual(new DateTime(2022, 03, 12), sales[0].dateSale);
            Assert.AreEqual("95111441115", sales[0].clientCpfCnpj);
            Assert.AreEqual("CRISTIANO", sales[0].seller);
            sales.ForEach(s =>
            {
                Assert.AreEqual("02", s.idCompany);
                Assert.AreEqual("sale ", s.posSale);
                Assert.AreEqual("20240-JUNIOR BERLANDA E OUTROS", s.client);
            });
        }
    }
}
