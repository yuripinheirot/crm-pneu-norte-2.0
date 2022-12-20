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
        List<AnswerModel> getAnswers(AnswersFilters filters);
    }

    interface IGetAnswersNotResolved
    {
        List<AnswerNotResolvedDataView> getAnswersNotResolved();
    }

    interface IGetAnswerById
    {
        List<AnswerNotResolvedDataView> getAnswerById(string id);
    }

}
