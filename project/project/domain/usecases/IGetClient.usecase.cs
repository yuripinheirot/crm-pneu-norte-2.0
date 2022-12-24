using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    public interface IGetClient
    {
        ClientModel getClient(string id);
    }

    public interface IGetClients
    {
        List<ClientModel> getClients(string fieldFilter, string valueFilter);
    }

    public interface IGetClientsAndSalesByAnswerAndQuestion
    {
        List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(string idQuestion, string answer);
    }
}
