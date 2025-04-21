using project.data.usecases.answers;
using project.models;
using project.presentation.errors;
using project.presentation.forms.crmNotResolved;
using project.presentation.forms.dobList;
using project.presentation.forms.questionnaireAnalysis;
using project.presentation.forms.searchSale;
using project.presentation.protocols;
using project.presentation.reports.doblist;
using project.presentation.reports.questionnaireAnalysis;
using project.presentation.reports.questionnaireAnalysisGraphic;
using project.presentation.utils;
using project.validations.crm;
using System;
using System.Linq;
using System.Windows.Forms;

namespace project.presentation.forms.main
{
    public partial class MainForm : Form
    {
        readonly MainFunctions functions = new MainFunctions();
        readonly string defaultCompany = Properties.Settings.Default.defaultCompany;
        
        VerifyIfExistsCurrentCrmValidation verifyIfExistsCurrentCrmValidation = new VerifyIfExistsCurrentCrmValidation(new GetAnswers());

        public MainForm()
        {
            InitializeComponent();
        }

        void clearScreen()
        {
            tbxPosSale.Text = TbxClientName.Text = TbxIdSale.Text = "";
            if (string.IsNullOrWhiteSpace(defaultCompany)) TbxIdCompany.Text = "";
            flpQuestions.Controls.OfType<ComboBox>().ToList().ForEach(c => c.SelectedIndex = 0);
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
            try
            {
                if (!string.IsNullOrWhiteSpace(defaultCompany))
                {
                    TbxIdCompany.Text = defaultCompany;
                }
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void TbxIdSale_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (DefaultButtonOpenForms.handle(e))
                {
                    new SearchSaleForm(this).ShowDialog();
                }
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void analiseDeRespostasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new QuestionnaireAnalysisReportForm().ShowDialog();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void LoadInfoSalesOnFields(SaleModel sale)
        {
            tbxPosSale.Text = TextUtils.translatePosSalePresentation(sale.posSale);
            TbxClientName.Text = sale.client;
            TbxIdCompany.Text = sale.idCompany;
        }

        private void tbxFillZeros(TextBox tbx, int length)
        {
            tbx.Text = tbx.Text.PadLeft(length, '0');
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

                string idCompany = TbxIdCompany.Text;
                tbxFillZeros(TbxIdSale, 7);
                string idSale = TbxIdSale.Text;

                if (functions.crmAlreadyExists(idCompany, idSale))
                {
                    MessageBox.Show("Já existe um crm registrado para este pedido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    TbxIdSale.Text = null;
                    return;
                }

                var sale = functions.getSale(TbxIdCompany.Text, TbxIdSale.Text);

                if (sale == null)
                {
                    MessageBox.Show("Pedido de venda não encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    clearScreen();
                    return;
                }

                var filters = new AnswersFilters() { idCompany = TbxIdCompany.Text, idSale = TbxIdSale.Text };
                verifyIfExistsCurrentCrmValidation.validate(filters, clearScreen);

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

        private void crmNotResolvedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new CrmNotResolved().ShowDialog();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void TbxIdCompany_Leave(object sender, EventArgs e)
        {
            try
            {
                tbxFillZeros(TbxIdCompany, 2);
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void analiseDeQuestionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new QuestionnaireAnalysisForm().ShowDialog();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void análiseDeQuestionáriográficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new QuestionnaireAnalysisGraphicReportForm().ShowDialog();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void aniversariantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new DobListForm().ShowDialog();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void listaDeAniversariantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                new DobListReportForm().ShowDialog();
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }
    }
}
