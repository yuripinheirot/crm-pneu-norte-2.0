using project.domain.model;
using project.main.factories;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.searchSale
{
    internal class SearchSalesFunctions
    {
        private List<Sale> translatePosSale(List<Sale> sales)
        {
            sales.ForEach(s =>
           {
               if (s.posSale == "order")
               {
                   s.posSale = "SERVIÇO";
               }
               else
               {
                   s.posSale = "VENDAS";
               }
           });

            return sales;
        }
        public void renderSalesOnGrid(DataGridView grid, DateTime initial, DateTime final)
        {
            var sales = SalesFactory.handle.getSales(initial, final);
            var salesWithTranslations = translatePosSale(sales);
            var dataSource = GridUtils.ToDataTable(salesWithTranslations);

            grid.DataSource = dataSource;
        }
    }
}
