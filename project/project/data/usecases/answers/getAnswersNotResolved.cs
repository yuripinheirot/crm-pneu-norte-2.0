using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.answers
{
    internal class GetAnswersNotResolved
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        public virtual List<AnswerNotResolvedDataView> execute()
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
}
