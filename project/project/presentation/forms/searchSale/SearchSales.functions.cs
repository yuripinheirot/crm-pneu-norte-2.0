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
        private void convertNamePosSale(DataTable sales)
        {
            foreach (DataRow row in sales.Rows)
            {
                if (row["posSale"].ToString() == "order")
                {
                    row["posSale"] = "SERVIÇOS";
                }
                else if (row["posSale"].ToString() == "sale")
                {
                    row["posSale"] = "VENDAS";
                }
            }
        }
        public void renderSalesOnGrid(DataGridView grid, DateTime initial, DateTime final, string module)
        {
            var sales = SalesFactory.handle.getSales(initial, final, module);
            var dataSource = GridUtils.ToDataTable(sales);
            convertNamePosSale(dataSource);

            grid.DataSource = dataSource;
        }
    }
}
