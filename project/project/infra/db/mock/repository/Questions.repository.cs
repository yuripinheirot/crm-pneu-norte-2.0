using project.domain.model;
using project.domain.usecases;
using project.specs.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.mock.repository
{
    public class QuestionsRepository : IGetQuestions
    {
        public List<QuestionModel> getQuestions()
        {
            return QuestionsMock.questions;
        }

        public QuestionModel getQuestion(string idQuestion)
        {
            return QuestionsMock.questions.Where(q => q.id == idQuestion).FirstOrDefault();
        }
    }
}
