using project.data.client;
using project.domain.model;
using project.domain.usecases;
using project.specs.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.mock.repository
{
    internal class ClientDbMockRepository : IGetClients
    {
        public List<ClientModel> getClients(string fieldFilter, string valueFilter)
        {
            return ClientMock.clients.Where(client => client.acessByProp(fieldFilter).ToString().Contains(valueFilter)).ToList();
        }
    }
}
