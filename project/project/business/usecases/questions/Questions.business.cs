using project.data.usecases.questions;
using project.domain.interfaces;
using project.domain.interfaces.Struct;
using project.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.usecases.questions
{
    public class QuestionsBusiness<QuestionsData> : IQuestionsBusiness
        where QuestionsData : IQuestionsData
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
