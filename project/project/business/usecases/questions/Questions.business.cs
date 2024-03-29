﻿using project.domain.interfaces.Struct;
using project.domain.model.entities;
using System.Collections.Generic;
using System.Linq;
using project.data.usecases.questions;

namespace project.business.usecases.questions
{
    public class QuestionsBusiness : IQuestionsBusiness
    {
        QuestionsData questionsData;
        public QuestionsBusiness(QuestionsData questionsData)
        {
            this.questionsData = questionsData;
        }


        public List<QuestionModel> getQuestions()
        {
            return questionsData.getQuestions().Where(q => q.active == true).ToList();
        }

        public QuestionModel getQuestion(string idQuestion)
        {
            return questionsData.getQuestion(idQuestion);
        }
    }
}
