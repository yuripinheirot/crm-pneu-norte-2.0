using project.domain.model.entities;
using project.main.factories.business;
using project.presentation.protocols;
using project.presentation.utils;
using System.Data;
using System.Windows.Forms;

namespace project.presentation.forms.searchSale
{
    internal class SearchSalesFunctions
    {
        private void convertNamePosSale(DataTable sales)
        {
            foreach (DataRow row in sales.Rows)
            {
                if (row["posSale"].ToString().Trim() == "order")
                {
                    row["posSale"] = "SERVIÇOS";
                }
                else if (row["posSale"].ToString().Trim() == "sale")
                {
                    row["posSale"] = "VENDAS";
                }
            }
        }
        public void renderSalesOnGrid(DataGridView grid, SalesFilters filters)
        {
            var sales = SalesFactory.handle.getSales(filters);
            var dataSource = GridUtils.ToDataTable(sales);
            convertNamePosSale(dataSource);

            if (!string.IsNullOrWhiteSpace(filters.posSale))
            {
                dataSource.DefaultView.RowFilter = $"posSale = '{TextUtils.translatePosSalePresentation(filters.posSale)}'";
            }
            else
            {
                dataSource.DefaultView.RowFilter = null;
            }

            grid.DataSource = dataSource;
        }

        public ClientModel getClient(string id)
        {
            return ClientFactory.handle.getClient(id);
        }
    }
}
