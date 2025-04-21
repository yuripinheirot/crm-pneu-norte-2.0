using project.infra.db.firebird.config;
using project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.client
{
    internal class GetClients
    {
        FbDbContext fb = new FbDbContext();
        private string translatedFieldFilter(string fieldFilter)
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

        private string buildQuery(string fieldFilter, string valueFilter)
        {
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

            string whereFilter = $"where {translatedFieldFilter(fieldFilter)} like '%{valueFilter}%'";

            if (fieldFilter == "dob")
            {
                string[] dob = valueFilter.Split('/');

                whereFilter =
                     "WHERE                                          " +
                    $"EXTRACT(MONTH FROM cpf.DATANASC) = {dob[1]}    " +
                    $"AND EXTRACT(DAY FROM cpf.DATANASC) = {dob[0]}; ";
            }

            query += whereFilter;

            return query;
        }


        public List<ClientModel> execute(string fieldFilter, string valueFilter)
        {
            string query = buildQuery(fieldFilter, valueFilter);
            return fb.Database.SqlQuery<ClientModel>(query).ToList();
        }
    }
}
