using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project.data.usecases.answers;
using project.domain.model;
using project.domain.usecases;
using project.presentation.errors.exceptions;
using project.presentation.protocols;
using project.validations.crm;

namespace project.business.usecases.answers
{
    internal class AnswersBusiness : IPostCrm, IGetAnswers, IGetCrm
    {
        AnswersData answersData;
        public AnswersBusiness(AnswersData answersData)
        {
            this.answersData = answersData;
        }

        public void addCrm(List<PostAnswerDTO> answers)
        {
            answersData.addCrm(answers);
        }

        public List<AnswerModel> getAnswers(GetAnswersDTO filters)
        {
            return answersData.getAnswers(filters);
        }

        public List<AnswerModel> getCrm(string idSale, string idCompany)
        {
            return answersData.getCrm(idSale, idCompany);
        }
    }
}
