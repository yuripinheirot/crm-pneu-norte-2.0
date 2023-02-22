using project.domain.model.entities;
using project.presentation.protocols;
using System.Collections.Generic;

namespace project.domain.interfaces.usecases
{

    public interface IGetSales
    {
        List<SaleModel> getSales(SalesFilters filters);
    }
}
