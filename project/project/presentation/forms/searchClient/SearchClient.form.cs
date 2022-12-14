using project.presentation.forms.searchSale;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.searchClient
{
    public partial class SearchClientForm : Form
    {
        SearchSaleForm searchSaleForm;
        SearchClientFunctions functions = new SearchClientFunctions();

        void loadGrid()
        {
            try
            {
                functions.renderClientsOnGrid(dgvClients, cbxSearchBy.Text, tbxValueFilter.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SearchClientForm(SearchSaleForm searchSaleForm)
        {
            InitializeComponent();
            this.searchSaleForm = searchSaleForm;
        }

        private void SearchClientForm_Load(object sender, EventArgs e)
        {
            cbxSearchBy.SelectedIndex = 0;
            loadGrid();
        }

        private void tbxValueFilter_TextChanged(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dgvClients.RowCount > 0)
            {
                searchSaleForm.tbxClientId.Text = dgvClients.CurrentRow.Cells["id"].Value.ToString();
                searchSaleForm.tbxClientName.Text = dgvClients.CurrentRow.Cells["name"].Value.ToString();

                Close();
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
    }
}
