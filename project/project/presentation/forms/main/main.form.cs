using project.domain.model;
using project.presentation.errors;
using project.presentation.forms.questionnaireAnalysis;
using project.presentation.forms.searchSale;
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

namespace project.presentation.forms.main
{
    public partial class MainForm : Form
    {
        readonly MainFunctions functions = new MainFunctions();
        public MainForm()
        {
            InitializeComponent();
        }

        void clearScreen()
        {
            tbxPosSale.Text = TbxClientName.Text = TbxIdCompany.Text = TbxIdSale.Text = "";
            flpQuestions.Controls.Clear();
            BtnSave.Enabled = false;
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                functions.saveCrm(this);
                MessageBox.Show("CRM cadastrado com sucesso!", "Info!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TbxIdCompany.Focus();
                clearScreen();
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void TbxIdSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F2)
            {
                SearchSaleForm searchSale = new SearchSaleForm(this);
                searchSale.ShowDialog();
            }
        }

        private void analiseDeRespostasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            QuestionnaireAnalysisForm questionnaire = new QuestionnaireAnalysisForm();
            questionnaire.ShowDialog();
        }

        private void TbxIdSale_Leave(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(TbxIdSale.Text))
                {
                    clearScreen();
                    return;
                }

                TbxIdSale.Text = TbxIdSale.Text.PadLeft(7, '0');

                var sale = functions.getSale(TbxIdCompany.Text, TbxIdSale.Text);

                if (sale == null)
                {
                    MessageBox.Show("Pedido de venda não encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearScreen();
                    return;
                }

                tbxPosSale.Text = TextUtils.translatePosSalePresentation(sale.posSale);
                TbxClientName.Text = sale.client;
                TbxIdCompany.Text = sale.idCompany;

                functions.renderQuestions(flpQuestions, tbxPosSale.Text);
                flpQuestions.Focus();
                BtnSave.Enabled = true;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
