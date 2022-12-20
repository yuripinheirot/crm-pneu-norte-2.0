using project.domain.model;
using project.main.factories.business;
using project.main.factories.validations;
using project.presentation.protocols;
using project.presentation.utils;
using project.validations.crm;
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
        Dictionary<string, string> observationsAnswers = new Dictionary<string, string>();
        private List<PostAnswerDTO> getAnswersFromForm(MainForm mainForm)
        {
            List<PostAnswerDTO> answersList = new List<PostAnswerDTO>();
            FlowLayoutPanel flpQuestions = (FlowLayoutPanel)mainForm.Controls.Find("flpQuestions", true)[0];
            string idSale = mainForm.TbxIdSale.Text;
            string idClient = mainForm.TbxClientName.Text.Split('-')[0];
            string status = "pending";
            string idCompany = mainForm.TbxIdCompany.Text;


            foreach (Control control in flpQuestions.Controls)
            {
                if (control is ComboBox currentComboBox)
                {
                    var idQuestion = currentComboBox.Tag.ToString();
                    answersList.Add(new PostAnswerDTO()
                    {
                        idQuestion = idQuestion,
                        idSale = idSale,
                        idClient = idClient,
                        status = status,
                        answer = currentComboBox.SelectedValue.ToString(),
                        observation = observationsAnswers[idQuestion],
                        updatedAt = DateTime.Now,
                        idCompany = idCompany
                    });
                }
            }

            return answersList;
        }

        private List<QuestionModel> getQuestions(string module)
        {
            module = TextUtils.translatePosSaleData(module);
            return QuestionsFactory.handle.getQuestions().Where(p => p.posSale == module).ToList();
        }

        private void addBlankAnswerOnQuestion(QuestionModel question)
        {
            if (!question.answers.Contains(""))
            {
                question.answers.Insert(0, "");
            }
        }

        public SaleModel getSale(string idCompany, string idSale)
        {
            return SalesFactory.handle.getSale(idCompany, idSale);
        }

        Button observationButton(string idQuestion)
        {
            void observationButtonClick(object sender, EventArgs e)
            {
                new ObservationAnswer(observationsAnswers, idQuestion).ShowDialog();
            }

            var button = new Button()
            {
                Text = "...",
                Width = 30,
                UseVisualStyleBackColor = true,
            };

            button.Click += new EventHandler(observationButtonClick);

            return button;
        }

        public void renderQuestions(FlowLayoutPanel flpQuestions, string posSale)
        {
            flpQuestions.Controls.Clear();
            var questions = getQuestions(posSale);
            int widthControls = flpQuestions.Width - 70;

            foreach (var question in questions)
            {
                addBlankAnswerOnQuestion(question);
                Control[] questionRendered = new Control[3]
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
                            Size = new Size(745, 70),
                            Tag = question.id,
                        },
                        observationButton(question.id)
                };

                flpQuestions.Controls.AddRange(questionRendered);
            }

        }

        public void saveCrm(MainForm mainForm)
        {
            var answers = getAnswersFromForm(mainForm);
            VerifyEmptyAnswersValidationFactory.handle.validate(answers);

            AnswersFactory.handle.addCrm(answers);
            observationsAnswers.Clear();
        }
    }
}
