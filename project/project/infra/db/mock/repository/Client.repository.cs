using project.data.client;
using project.domain.model;
using project.domain.usecases;
using project.presentation.protocols;
using project.specs.mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.mock.repository
{
    internal class ClientDbMockRepository : IGetClients, IGetClient, IGetClientsAndSalesByAnswerAndQuestion
    {
        public ClientModel getClient(string id)
        {
            return ClientMock.clients.Where(client => client.id == id).FirstOrDefault();
        }

        public List<ClientModel> getClients(string fieldFilter, string valueFilter)
        {
            return ClientMock.clients.Where(client => client.acessByProp(fieldFilter).ToString().Contains(valueFilter)).ToList();
        }

        public List<AnalysisByQuestionProtocol> getClientsAndSalesByAnswerAndQuestion(string idAnswer, string answer)
        {
            //var clientsIdByAnswer = AnswersMock.answers.Where(p => p.id == idAnswer && p.answer == answer).Select(s => s.idClient).ToList();
            //return ClientMock.clients.Where(client => clientsIdByAnswer.Contains(client.id)).ToList();

            var query =
                (from _answer in AnswersMock.answers
                join client in ClientMock.clients on _answer.idClient equals client.id
                join sale in SalesMock.sales on _answer.idSale equals sale.id
                select new
                {
                    idClient = client.id,
                    clientName = client.name,
                    clientNameFantasy = client.nameFantasy,
                    idSale = sale.id,
                    _answer.observation,
                }).Distinct();

            List<AnalysisByQuestionProtocol> analysis = new List<AnalysisByQuestionProtocol>();

            foreach (var value in query)
            {
                analysis.Add(new AnalysisByQuestionProtocol()
                {
                    clientName = value.clientName,
                    clientNameFantasy = value.clientNameFantasy,
                    idClient = value.idClient,
                    idSale = value.idSale,
                    observation = value.observation,
                });
            }

            return analysis;
        }
    }
}
