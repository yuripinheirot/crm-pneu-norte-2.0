using Moq;
using project.business.usecases.client;
using project.data.usecases.client;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.config;
using project.infra.db.firebird.repository;
using project.infra.db.postgres.config;

namespace specs.suport.factories.unit.business
{
    public class ClientBusinessFactoryMock
    {
        public static Mock<ClientFirebirdRepository> clientRepository = new Mock<ClientFirebirdRepository>(new FbDbContext(), new PgDbContext());
        public static Mock<ClientData<IClientRepository>> clientDataMock = new Mock<ClientData<IClientRepository>>(clientRepository.Object);

        public static ClientBusiness<IClientData> clientBusiness = new ClientBusiness<IClientData>(clientDataMock.Object);
    }
}
