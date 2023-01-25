using project.domain.model;
using project.presentation.errors;
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
            cbxPosSale.SelectedIndex = 0;
            string defaultCompany = Properties.Settings.Default.defaultCompany;
            if (!string.IsNullOrWhiteSpace(defaultCompany))
            {
                tbxIdCompany.Text = defaultCompany;
            }
            functions.loadQuestionsOnComboBox(cbxQuestions, cbxPosSale.Text);
        }

        private void cbxPosSale_SelectedIndexChanged(object sender, EventArgs e)
        {
            functions.loadQuestionsOnComboBox(cbxQuestions, cbxPosSale.Text);
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
                var selectedItem = (QuestionModel)cbxQuestions.SelectedItem;
                string idQuestion = selectedItem.id;
                string answer = dgvAnswers.CurrentRow.Cells["answer"].Value.ToString();
                string idCompany = tbxIdCompany.Text;

                functions.loadClientsByAnswerOnDataGrid(dgvAnalysis, idQuestion, answer, idCompany);
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
    }
}
