using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.presentation.protocols;
using System.Collections.Generic;
using project.data.usecases.client;

namespace project.business.usecases.client
{
    public class ClientBusiness : IClientBusiness
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

        public List<ClientModel> getClients(string fieldFilter = null, string valueFilter = null)
        {
            return clientData.getClients(fieldFilter, valueFilter);
        }

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(AnswersFilters filters)
        {
            return clientData.getClientsAndSalesByAnswerAndQuestion(filters);
        }

        public List<DobListReport> getClientsByDob(string startDate, string endDate)
        {
            return clientData.getClientsByDob(startDate, endDate);
        }
    }
}
