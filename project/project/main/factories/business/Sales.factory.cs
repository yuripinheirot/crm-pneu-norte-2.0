using project.business.usecases.sales;
using project.data.usecases.sales;
using project.infra.db.firebird.repository;

namespace project.main.factories.business
{
    public class SalesFactory
    {
        private static SalesFirebirdRepository salesFirebirdRepository = new SalesFirebirdRepository();
        private static SalesData<SalesFirebirdRepository> salesData = new SalesData<SalesFirebirdRepository>(salesFirebirdRepository);

        public static SalesBusiness<SalesData<SalesFirebirdRepository>> handle = new SalesBusiness<SalesData<SalesFirebirdRepository>>(salesData);

    }
}
