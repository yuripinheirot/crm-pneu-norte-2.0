using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    public interface IGetAnswers
    {
        List<AnswerModel> getAnswers(AnswersFilters filters);
    }

    public interface IGetAnswersNotResolved
    {
        List<AnswerNotResolvedDataView> getAnswersNotResolved();
    }

    public interface IGetAnswerDataView
    {
        List<AnswerNotResolvedDataView> getAnswerDataView(string idCompany, string idSale);
    }

    public interface IGetAnswerDetails
    {
        AnswerDetails getAnswerDetailsDataView(string idAnswer);
    }

}
