﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using project.domain.model.entities;
using project.presentation.protocols;
using specs.suport.factories.unit.answers;
using specs.suport.mocks;
using System;
using System.Collections.Generic;

namespace specs
{
    [TestClass]
    public class AnswerBusinessSpec
    {
        [TestCategory("aaa")]
        [TestMethod]
        [Description("AddAnswersDTO should throw if question data throws")]
        public void ShouldThrowIfQuestionDataThrows()
        {
            AnswersBusinessFactoryMock.questionsDataMock
                .Setup(x => x.getQuestion(It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             AnswersBusinessFactoryMock.answersBusiness.addAnswersDTO(ListPostAnswerDtoMock.listPostAnswersDTO)
            );
        }

        [TestMethod]
        [Description("AddAnswersDTO should throw if answers data throws")]
        public void ShouldThrowIfAnswersDataThrows()
        {
            var questionModel = new QuestionModel()
            {
                answers = new List<string>() { "yes", "no" },
                badAnswers = new List<string>() { "no" }
            };

            AnswersBusinessFactoryMock.questionsDataMock
                .Setup(x => x.getQuestion(It.Is<string>(i => true)))
                .Returns(questionModel);

            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.addAnswersDTO(It.IsAny<List<PostAnswerDTO>>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             AnswersBusinessFactoryMock.answersBusiness.addAnswersDTO(ListPostAnswerDtoMock.listPostAnswersDTO)
            );
        }

        [TestMethod]
        [Description("AddAnswersDTO should return list with correct values")]
        public void ShouldReturnListWithCorrectValues()
        {
            List<PostAnswerDTO> expectedListPostAnswersDTO = new List<PostAnswerDTO>()
            {
                new PostAnswerDTO()
                {
                    answer = "yes",
                    idClient = "00013",
                    idQuestion = "1",
                    idCompany = "02",
                    idSale = "0000301",
                    observation = "Lorem ipsum dolor",
                    status = "done"
                },
                new PostAnswerDTO()
                {
                    answer       = "no",
                    idClient         = "00013",
                    idQuestion   = "2",
                    idCompany       = "02",
                    idSale      = "0000301",
                    observation = "Lorem ipsum dolor",
                    status       = "pending"
                },
            };

            var questionModel = new QuestionModel()
            {
                answers = new List<string>() { "yes", "no" },
                badAnswers = new List<string>() { "no" }
            };

            AnswersBusinessFactoryMock.questionsDataMock
                .Setup(x => x.getQuestion(It.Is<string>(i => true)))
                .Returns(questionModel);

            AnswersBusinessFactoryMock.answersDataMock.Setup(x => x.addAnswersDTO(It.IsAny<List<PostAnswerDTO>>()))
              .Callback((List<PostAnswerDTO> answers) =>
              {
                  Assert.AreEqual(expectedListPostAnswersDTO[0].answer, answers[0].answer);
                  Assert.AreEqual(expectedListPostAnswersDTO[0].idClient, answers[0].idClient);
                  Assert.AreEqual(expectedListPostAnswersDTO[0].idQuestion, answers[0].idQuestion);
                  Assert.AreEqual(expectedListPostAnswersDTO[0].idCompany, answers[0].idCompany);
                  Assert.AreEqual(expectedListPostAnswersDTO[0].idSale, answers[0].idSale);
                  Assert.AreEqual(expectedListPostAnswersDTO[0].observation, answers[0].observation);
                  Assert.AreEqual(expectedListPostAnswersDTO[0].status, answers[0].status);

                  Assert.AreEqual(expectedListPostAnswersDTO[1].answer, answers[1].answer);
                  Assert.AreEqual(expectedListPostAnswersDTO[1].idClient, answers[1].idClient);
                  Assert.AreEqual(expectedListPostAnswersDTO[1].idQuestion, answers[1].idQuestion);
                  Assert.AreEqual(expectedListPostAnswersDTO[1].idCompany, answers[1].idCompany);
                  Assert.AreEqual(expectedListPostAnswersDTO[1].idSale, answers[1].idSale);
                  Assert.AreEqual(expectedListPostAnswersDTO[1].observation, answers[1].observation);
                  Assert.AreEqual(expectedListPostAnswersDTO[1].status, answers[1].status);
              });

            AnswersBusinessFactoryMock.answersBusiness.addAnswersDTO(ListPostAnswerDtoMock.listPostAnswersDTO);
        }

        [TestMethod]
        [Description("postAnswerAlreadyExists should throw if answers data throws")]
        public void PostAnswerAlreadyExistsShouldThrowIfAnswersDataThrows()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.postAnswerAlreadyExists(It.IsAny<string>(), It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             AnswersBusinessFactoryMock.answersBusiness.postAnswerAlreadyExists("idCompany", "idSale")
            );
        }

