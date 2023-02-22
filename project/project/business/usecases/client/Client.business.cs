using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.presentation.protocols;
using System.Collections.Generic;

namespace project.business.usecases.client
{
    public class ClientBusiness<ClientData> : IClientBusiness
        where ClientData : IClientData
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

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(AnswersFilters filters)
        {
            return clientData.getClientsAndSalesByAnswerAndQuestion(filters);
        }
    }
}
