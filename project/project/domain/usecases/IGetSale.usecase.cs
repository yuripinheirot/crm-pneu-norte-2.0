using project.domain.model;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    internal interface IGetSale
    {
        SaleModel getSale(string idCompany, string idSale);
    }

    internal interface IGetSales
    {
        List<SaleModel> getSales(GetSalesDTO filters);
    }
}
