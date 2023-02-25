using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;

namespace specs.suport.factories.feature
{
    public class AnswersRepositoryFactoryMock
    {
        static string connectionSpecsPostgres = Properties.Settings.Default.postgresConnection;
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);
        public static FbDbContext firebirdMock = new FbDbContext();

        public static AnswersPostgresRepository answerRepository = new AnswersPostgresRepository(postgresMock, firebirdMock);
    }
}
