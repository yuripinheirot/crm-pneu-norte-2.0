using project.domain.model;
using project.domain.usecases;
using project.infra.db.mock.repository;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.client
{
    public class ClientData : IGetClients, IGetClient, IGetClientsAndSalesByAnswerAndQuestion
    {
        ClientMockRepository clientRepository;

        public ClientData(ClientMockRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public ClientModel getClient(string id)
        {
            return clientRepository.getClient(id);
        }

        public List<ClientModel> getClients(string fieldFilter, string valueFilter)
        {
            return clientRepository.getClients(fieldFilter, valueFilter);
        }

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(string idQuestion, string answer)
        {
            return clientRepository.getClientsAndSalesByAnswerAndQuestion(idQuestion, answer);
        }
    }
}
