using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    internal interface IGetAnswers
    {
        List<AnswerModel> getAnswers(GetAnswersDTO filters);
    }

    interface IGetAnswersNotResolved
    {
        List<AnswerNotResolvedProtocol> getAnswersNotResolved();
    }

    interface IGetAnswerById
    {
        List<AnswerNotResolvedProtocol> getAnswerById(string id);
    }

    //internal interface IGetCrm
    //{
    //    List<AnswerModel> getCrm(string idSale, string idCompany);
    //}

}
