using project.domain.model.entities;
using project.infra.db.firebird.config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.client
{
    internal class GetClient
    {
        FbDbContext fb = new FbDbContext();
        public ClientModel execute(string id)
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
    }
}
