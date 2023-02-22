using project.business.usecases.client;
using project.data.usecases.client;
using project.infra.db.firebird.repository;

namespace project.main.factories.business
{
    public class ClientFactory
    {
        private static ClientFirebirdRepository clientsRepository = new ClientFirebirdRepository();
        private static ClientData<ClientFirebirdRepository> ClientsData =
            new ClientData<ClientFirebirdRepository>(clientsRepository);


        public static ClientBusiness<ClientData<ClientFirebirdRepository>> handle =
            new ClientBusiness<ClientData<ClientFirebirdRepository>>(ClientsData);
    }
}
