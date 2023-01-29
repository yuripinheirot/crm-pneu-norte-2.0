using project.data.usecases.sales;
using project.domain.interfaces;
using project.domain.interfaces.Struct;
using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.usecases.sales
{
    public class SalesBusiness<SalesData> : ISalesBusiness
        where SalesData : ISalesData
    {
        SalesData salesData;
        public SalesBusiness(SalesData salesData)
        {
            this.salesData = salesData;
        }

        public SaleModel getSale(string idCompany, string idSale)
        {
            return salesData.getSale(idCompany, idSale);
        }

        public List<SaleModel> getSales(SalesFilters filters)
        {
            return salesData.getSales(filters);
        }
    }
}
