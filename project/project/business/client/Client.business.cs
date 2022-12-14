using project.data.client;
using project.domain.model;
using project.domain.usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.client
{
    internal class ClientBusiness : IGetClients, IGetClient
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
    }
}
