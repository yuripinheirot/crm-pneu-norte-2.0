using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.sales
{
    internal class SalesData : IGetSales, IGetSale
    {
        SalesRepository salesRepository;

        public SalesData(SalesRepository salesRepository)
        {
            this.salesRepository = salesRepository;
        }

        public SaleModel getSale(string idCompany, string idSale)
        {
            return salesRepository.getSale(idCompany, idSale);
        }

        public List<SaleModel> getSales(GetSalesDTO filters)
        {
            filters.initialDate = new DateTime(filters.initialDate.Year, filters.initialDate.Month, filters.initialDate.Day, 0, 0, 0);
            filters.finalDate = new DateTime(filters.finalDate.Year, filters.finalDate.Month, filters.finalDate.Day, 0, 0, 0);

            return salesRepository.getSales(filters);
        }
    }
}
