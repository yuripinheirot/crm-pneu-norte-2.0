using Microsoft.VisualStudio.TestTools.UnitTesting;
using project.domain.model;
using project.infra.db.postgres.repository;
using project.presentation.protocols;
using specs.suport.factories.feature;
using specs.suport.helpers;
using System;
using System.Collections.Generic;

namespace specs.feature.postgres
{
    [TestClass]
    public class QuestionsPostgresRepositoryTest
    {
        static List<QuestionModel> questionsInserted = new List<QuestionModel>()
        {
            new QuestionModel()
            {
                id = Guid.NewGuid().ToString(),
                active = true,
                answers = new List<string>() {"yes", "no"},
                badAnswers = new List<string>() {"no"},
                description = "description1",
                posSale = "order"
            },
            new QuestionModel()
            {
                id = Guid.NewGuid().ToString(),
                active = true,
                answers = new List<string>() {"yes", "no"},
                badAnswers = new List<string>() {"yes"},
                description = "description2",
                posSale = "sale"
            },
        };
        static List<AnswerModel> answersInserted = new List<AnswerModel>()
        {
            new AnswerModel()
            {
                id =  Guid.NewGuid().ToString(),
                answer = "answer1",
                idClient = "00001",
                idCompany = "01",
                idQuestion = questionsInserted[0].id,
                idSale = "0000200",
                observation = "observation",
                resolution = "resolution",
                status = "done",
                createdAt = new DateTime(2000, 01, 01),
                updatedAt = new DateTime(2002, 02, 02)
            },
            new AnswerModel()
            {
                id =  Guid.NewGuid().ToString(),
                answer = "answer2",
                idClient = "00002",
                idCompany = "02",
                idQuestion = questionsInserted[1].id,
                idSale = "0000201",
                observation = "observation",
                resolution = "resolution",
                status = "pending",
                createdAt = new DateTime(2003, 03, 03),
                updatedAt = new DateTime(2004, 04, 04)
            },
        };

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {
            MethodsPostgresHelper.insertManyQuestions(questionsInserted);
            MethodsPostgresHelper.insertManyAnswers(answersInserted);
        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {
            MethodsPostgresHelper.cleanAnswers();
            MethodsPostgresHelper.cleanQuestions();
        }

        [TestMethod]
        [Description("Should getQuestion return correct values")]
        public void ShouldGetQuestionReturnCorrectValues()
        {

            var question = QuestionsRepositoryFactoryMock.questionRepository.getQuestion(questionsInserted[0].id);

            Assert.IsNotNull(question);
            Assert.AreEqual(questionsInserted[0].id, question.id);
            Assert.AreEqual(questionsInserted[0].active, question.active);
            //CollectionAssert.AreEqual(questionsInserted[0].answers, question.answers);
            //CollectionAssert.AreEqual(questionsInserted[0].badAnswers, question.badAnswers);
            Assert.AreEqual(questionsInserted[0].description, question.description);
            Assert.AreEqual(questionsInserted[0].posSale, question.posSale);
        }

        [TestMethod]
        [Description("Should getQuestions return correct values")]
        public void ShouldGetQuestionsReturnCorrectValues()
        {
            var questions = QuestionsRepositoryFactoryMock.questionRepository.getQuestions();

            Assert.AreEqual(2, questions.Count);
        }
    }
}
