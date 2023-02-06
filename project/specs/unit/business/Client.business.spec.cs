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
    }
}
