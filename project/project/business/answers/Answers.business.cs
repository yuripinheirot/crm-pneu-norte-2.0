using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.data.answers;
using project.domain.model;
using project.domain.usecases;
using project.presentation.protocols;

namespace project.business.answers
{
    internal class AnswersBusiness : IAddCrmDTO
    {
        AnswersData answersData;
        public AnswersBusiness(AnswersData answersData)
        {
            this.answersData = answersData;
        }
        private void validateAnswers(List<AnswerDTO> answers)
        {
            foreach (AnswerDTO answer in answers)
            {
                if (string.IsNullOrEmpty(answer.answer))
                {
                    throw new Exception("Todas as respostas devem ser preenchidas");
                }
            }
        }

        public void addCrm(List<AnswerDTO> answers)
        {
            validateAnswers(answers);
            answersData.addCrm(answers);
        }
    }
}
