using Npgsql;
using project.data.utils;
using project.infra.db.postgres.config;
using project.models;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.answers
{
    public class GetAnswers
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        private string buildQuery(AnswersFilters filters)
        {
            string _query = $"select * from crm.answers a " +
            $"where " +
            $"a.id_company = '{filters.idCompany}'";

            if (filters.initialDate != null && filters.finalDate != null)
            {
                _query += $"and a.created_at between '{filters.initialDate.Value:yyyy-MM-dd HH:mm:ss}' and '{filters.finalDate.Value:yyyy-MM-dd HH:mm:ss}' ";
            }
            if (!string.IsNullOrEmpty(filters.idQuestion)) _query += $" and a.id_Question = '{filters.idQuestion}'";
            if (!string.IsNullOrEmpty(filters.idSale)) _query += $" and a.id_Sale = '{filters.idSale}'";

            return _query;
        }

        private List<AnswerModel> getAnswers(AnswersFilters filters)
        {

            var command = new NpgsqlCommand(buildQuery(filters), pg.Database.Connection as NpgsqlConnection);

            NpgsqlDataAdapter adapter = new NpgsqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            var result = table.AsEnumerable()
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
                });

            return result.ToList();
        }

        public virtual List<AnswerModel> execute(AnswersFilters filters)
        {
            if (filters.initialDate != null && filters.finalDate != null)
            {
                filters.initialDate = DateTimeUtils.convertToInitial((DateTime)filters.initialDate);
                filters.finalDate = DateTimeUtils.convertToFinal((DateTime)filters.finalDate);
            }

            return getAnswers(filters);
        }
    }
}
