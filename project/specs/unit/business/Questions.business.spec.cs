﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using project.domain.model.entities;
using specs.suport.factories.unit.business;
using System;
using System.Collections.Generic;

namespace specs
{
    [TestClass]
    public class QuestionBusinessSpec
    {
        [TestMethod]
        [Description("getQuestions should throw if question data throws")]
        public void GetQuestionsShouldThrowIfQuestionDataThrows()
        {
            QuestionsBusinessFactoryMock.questionsDataMock
                .Setup(x => x.getQuestions())
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             QuestionsBusinessFactoryMock.questionsBusiness.getQuestions()
            );
        }

        [TestMethod]
        [Description("getQuestions should return correct values")]
        public void GetQuestionsShouldReturnCorrectValues()
        {
            List<QuestionModel> questions = new List<QuestionModel>()
            {
                new QuestionModel()
                {
                    id = "idd",
                    active = true,
                    answers = new List<string>(){"yess", "noo"},
                    badAnswers = new List<string>(){"noo"},
                    description = "descriptionn",
                    posSale = "posSales"
                },
                new QuestionModel()
                {
                    id = "id",
                    active = false,
                    answers = new List<string>(){"yes", "no"},
                    badAnswers = new List<string>(){"no"},
                    description = "description",
                    posSale = "posSale"
                }
            };

            QuestionsBusinessFactoryMock.questionsDataMock
                .Setup(x => x.getQuestions())
                .Returns(questions);

            var questionsReturned = QuestionsBusinessFactoryMock.questionsBusiness.getQuestions();

            Assert.AreEqual(1, questionsReturned.Count);
            Assert.AreEqual(questions[0].id, questionsReturned[0].id);
            Assert.AreEqual(questions[0].active, questionsReturned[0].active);
            CollectionAssert.AreEqual(questions[0].answers, questionsReturned[0].answers);
            CollectionAssert.AreEqual(questions[0].badAnswers, questionsReturned[0].badAnswers);
            Assert.AreEqual(questions[0].description, questionsReturned[0].description);
            Assert.AreEqual(questions[0].posSale, questionsReturned[0].posSale);
        }

        [TestMethod]
        [Description("getQuestion should throw if question data throws")]
        public void GetQuestionShouldThrowIfQuestionDataThrows()
        {
            QuestionsBusinessFactoryMock.questionsDataMock
                .Setup(x => x.getQuestion(It.IsAny<string>()))
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
             QuestionsBusinessFactoryMock.questionsBusiness.getQuestion("invalidId")
            );
        }

        [TestMethod]
        [Description("getQuestion should return correct values")]
        public void GetQuestionShouldReturnCorrectValues()
        {
            QuestionModel question = new QuestionModel()
            {
                id = "id",
                active = false,
                answers = new List<string>() { "yes", "no" },
                badAnswers = new List<string>() { "no" },
                description = "description",
                posSale = "posSale"
            };

            QuestionsBusinessFactoryMock.questionsDataMock
                .Setup(x => x.getQuestion(It.IsAny<string>()))
                .Returns(question);

            var questionsReturned = QuestionsBusinessFactoryMock.questionsBusiness.getQuestion("validId");

            Assert.IsNotNull(questionsReturned);
            Assert.AreEqual(question.id, questionsReturned.id);
            Assert.AreEqual(question.active, questionsReturned.active);
            CollectionAssert.AreEqual(question.answers, questionsReturned.answers);
            CollectionAssert.AreEqual(question.badAnswers, questionsReturned.badAnswers);
            Assert.AreEqual(question.description, questionsReturned.description);
            Assert.AreEqual(question.posSale, questionsReturned.posSale);
        }
    }
}
