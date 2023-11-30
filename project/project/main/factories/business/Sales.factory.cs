using project.business.usecases.sales;
using project.data.usecases.sales;
using project.infra.db.firebird.repository;

namespace project.main.factories.business
{
    public class SalesFactory
    {
        private static SalesFirebirdRepository salesFirebirdRepository = new SalesFirebirdRepository();
        private static SalesData salesData = new SalesData(salesFirebirdRepository);

        public static SalesBusiness handle = new SalesBusiness(salesData);

    }
}
