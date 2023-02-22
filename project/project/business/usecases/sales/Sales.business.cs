using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.presentation.protocols;
using System.Collections.Generic;

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
