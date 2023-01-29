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

namespace specs
{
    [TestClass]
    public class AnswerBusinessSpec
    {
        [TestMethod]
        public void TestMethod2()
        {
            List<PostAnswerDTO> listPostAnswersDTO = new List<PostAnswerDTO>()
            {
                new PostAnswerDTO()
                {
                    answer = "yes",
                    idClient = "00013",
                    idQuestion = "1",
                    idCompany = "02",
                    idSale = "0000301",
                    observation = "Lorem ipsum dolor",
                    updatedAt = DateTime.Now,
                },
                new PostAnswerDTO()
                {
                    answer = "no",
                    idClient = "00013",
                    idQuestion = "2",
                    idCompany = "02",
                    idSale = "0000301",
                    observation = "Lorem ipsum dolor",
                    updatedAt = DateTime.Now,
                },
            };

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

            AnswersBusinessFactoryMock.questionsData
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


            AnswersBusinessFactoryMock.answersBusiness.addAnswersDTO(listPostAnswersDTO);
        }
    }
}
