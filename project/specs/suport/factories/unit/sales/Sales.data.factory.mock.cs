using Moq;
using project.data.usecases.sales;
using project.domain.interfaces.Struct;
using project.infra.db.firebird.repository;

namespace specs.suport.factories.unit.business
{
    public class SalesDataFactoryMock
    {
        public static Mock<SalesFirebirdRepository> salesRepositoryMock = new Mock<SalesFirebirdRepository>();
        public static SalesData<ISalesRepository> salesData = new SalesData<ISalesRepository>(salesRepositoryMock.Object);
    }
}
