using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;

namespace project.main.factories.business
{
    public class AnswersFactory
    {
        static PgDbContext postgres = new PgDbContext(Properties.Settings.Default.postgresConnectionString);
        static FbDbContext firebird = new FbDbContext();
        private static QuestionsPostgresRepository questionsRepository = new QuestionsPostgresRepository(postgres);
        private static QuestionsData questionsData = new QuestionsData(questionsRepository);


        private static AnswersPostgresRepository answersRepository = new AnswersPostgresRepository(postgres, firebird);
        private static AnswersData answersData = new AnswersData(answersRepository);


        public static AnswersBusiness handle =
            new AnswersBusiness(answersData, questionsData);
    }
}
