using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using project.infra.db.firebird.repository;

namespace project.data.usecases.sales
{
    public class SalesData : ISalesData
    {
        private SalesFirebirdRepository salesRepository;

        public SalesData(SalesFirebirdRepository salesRepository)
        {
            this.salesRepository = salesRepository;
        }

        public virtual SaleModel getSale(string idCompany, string idSale)
        {
            return salesRepository.getSale(idCompany, idSale);
        }

        public virtual List<SaleModel> getSales(SalesFilters filters)
        {
            filters.initialDate = new DateTime(filters.initialDate.Year, filters.initialDate.Month, filters.initialDate.Day, 0, 0, 0);
            filters.finalDate = new DateTime(filters.finalDate.Year, filters.finalDate.Month, filters.finalDate.Day, 23, 59, 59);
            filters.posSale = string.IsNullOrWhiteSpace(filters.posSale) ? "" : TextUtils.translatePosSaleData(filters.posSale);

            return salesRepository.getSales(filters);
        }
    }
}
