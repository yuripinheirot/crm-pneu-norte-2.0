using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using project.presentation.protocols;
using project.presentation.utils;

namespace project.data.usecases.answers
{
    public class AnswersData<AnswersRepository> : IPostAnswers, IGetAnswers, IGetAnswersNotResolved, IGetAnswerDetails, IPutAnswer 
        where AnswersRepository : IPostAnswersRepository, IGetAnswers, IGetAnswersNotResolved, IGetAnswerDetails, IPutAnswer
    {
        private AnswersRepository answersRepository;
        public AnswersData(AnswersRepository answersRepository)
        {
            this.answersRepository = answersRepository;
        }

        public void addAnswersDTO(List<PostAnswerDTO> answersDTO)
        {
            var answers = answersDTO.Select(a => new AnswerModel()
            {
                id = Guid.NewGuid().ToString(),
                idQuestion = a.idQuestion,
                idSale = a.idSale,
                idClient = a.idClient,
                status = a.status,
                answer = a.answer,
                observation = a.observation,
                resolution = null,
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now,
                idCompany = a.idCompany
            }).ToList();

            answersRepository.addAnswersRepository(answers);
        }

        public AnswerDetails getAnswerDetailsDataView(string idAnswer)
        {
            return answersRepository.getAnswerDetailsDataView(idAnswer);
        }

        public List<AnswerModel> getAnswers(AnswersFilters filters)
        {
            if (filters.initialDate != null && filters.finalDate != null)
            {
                filters.initialDate = new DateTime(filters.initialDate.Value.Year, filters.initialDate.Value.Month, filters.initialDate.Value.Day, 0, 0, 0);
                filters.finalDate = new DateTime(filters.finalDate.Value.Year, filters.finalDate.Value.Month, filters.finalDate.Value.Day, 23, 59, 59);
            }

            return answersRepository.getAnswers(filters);
        }

        public List<AnswerNotResolvedDataView> getAnswersNotResolved()
        {
            return answersRepository.getAnswersNotResolved();
        }

        public void putAnswer(AnswerModel answer)
        {
            answer.updatedAt = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(answer.status)) answer.status = TextUtils.translateStatusAnswerData(answer.status);
            answersRepository.putAnswer(answer);
        }
    }
}
