﻿using project.business.questions;
using project.data.questions;
using project.infra.db.mock.repository;

namespace project.main.factories
{
    internal class QuestionsFactory
    {
        private static QuestionsDbMockRepository questionsRepository =
               new QuestionsDbMockRepository();
        private static QuestionsData questionsData =
            new QuestionsData(questionsRepository);


        public static QuestionsBusiness handle =
            new QuestionsBusiness(questionsData);
    }
}