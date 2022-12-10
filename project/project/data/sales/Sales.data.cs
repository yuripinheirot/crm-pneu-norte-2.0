using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.sales
{
    internal class SalesData : IGetSales
    {
        SalesRepository salesRepository;

        public SalesData(SalesRepository salesRepository)
        {
            this.salesRepository = salesRepository;
        }
        public List<Sale> getSales(DateTime initial, DateTime final)
        {
            DateTime initialZero = new DateTime(initial.Year, initial.Month, initial.Day, 0, 0, 0);
            DateTime finalZero = new DateTime(final.Year, final.Month, final.Day, 0, 0, 0);

            return salesRepository.getSales(initialZero, finalZero);
        }
    }
}
