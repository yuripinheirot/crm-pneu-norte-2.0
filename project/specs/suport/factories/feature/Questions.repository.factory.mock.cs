using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;

namespace specs.suport.factories.feature
{
    public class QuestionsRepositoryFactoryMock
    {
        static string connectionSpecsPostgres = Properties.Settings.Default.postgresConnection;
        public static PgDbContext postgresMock = new PgDbContext(connectionSpecsPostgres);

        public static QuestionsPostgresRepository questionRepository = new QuestionsPostgresRepository(postgresMock);
    }
}
