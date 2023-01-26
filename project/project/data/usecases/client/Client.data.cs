using project.data.utils;
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
    public class ClientData<T> : IGetClients, IGetClient, IGetClientsAndSalesByAnswerAndQuestion
        where T : IGetClients, IGetClient, IGetClientsAndSalesByAnswerAndQuestion
    {
        T clientRepository;

        public ClientData(T clientRepository)
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

        public List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(AnswersFilters filters)
        {
            filters.initialDate = DateTimeUtils.convertToInitial((DateTime)filters.initialDate);
            filters.finalDate = DateTimeUtils.convertToFinal((DateTime)filters.finalDate);

            return clientRepository.getClientsAndSalesByAnswerAndQuestion(filters);
        }
    }
}
