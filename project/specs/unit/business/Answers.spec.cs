using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using Moq;
using project.infra.db.postgres.repository;
using project.presentation.protocols;
using System.Collections.Generic;
using project.domain.model;
using project.domain.interfaces.Struct;
using specs.suport;
using specs.suport.factories;
using specs.suport.mocks;

namespace specs
{
    [TestClass]
    public class AnswerBusinessSpec
    {
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
    }
}
