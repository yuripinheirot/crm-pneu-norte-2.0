using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.infra.db.firebird.config;
using project.infra.db.mock.repository;
using project.infra.db.postgres.config;
using project.infra.db.postgres.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories.business
{
    public class AnswersFactory
    {
        static PgDbContext postgres = new PgDbContext(Properties.Settings.Default.postgresConnectionString);
        static FbDbContext firebird = new FbDbContext();
        //private static QuestionsMockRepository questionsRepository = new QuestionsMockRepository();
        private static QuestionsPostgresRepository questionsRepository = new QuestionsPostgresRepository(postgres);
        private static QuestionsData<QuestionsPostgresRepository> questionsData = new QuestionsData<QuestionsPostgresRepository>(questionsRepository);


        //private static AnswersMockRepository answersRepository = new AnswersMockRepository();
        private static AnswersPostgresRepository answersRepository = new AnswersPostgresRepository(postgres, firebird);
        private static AnswersData<AnswersPostgresRepository> answersData = new AnswersData<AnswersPostgresRepository>(answersRepository);


        public static AnswersBusiness<AnswersData<AnswersPostgresRepository>, QuestionsData<QuestionsPostgresRepository>> handle = 
            new AnswersBusiness<AnswersData<AnswersPostgresRepository>, QuestionsData<QuestionsPostgresRepository>>(answersData, questionsData);
    }
}
