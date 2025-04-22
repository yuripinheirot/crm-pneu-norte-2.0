using project.data.usecases.answers;
using project.data.usecases.client;
using project.data.usecases.questions;
using project.models;
using project.presentation.errors;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace project.presentation.forms.questionnaireAnalysis
{
    public partial class QuestionnaireAnalysisForm : Form
    {
        static GetQuestions getQuestions = new GetQuestions();
        static GetAnswers getAnswers = new GetAnswers();
        static GetClientsAndSalesByAnswerAndQuestion getClientsAndSalesByAnswerAndQuestion = new GetClientsAndSalesByAnswerAndQuestion();

        public QuestionnaireAnalysisForm()
        {
            InitializeComponent();
        }

        public void loadQuestionsOnComboBox(ComboBox cbx, string posSale)
        {
            cbx.Items.Clear();
            cbx.DisplayMember = "description";
            var questions = getQuestions.execute();

            foreach (QuestionModel question in questions)
            {
                if (question.posSale == TextUtils.translatePosSaleData(posSale))
                {
                    cbx.Items.Add(question);
                }
            }

            cbx.SelectedIndex = 0;
        }

        public void loadAnswersOnDataGrid(DataGridView dgv, AnswersFilters filters)
        {
            var result =
                from answers in getAnswers.execute(filters)
                group answers by answers.answer into answersGroup
                select new
                {
                    answer = answersGroup.Key,
                    count = answersGroup.Count(),
                };

            var dataSource = GridUtils.ToDataTable(result.ToList());

            dgv.DataSource = dataSource;
        }

        public void loadClientsByAnswerOnDataGrid(DataGridView dgv, AnswersFilters filters)
        {
            var clients = getClientsAndSalesByAnswerAndQuestion.execute(filters);
            var dataSource = GridUtils.ToDataTable(clients);

            dgv.DataSource = dataSource;
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
                loadQuestionsOnComboBox(cbxQuestions, cbxPosSale.Text);
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
                loadQuestionsOnComboBox(cbxQuestions, cbxPosSale.Text);
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

                loadAnswersOnDataGrid(dgvAnswers, filters);

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

                loadClientsByAnswerOnDataGrid(dgvAnalysis, filters);
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