        [TestMethod]
        [Description("postAnswerAlreadyExists should call answerData with correct params")]
        public void PostAnswerAlreadyExistsShouldCallAnswerDataWithCorrectParams()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.postAnswerAlreadyExists(It.IsAny<string>(), It.IsAny<string>()))
                .Callback((string idCompany, string idSale) =>
                {
                    Assert.AreEqual("idCompany", idCompany);
                    Assert.AreEqual("idSale", idSale);
                });
            AnswersBusinessFactoryMock.answersBusiness.postAnswerAlreadyExists("idCompany", "idSale");
        }

        [TestMethod]
        [Description("postAnswerAlreadyExists should return correct boolean value")]
        public void PostAnswerAlreadyExistsShouldReturnCorrectBooleanValue()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.postAnswerAlreadyExists(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(true);
            Assert.AreEqual(true,
                AnswersBusinessFactoryMock.answersBusiness.postAnswerAlreadyExists("idCompany", "idSale")
            );

            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.postAnswerAlreadyExists(It.IsAny<string>(), It.IsAny<string>()))
                .Returns(false);
            Assert.AreEqual(false,
                AnswersBusinessFactoryMock.answersBusiness.postAnswerAlreadyExists("idCompany", "idSale")
            );
        }

        [TestMethod]
        [Description("getAnswerDetailsDataView should throw if answers data throws")]
        public void GetAnswerDetailsDataViewShouldThrowIfAnswersDataThrows()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswerDetailsDataView(It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             AnswersBusinessFactoryMock.answersBusiness.getAnswerDetailsDataView("idAnswer")
            );
        }

        [TestMethod]
        [Description("getAnswerDetailsDataView should call answerData with correct params")]
        public void getAnswerDetailsDataViewShouldCallAnswerDataWithCorrectParams()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswerDetailsDataView(It.IsAny<string>()))
                .Callback((string idAnswer) =>
                {
                    Assert.AreEqual("idAnswer", idAnswer);
                });
            AnswersBusinessFactoryMock.answersBusiness.getAnswerDetailsDataView("idAnswer");
        }

        [TestMethod]
        [Description("getAnswerDetailsDataView should return correct values")]
        public void GetAnswerDetailsDataViewShouldReturnCorrectValues()
        {
            var answerDetails = new AnswerDetails()
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

            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswerDetailsDataView(It.IsAny<string>()))
                .Returns(answerDetails);

            Assert.AreEqual(
                    answerDetails,
                    AnswersBusinessFactoryMock.answersBusiness.getAnswerDetailsDataView("idAnswer")
                );
        }

        [TestMethod]
        [Description("getAnswers should throw if answers data throws")]
        public void GetAnswersShouldThrowIfAnswersDataThrows()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswers(It.IsAny<AnswersFilters>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             AnswersBusinessFactoryMock.answersBusiness.getAnswers(new AnswersFilters())
            );
        }

        [TestMethod]
        [Description("getAnswers should call answerData with correct params")]
        public void getAnswersShouldCallAnswerDataWithCorrectParams()
        {
            var expectedAnswerFiltersMock = new AnswersFilters()
            {
                answer = "answer",
                idCompany = "idCompany",
                finalDate = new DateTime(2000, 01, 01),
                initialDate = new DateTime(2000, 01, 01),
                idQuestion = "idQuestion",
                idSale = "idSale",
            };

            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswers(It.IsAny<AnswersFilters>()))
                .Callback((AnswersFilters filters) =>
                {
                    Assert.AreEqual(expectedAnswerFiltersMock, filters);
                });

            AnswersBusinessFactoryMock.answersBusiness.getAnswers(expectedAnswerFiltersMock);
        }

        [TestMethod]
        [Description("getAnswers should return correct values")]
        public void GetAnswersShouldReturnCorrectValues()
        {
            var answerModelMock = new List<AnswerModel>(){
                new AnswerModel()
                {
                    answer = "answer",
                    createdAt = new DateTime(2000, 01, 01),
                    id = "id",
                    idClient = "idClient",
                    idCompany = "idCompany",
                    idQuestion = "idQuestion",
                    idSale = "idSale",
                    observation = "observation",
                    resolution = "resolution",
                    status = "status",
                    updatedAt = new DateTime(2000, 01, 01)
                }
            };

            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswers(It.IsAny<AnswersFilters>()))
                .Returns(answerModelMock);

            CollectionAssert.AreEquivalent(
                answerModelMock,
                AnswersBusinessFactoryMock.answersBusiness.getAnswers(new AnswersFilters())
                );
        }

        [TestMethod]
        [Description("getAnswersNotResolved should throw if answers data throws")]
        public void GetAnswersNotResolvedShouldThrowIfAnswersDataThrows()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswersNotResolved())
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             AnswersBusinessFactoryMock.answersBusiness.getAnswersNotResolved()
            );
        }


        [TestMethod]
        [Description("getAnswersNotResolved should return correct values")]
        public void GetAnswersNotResolvedShouldReturnCorrectValues()
        {
            var answerModelMock = new List<AnswerNotResolvedDataView>(){
                new AnswerNotResolvedDataView()
                {
                    answer = "answer",
                    idClient = "idClient",
                    idCompany = "idCompany",
                    idSale = "idSale",
                    observation = "observation",
                    resolution = "resolution",
                    descriptionQuestion = "descriptionQuestion",
                    idAnswer = "idAnswer"
                }
            };

            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.getAnswersNotResolved())
                .Returns(answerModelMock);

            CollectionAssert.AreEquivalent(
                answerModelMock,
                AnswersBusinessFactoryMock.answersBusiness.getAnswersNotResolved()
                );
        }

        [TestMethod]
        [Description("putAnswer should throw if answers data throws")]
        public void PutAnswerShouldThrowIfAnswersDataThrows()
        {
            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.putAnswer(It.IsAny<AnswerModel>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             AnswersBusinessFactoryMock.answersBusiness.putAnswer(new AnswerModel())
            );
        }

        [TestMethod]
        [Description("putAnswer should call answersData.putAnswer with correct values")]
        public void PutAnswerShouldReturnCorrectValues()
        {
            var answerModelMock = new AnswerModel()
            {
                answer = "answer",
                createdAt = new DateTime(2000, 01, 01),
                id = "id",
                idClient = "idClient",
                idCompany = "idCompany",
                idQuestion = "idQuestion",
                idSale = "idSale",
                observation = "observation",
                resolution = "resolution",
                status = "status",
                updatedAt = new DateTime(2000, 01, 01)
            };

            AnswersBusinessFactoryMock.answersDataMock
                .Setup(x => x.putAnswer(It.IsAny<AnswerModel>()))
                .Callback((AnswerModel answer) =>
                {
                    Assert.AreEqual(answerModelMock, answer);
                });

            AnswersBusinessFactoryMock.answersBusiness.putAnswer(answerModelMock);
        }
    }
}
