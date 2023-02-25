using Moq;
using project.data.usecases.answers;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;

namespace specs.suport.factories.unit.answers
{
    public class AnswersDataFactoryMock
    {
        static string connectionSpecsPostgres = Properties.Settings.Default.postgresConnection;
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);
        public static FbDbContext firebirdMock = new FbDbContext();

        public static Mock<AnswersPostgresRepository> answerRepositoryMock = new Mock<AnswersPostgresRepository>(postgresMock, firebirdMock);
        public static AnswersData<IAnswersRepository> answersData = new AnswersData<IAnswersRepository>(answerRepositoryMock.Object);
    }
}
