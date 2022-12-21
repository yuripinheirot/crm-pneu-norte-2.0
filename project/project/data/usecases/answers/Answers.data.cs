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

namespace project.data.usecases.answers
{
    internal class AnswersData : IPostCrm, IGetAnswers, IGetCrm, IGetAnswersNotResolved
    {
        AnswersRepository answersRepository;
        public AnswersData(AnswersRepository answersRepository)
        {
            this.answersRepository = answersRepository;
        }

        public void addCrm(List<PostAnswerDTO> answersDTO)
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

            answersRepository.addCrm(answers);
        }

        public List<AnswerModel> getAnswers(GetAnswersDTO filters)
        {
            filters.initialDate = new DateTime(filters.initialDate.Year, filters.initialDate.Month, filters.initialDate.Day, 0, 0, 0);
            filters.finalDate = new DateTime(filters.finalDate.Year, filters.finalDate.Month, filters.finalDate.Day, 23, 59, 59);
            return answersRepository.getAnswers(filters);
        }

        public List<AnswerModel> getCrm(string idSale, string idCompany)
        {
            return answersRepository.getCrm(idSale, idCompany);
        }

        public List<AnswerNotResolvedProtocol> getAnswersNotResolved()
        {
            return answersRepository.getAnswersNotResolved();
        }
    }
}
