using project.data.usecases.client;
using project.presentation.errors;
using project.presentation.forms.searchSale;
using project.presentation.utils;
using System;
using System.Windows.Forms;

namespace project.presentation.forms.searchClient
{
    public partial class SearchClientForm : Form
    {
        SearchSaleForm searchSaleForm;
        GetClients getClients = new GetClients();

        string convertClientSearchBy(string searchBy)
        {
            switch (searchBy)
            {
                case "RAZÃO":
                    return "name";
                case "FANTASIA":
                    return "nameFantasy";
                case "CPF/CNPJ":
                    return "cpfCnpj";
                case "FONE":
                    return "phone";
                default:
                    throw new Exception("Unexpected searchBy client");
            }
        }

        public void renderClientsOnGrid(DataGridView dgv, string fieldFilter, string filterValue)
        {
            var clients = getClients.execute(convertClientSearchBy(fieldFilter), filterValue);
            var dataSource = GridUtils.ToDataTable(clients);

            dgv.DataSource = dataSource;
        }

        void loadGrid()
        {
            renderClientsOnGrid(dgvClients, cbxSearchBy.Text, tbxValueFilter.Text);
        }
        public SearchClientForm(SearchSaleForm searchSaleForm)
        {
            InitializeComponent();
            this.searchSaleForm = searchSaleForm;
        }



        private void SearchClientForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbxSearchBy.SelectedIndex = 0;
                loadGrid();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void tbxValueFilter_TextChanged(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
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
                if (dgvClients.RowCount > 0)
                {
                    searchSaleForm.tbxClientId.Text = dgvClients.CurrentRow.Cells["id"].Value.ToString();
                    searchSaleForm.tbxClientName.Text = dgvClients.CurrentRow.Cells["name"].Value.ToString();

                    Close();
                }
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void SearchClientForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvClients.Focused == false)
            {
                try
                {
                    if (dgvClients.Focused == false)
                    {
                        if (e.KeyCode == Keys.Up)
                        {
                            int i = dgvClients.CurrentRow.Index - 1;
                            dgvClients.CurrentCell = dgvClients.Rows[i].Cells[0];
                        }
                        else if (e.KeyCode == Keys.Down)
                        {
                            int i = dgvClients.CurrentRow.Index + 1;
                            dgvClients.CurrentCell = dgvClients.Rows[i].Cells[0];
                        }
                    }
                }
                catch
                {
                }
            }
        }

        private void cbxSearchBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                loadGrid();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }
    }
}
