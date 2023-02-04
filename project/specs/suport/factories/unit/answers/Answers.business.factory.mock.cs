using Moq;
using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.factories.unit.answers
{
    public class AnswersBusinessFactoryMock
    {
        static string connectionSpecsPostgres = ConfigurationManager.ConnectionStrings["specs"].ToString();
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);
        public static FbDbContext firebirdMock = new FbDbContext();

        public static Mock<AnswersPostgresRepository> answerRepositoryMock = new Mock<AnswersPostgresRepository>(postgresMock, firebirdMock);
        public static Mock<AnswersData<IAnswersRepository>> answersDataMock = new Mock<AnswersData<IAnswersRepository>>(answerRepositoryMock.Object);

        public static Mock<QuestionsPostgresRepository> questionRepositoryMock = new Mock<QuestionsPostgresRepository>(postgresMock);
        public static Mock<QuestionsData<IQuestionsRepository>> questionsDataMock = new Mock<QuestionsData<IQuestionsRepository>>(questionRepositoryMock.Object);

        public static AnswersBusiness<IAnswersData, IQuestionsData> answersBusiness = new AnswersBusiness<IAnswersData, IQuestionsData>(answersDataMock.Object, questionsDataMock.Object);
    }
}
