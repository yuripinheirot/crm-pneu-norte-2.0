using Microsoft.VisualStudio.TestTools.UnitTesting;
using specs.suport.factories;
using System;
using Moq;
using project.domain.model;
using System.Collections.Generic;
using project.presentation.protocols;

namespace specs.unit.data
{
    [TestClass]
    public class AnswersDataSpec
    {
        [TestMethod]
        [Description("addAnswersDTO should throw if answersRepository throws")]
        public void AddAnswersDtoShouldThrowIfAnswersRepositoryThrows()
        {
            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.addAnswersRepository(It.IsAny<List<AnswerModel>>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                AnswersDataFactoryMock.answersData.addAnswersDTO(new List<PostAnswerDTO>());
            });
        }

        [TestMethod]
        [Description("addAnswersDTO should call answersRepository.addAnswersRepository with correct values")]
        public void AddAnswersDtoShouldCallAddAnswersRepositoryWithCorrectValues()
        {
            var listPostAnswerDtoMock = new List<PostAnswerDTO>()
            {
                new PostAnswerDTO()
                {
                    answer = "answer",
                    idClient = "idClient",
                    idCompany = "idCompany",
                    idQuestion = "idQuestion",
                    idSale = "idSale",
                    observation = "observation",
                    status = "status",
                }
            };

            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.addAnswersRepository(It.IsAny<List<AnswerModel>>()))
                .Callback((List<AnswerModel> param) =>
                {
                    Assert.AreEqual(listPostAnswerDtoMock[0].answer, param[0].answer);
                    Assert.AreEqual(listPostAnswerDtoMock[0].idClient, param[0].idClient);
                    Assert.AreEqual(listPostAnswerDtoMock[0].idCompany, param[0].idCompany);
                    Assert.AreEqual(listPostAnswerDtoMock[0].idQuestion, param[0].idQuestion);
                    Assert.AreEqual(listPostAnswerDtoMock[0].idSale, param[0].idSale);
                    Assert.AreEqual(listPostAnswerDtoMock[0].observation, param[0].observation);
                    Assert.AreEqual(listPostAnswerDtoMock[0].status, param[0].status);
                    Assert.IsNotNull(param[0].id);
                    Assert.IsNull(param[0].resolution);
                    Assert.IsInstanceOfType(param[0].createdAt, typeof(DateTime));
                    Assert.IsInstanceOfType(param[0].updatedAt, typeof(DateTime));
                });

            AnswersDataFactoryMock.answersData.addAnswersDTO(listPostAnswerDtoMock);
        }

        [TestMethod]
        [Description("postAnswerAlreadyExists should throw if answersRepository throws")]
        public void PostAnswerAlreadyExistsShouldThrowIfAnswersRepositoryThrows()
        {
            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.postAnswerAlreadyExists(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                AnswersDataFactoryMock.answersData.postAnswerAlreadyExists("idCompany", "idSale");
            });
        }


        [TestMethod]
        [Description("postAnswerAlreadyExists should call answersRepository with correct values")]
        public void PostAnswerAlreadyExistsShouldCallAnswersRepositoryWithCorrectValues()
        {
            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.postAnswerAlreadyExists(It.IsAny<string>(), It.IsAny<string>()))
                .Callback((string idCompany, string idSale) =>
                {
                    Assert.AreEqual("idCompany", idCompany);
                    Assert.AreEqual("idSale", idSale);
                });

            AnswersDataFactoryMock.answersData.postAnswerAlreadyExists("idCompany", "idSale");
        }

        [TestMethod]
        [Description("postAnswerAlreadyExists should return correct value")]
        public void PostAnswerAlreadyExistsShouldReturnCorrectValue()
        {
            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.postAnswerAlreadyExists(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);

            Assert.AreEqual(
                    AnswersDataFactoryMock.answersData.postAnswerAlreadyExists("idCompany", "idSale"),
                    true
                );
        }


    }
}
