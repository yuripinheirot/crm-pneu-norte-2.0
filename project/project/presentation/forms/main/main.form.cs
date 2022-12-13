using project.domain.model;
using project.presentation.forms.searchSale;
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

namespace project.presentation.forms.main
{
    public partial class MainForm : Form
    {
        readonly MainFunctions functions = new MainFunctions();
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                functions.saveCrm(this);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string module = TbxModule.Text == "SERVIÇOS" ? "order" : "sale";
            functions.renderQuestions(FlpQuestions, module);
        }

        private void TbxIdSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SearchSaleForm searchSale = new SearchSaleForm(this);
                searchSale.ShowDialog();
            }
        }
    }
}
