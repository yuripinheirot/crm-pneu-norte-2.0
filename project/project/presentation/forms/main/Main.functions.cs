using project.domain.model;
using project.main.factories;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.main
{
    internal class MainFunctions
    {
        private List<AnswerDTO> getAnswersFromForm(MainForm mainForm)
        {
            List<AnswerDTO> answersList = new List<AnswerDTO>();
            FlowLayoutPanel flpQuestions = (FlowLayoutPanel)mainForm.Controls.Find("flpQuestions", true)[0];
            string idSale = mainForm.TbxIdSale.Text;
            string idClient = mainForm.TbxClientName.Text.Split('-')[0];
            string status = "pending";
            string idCompany = mainForm.TbxCompany.Text;


            foreach (Control control in flpQuestions.Controls)
            {
                if (control is ComboBox)
                {
                    ComboBox currentComboBox = (ComboBox)control;
                    answersList.Add(new AnswerDTO()
                    {
                        idQuestion = currentComboBox.Tag.ToString(),
                        idSale = idSale,
                        idClient = idClient,
                        status = status,
                        answer = currentComboBox.SelectedValue.ToString(),
                        observation = "",
                        updatedAt = DateTime.Now,
                        idCompany = idCompany
                    });
                }
            }

            return answersList;
        }

        private List<Question> getQuestions(string module)
        {
            return QuestionsFactory.handle.getQuestions().Where(p => p.module == module).ToList();
        }

        private void addBlankAnswerOnQuestion(Question question)
        {
            question.answers.Insert(0, "");
        }

        public void renderQuestions(FlowLayoutPanel flpQuestions, string module)
        {

            var questions = getQuestions(module);
            int widthControls = flpQuestions.Width - 40;

            foreach (var question in questions)
            {
                addBlankAnswerOnQuestion(question);

                Control[] questionRendered = new Control[2]
                {
                        new Label()
                        {
                            Text = question.description,
                            Width = widthControls,
                            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
                        },
                        new ComboBox()
                        {
                            DataSource = question.answers,
                            DropDownStyle = ComboBoxStyle.DropDownList,
                            Width = widthControls,
                            FormattingEnabled = true,
                            Size = new Size(745, 28),
                            Tag = question.id
                        }
                };

                flpQuestions.Controls.AddRange(questionRendered);
            }

        }

        public void saveCrm(MainForm mainForm)
        {
            var answers = getAnswersFromForm(mainForm);
            AnswersFactory.handle.addCrm(answers);
        }
    }
}
