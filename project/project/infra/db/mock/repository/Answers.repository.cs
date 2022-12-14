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
    public class AnswersRepository : IPostAnswersRepository, IGetAnswers, IGetAnswersNotResolved, IGetAnswerDetails
    {
        public void addAnswersRepository(List<AnswerModel> answers)
        {
            AnswersMock.answers.AddRange(answers);
        }

        public AnswerDetails getAnswerDetailsDataView(string idAnswer)
        {
            var answerDetails =
                from answer in AnswersMock.answers
                join sale in SalesMock.sales on answer.idSale equals sale.id
                join question in QuestionsMock.questions on answer.idQuestion equals question.id
                where answer.id == idAnswer
                select new AnswerDetails()
                {
                    answer = answer.answer,
                    client = sale.client,
                    idCompany = answer.idCompany,
                    idSale = answer.idSale,
                    descriptionQuestion = question.description,
                    observation = answer.observation,
                    resolution = answer.resolution,
                    seller = sale.seller,
                    status = answer.status
                };

            return answerDetails.FirstOrDefault();
        }

        public List<AnswerModel> getAnswers(AnswersFilters filters)
        {
            return AnswersMock.answers.Where(answer =>
            {
                return
                (filters.initialDate != null ? answer.createdAt >= filters.initialDate : true) &&
                (filters.finalDate != null ? answer.createdAt <= filters.finalDate : true) &&
                (!string.IsNullOrWhiteSpace(filters.idSale) ? answer.idSale == filters.idSale : true) &&
                (!string.IsNullOrWhiteSpace(filters.idQuestion) ? answer.idQuestion == filters.idQuestion : true) &&
                (!string.IsNullOrWhiteSpace(filters.idCompany) ? answer.idCompany == filters.idCompany : true);
            }).ToList();
        }

        public List<AnswerNotResolvedDataView> getAnswersNotResolved()
        {
            var query =
                from answer in AnswersMock.answers
                join question in QuestionsMock.questions on answer.idQuestion equals question.id
                where answer.status == "pending"
                select new AnswerNotResolvedDataView()
                {
                    idAnswer = answer.id,
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
    }
}
