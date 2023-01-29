using project.domain.model;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using project.presentation.protocols;
using project.presentation.utils;
using project.data.utils;
using project.domain.interfaces;
using project.domain.interfaces.Struct;

namespace project.data.usecases.answers
{
    public class AnswersData<AnswersRepository> : IAnswersData
        where AnswersRepository : IAnswersRepository
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

        public bool postAnswerAlreadyExists(string idCompany, string idSale)
        {
            return answersRepository.postAnswerAlreadyExists(idCompany, idSale);
        }

        public AnswerDetails getAnswerDetailsDataView(string idAnswer)
        {
            return answersRepository.getAnswerDetailsDataView(idAnswer);
        }

        public List<AnswerModel> getAnswers(AnswersFilters filters)
        {
            if (filters.initialDate != null && filters.finalDate != null)
            {
                filters.initialDate = DateTimeUtils.convertToInitial((DateTime)filters.initialDate);
                filters.finalDate = DateTimeUtils.convertToFinal((DateTime)filters.finalDate);
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
