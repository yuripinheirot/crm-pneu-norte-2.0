using project.domain.model.entities;
using project.presentation.errors;
using project.presentation.protocols;
using System;
using System.Windows.Forms;

namespace project.presentation.forms.questionnaireAnalysis
{
    public partial class QuestionnaireAnalysisForm : Form
    {
        QuestionnaireAnalysisFunctions functions = new QuestionnaireAnalysisFunctions();
        public QuestionnaireAnalysisForm()
        {
            InitializeComponent();
        }

        private void QuestionnaireAnalysisForm_Load(object sender, EventArgs e)
        {
            try
            {
                cbxPosSale.SelectedIndex = 0;
                string defaultCompany = Properties.Settings.Default.defaultCompany;
                if (!string.IsNullOrWhiteSpace(defaultCompany))
                {
                    tbxIdCompany.Text = defaultCompany;
                }
                functions.loadQuestionsOnComboBox(cbxQuestions, cbxPosSale.Text);
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void cbxPosSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                functions.loadQuestionsOnComboBox(cbxQuestions, cbxPosSale.Text);
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedItem = (QuestionModel)cbxQuestions.SelectedItem;
                var filters = new AnswersFilters()
                {
                    idQuestion = selectedItem.id,
                    finalDate = tbxDtf.Value,
                    initialDate = tbxDti.Value,
                    idCompany = tbxIdCompany.Text,
                };

                functions.loadAnswersOnDataGrid(dgvAnswers, filters);

                if (dgvAnswers.Rows.Count == 0)
                {
                    MessageBox.Show("Nenhum registro foi encontrado.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void dgvAnswers_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                AnswersFilters filters = new AnswersFilters()
                {
                    answer = dgvAnswers.CurrentRow.Cells["answer"].Value.ToString(),
                    idCompany = tbxIdCompany.Text,
                    idQuestion = ((QuestionModel)cbxQuestions.SelectedItem).id,
                    initialDate = tbxDti.Value,
                    finalDate = tbxDtf.Value
                };

                functions.loadClientsByAnswerOnDataGrid(dgvAnalysis, filters);
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void dgvAnswers_DataSourceChanged(object sender, EventArgs e)
        {
            //TODO: Fix it
            //if (dgvAnswers.RowCount == 0)
            //{
            //    dgvAnalysis.DataSource = false;
            //}
        }

        private void tbxIdCompany_Leave(object sender, EventArgs e)
        {
            try
            {
                tbxIdCompany.Text = tbxIdCompany.Text.PadLeft(2, '0');
            }
            catch (Exception err)
            {
                ThrowCustomException.Throw(err);
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {

        }
    }
}
