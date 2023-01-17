using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.sales
{
    public class SalesData : IGetSales, IGetSale
    {
        SalesMockRepository salesRepository;

        public SalesData(SalesMockRepository salesRepository)
        {
            this.salesRepository = salesRepository;
        }

        public SaleModel getSale(string idCompany, string idSale)
        {
            return salesRepository.getSale(idCompany, idSale);
        }

        public List<SaleModel> getSales(SalesFilters filters)
        {
            filters.initialDate = new DateTime(filters.initialDate.Year, filters.initialDate.Month, filters.initialDate.Day, 0, 0, 0);
            filters.finalDate = new DateTime(filters.finalDate.Year, filters.finalDate.Month, filters.finalDate.Day, 23, 59, 59);
            filters.posSale = string.IsNullOrWhiteSpace(filters.posSale) ? "" : TextUtils.translatePosSaleData(filters.posSale);

            return salesRepository.getSales(filters);
        }
    }
}
