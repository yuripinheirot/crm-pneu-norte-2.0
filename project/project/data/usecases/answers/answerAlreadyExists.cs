using project.infra.db.postgres.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.answers
{
    internal class AnswerAlreadyExists
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        public virtual bool execute(string idCompany, string idSale)
        {
            return pg.answers.Any(a => a.idCompany == idCompany && a.idSale == idSale);
        }
    }
}
