using project.data.utils;
using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using project.infra.db.firebird.repository;

namespace project.data.usecases.client
{
    public class ClientData : IClientData
    {
        ClientFirebirdRepository clientRepository;

        public ClientData(ClientFirebirdRepository clientRepository)
        {
            this.clientRepository = clientRepository;
        }

        public virtual ClientModel getClient(string id)
        {
            return clientRepository.getClient(id);
        }

        public virtual List<ClientModel> getClients(string fieldFilter = null, string valueFilter = null)
        {
            return clientRepository.getClients(fieldFilter, valueFilter);
        }

        public virtual List<AnalysisByQuestionDateView> getClientsAndSalesByAnswerAndQuestion(AnswersFilters filters)
        {
            filters.initialDate = DateTimeUtils.convertToInitial((DateTime)filters.initialDate);
            filters.finalDate = DateTimeUtils.convertToFinal((DateTime)filters.finalDate);

            return clientRepository.getClientsAndSalesByAnswerAndQuestion(filters);
        }
    }
}
