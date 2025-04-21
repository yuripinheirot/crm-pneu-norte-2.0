using project.data.usecases.questions;
using project.infra.db.postgres.config;
using project.models;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.answers
{
    internal class AddAnswerDto
    {
        GetQuestion getQuestion = new GetQuestion();
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        private void createAnswers(List<AnswerModel> answers)
        {
            answers.ForEach(a =>
            {
                pg.answers.Add(new PgDbContext.Answers()
                {
                    answer = a.answer,
                    createdAt = a.createdAt,
                    id = a.id,
                    idClient = a.idClient,
                    idCompany = a.idCompany,
                    idQuestion = a.idQuestion,
                    idSale = a.idSale,
                    observation = a.observation,
                    resolution = a.resolution,
                    status = a.status,
                    updatedAt = a.updatedAt,
                });
            });

            pg.SaveChanges();
        }

        private  List<AnswerModel> formatAnswersListDto(List<PostAnswerDTO> answersDTO)
        {
            var answers = answersDTO.Select(a => new AnswerModel()
            {
                id = Guid.NewGuid().ToString(),
                idQuestion = a.idQuestion,
                idSale = a.idSale,
                idClient = a.idClient,
                status = a.status,
                answer = a.answer,
                observation = a.observation,
                resolution = null,
                updatedAt = DateTime.Now,
                createdAt = DateTime.Now,
                idCompany = a.idCompany
            }).ToList();

            return answers;
        }

        private void determineAnswerStatus(List<PostAnswerDTO> answers)
        {
            answers.ForEach(answer =>
            {
                var currentQuestion = getQuestion.execute(answer.idQuestion);
                var status = currentQuestion.badAnswers.Contains(answer.answer) ? "pending" : "done";

                answer.status = status;
            });
        }

        public void execute(List<PostAnswerDTO> answers)
        {
            determineAnswerStatus(answers);

            var answersFormatted = formatAnswersListDto(answers);

            createAnswers(answersFormatted);
        }
    }
}
