using project.business.usecases.sales;
using project.data.usecases.sales;
using project.domain.usecases;
using project.infra.db.firebird.repository;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories.business
{
    public class SalesFactory
    {
        //private static SalesMockRepository salesMockRepository = new SalesMockRepository();
        private static SalesFirebirdRepository salesFirebirdRepository = new SalesFirebirdRepository();
        private static SalesData<SalesFirebirdRepository> salesData = new SalesData<SalesFirebirdRepository>(salesFirebirdRepository);

        public static SalesBusiness<SalesData<SalesFirebirdRepository>> handle = new SalesBusiness<SalesData<SalesFirebirdRepository>>(salesData);
    
    }
}
