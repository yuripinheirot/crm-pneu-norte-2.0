using project.domain.interfaces;
using project.domain.interfaces.Struct;
using project.domain.model;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.repository
{
    public class QuestionsPostgresRepository : IQuestionsRepository
    {
        PgDbContext db;
        public QuestionsPostgresRepository(PgDbContext postgres)
        {
            db = postgres;
        }
        public virtual QuestionModel getQuestion(string idQuestion)
        {
            //using (var db = new PgDbContext())
            //{
            var questionDb = db.questions.Where(q => q.id == idQuestion).First();

            return new QuestionModel()
            {
                id = questionDb.id,
                active = questionDb.active,
                answers = questionDb.answers,
                badAnswers = questionDb.badAnswers,
                description = questionDb.description,
                posSale = questionDb.posSale,
            };
            //}
        }

        public virtual List<QuestionModel> getQuestions()
        {
            //using (var db = new PgDbContext())
            //{
            var questionsDb = db.questions.ToList();
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
            //}
        }
    }
}
