using project.business.usecases.client;
using project.data.usecases.client;
using project.infra.db.firebird.repository;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories.business
{
    public class ClientFactory
    {
        // private static ClientMockRepository ClientsRepository =
        //new ClientMockRepository();
        private static ClientFirebirdRepository clientsRepository = new ClientFirebirdRepository();
        private static ClientData<ClientFirebirdRepository> ClientsData =
            new ClientData<ClientFirebirdRepository>(clientsRepository);


        public static ClientBusiness<ClientData<ClientFirebirdRepository>> handle =
            new ClientBusiness<ClientData<ClientFirebirdRepository>>(ClientsData);
    }
}
