using project.data.utils;
using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.domain.model.reports.questionnaireAnalysis;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Linq;

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

        public virtual void addAnswersDTO(List<PostAnswerDTO> answersDTO)
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

        public virtual bool postAnswerAlreadyExists(string idCompany, string idSale)
        {
            return answersRepository.postAnswerAlreadyExists(idCompany, idSale);
        }

        public virtual AnswerDetails getAnswerDetailsDataView(string idAnswer)
        {
            return answersRepository.getAnswerDetailsDataView(idAnswer);
        }

        public virtual List<AnswerModel> getAnswers(AnswersFilters filters)
        {
            if (filters.initialDate != null && filters.finalDate != null)
            {
                filters.initialDate = DateTimeUtils.convertToInitial((DateTime)filters.initialDate);
                filters.finalDate = DateTimeUtils.convertToFinal((DateTime)filters.finalDate);
            }

            return answersRepository.getAnswers(filters);
        }

        public virtual List<AnswerNotResolvedDataView> getAnswersNotResolved()
        {
            return answersRepository.getAnswersNotResolved();
        }

        public virtual void putAnswer(AnswerModel answer)
        {
            answer.updatedAt = DateTime.Now;
            if (!string.IsNullOrWhiteSpace(answer.status)) answer.status = TextUtils.translateStatusAnswerData(answer.status);
            answersRepository.putAnswer(answer);
        }

        public List<QuestionnaireAnalysisReportModel> postQuestionnaireAnalysisReport(QuestionnaireAnalysisFilters filters)
        {
            if (filters.initialDate != null && filters.finalDate != null)
            {
                filters.initialDate = DateTimeUtils.convertToInitial((DateTime)filters.initialDate);
                filters.finalDate = DateTimeUtils.convertToFinal((DateTime)filters.finalDate);
            }
            return answersRepository.postQuestionnaireAnalysisReport(filters);
        }
    }
}
