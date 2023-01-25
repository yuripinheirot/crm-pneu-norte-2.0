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
using static project.infra.db.firebird.config.FbDbContext;

namespace project.infra.db.firebird.repository
{
    public class ClientFirebirdRepository : IGetClients, IGetClient, IGetClientsAndSalesByAnswerAndQuestion
    {
        public ClientModel getClient(string id)
        {
            using (var db = new FbDbContext())
            {
                var clientDb = db.trecclientegeral.Where(client => client.CODIGO == id).FirstOrDefault();
                return new ClientModel()
                {
                    cpfCnpj = clientDb.CPFCNPJ,
                    id = clientDb.CODIGO,
                    name = clientDb.NOME,
                    nameFantasy = clientDb.FANTASIA,
                    phone = clientDb.FONE
                };
            }
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
            using (var db = new FbDbContext())
            {
                return db.Database.SqlQuery<TRECCLIENTEGERAL>(
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
        }

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(string idQuestion, string answer, string idCompany)
        {
            using (var pg = new PgDbContext())
            using (var fb = new FbDbContext())
            {
                var answers =
                    (from _answer in pg.answers
                     where _answer.idQuestion == idQuestion && _answer.answer == answer  && _answer.idCompany == idCompany
                     select new
                     {
                         idSale = _answer.idSale,
                         idCompany = _answer.idCompany,
                         idClient = _answer.idClient,
                         observation = _answer.observation,
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
}
