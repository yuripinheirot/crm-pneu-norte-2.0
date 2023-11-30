using project.business.usecases.client;
using project.data.usecases.client;
using project.infra.db.firebird.config;
using project.infra.db.firebird.repository;
using project.infra.db.postgres.config;

namespace project.main.factories.business
{
    public class ClientFactory
    {
        static PgDbContext postgres = new PgDbContext(Properties.Settings.Default.postgresConnectionString);
        static FbDbContext firebird = new FbDbContext();
        private static ClientFirebirdRepository clientsRepository = new ClientFirebirdRepository(firebird, postgres);
        private static ClientData ClientsData =
            new ClientData(clientsRepository);


        public static ClientBusiness handle =
            new ClientBusiness(ClientsData);
    }
}
