using project.domain.model.entities;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using project.data.usecases.questions;
using project.data.usecases.answers;
using project.validations.crm;
using project.data.usecases.sales;

namespace project.presentation.forms.main
{
    internal class MainFunctions
    {
        static GetQuestions getQuestionsData = new GetQuestions();
        static GetSale getSaleData = new GetSale();
        static AddAnswerDto addAnswerDto = new AddAnswerDto();
        static AnswerAlreadyExists answerAlreadyExists = new AnswerAlreadyExists();
        static VerifyEmptyAnswersValidation verifyEmptyAnswersValidation = new VerifyEmptyAnswersValidation();

        Dictionary<string, string> observationsAnswers = new Dictionary<string, string>();

        private List<PostAnswerDTO> getAnswersFromForm(MainForm mainForm)
        {
            List<PostAnswerDTO> answersList = new List<PostAnswerDTO>();
            FlowLayoutPanel flpQuestions = mainForm.Controls.OfType<FlowLayoutPanel>().FirstOrDefault();
            string idSale = mainForm.TbxIdSale.Text;
            string idClient = mainForm.TbxClientName.Text.Split('-')[0];
            string idCompany = mainForm.TbxIdCompany.Text;


            foreach (Control control in flpQuestions.Controls)
            {
                if (control is ComboBox currentComboBox)
                {
                    var idQuestion = currentComboBox.Tag.ToString();
                    var currentAnswer = currentComboBox.SelectedValue.ToString();
                    var observation = observationsAnswers.ContainsKey(idQuestion) ? observationsAnswers[idQuestion] : "";

                    answersList.Add(new PostAnswerDTO()
                    {
                        idQuestion = idQuestion,
                        idSale = idSale,
                        idClient = idClient,
                        status = null,
                        answer = currentAnswer,
                        observation = observation,
                        updatedAt = null,
                        idCompany = idCompany
                    });
                }
            }

            return answersList;
        }

        private List<QuestionModel> getQuestions(string module)
        {
            module = TextUtils.translatePosSaleData(module);
            return getQuestionsData.execute().Where(p => p.posSale == module).ToList();
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
            return getSaleData.execute(idCompany, idSale);
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
                Height = 29,
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
                            Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Regular, GraphicsUnit.Point, 0)
                        },
                        observationButton(question.id)
                };

                flpQuestions.Controls.AddRange(questionRendered);
            }

        }

        public void saveCrm(MainForm mainForm)
        {
            var answers = getAnswersFromForm(mainForm);
            verifyEmptyAnswersValidation.execute(answers);
            addAnswerDto.execute(answers);

            observationsAnswers.Clear();
        }

        public bool crmAlreadyExists(string idCompany, string idSale)
        {
            return answerAlreadyExists.execute(idCompany, idSale);
        }

    }
}
