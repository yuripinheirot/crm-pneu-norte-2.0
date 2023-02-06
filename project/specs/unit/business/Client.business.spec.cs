using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using specs.suport.factories.unit.business;
using System;

namespace specs
{
    [TestClass]
    public class ClientBusinessSpec
    {
        [TestMethod]
        [Description("getClient should throw if clientData throws")]
        public void getClientShouldThrowIfClientDataThrows()
        {
            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClient(It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             ClientBusinessFactoryMock.clientBusiness.getClient("invalidIdClient")
            );
        }

        [TestMethod]
        [Description("getClient should pass correct params to clientData")]
        public void getClientShouldPassCorrectParamsToClientData()
        {
            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClient(It.IsAny<string>()))
                .Callback((string idClient) =>
                {
                    Assert.AreEqual("validIdClient", idClient);
                });

            ClientBusinessFactoryMock.clientBusiness.getClient("validIdClient");
        }
    }
}
