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
        public SearchSale(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void SearchSale_Load(object sender, EventArgs e)
        {
            functions.renderSalesOnGrid(dgvPedidos, new DateTime(2000, 1, 1), new DateTime(2050, 1, 1));
        }
    }
}
