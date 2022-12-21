using project.business.usecases.answers;
using project.data.usecases.answers;
using project.data.usecases.questions;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories.business
{
    internal class AnswersFactory
    {
        private static QuestionsRepository questionsRepository = new QuestionsRepository();
        private static QuestionsData questionsData = new QuestionsData(questionsRepository);


        private static AnswersRepository answersRepository = new AnswersRepository();
        private static AnswersData answersData = new AnswersData(answersRepository);


        public static AnswersBusiness handle = new AnswersBusiness(answersData, questionsData);
    }
}
