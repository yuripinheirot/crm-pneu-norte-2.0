using project.business.usecases.questions;
using project.data.usecases.questions;
using project.infra.db.mock.repository;
using project.infra.db.postgres.repository;

namespace project.main.factories.business
{
    public class QuestionsFactory
    {
        //private static QuestionsMockRepository questionsRepository =
        //       new QuestionsMockRepository();        
        private static QuestionsPostgresRepository questionsRepository = new QuestionsPostgresRepository();
        private static QuestionsData<QuestionsPostgresRepository> questionsData =
            new QuestionsData<QuestionsPostgresRepository>(questionsRepository);


        public static QuestionsBusiness<QuestionsData<QuestionsPostgresRepository>> handle =
            new QuestionsBusiness<QuestionsData<QuestionsPostgresRepository>>(questionsData);
    }
}
