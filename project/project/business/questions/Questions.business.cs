using project.data.questions;
using project.domain.model;
using project.domain.usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.questions
{
    internal class QuestionsBusiness : IGetQuestions
    {
        QuestionsData questionsData;
        public QuestionsBusiness(QuestionsData questionsData)
        {
            this.questionsData = questionsData;
        }


        public List<Question> getQuestions()
        {
            return questionsData.getQuestions().Where(q => q.active == true).ToList();
        }
    }
}
