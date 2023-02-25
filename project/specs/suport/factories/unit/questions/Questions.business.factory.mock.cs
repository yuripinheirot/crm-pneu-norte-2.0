using Moq;
using project.business.usecases.questions;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;

namespace specs.suport.factories.unit.business
{
    public class QuestionsBusinessFactoryMock
    {
        static readonly string connectionSpecsPostgres = Properties.Settings.Default.postgresConnection;
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);
        public static FbDbContext firebirdMock = new FbDbContext();

        public static Mock<QuestionsPostgresRepository> questionRepositoryMock = new Mock<QuestionsPostgresRepository>(postgresMock);
        public static Mock<QuestionsData<IQuestionsRepository>> questionsDataMock = new Mock<QuestionsData<IQuestionsRepository>>(questionRepositoryMock.Object);

        public static QuestionsBusiness<IQuestionsData> questionsBusiness = new QuestionsBusiness<IQuestionsData>(questionsDataMock.Object);
    }
}
