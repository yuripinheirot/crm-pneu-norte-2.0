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
    internal class AnswersRepository : IPostCrmRepository, IGetAnswers, IGetCrm, IGetAnswersNotResolved
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

        public List<AnswerNotResolvedProtocol> getAnswersNotResolved()
        {
            var query =
                from answer in AnswersMock.answers
                join question in QuestionsMock.questions on answer.idQuestion equals question.id
                where answer.status == "pending"
                select new AnswerNotResolvedProtocol()
                {
                    idCompany = answer.idCompany,
                    idSale = answer.idSale,
                    idClient = answer.idClient,
                    answer = answer.answer,
                    descriptionQuestion = question.description,
                    observation = answer.observation,
                    resolution = answer.resolution,
                };

            return query.ToList();
        }

        public List<AnswerModel> getCrm(string idSale, string idCompany)
        {
            return AnswersMock.answers.Where(a => a.idSale == idSale && a.idCompany == idCompany).ToList();
        }
    }
}
