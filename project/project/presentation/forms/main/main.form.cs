using project.domain.model;
using project.main.factories.validations;
using project.presentation.errors;
using project.presentation.forms.questionnaireAnalysis;
using project.presentation.forms.searchSale;
using project.presentation.utils;
using project.validations;
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
        readonly string defaultCompany = Properties.Settings.Default.defaultCompany;

        public MainForm()
        {
            InitializeComponent();
        }

        void clearScreen()
        {
            tbxPosSale.Text = TbxClientName.Text = TbxIdSale.Text = "";
            if (string.IsNullOrWhiteSpace(defaultCompany)) TbxIdCompany.Text = "";
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

            if (!string.IsNullOrWhiteSpace(defaultCompany))
            {
                TbxIdCompany.Text = defaultCompany;
            }
        }

        private void TbxIdSale_KeyDown(object sender, KeyEventArgs e)
        {
            if (DefaultButtonOpenForms.handle(e))
            {
                new SearchSaleForm(this).ShowDialog();
            }
        }

        private void analiseDeRespostasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new QuestionnaireAnalysisForm().ShowDialog();
        }

        private void LoadInfoSalesOnFields(SaleModel sale)
        {
            tbxPosSale.Text = TextUtils.translatePosSalePresentation(sale.posSale);
            TbxClientName.Text = sale.client;
            TbxIdCompany.Text = sale.idCompany;
        }

        private void fillZerosOnIdSale()
        {
            TbxIdSale.Text = TbxIdSale.Text.PadLeft(7, '0');
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

                fillZerosOnIdSale();
                var sale = functions.getSale(TbxIdCompany.Text, TbxIdSale.Text);

                if (sale == null)
                {
                    MessageBox.Show("Pedido de venda não encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearScreen();
                    return;
                }

                VerifyIfExistsCurrentCrmValidationFactory.handle.validate(sale.idCompany, sale.id);

                LoadInfoSalesOnFields(sale);
                functions.renderQuestions(flpQuestions, tbxPosSale.Text);
                flpQuestions.Focus();
                BtnSave.Enabled = true;
            }
            catch (Exception error)
            {
                ThrowCustomException.Throw(error);
            }
        }
    }
}
