using project.domain.model;
using project.main.factories;
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

        string convertPosSale(string posSale)
        {
            if (posSale == "VENDAS")
            {
                return "sale";
            }
            else if (posSale == "SERVIÇOS")
            {
                return "order";
            }
            else
            {
                throw new Exception("Unexpected posSale name");
            }
        }

        public void loadQuestionsOnComboBox(ComboBox cbx, string posSale)
        {
            cbx.Items.Clear();

            foreach (QuestionModel question in questions)
            {
                if (question.posSale == convertPosSale(posSale))
                {
                    cbx.Items.Add($"{question.id}-{question.description}");
                }
            }

            cbx.SelectedIndex = 0;
        }

        public void loadAnswersOnDataGrid(DataGridView dgv, GetAnswersDTO filters)
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
    }
}
