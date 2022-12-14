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
        public List<SaleModel> getSales(DateTime initial, DateTime final, string module)
        {
            return SalesMock.sales.Where(sale =>
            {
                if (string.IsNullOrWhiteSpace(module))
                {
                    return sale.dateSale >= initial && sale.dateSale <= final;
                }
                else
                {
                    return sale.posSale == module;
                }
            }).ToList();
        }
    }
}
