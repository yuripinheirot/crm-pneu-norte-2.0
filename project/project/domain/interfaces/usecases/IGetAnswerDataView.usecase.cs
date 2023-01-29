using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces.usecases
{
    public interface IGetAnswerDataView
    {
        List<AnswerNotResolvedDataView> getAnswerDataView(string idCompany, string idSale);
    }
}
