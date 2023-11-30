using project.data.usecases.answers;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using project.validations.crm;

namespace project.main.factories.validations
{
    public class VerifyIfExistsCurrentCrmValidationFactory
    {
        static PgDbContext postgres = new PgDbContext(Properties.Settings.Default.postgresConnectionString);
        static FbDbContext firebird = new FbDbContext();
        private static AnswersPostgresRepository answersRepository = new AnswersPostgresRepository(postgres, firebird);
        private static AnswersData answersData = new AnswersData(answersRepository);

        public static VerifyIfExistsCurrentCrmValidation
            handle = new VerifyIfExistsCurrentCrmValidation(answersData);
    }
}
