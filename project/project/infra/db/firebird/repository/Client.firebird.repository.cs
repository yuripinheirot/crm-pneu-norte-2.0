using FastReport.Utils;
using project.domain.interfaces.entities;
using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.infra.db.firebird.config;
using project.infra.db.postgres.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Linq;
using static project.infra.db.firebird.config.FbDbContext;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace project.infra.db.firebird.repository
{
    public class ClientFirebirdRepository : IClientRepository
    {
        PgDbContext pg;
        FbDbContext fb;
        public ClientFirebirdRepository(FbDbContext firebird, PgDbContext postgres)
        {
            fb = firebird;
            pg = postgres;
        }
        public ClientModel getClient(string id)
        {
            var clientDb = fb.trecclientegeral.Where(client => client.CODIGO == id).FirstOrDefault();
            var clientModel = new ClientModel()
            {
                cpfCnpj = clientDb.CPFCNPJ,
                id = clientDb.CODIGO,
                name = clientDb.NOME,
                nameFantasy = clientDb.FANTASIA,
                phone = clientDb.FONE
            };

            return clientModel;
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
                    case "dob":
                        return "";
                    default:
                        throw new Exception("Invalid field filter");
                }
            }

            string query =
                 "select                                                " +
                 "clg.cpfcnpj AS cpfCnpj,                               " +
                 "clg.codigo AS id,                                     " +
                 "clg.nome AS name,                                     " +
                 "clg.fantasia AS nameFantasy,                          " +
                 "clg.fone AS phone,                                    " +
                 "cpf.DATANASC AS dob                                   " +
                 "from trecclientegeral clg                             " +
                 "LEFT JOIN TRECPFISICA cpf ON(clg.CODIGO = cpf.CODIGO) ";

            string whereFilter = $"where {translatedFieldFilter()} like '%{valueFilter}%'";

            if (fieldFilter == "dob")
            {
                string[] dob = valueFilter.Split('/');

                whereFilter =
                     "WHERE                                          " +
                    $"EXTRACT(MONTH FROM cpf.DATANASC) = {dob[1]}    " +
                    $"AND EXTRACT(DAY FROM cpf.DATANASC) = {dob[0]}; ";
            }

            query += whereFilter;

            return fb.Database.SqlQuery<ClientModel>(query).ToList();
        }

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
    }
}
