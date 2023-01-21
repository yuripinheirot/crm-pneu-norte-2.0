using project.domain.model;
using project.domain.usecases;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.repository
{
    internal class AnswersPostgresRepository : IPostAnswersRepository, IGetAnswers, IGetAnswersNotResolved, IGetAnswerDetails, IPutAnswer
    {
        public void addAnswersRepository(List<AnswerModel> answers)
        {
            using (var db = new PgDbContext())
            {
                db.answers.AddRange((IEnumerable<PgDbContext.Answers>)answers);
            }
        }

        public AnswerDetails getAnswerDetailsDataView(string idAnswer)
        {
            using (var fb = new FbDbContext())
            using (var pg = new PgDbContext())
            {
                var answer = pg.answers.Where(a => a.id == idAnswer).First();
                var question = pg.questions.Where(a => a.id == answer.idQuestion).First();
                var sale = fb.tvenpedido.Where(s => s.EMPRESA == answer.idCompany && s.CODIGO == answer.idSale).First();
                var seller = fb.tvenvendedor.Where(s => s.EMPRESA == answer.idCompany && s.CODIGO == answer.idSale).First();

                return new AnswerDetails()
                {
                    idCompany = answer.idCompany,
                    idSale = answer.idSale,
                    client = answer.idClient,
                    seller = seller.NOME,
                    status = answer.status,
                    descriptionQuestion = question.description,
                    answer = answer.answer,
                    observation = answer.observation,
                    resolution = answer.resolution,
                };
            }
        }

        public List<AnswerModel> getAnswers(AnswersFilters filters)
        {
            using (var pg = new PgDbContext())
            {
                var answers = pg.answers.Where(answer =>
                    (filters.initialDate != null ? answer.createdAt >= filters.initialDate : true) &&
                    (filters.finalDate != null ? answer.createdAt <= filters.finalDate : true) &&
                    (!string.IsNullOrWhiteSpace(filters.idSale) ? answer.idSale == filters.idSale : true) &&
                    (!string.IsNullOrWhiteSpace(filters.idQuestion) ? answer.idQuestion == filters.idQuestion : true) &&
                    (!string.IsNullOrWhiteSpace(filters.idCompany) ? answer.idCompany == filters.idCompany : true)
                );

                return (List<AnswerModel>)answers;
            }
        }

        public List<AnswerNotResolvedDataView> getAnswersNotResolved()
        {
            using (var pg = new PgDbContext())
            {
                var query =
                    from answer in pg.answers
                    join question in pg.questions on answer.idQuestion equals question.id
                    where answer.status == "pending"
                    select new AnswerNotResolvedDataView()
                    {
                        idAnswer = answer.id,
                        idCompany = answer.idCompany,
                        idSale = answer.idSale,
                        idClient = answer.idClient,
                        answer = answer.answer,
                        descriptionQuestion = question.description,
                        observation = answer.observation,
                        resolution = answer.resolution,
                    };

                return query.ToList();
            }
        }

        public void putAnswer(AnswerModel answerUpdated)
        {
            using (var pg = new PgDbContext())
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
        }
    }
}
