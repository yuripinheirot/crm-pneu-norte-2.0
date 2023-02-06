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

        [TestMethod]
        [Description("getClient should return correct values")]
        public void getClientShouldReturnCorrectValues()
        {
            var client = new ClientModel()
            {
                id = "id",
                cpfCnpj = "cpfCnpj",
                name = "name",
                nameFantasy = "nameFantasy",
                phone = "phone"
            };

            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClient(It.IsAny<string>()))
                .Returns(client);
            var clientReturned = ClientBusinessFactoryMock.clientBusiness.getClient("validIdClient");

            AssertObjectAreEqualHelper.verify(client, clientReturned);
        }

        //////////////////

        [TestMethod]
        [Description("getClients should throw if clientData throws")]
        public void getClientsShouldThrowIfClientDataThrows()
        {
            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClients(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             ClientBusinessFactoryMock.clientBusiness.getClients("invalidField", "invalidValue")
            );
        }

        [TestMethod]
        [Description("getClients should pass correct params to clientData")]
        public void getClientsShouldPassCorrectParamsToClientData()
        {
            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClients(It.IsAny<string>(), It.IsAny<string>()))
                .Callback((string field, string value) =>
                {
                    Assert.AreEqual("field", field);
                    Assert.AreEqual("value", value);
                });

            ClientBusinessFactoryMock.clientBusiness.getClients("field", "value");
        }

        [TestMethod]
        [Description("getClients should return correct values")]
        public void getClientsShouldReturnCorrectValues()
        {
            var client = new List<ClientModel>()
            {
                new ClientModel()
                {
                    id = "id",
                    cpfCnpj = "cpfCnpj",
                    name = "name",
                    nameFantasy = "nameFantasy",
                    phone = "phone"
                },
                new ClientModel()
                {
                    id = "ids",
                    cpfCnpj = "cpfCnpjs",
                    name = "names",
                    nameFantasy = "nameFantasys",
                    phone = "phones"
                }
            };

            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClients(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(client);

            var clientReturned = ClientBusinessFactoryMock.clientBusiness.getClients("validField", "validValue");

            AssertObjectAreEqualHelper.verify(client[0], clientReturned[0]);
            AssertObjectAreEqualHelper.verify(client[1], clientReturned[1]);
        }

        //////////

        [TestMethod]
        [Description("getClientsAndSalesByAnswerAndQuestion should throw if clientData throws")]
        public void getClientsAndSalesByAnswerAndQuestionShouldThrowIfClientDataThrows()
        {
            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClientsAndSalesByAnswerAndQuestion(It.IsAny<AnswersFilters>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             ClientBusinessFactoryMock.clientBusiness.getClientsAndSalesByAnswerAndQuestion(new AnswersFilters())
            );
        }

        [TestMethod]
        [Description("getClientsAndSalesByAnswerAndQuestion should pass correct params to clientData")]
        public void getClientsAndSalesByAnswerAndQuestionShouldPassCorrectParamsToClientData()
        {
            var filters = new AnswersFilters()
            {
                answer = "answer",
                idCompany = "idCompany",
                idQuestion = "idQuestion",
                idSale = "idSale",
                initialDate = new DateTime(2000, 01, 01),
                finalDate = new DateTime(2001, 01, 01),
            };

            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClientsAndSalesByAnswerAndQuestion(It.IsAny<AnswersFilters>()))
                .Callback((AnswersFilters filtersReceived) =>
                {
                    AssertObjectAreEqualHelper.verify(filters, filtersReceived);
                });

            ClientBusinessFactoryMock.clientBusiness.getClientsAndSalesByAnswerAndQuestion(filters);
        }

        [TestMethod]
        [Description("getClientsAndSalesByAnswerAndQuestion should return correct values")]
        public void getClientsAndSalesByAnswerAndQuestionShouldReturnCorrectValues()
        {
            var analysis = new List<AnalysisByQuestionDateView>()
            {
                new AnalysisByQuestionDateView()
                {
                    idSale = "idSale",
                    clientName = "clientName",
                    clientNameFantasy = "clientNameFantasy",
                    idClient = "idClient",
                    observation = "observation"
                },
                new AnalysisByQuestionDateView()
                {
                    idSale = "idSales",
                    clientName = "clientNames",
                    clientNameFantasy = "clientNameFantasys",
                    idClient = "idClients",
                    observation = "observations"
                }
            };

            ClientBusinessFactoryMock.clientDataMock
                .Setup(x => x.getClientsAndSalesByAnswerAndQuestion(It.IsAny<AnswersFilters>()))
                .Returns(analysis);

            var analysisReturned = ClientBusinessFactoryMock.clientBusiness.getClientsAndSalesByAnswerAndQuestion(new AnswersFilters());

            AssertObjectAreEqualHelper.verify(analysis[0], analysisReturned[0]);
            AssertObjectAreEqualHelper.verify(analysis[1], analysisReturned[1]);
        }
    }
}
