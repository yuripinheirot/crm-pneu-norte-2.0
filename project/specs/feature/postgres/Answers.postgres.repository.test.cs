using Microsoft.VisualStudio.TestTools.UnitTesting;
using project.domain.model;
using project.presentation.protocols;
using specs.suport.factories.feature.answers;
using specs.suport.helpers;
using System;
using System.Collections.Generic;

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
        [Description("Should addAnswersRepository add on db with correct values")]
        public void ShouldAddAnswersRepositoryOnDbWithCorrectValues()
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

        [TestMethod]
        [Description("PostAnswerAlreadyExists should return correct values")]
        public void PostAnswerAlreadyExistsShouldReturnCorrectValue()
        {
            var answerExist = AnswersRepositoryFactoryMock.answerRepository.postAnswerAlreadyExists(answersInserted[0].idCompany, answersInserted[0].idSale);
            var answerNotExist = AnswersRepositoryFactoryMock.answerRepository.postAnswerAlreadyExists(answersInserted[0].idCompany, "invalidIdSale");

            Assert.IsFalse(answerNotExist);
            Assert.IsTrue(answerExist);
        }

        [TestMethod]
        [Description("GetAnswerDetailsDataView should return correct values")]
        public void GetAnswerDetailsDataViewShouldReturnCorrectValue()
        {
            var answerDetail = AnswersRepositoryFactoryMock.answerRepository.getAnswerDetailsDataView(answersInserted[0].id);

            Assert.AreEqual(answersInserted[0].idCompany, answerDetail.idCompany);
            Assert.AreEqual(answersInserted[0].idSale, answerDetail.idSale);
            Assert.AreEqual(answersInserted[0].resolution, answerDetail.resolution);
            Assert.AreEqual(answersInserted[0].status, answerDetail.status);
            Assert.AreEqual(answersInserted[0].observation, answerDetail.observation);
            Assert.AreEqual(answersInserted[0].answer, answerDetail.answer);
            Assert.AreEqual(answersInserted[0].idClient, answerDetail.client);
            Assert.AreEqual(questionsInserted[0].description, answerDetail.descriptionQuestion);
        }

        [TestMethod]
        [Description("getAnswers should return correct values")]
        public void getAnswersShouldReturnCorrectValue()
        {
            var filters = new AnswersFilters()
            {
                answer = "answer2",
                initialDate = new DateTime(2000, 01, 01),
                finalDate = new DateTime(2010, 01, 01),
                idCompany = "02",
                idQuestion = questionsInserted[1].id,
                idSale = "0000201"
            };
            var answers = AnswersRepositoryFactoryMock.answerRepository.getAnswers(filters);

            Assert.AreEqual(1, answers.Count);
            Assert.AreEqual(answersInserted[1].id, answers[0].id);
            Assert.AreEqual(answersInserted[1].idQuestion, answers[0].idQuestion);
            Assert.AreEqual(answersInserted[1].idSale, answers[0].idSale);
            Assert.AreEqual(answersInserted[1].idClient, answers[0].idClient);
            Assert.AreEqual(answersInserted[1].status, answers[0].status);
            Assert.AreEqual(answersInserted[1].answer, answers[0].answer);
            Assert.AreEqual(answersInserted[1].observation, answers[0].observation);
            Assert.AreEqual(answersInserted[1].resolution, answers[0].resolution);
            Assert.AreEqual(answersInserted[1].createdAt, answers[0].createdAt);
            Assert.AreEqual(answersInserted[1].updatedAt, answers[0].updatedAt);
            Assert.AreEqual(answersInserted[1].idCompany, answers[0].idCompany);
        }

        [TestMethod]
        [Description("getAnswersNotResolved should return correct values")]
        public void getAnswersNotResolvedShouldReturnCorrectValue()
        {
            var answersNotResolved = AnswersRepositoryFactoryMock.answerRepository.getAnswersNotResolved();

            Assert.AreEqual(1, answersNotResolved.Count);
            Assert.AreEqual(answersInserted[1].id, answersNotResolved[0].idAnswer);
            Assert.AreEqual(answersInserted[1].idCompany, answersNotResolved[0].idCompany);
            Assert.AreEqual(answersInserted[1].idSale, answersNotResolved[0].idSale);
            Assert.AreEqual(answersInserted[1].idClient, answersNotResolved[0].idClient);
            Assert.AreEqual(answersInserted[1].answer, answersNotResolved[0].answer);
            Assert.AreEqual(questionsInserted[1].description, answersNotResolved[0].descriptionQuestion);
            Assert.AreEqual(answersInserted[1].observation, answersNotResolved[0].observation);
            Assert.AreEqual(answersInserted[1].resolution, answersNotResolved[0].resolution);
        }
    }
}
