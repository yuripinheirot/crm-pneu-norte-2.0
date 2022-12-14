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
        public SearchClientForm(searchSale.SearchSaleForm searchSaleForm)
        {
            InitializeComponent();
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
    }
}
