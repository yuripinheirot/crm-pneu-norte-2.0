using Moq;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories.unit.answers
{
    public class AnswersBusinessFactoryMock
    {
        public static Mock<AnswersPostgresRepository> answerRepositoryMock = new Mock<AnswersPostgresRepository>();
        public static Mock<AnswersData<IAnswersRepository>> answersDataMock = new Mock<AnswersData<IAnswersRepository>>(answerRepositoryMock.Object);

        public static Mock<QuestionsPostgresRepository> questionRepositoryMock = new Mock<QuestionsPostgresRepository>();
        public static Mock<QuestionsData<IQuestionsRepository>> questionsDataMock = new Mock<QuestionsData<IQuestionsRepository>>(questionRepositoryMock.Object);

        public static AnswersBusiness<IAnswersData, IQuestionsData> answersBusiness = new AnswersBusiness<IAnswersData, IQuestionsData>(answersDataMock.Object, questionsDataMock.Object);
    }
}
