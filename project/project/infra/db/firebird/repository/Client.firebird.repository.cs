using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;

namespace project.infra.db.firebird.repository
{
    public class ClientFirebirdRepository : IClientRepository
    {
        PgDbContext pg;
        FbDbContext fb;
        public ClientFirebirdRepository(FbDbContext firebird, PgDbContext postgres)
        {
            pg = postgres;
            fb = firebird;
        }
        public ClientModel getClient(string id)
        {
            var clientDb = fb.trecclientegeral.Where(client => client.CODIGO == id).FirstOrDefault();
            return new ClientModel()
            {
                cpfCnpj = clientDb.CPFCNPJ,
                id = clientDb.CODIGO,
                name = clientDb.NOME,
                nameFantasy = clientDb.FANTASIA,
                phone = clientDb.FONE
            };
        }

        public List<ClientModel> getClients(string fieldFilter, string valueFilter)
        {
            string translatedFieldFilter()
            {
                switch (fieldFilter)
                {
                    case "name":
                        return "NOME";
                    case "nameFantasy":
                        return "FANTASIA";
                    case "cpfCnpj":
                        return "cpfCnpj";
                    case "phone":
                        return "FONE";
                    default:
                        throw new Exception("Invalid field filter");
                }
            }

            return fb.Database.SqlQuery<FbDbContext.TRECCLIENTEGERAL>(
                "select                                     " +
                "cpfcnpj,                                   " +
                "codigo,                                    " +
                "nome,                                      " +
                "fantasia,                                  " +
                "fone                                       " +
                "from trecclientegeral                      " +
                $"where {translatedFieldFilter()} like '%{valueFilter}%'"
                ).Select(x => new ClientModel()
                {
                    cpfCnpj = x.CPFCNPJ,
                    id = x.CODIGO,
                    name = x.NOME,
                    nameFantasy = x.FANTASIA,
                    phone = x.FONE
                }).ToList();
        }

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(AnswersFilters filters)
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

            List<string> clientsIds = answers.Select(a => a.idClient).ToList();

            var clients =
                (from client in fb.trecclientegeral
                 where clientsIds.Contains(client.CODIGO)
                 select new
                 {
                     idClient = client.CODIGO,
                     clientName = client.NOME,
                     clientNameFantasy = client.FANTASIA,
                 }).ToList();

            var result =
                from a in answers
                join c in clients on a.idClient equals c.idClient
                select new AnalysisByQuestionDateView()
                {
                    idClient = a.idClient,
                    clientName = c.clientName,
                    clientNameFantasy = c.clientNameFantasy,
                    idSale = a.idSale,
                    observation = a.observation
                };

            return result.ToList();
        }
    }
}
