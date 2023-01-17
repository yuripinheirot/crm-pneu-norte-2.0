using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.infra.db.mock.repository;
using project.presentation.protocols;
using System.Collections.Generic;
using Moq;
using project.domain.model;
using project.domain.usecases;

namespace specs.business.answer
{


    [TestClass]
    public class AnswersBusinessSpec
    {
        static QuestionsMockRepository questionsRepository = new QuestionsMockRepository();
        static QuestionsData questionData = new QuestionsData(questionsRepository);
        static AnswersMockRepository answerRepository = new AnswersMockRepository();
        static AnswersData answerData = new AnswersData(answerRepository);
        AnswersBusiness sut;


        List<PostAnswerDTO> postAnswerDtoList = new List<PostAnswerDTO>()
        {
            new PostAnswerDTO()
            {
                answer = "badAnswer",
                idClient = "idClient",
                idCompany = "idCompany",
                idQuestion = "idQuestion",
                idSale = "idSale",
                observation = "observation",
                status = "status",
                updatedAt = DateTime.Now,
            },
            new PostAnswerDTO()
            {
                answer = "badAnswer",
                idClient = "idClient",
                idCompany = "idCompany",
                idQuestion = "idQuestion",
                idSale = "idSale",
                observation = "observation",
                status = "status",
                updatedAt = DateTime.Now,
            },
            new PostAnswerDTO()
            {
                answer = "goodAnswer",
                idClient = "idClient",
                idCompany = "idCompany",
                idQuestion = "idQuestion",
                idSale = "idSale",
                observation = "observation",
                status = "status",
                updatedAt = DateTime.Now,
            }
        };

        //private Mock<AnswersRepository> answerRepositoryMock;
        //private Mock<AnswersData> answerDataMock;
        //private Mock<AnswersBusiness> answersBusiness;
        //private Mock<QuestionsRepository> questionsRepositoryMock;
        //private Mock<QuestionsData> questionDataMock;

        [TestMethod]
        public void TestMethod1()
        {
            //AnswersRepository answerRepository = new Mock<AnswersRepository>().Object;
            //AnswersData answerDataMock = new Mock<AnswersData>(answerRepository).Object;
            Mock<QuestionsData> questionDataMock = new Mock<QuestionsData>();

            questionDataMock.Setup(m => m.getQuestion("2")).Returns(new QuestionModel()
            {
                active = true,
                answers = new List<string>() { "answer" },
                badAnswers = new List<string>() { "badAnswer" },
                description = "description",
                id = "id",
                posSale = "posSale"
            });
            sut = new AnswersBusiness(answerData, questionData);
            sut.addAnswersDTO(postAnswerDtoList);

            //answerDataMock.Verify(m => m.addAnswersDTO(postAnswerDtoList), Times.Once);

        }
    }
}
