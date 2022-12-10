using project.domain.model;
using project.domain.usecases;
using project.specs.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.mock.repository
{
    internal class SalesRepository : IGetSales
    {
        public List<Sale> getSales(DateTime initial, DateTime final)
        {
            return SalesMock.sales.Where(sale => sale.dateSale >= initial && sale.dateSale <= final).ToList();
        }
    }
}
