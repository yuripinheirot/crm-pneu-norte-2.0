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
    internal class AnswersBusiness : IPostCrm, IGetAnswers
    {
        AnswersData answersData;
        public AnswersBusiness(AnswersData answersData)
        {
            this.answersData = answersData;
        }
        private void validateAnswers(List<PostAnswerDTO> answers)
        {
            foreach (PostAnswerDTO answer in answers)
            {
                if (string.IsNullOrEmpty(answer.answer))
                {
                    throw new Exception("Todas as respostas devem ser preenchidas");
                }
            }
        }

        public void addCrm(List<PostAnswerDTO> answers)
        {
            validateAnswers(answers);
            answersData.addCrm(answers);
        }

        public List<AnswerModel> getAnswers(GetAnswersDTO filters)
        {
            return answersData.getAnswers(filters);
        }
    }
}
