using project.business.usecases.client;
using project.data.usecases.client;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories.business
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
