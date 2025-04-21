using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.answers
{
    internal class GetAnswerDetailsDataView
    {
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);
        FbDbContext fb = new FbDbContext();

        public virtual AnswerDetails execute(string idAnswer)
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
}
