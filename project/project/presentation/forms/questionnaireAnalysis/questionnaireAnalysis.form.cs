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
                var filters = new AnswersFilters()
                {
                    idQuestion = cbxQuestions.Text.Split('-')[0],
                    finalDate = tbxDtf.Value,
                    initialDate = tbxDti.Value,
                    idCompany = "02"
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
            string idQuestion = cbxQuestions.Text.Split('-')[0];
            string answer = dgvAnswers.CurrentRow.Cells["answer"].Value.ToString();

            functions.loadClientsByAnswerOnDataGrid(dgvAnalysis, idQuestion, answer);
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
