using project.data.usecases.client;
using project.data.usecases.sales;
using project.models;
using project.presentation.errors;
using project.presentation.forms.main;
using project.presentation.forms.searchClient;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace project.presentation.forms.searchSale
{
    public partial class SearchSaleForm : Form
    {
        static GetSales getSales = new GetSales();
        static GetClient getClients = new GetClient();
        MainForm mainForm;


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
            var sales = getSales.execute(filters);
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
            return new GetClient().execute(id);
        }
        void loadGrid()
        {
            try
            {
                SalesFilters filters = new SalesFilters()
                {
                    idCompany = tbxIdCompany.Text,
                    idClient = tbxClientId.Text,
                    initialDate = tbxDti.Value,
                    finalDate = tbxDtf.Value,
                    posSale = cbxTypeCrm.Text
                };

                renderSalesOnGrid(dgvSales, filters);
                lblNumberSales.Text = "Pedidos encontrados: " + dgvSales.RowCount;
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }
        void formatClientId()
        {
            tbxClientId.Text = tbxClientId.Text.PadLeft(5, '0');
        }
        void cleanClientId()
        {
            tbxClientId.Text = tbxClientName.Text = null;
        }
        public SearchSaleForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SearchSale_Load(object sender, EventArgs e)
        {
            try
            {
                string defaultCompany = Properties.Settings.Default.defaultCompany;
                if (!string.IsNullOrWhiteSpace(defaultCompany))
                {
                    tbxIdCompany.Text = defaultCompany;
                }

                loadGrid();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                loadGrid();

                if (dgvSales.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro foi encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void tbxClientId_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (DefaultButtonOpenForms.handle(e))
                {
                    SearchClientForm clientForm = new SearchClientForm(this);
                    clientForm.ShowDialog();
                }
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void tbxClientId_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxClientId.Text))
                {
                    tbxClientName.Text = "";
                    return;
                };

                formatClientId();
                var client = getClient(tbxClientId.Text);

                if (client == null)
                {
                    cleanClientId();
                    MessageBox.Show("Cliente não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                tbxClientName.Text = client.name;
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvSales.RowCount == 0) return;
                mainForm.TbxClientName.Text = dgvSales.CurrentRow.Cells["client"].Value.ToString();
                mainForm.TbxIdCompany.Text = dgvSales.CurrentRow.Cells["idCompany"].Value.ToString();
                mainForm.tbxPosSale.Text = dgvSales.CurrentRow.Cells["posSale"].Value.ToString();
                mainForm.TbxIdSale.Text = dgvSales.CurrentRow.Cells["id"].Value.ToString();

                Close();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void dgvPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    btnInsert_Click(sender, e);
                }
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void SearchSaleForm_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (dgvSales.RowCount > 0 && dgvSales.Focused == false)
                {
                    if (e.KeyCode == Keys.Up)
                    {
                        int i = dgvSales.CurrentRow.Index - 1;
                        dgvSales.CurrentCell = dgvSales.Rows[i].Cells[0];
                    }
                    else if (e.KeyCode == Keys.Down)
                    {
                        int i = dgvSales.CurrentRow.Index + 1;
                        dgvSales.CurrentCell = dgvSales.Rows[i].Cells[0];
                    }
                }
            }
            catch
            {
            }
        }
    }
}
