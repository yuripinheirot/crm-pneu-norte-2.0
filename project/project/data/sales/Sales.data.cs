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
            return salesRepository.getSales(initial, final);
        }
    }
}
