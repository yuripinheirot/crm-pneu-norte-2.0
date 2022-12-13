using project.presentation.forms.main;
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
    public partial class SearchSale : Form
    {
        SearchSalesFunctions functions = new SearchSalesFunctions();
        MainForm mainForm;
        void loadGrid()
        {
            try
            {
                functions.renderSalesOnGrid(dgvPedidos, tbxDti.Value, tbxDtf.Value, cbxTypeCrm.Text);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public SearchSale(MainForm mainForm)
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
    }
}
