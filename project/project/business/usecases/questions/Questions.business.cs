using project.data.usecases.questions;
using project.domain.model;
using project.domain.usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.usecases.questions
{
    public class QuestionsBusiness<T> : IGetQuestions, IGetQuestion
        where T : IGetQuestions, IGetQuestion
    {
        T questionsData;
        public QuestionsBusiness(T questionsData)
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
