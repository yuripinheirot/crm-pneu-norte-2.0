using project.business.client;
using project.data.client;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories
{
    internal class ClientFactory
    {
        private static ClientDbMockRepository ClientsRepository =
       new ClientDbMockRepository();
        private static ClientData ClientsData =
            new ClientData(ClientsRepository);


        public static ClientBusiness handle =
            new ClientBusiness(ClientsData);
    }
}
