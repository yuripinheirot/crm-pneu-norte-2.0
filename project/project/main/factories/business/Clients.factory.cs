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
    public class ClientFactory
    {
        private static ClientRepository ClientsRepository =
       new ClientRepository();
        private static ClientData ClientsData =
            new ClientData(ClientsRepository);


        public static ClientBusiness handle =
            new ClientBusiness(ClientsData);
    }
}
