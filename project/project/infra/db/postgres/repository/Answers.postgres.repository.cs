using Npgsql;
using project.domain.interfaces;
using project.domain.interfaces.Struct;
using project.domain.model;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.repository
{
    public class AnswersPostgresRepository : IAnswersRepository
    {
        public virtual void addAnswersRepository(List<AnswerModel> answers)
        {
            using (var db = new PgDbContext())
            {
                answers.ForEach(a =>
                {
                    db.answers.Add(new PgDbContext.Answers()
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

                db.SaveChanges();
            }
        }

        public virtual bool postAnswerAlreadyExists(string idCompany, string idSale)
        {
            using (var pg = new PgDbContext())
            {
                return pg.answers.Any(a => a.idCompany == idCompany && a.idSale == idSale);
            }
        }

        public virtual AnswerDetails getAnswerDetailsDataView(string idAnswer)
        {
            using (var fb = new FbDbContext())
            using (var pg = new PgDbContext())
            {
                var answer = pg.answers.Where(a => a.id == idAnswer).First();
                var question = pg.questions.Where(a => a.id == answer.idQuestion).First();
                var sale = fb.tvenpedido.Where(s => s.EMPRESA == answer.idCompany && s.CODIGO == answer.idSale).First();
                var seller = fb.tvenvendedor.Where(s => s.EMPRESA == answer.idCompany && s.CODIGO == sale.VENDEDOR).First();

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
            using (var db = new PgDbContext())
            {
                string buildQuery()
                {
                    string _query = $"select * from answers a " +
                    $"where " +
                    $"a.id_company = '{filters.idCompany}' and " +
                    $"a.created_at between '{filters.initialDate.Value:yyyy-MM-dd HH:mm:ss}' and '{filters.finalDate.Value:yyyy-MM-dd HH:mm:ss}' ";

                    if (!string.IsNullOrEmpty(filters.idQuestion)) _query += $" and a.id_Question = '{filters.idQuestion}'";
                    if (!string.IsNullOrEmpty(filters.idSale)) _query += $" and a.id_Sale = '{filters.idSale}'";

                    return _query;
                }
                var command = new NpgsqlCommand(buildQuery(), db.Database.Connection as NpgsqlConnection);
                db.Database.Connection.Open();

                NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table.AsEnumerable()
                    .Select(row => new AnswerModel()
                    {
                        answer = row.Field<string>("answer"),
                        createdAt = row.Field<DateTime>("created_at"),
                        updatedAt = row.Field<DateTime>("updated_at"),
                        id = row.Field<Guid>("id").ToString(),
                        idClient = row.Field<string>("id_client"),
                        idCompany = row.Field<string>("id_company"),
                        idQuestion = row.Field<Guid>("id_question").ToString(),
                        idSale = row.Field<string>("id_sale"),
                        observation = row.Field<string>("observation"),
                        resolution = row.Field<string>("resolution"),
                        status = row.Field<string>("status"),
                    }).ToList();
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
