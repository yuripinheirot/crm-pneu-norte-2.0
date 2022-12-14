using project.data.usecases.client;
using project.domain.model;
using project.domain.usecases;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.usecases.client
{
    public class ClientBusiness : IGetClients, IGetClient, IGetClientsAndSalesByAnswerAndQuestion
    {
        ClientData clientData;
        public ClientBusiness(ClientData clientData)
        {
            this.clientData = clientData;
        }

        public ClientModel getClient(string id)
        {
            return clientData.getClient(id);
        }

        public List<ClientModel> getClients(string fieldFilter, string valueFilter)
        {
            return clientData.getClients(fieldFilter, valueFilter);
        }

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(string idQuestion, string answer)
        {
            return clientData.getClientsAndSalesByAnswerAndQuestion(idQuestion, answer);
        }
    }
}
