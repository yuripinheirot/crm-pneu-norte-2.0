using project.infra.db.postgres.config;
using project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.questions
{
    internal class GetQuestion
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        public virtual QuestionModel execute(string idQuestion)
        {
            var questionDb = pg.questions.Where(q => q.id == idQuestion).First();

            return new QuestionModel()
            {
                id = questionDb.id,
                active = questionDb.active,
                answers = questionDb.answers,
                badAnswers = questionDb.badAnswers,
                description = questionDb.description,
                posSale = questionDb.posSale,
            };
        }
    }
}
