﻿using project.domain.model;
using project.main.factories.questions;
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
        public List<Question> getQuestions(string module)
        {
            return QuestionsFactory.questions.getQuestions().Where(p => p.module == module).ToList();
        }

        public void getAnswersFromForm()
        {

        }

        public void renderQuestions(FlowLayoutPanel flpQuestions, string module)
        {

            var questions = getQuestions(module);
            int widthControls = flpQuestions.Width - 40;

            foreach (var question in questions)
            {
                //add blank answer
                question.answers.Insert(0, "");

                Control[] questionRendered = new Control[2]
                {
                        new Label()
                        {
                            Text = question.description,
                            Width = widthControls,
                            Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)))
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
    }
}