using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.models;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.client
{
    internal class GetClientsByDob
    {
        readonly FbDbContext fb = new FbDbContext();
        readonly PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        private int convertDobToQuery(string date)
        {
            string month = date.Split('-')[1];
            string day = date.Split('-')[2];

            return (Convert.ToInt32(month) * 100) + Convert.ToInt32(day);
        }

        public List<DobListReport> execute(string startDate, string endDate)
        {
            int startDateParsed = Convert.ToInt32(convertDobToQuery(startDate));
            int endDateParsed = Convert.ToInt32(convertDobToQuery(endDate));

            string queryFB =
                "select                                                                     " +
                "clg.cpfcnpj AS cpfCnpj,                                                    " +
                "clg.codigo AS id,                                                          " +
                "clg.nome AS name,                                                          " +
                "clg.fantasia AS nameFantasy,                                               " +
                "clg.fone AS phone,                                                         " +
                "cpf.DATANASC AS dob                                                        " +
                "from trecclientegeral clg                                                  " +
                "LEFT JOIN TRECPFISICA cpf ON(clg.CODIGO = cpf.CODIGO)                      " +
                "WHERE                                                                      " +
                $"(EXTRACT(MONTH FROM cpf.DATANASC) * 100 + EXTRACT(DAY FROM cpf.DATANASC)) " +
                $"BETWEEN {startDateParsed} AND {endDateParsed};                            ";

            var clientsFB = fb.Database.SqlQuery<ClientModel>(queryFB).ToList();

            DateTime startDatePg = DateTime.ParseExact(startDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime endDatePg = DateTime.ParseExact(endDate, "yyyy-MM-dd", CultureInfo.InvariantCulture);

            string startDateFormatted = $"{startDatePg.Day.ToString().PadLeft(2, '0')}/{startDatePg.Month}";
            string endDateFormatted = $"{endDatePg.Day.ToString().PadLeft(2, '0')}/{endDatePg.Month}";
            int year = startDatePg.Year;

            string queryPG =
                "SELECT " +
                "  id::text AS id, " +
                "  id_client as idClient, " +
                "  observations, " +
                "  dob, " +
                "  done, " +
                "  year, " +
                "  updated_at, " +
                "  created_at " +
                "FROM crm.doblist d " +
                "WHERE done = true " +
               $"AND year = {year} " +
                "AND TO_DATE(" +
                "  LPAD(SPLIT_PART(dob, '/', 1), 2, '0') || '/' || " +
                "  LPAD(SPLIT_PART(dob, '/', 2), 2, '0') || '/' || year, " +
                "'DD/MM/YYYY') " +
               $"BETWEEN TO_DATE('{startDateFormatted}/{year}', 'DD/MM/YYYY') " +
               $"AND TO_DATE('{endDateFormatted}/{year}', 'DD/MM/YYYY');";

            var dobsPG = pg.Database.SqlQuery<DobListModel>(queryPG).ToList();

            var result = from client in clientsFB
                         join dob in dobsPG on client.id equals dob.idClient into dobGroup
                         from dob in dobGroup.DefaultIfEmpty()
                         select new DobListReport()
                         {
                             clientId = client.id,
                             clientName = client.name,
                             observation = dob?.observations,
                             done = dob != null ? (dob.done ? "Sim" : "Não") : "Não",
                             dob = client.dob.ToString()
                         };

            return result.ToList();

        }
    }
}
