using project.business.usecases.questions;
using project.data.usecases.questions;
using project.infra.db.mock.repository;

namespace project.main.factories.business
{
    public class QuestionsFactory
    {
        private static QuestionsRepository questionsRepository =
               new QuestionsRepository();
        private static QuestionsData questionsData =
            new QuestionsData(questionsRepository);


        public static QuestionsBusiness handle =
            new QuestionsBusiness(questionsData);
    }
}
