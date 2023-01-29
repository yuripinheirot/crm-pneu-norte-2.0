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

namespace specs.suport
{
    public class AnswersBusinessFactoryMock
    {
        public static Mock<AnswersPostgresRepository> answerRepository = new Mock<AnswersPostgresRepository>();
        public static Mock<AnswersData<IAnswersRepository>> answersDataMock = new Mock<AnswersData<IAnswersRepository>>(answerRepository.Object);

        public static Mock<QuestionsPostgresRepository> questionRepository = new Mock<QuestionsPostgresRepository>();
        public static Mock<QuestionsData<IQuestionsRepository>> questionsData = new Mock<QuestionsData<IQuestionsRepository>>(questionRepository.Object);

        public static AnswersBusiness<IAnswersData, IQuestionsData> answersBusiness = new AnswersBusiness<IAnswersData, IQuestionsData>(answersDataMock.Object, questionsData.Object);
    }
}
