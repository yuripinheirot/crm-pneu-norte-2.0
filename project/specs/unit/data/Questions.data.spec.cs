using Microsoft.VisualStudio.TestTools.UnitTesting;
using specs.suport.factories;
using System;
using Moq;
using project.domain.model;
using System.Collections.Generic;
using project.presentation.protocols;
using specs.suport.factories.unit;

namespace specs.unit.data
{
    [TestClass]
    public class QuestionsDataSpec
    {
        [TestMethod]
        [Description("getQuestions should throw if QuestionsRepository throws")]
        public void getQuestionsShouldThrowIfQuestionsRepositoryThrows()
        {
            QuestionsDataFactoryMock.questionRepositoryMock
                .Setup(x => x.getQuestions())
                .Throws(new Exception());

            Assert.ThrowsException<Exception>(() =>
            {
                QuestionsDataFactoryMock.questionsData.getQuestions();
            });
        }

    }
}
