﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        [TestMethod]
        [Description("getAnswerDetailsDataView should throw if answersRepository throws")]
        public void GetAnswerDetailsDataViewShouldThrowIfAnswersRepositoryThrows()
        {
            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.getAnswerDetailsDataView(It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                AnswersDataFactoryMock.answersData.getAnswerDetailsDataView("idAnswer");
            });
        }


        [TestMethod]
        [Description("getAnswerDetailsDataView should call answersRepository with correct values")]
        public void GetAnswerDetailsDataViewShouldCallAnswersRepositoryWithCorrectValues()
        {
            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.getAnswerDetailsDataView(It.IsAny<string>()))
                .Callback((string idAnswer) =>
                {
                    Assert.AreEqual("idAnswer", idAnswer);
                });

            AnswersDataFactoryMock.answersData.postAnswerAlreadyExists("idCompany", "idSale");
        }

        [TestMethod]
        [Description("getAnswerDetailsDataView should return correct value")]
        public void GetAnswerDetailsDataViewShouldReturnCorrectValue()
        {
            var answerDetailsMock = new AnswerDetails()
            {
                answer = "answer",
                client = "client",
                descriptionQuestion = "descriptionQuestion",
                idCompany = "idCompany",
                idSale = "idSale",
                observation = "observation",
                resolution = "resolution",
                seller = "seller",
                status = "status"
            };

            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.getAnswerDetailsDataView(It.IsAny<string>()))
                .Returns(answerDetailsMock);

            Assert.AreEqual(
                    AnswersDataFactoryMock.answersData.getAnswerDetailsDataView("idAnswer"),
                    answerDetailsMock
                );
        }

        [TestMethod]
        [Description("getAnswers should throw if answersRepository throws")]
        public void GetAnswersShouldThrowIfAnswersRepositoryThrows()
        {
            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.getAnswers(It.IsAny<AnswersFilters>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                AnswersDataFactoryMock.answersData.getAnswers(new AnswersFilters());
            });
        }

        [TestMethod]
        [Description("getAnswers should pass null date filters if null")]
        public void GetAnswersShouldPassNullDateFiltersIfNull()
        {
            var expectedAnswerFiltersMock = new AnswersFilters()
            {
                answer = "answer",
                idCompany = "idCompany",
                finalDate = null,
                initialDate = null,
                idQuestion = "idQuestion",
                idSale = "idSale",
            };

            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.getAnswers(It.IsAny<AnswersFilters>()))
                .Callback((AnswersFilters filter) =>
                {
                    Assert.IsNull(filter.initialDate);
                    Assert.IsNull(filter.finalDate);
                });

            AnswersDataFactoryMock.answersData.getAnswers(expectedAnswerFiltersMock);
        }

        [TestMethod]
        [Description("getAnswers should convert initial and final date")]
        public void GetAnswersShouldConvertInitialAndFinalDate()
        {
            var expectedAnswerFiltersMock = new AnswersFilters()
            {
                answer = "answer",
                idCompany = "idCompany",
                finalDate = new DateTime(2000, 01, 01, 22, 22, 22),
                initialDate = new DateTime(2000, 01, 01, 11, 11, 11),
                idQuestion = "idQuestion",
                idSale = "idSale",
            };

            AnswersDataFactoryMock.answerRepositoryMock
                .Setup(x => x.getAnswers(It.IsAny<AnswersFilters>()))
                .Callback((AnswersFilters filter) =>
                {
                    Assert.AreEqual(filter.initialDate, new DateTime(2000, 01, 01, 00, 00, 00));
                    Assert.AreEqual(filter.finalDate, new DateTime(2000, 01, 01, 23, 59, 59));
                });

            AnswersDataFactoryMock.answersData.getAnswers(expectedAnswerFiltersMock);
        }
    }
}