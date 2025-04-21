using project.data.utils;
using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.client
{
    internal class GetClientsAndSalesByAnswerAndQuestion
    {
        FbDbContext fb = new FbDbContext();
        PgDbContext pg = new PgDbContext(Properties.Settings.Default.postgresConnectionString);

        private List<ClientModel> getClientsByIds(List<string> clientIds)
        {
            var lengthSkip = 1000;
            decimal times = Convert.ToDecimal((clientIds.Count / lengthSkip) + 1);
            var remainsIdsCount = clientIds.Count % lengthSkip;
            var clients = new List<ClientModel>();
            void execute(List<string> ids)
            {
                var result = from client in fb.trecclientegeral
                             where ids.Contains(client.CODIGO)
                             select new ClientModel()
                             {
                                 id = client.CODIGO,
                                 cpfCnpj = client.CPFCNPJ,
                                 name = client.NOME,
                                 nameFantasy = client.FANTASIA,
                                 phone = client.FONE,
                             };

                clients.AddRange(result.ToList());
            }

            for (int i = 0; i < times; i++)
            {
                var ids = clientIds.Skip(i * lengthSkip).Take(lengthSkip).ToList();
                execute(ids);
            }

            return clients;
        }

        private List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(AnswersFilters filters)
        {

            var answers =
                (from answer in pg.answers
                 where
                 answer.idQuestion == filters.idQuestion &&
                 answer.answer == filters.answer &&
                 answer.idCompany == filters.idCompany &&
                 answer.createdAt >= filters.initialDate &&
                 answer.createdAt <= filters.finalDate
                 select new
                 {
                     idSale = answer.idSale,
                     idCompany = answer.idCompany,
                     idClient = answer.idClient,
                     observation = answer.observation,
                 }).Distinct().ToList();

            List<string> clientsIds = answers.Select(a => a.idClient).Distinct().ToList();

            var clients = getClientsByIds(clientsIds);

            var result =
                (from a in answers
                 join c in clients on a.idClient equals c.id
                 select new AnalysisByQuestionDateView()
                 {
                     idClient = a.idClient,
                     clientName = c.name,
                     clientNameFantasy = c.nameFantasy,
                     idSale = a.idSale,
                     observation = a.observation
                 }).ToList();

            return result;
        }

        public virtual List<AnalysisByQuestionDateView> execute(AnswersFilters filters)
        {
            filters.initialDate = DateTimeUtils.convertToInitial((DateTime)filters.initialDate);
            filters.finalDate = DateTimeUtils.convertToFinal((DateTime)filters.finalDate);

            return getClientsAndSalesByAnswerAndQuestion(filters);
        }
    }
}
