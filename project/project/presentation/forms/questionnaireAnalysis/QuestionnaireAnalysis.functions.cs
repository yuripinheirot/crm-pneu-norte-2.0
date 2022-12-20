using project.domain.model;
using project.main.factories.business;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.questionnaireAnalysis
{
    internal class QuestionnaireAnalysisFunctions
    {
        List<QuestionModel> questions = QuestionsFactory.handle.getQuestions();

        public void loadQuestionsOnComboBox(ComboBox cbx, string posSale)
        {
            cbx.Items.Clear();

            foreach (QuestionModel question in questions)
            {
                if (question.posSale == TextUtils.translatePosSaleData(posSale))
                {
                    cbx.Items.Add($"{question.id}-{question.description}");
                }
            }

            cbx.SelectedIndex = 0;
        }

        public void loadAnswersOnDataGrid(DataGridView dgv, AnswersFilters filters)
        {
            var answers = AnswersFactory.handle.getAnswers(filters)
                .GroupBy(answer => answer.answer)
                .Select(answer => new
                {
                    answer = answer.Key,
                    count = answer.Select(p => p.answer).Distinct().Count(),
                })
                .ToList();
            var dataSource = GridUtils.ToDataTable(answers);

            dgv.DataSource = dataSource;
        }

        public void loadClientsByAnswerOnDataGrid(DataGridView dgv, string idQuestion, string answer)
        {
            var clients = ClientFactory.handle.getClientsAndSalesByAnswerAndQuestion(idQuestion, answer);
            var dataSource = GridUtils.ToDataTable(clients);

            dgv.DataSource = dataSource;
        }
    }
}
