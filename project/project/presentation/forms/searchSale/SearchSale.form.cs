using project.presentation.forms.main;
using project.presentation.forms.searchClient;
using project.presentation.protocols;
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
                GetSalesDTO filters = new GetSalesDTO()
                {
                    idCompany = tbxIdCompany.Text,
                    idClient = tbxClientId.Text,
                    initialDate = tbxDti.Value,
                    finalDate = tbxDtf.Value,
                    posSale = cbxTypeCrm.Text
                };

                functions.renderSalesOnGrid(dgvSales, filters);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SearchSaleForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SearchSale_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void tbxClientId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SearchClientForm clientForm = new SearchClientForm(this);
                clientForm.ShowDialog();
            }
        }

        private void tbxClientId_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxClientId.Text)) return;

            tbxClientId.Text = tbxClientId.Text.PadLeft(5, '0');
            var client = functions.getClient(tbxClientId.Text);

            if (client == null)
            {
                tbxClientId.Text = tbxClientName.Text = null;
                MessageBox.Show("Cliente não encontrado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            tbxClientName.Text = client.name;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            mainForm.TbxClientName.Text = dgvSales.CurrentRow.Cells["client"].Value.ToString();
            mainForm.TbxCompany.Text = dgvSales.CurrentRow.Cells["idCompany"].Value.ToString();
            mainForm.TbxModule.Text = dgvSales.CurrentRow.Cells["posSale"].Value.ToString();
            mainForm.TbxIdSale.Text = dgvSales.CurrentRow.Cells["idSale"].Value.ToString();

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
            if (dgvSales.Focused == false || cbxTypeCrm.Focused == false)
            {
                try
                {
                    if (dgvSales.Focused == false)
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
}
