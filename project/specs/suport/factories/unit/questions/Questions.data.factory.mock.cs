using Moq;
using project.data.usecases.questions;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;

namespace specs.suport.factories.unit.business
{
    public class QuestionsDataFactoryMock
    {
        static readonly string connectionSpecsPostgres = Properties.Settings.Default.postgresConnection;
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);
        public static FbDbContext firebirdMock = new FbDbContext();

        public static Mock<QuestionsPostgresRepository> questionRepositoryMock = new Mock<QuestionsPostgresRepository>(postgresMock);
        public static QuestionsData<IQuestionsRepository> questionsData = new QuestionsData<IQuestionsRepository>(questionRepositoryMock.Object);
    }
}
