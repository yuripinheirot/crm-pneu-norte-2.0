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

namespace project.data.answers
{
    internal class AnswersData : IAddCrmDTO
    {
        AnswersRepository answersRepository;
        public AnswersData(AnswersRepository answersRepository)
        {
            this.answersRepository = answersRepository;
        }

        private List<AnswerModel> convertAnswerDTOinAnswer(List<AnswerDTO> answersDTO)
        {
            List<AnswerModel> answers = new List<AnswerModel>();
            Guid newId = Guid.NewGuid();

            foreach (AnswerDTO a in answersDTO)
            {
                answers.Add(new AnswerModel()
                {
                    id = newId.ToString(),
                    idQuestion = a.idQuestion,
                    idSale = a.idSale,
                    idClient = a.idClient,
                    status = a.status,
                    answer = a.answer,
                    observation = a.observation,
                    resolution = null,
                    updatedAt = DateTime.Now,
                    idCompany = a.idCompany
                });
            }

            return answers;
        }

        public void addCrm(List<AnswerDTO> answersDTO)
        {
            var answers = convertAnswerDTOinAnswer(answersDTO);
            answersRepository.addCrm(answers);
        }
    }
}
