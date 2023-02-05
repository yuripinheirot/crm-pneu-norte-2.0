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
using specs.suport.factories.unit;

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
    }
}
