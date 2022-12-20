using project.domain.model;
using project.domain.usecases;
using project.presentation.protocols;
using project.specs.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.mock.repository
{
    internal class SalesRepository : IGetSales, IGetSale
    {
        public SaleModel getSale(string idCompany, string idSale)
        {
            return SalesMock.sales.Where(s => s.id == idSale && s.idCompany == idCompany).FirstOrDefault();
        }

        public List<SaleModel> getSales(SalesFilters filters)
        {
            return SalesMock.sales.Where(sale =>
            {
                return (sale.dateSale >= filters.initialDate) &&
                (sale.dateSale <= filters.finalDate) &&
                (!string.IsNullOrWhiteSpace(filters.idClient) ? sale.client.Split('-')[0] == filters.idClient : true) &&
                (!string.IsNullOrWhiteSpace(filters.posSale) ? sale.posSale == filters.posSale : true) &&
                (!string.IsNullOrWhiteSpace(filters.idCompany) ? sale.idCompany == filters.idCompany : true);
            }).ToList();
        }
    }
}
