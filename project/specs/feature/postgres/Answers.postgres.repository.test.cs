using Microsoft.VisualStudio.TestTools.UnitTesting;
using project.domain.model;
using specs.suport.factories.feature.answers;
using specs.suport.helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;

namespace specs.feature.postgres
{
    [TestClass]
    public class UnitTest1
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
                idSale = "0000001",
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
                idSale = "0000002",
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
        [Description("Should add answers on db with correct values")]
        public void ShouldAddAnswersOnDbWithCorrectValues()
        {
            var id = Guid.NewGuid().ToString();
            var answerToInsert = new List<AnswerModel>()
            {
                new AnswerModel()
                {
                    id = id,
                    answer = "woooooorkkkkk!!!!!",
                    idClient = "00001",
                    idCompany = "01",
                    idQuestion = questionsInserted[0].id,
                    idSale = "0000001",
                    observation = "observation",
                    resolution = "resolution",
                    status = "done",
                    createdAt = new DateTime(2000, 01, 01),
                    updatedAt = new DateTime(2002, 02, 02)
                },
            };

            AnswersRepositoryFactoryMock.answerRepository.addAnswersRepository(answerToInsert);
            var insertedAnswer = MethodsPostgresHelper.getAnswerById(id);

            Assert.IsNotNull(insertedAnswer);
            Assert.AreEqual(answerToInsert[0].id, insertedAnswer.id);
            Assert.AreEqual(answerToInsert[0].answer, insertedAnswer.answer);
            Assert.AreEqual(answerToInsert[0].idClient, insertedAnswer.idClient);
            Assert.AreEqual(answerToInsert[0].idCompany, insertedAnswer.idCompany);
            Assert.AreEqual(answerToInsert[0].idQuestion, insertedAnswer.idQuestion);
            Assert.AreEqual(answerToInsert[0].idSale, insertedAnswer.idSale);
            Assert.AreEqual(answerToInsert[0].observation, insertedAnswer.observation);
            Assert.AreEqual(answerToInsert[0].resolution, insertedAnswer.resolution);
            Assert.AreEqual(answerToInsert[0].status, insertedAnswer.status);
            Assert.AreEqual(answerToInsert[0].createdAt, insertedAnswer.createdAt);
            Assert.AreEqual(answerToInsert[0].updatedAt, insertedAnswer.updatedAt);
        }
    }
}
