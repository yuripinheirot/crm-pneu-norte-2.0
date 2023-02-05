using project.domain.model;
using project.infra.db.postgres.config;
using specs.suport.factories.feature;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.helpers
{
    public class MethodsPostgresHelper
    {
        public static string FormatList(List<string> list)
        {
            return "{" + string.Join(", ", list.ConvertAll(x => "\"" + x + "\"")) + "}";
        }

        private static QuestionModel transformQuestionDbInModel(PgDbContext.Questions questionDb)
        {
            return new QuestionModel()
            {
                active = questionDb.active,
                answers = questionDb.answers,
                badAnswers = questionDb.badAnswers,
                description = questionDb.description,
                id = questionDb.id,
                posSale = questionDb.posSale,
            };
        }
        private static PgDbContext.Questions transformQuestionModelInDb(QuestionModel questionModel)
        {
            return new PgDbContext.Questions()
            {
                active = questionModel.active,
                answersArray = FormatList(questionModel.answers),
                badAnswersArray = FormatList(questionModel.badAnswers),
                description = questionModel.description,
                id = questionModel.id,
                posSale = questionModel.posSale,

            };
        }

        private static AnswerModel transformAnswerDbInModel(PgDbContext.Answers answerDb)
        {
            return new AnswerModel()
            {
                id = answerDb.id,
                idQuestion = answerDb.idQuestion,
                answer = answerDb.answer,
                createdAt = answerDb.createdAt,
                idClient = answerDb.idClient,
                idCompany = answerDb.idCompany,
                idSale = answerDb.idSale,
                observation = answerDb.observation,
                resolution = answerDb.resolution,
                status = answerDb.status,
                updatedAt = answerDb.updatedAt,
            };
        }
        private static PgDbContext.Answers transformAnswerModelInDb(AnswerModel answerModel)
        {
            return new PgDbContext.Answers()
            {
                answer = answerModel.answer,
                updatedAt = answerModel.updatedAt,
                status = answerModel.status,
                resolution = answerModel.resolution,
                observation = answerModel.observation,
                idSale = answerModel.idSale,
                idCompany = answerModel.idCompany,
                createdAt = answerModel.createdAt,
                id = answerModel.id,
                idClient = answerModel.idClient,
                idQuestion = answerModel.idQuestion,
            };
        }


        public static void insertManyQuestions(List<QuestionModel> questions)
        {
            var questionsToAdd = questions.Select((q) => transformQuestionModelInDb(q));
            QuestionsRepositoryFactoryMock.postgresMock.questions.AddRange(questionsToAdd);

            QuestionsRepositoryFactoryMock.postgresMock.SaveChanges();
        }

        public static QuestionModel getQuestionById(string idQuestion)
        {
            return QuestionsRepositoryFactoryMock.postgresMock.questions
                .Where(q => q.id == idQuestion)
                .Select(q => transformQuestionDbInModel(q))
                .FirstOrDefault();
        }

        public static void cleanQuestions()
        {
            QuestionsRepositoryFactoryMock.postgresMock.Database.ExecuteSqlCommand("delete from questions;");
        }

        public static void insertManyAnswers(List<AnswerModel> answers)
        {
            var answersToAdd = answers.Select((q) => transformAnswerModelInDb(q));
            AnswersRepositoryFactoryMock.postgresMock.answers.AddRange(answersToAdd);

            AnswersRepositoryFactoryMock.postgresMock.SaveChanges();
        }

        public static AnswerModel getAnswerById(string idAnswer)
        {
            var answer = AnswersRepositoryFactoryMock.postgresMock.answers
                .Where(q => q.id == idAnswer)
                .FirstOrDefault();

            return transformAnswerDbInModel(answer);
        }

        public static void cleanAnswers()
        {
            QuestionsRepositoryFactoryMock.postgresMock.Database.ExecuteSqlCommand("delete from answers;");
        }
    }
}
