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
    }
}
