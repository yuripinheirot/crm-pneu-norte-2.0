using project.domain.model;
using project.domain.usecases;
using project.infra.db.firebird.config;
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

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(string idQuestion, string answer)
        {
            throw new NotImplementedException();
        }
    }
}
