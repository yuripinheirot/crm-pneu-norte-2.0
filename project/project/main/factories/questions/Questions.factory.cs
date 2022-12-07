using project.business.questions;
using project.data.questions;
using project.infra.db.mock.repository;

namespace project.main.factories.questions
{
    internal class QuestionsFactory
    {
        private static QuestionsDbMockRepository questionsRepository =
               new QuestionsDbMockRepository();
        private static QuestionsData questionsData =
            new QuestionsData(questionsRepository);


        public static QuestionsBusiness questions =
            new QuestionsBusiness(questionsData);
    }
}
