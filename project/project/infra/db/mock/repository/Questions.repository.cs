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
    internal class QuestionsDbMockRepository : IGetQuestions
    {
        public List<Question> getQuestions()
        {
            return QuestionsMock.questionsMock;
        }
    }
}
