using project.business.usecases.sales;
using project.data.usecases.sales;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.main.factories.business
{
    internal class SalesFactory
    {
        private static SalesRepository SalesRepository = new SalesRepository();
        private static SalesData SalesData = new SalesData(SalesRepository);

        public static SalesBusiness handle = new SalesBusiness(SalesData);
    }
}
