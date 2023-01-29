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

namespace specs
{
    [TestClass]
    public class AnswerBusinessSpec
    {
        [TestMethod]
        public void TestMethod1()
        {
            // Usando o Moq
            var mockAnswersRepository = new Mock<AnswersPostgresRepository>();
            var mockQuestionsRepository = new Mock<QuestionsPostgresRepository>();
            var mockAnswersData = new Mock<AnswersData<AnswersPostgresRepository>>(mockAnswersRepository.Object) { CallBase = true };
            var mockQuestionsData = new Mock<QuestionsData<QuestionsPostgresRepository>>(mockQuestionsRepository.Object) { CallBase = true };

            mockQuestionsData.Setup(x => x.getQuestion(It.Is<string>(i => i == "1")))
                .Returns(
                    new QuestionModel()
                    {
                        answers = new List<string>() { "yes", "no" },
                        badAnswers = new List<string>() { "no" }
                    }
                );
            mockQuestionsData.Setup(x => x.getQuestion(It.Is<string>(i => i == "2")))
                .Returns(
                    new QuestionModel()
                    {
                        answers = new List<string>() { "yes", "no" },
                        badAnswers = new List<string>() { "no" }
                    }
                );

            // criar instâncias mockadas das classes
            var answersBusiness = new AnswersBusiness<
                AnswersData<AnswersPostgresRepository>,
                QuestionsData<QuestionsPostgresRepository>
                >(mockAnswersData.Object, mockQuestionsData.Object);

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
                    updatedAt = DateTime.Now,
                    status = "done"
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
                    status = "pending"
                },
            };

            //answersBusiness.addAnswersDTO(listPostAnswersDTO);

            mockAnswersData.Verify(x => x.addAnswersDTO(It.Is<List<PostAnswerDTO>>(a =>
    a[0].status == "done" &&
    a[1].status == "done")), Times.Once());
            //mockAnswersData.Setup(x => x.addAnswersDTO(It.IsAny<List<PostAnswerDTO>>()))
            //    .Callback((List<PostAnswerDTO> param) =>
            //    {
            //        Assert.Equals(param, expectedListPostAnswersDTO);
            //    });
        }
    }
}
