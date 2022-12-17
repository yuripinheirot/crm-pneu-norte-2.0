using project.domain.model;
using project.domain.usecases;
using project.presentation.protocols;
using project.specs.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.mock.repository
{
    internal class AnswersRepository : IPostCrmRepository, IGetAnswers
    {
        public void addCrm(List<AnswerModel> answers)
        {
            AnswersMock.answers.AddRange(answers);
        }

        public List<AnswerModel> getAnswers(GetAnswersDTO filters)
        {
            return AnswersMock.answers.Where(answer =>
            {
                return (answer.createdAt >= filters.initialDate) &&
                       (answer.createdAt <= filters.finalDate) &&
                       (answer.idQuestion == filters.idQuestion);
            }).ToList();
        }
    }
}
