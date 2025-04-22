using project.data.usecases.sales;
using project.models;
using project.presentation.errors;
using project.presentation.forms.main;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.crmPending
{

    public partial class CrmPending : Form
    {
        GetSalesWithoutCrm getSalesWithoutCrm = new GetSalesWithoutCrm();
        MainForm form;

        public CrmPending(MainForm form)
        {
            this.form = form;
            InitializeComponent();
        }

        private List<SaleModelGrid> getSales(SalesFilters filters)
        {
            List<SaleModel> sales = getSalesWithoutCrm.execute(filters);

            var salesFormatted = sales.Select(s => new SaleModelGrid(s)).ToList();

            return salesFormatted;
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

            List<SaleModelGrid> salesFormatted = getSales(filters);

            dgvCrmsPendentes.DataSource = GridUtils.ToDataTable(salesFormatted);


            if (salesFormatted.Count == 0)
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

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            form.TbxIdCompany.Text = dgvCrmsPendentes.Rows[dgvCrmsPendentes.CurrentRow.Index].Cells["EMPRESA"].Value.ToString();
            form.TbxIdSale.Text = dgvCrmsPendentes.Rows[dgvCrmsPendentes.CurrentRow.Index].Cells["PEDIDO"].Value.ToString();

            form.TbxIdSale_Leave(form.TbxIdSale, EventArgs.Empty);
            form.TbxIdSale.Focus();

            Close();
        }
    }

    public class SaleModelGrid
    {
        public SaleModelGrid(SaleModel sale)
        {
            id = sale.id;
            idCompany = sale.idCompany;
            liquidValue = Convert.ToDecimal(sale.liquidValue).ToString("N");
            dateSale = Convert.ToDateTime(sale.dateSale).ToShortDateString();
            client = sale.client;
            clientCpfCnpj = sale.clientCpfCnpj;
            posSale = sale.posSale;
            seller = sale.seller;
        }

        public string id { get; set; }
        public string idCompany { get; set; }
        public string liquidValue { get; set; }
        public string dateSale { get; set; }
        public string client { get; set; }
        public string clientCpfCnpj { get; set; }
        public string posSale { get; set; }
        public string seller { get; set; }
    }
}
