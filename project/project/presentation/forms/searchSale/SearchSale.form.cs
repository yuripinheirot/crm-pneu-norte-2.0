using project.presentation.errors;
using project.presentation.forms.main;
using project.presentation.forms.searchClient;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.searchSale
{
    public partial class SearchSaleForm : Form
    {
        SearchSalesFunctions functions = new SearchSalesFunctions();
        MainForm mainForm;
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

                functions.renderSalesOnGrid(dgvSales, filters);
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
            string defaultCompany = Properties.Settings.Default.defaultCompany;
            if (!string.IsNullOrWhiteSpace(defaultCompany))
            {
                tbxIdCompany.Text = defaultCompany;
            }

            loadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadGrid();

            if (dgvSales.Rows.Count == 0)
            {
                MessageBox.Show("Nenhum registro foi encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void tbxClientId_KeyDown(object sender, KeyEventArgs e)
        {
            if (DefaultButtonOpenForms.handle(e))
            {
                SearchClientForm clientForm = new SearchClientForm(this);
                clientForm.ShowDialog();
            }
        }

        private void tbxClientId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxClientId.Text))
            {
                tbxClientName.Text = "";
                return;
            };

            formatClientId();
            var client = functions.getClient(tbxClientId.Text);

            if (client == null)
            {
                cleanClientId();
                MessageBox.Show("Cliente não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            tbxClientName.Text = client.name;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (dgvSales.RowCount == 0) return;
            mainForm.TbxClientName.Text = dgvSales.CurrentRow.Cells["client"].Value.ToString();
            mainForm.TbxIdCompany.Text = dgvSales.CurrentRow.Cells["idCompany"].Value.ToString();
            mainForm.tbxPosSale.Text = dgvSales.CurrentRow.Cells["posSale"].Value.ToString();
            mainForm.TbxIdSale.Text = dgvSales.CurrentRow.Cells["id"].Value.ToString();

            Close();
        }

        private void dgvPedidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnInsert_Click(sender, e);
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
