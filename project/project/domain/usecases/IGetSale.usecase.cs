using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    public interface IGetSale
    {
        SaleModel getSale(string idCompany, string idSale);
    }

    public interface IGetSales
    {
        List<SaleModel> getSales(SalesFilters filters);
    }
}
