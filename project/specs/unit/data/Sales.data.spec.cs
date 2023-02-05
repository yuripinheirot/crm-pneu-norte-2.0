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
        public void AddAnswersDtoShouldThrowIfAnswersRepositoryThrows()
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
    }
}
