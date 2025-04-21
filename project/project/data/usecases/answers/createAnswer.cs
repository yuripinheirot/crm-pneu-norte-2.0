using project.infra.db.postgres.config;
using project.models;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.answers
{
    internal class CreateAnswer
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        public virtual void create(AnswerModel answerUpdated)
        {
            var answer = pg.answers.Where(a => a.id == answerUpdated.id).First();

            if (answer == null)
            {
                throw new Exception("Answer not found");
            }

            if (answerUpdated.idQuestion != null) answer.idQuestion = answerUpdated.idQuestion;
            if (answerUpdated.idSale != null) answer.idSale = answerUpdated.idSale;
            if (answerUpdated.idClient != null) answer.idClient = answerUpdated.idClient;
            if (answerUpdated.status != null) answer.status = answerUpdated.status;
            if (answerUpdated.answer != null) answer.answer = answerUpdated.answer;
            if (answerUpdated.observation != null) answer.observation = answerUpdated.observation;
            if (answerUpdated.resolution != null) answer.resolution = answerUpdated.resolution;
            if (answerUpdated.idCompany != null) answer.idCompany = answerUpdated.idCompany;
            if (answerUpdated.createdAt.Ticks > 0) answer.createdAt = answerUpdated.createdAt;

            pg.SaveChanges();
        }

        public virtual void execute(AnswerModel answer)
        {
            answer.updatedAt = DateTime.Now;
            
            if (!string.IsNullOrWhiteSpace(answer.status)) answer.status = TextUtils.translateStatusAnswerData(answer.status);

            create(answer);
        }
    }
}
