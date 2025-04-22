using project.data.usecases.sales;
using project.presentation.errors;
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

namespace project.presentation.forms.crmPending
{
    public partial class CrmPending : Form
    {
        GetSalesWithoutCrm getSalesWithoutCrm = new GetSalesWithoutCrm();
        public CrmPending()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var filters = new SalesFilters()
            {
                initialDate = tbxDti.Value,
                finalDate = tbxDtf.Value
            };

            if (!String.IsNullOrEmpty(tbxIdCompany.Text))
            {
                filters.idCompany = tbxIdCompany.Text;
            }

            var sales = getSalesWithoutCrm.execute(filters);
            dgvCrmsPendentes.DataSource = GridUtils.ToDataTable(sales);

            if (sales.Count == 0)
            {
                MessageBox.Show("Nenhum CRM pendente encontrado!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tbxIdCompany_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxIdCompany.Text))
            {
                tbxIdCompany.Text = tbxIdCompany.Text.PadLeft(2, '0');
            }
        }
    }
}
