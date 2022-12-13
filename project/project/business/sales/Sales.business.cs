using project.data.sales;
using project.domain.model;
using project.domain.usecases;
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
        public List<Sale> getSales(DateTime initial, DateTime final, string module)
        {
            string moduleSerialized = String.IsNullOrWhiteSpace(module) ? "" : module == "VENDAS" ? "sale" : "order";
            return salesData.getSales(initial, final, moduleSerialized);
        }
    }
}
