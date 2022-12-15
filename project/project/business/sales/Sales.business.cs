using project.data.sales;
using project.domain.model;
using project.domain.usecases;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.sales
{
    internal class SalesBusiness : IGetSales
    {
        SalesData salesData;
        public SalesBusiness(SalesData salesData)
        {
            this.salesData = salesData;
        }
        public List<SaleModel> getSales(GetSalesDTO filters)
        {
            filters.posSale = String.IsNullOrWhiteSpace(filters.posSale) ? "" : filters.posSale == "VENDAS" ? "sale" : "order";
            return salesData.getSales(filters);
        }
    }
}
