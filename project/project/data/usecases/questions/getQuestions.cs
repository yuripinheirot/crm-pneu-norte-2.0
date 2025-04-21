using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.infra.db.postgres.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.questions
{
    internal class GetQuestions
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        private List<QuestionModel> getQuestions()
        {
            var questionsDb = pg.questions.ToList();
            var questions = new List<QuestionModel>();

            questionsDb.ForEach(q =>
            {
                questions.Add(new QuestionModel()
                {
                    active = q.active,
                    answers = q.answers.ToList(),
                    badAnswers = q.badAnswers.ToList(),
                    description = q.description,
                    id = q.id,
                    posSale = q.posSale
                });
            });

            return questions;
        }

        public List<QuestionModel> execute()
        {
            return getQuestions().Where(q => q.active == true).ToList();
        }
    }
}
