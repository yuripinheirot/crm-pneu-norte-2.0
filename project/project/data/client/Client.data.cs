using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.client
{
    internal class ClientData : IGetClients, IGetClient
    {
        ClientDbMockRepository clientRepository;

        public ClientData(ClientDbMockRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public ClientModel getClient(string id)
        {
            return clientRepository.getClient(id);
        }

        public List<ClientModel> getClients(string fieldFilter, string valueFilter)
        {
            return clientRepository.getClients(fieldFilter, valueFilter);
        }
    }
}
