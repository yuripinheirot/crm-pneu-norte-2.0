using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    internal interface IGetClient
    {
        ClientModel getClient(string id);
    }

    internal interface IGetClients
    {
        List<ClientModel> getClients(string fieldFilter, string valueFilter);
    }

    internal interface IGetClientsAndSalesByAnswerAndQuestion
    {
        List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(string idQuestion, string answer);
    }
}
