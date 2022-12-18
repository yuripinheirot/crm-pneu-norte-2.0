using project.data.usecases.answers;
using project.presentation.errors.exceptions;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.validations.crm
{
    internal class VerifyIfExistsCurrentCrmValidation
    {
        AnswersData answersData;
        public VerifyIfExistsCurrentCrmValidation(AnswersData answersData)
        {
            this.answersData = answersData;
        }

        public void validate(string idCompany, string idSale)
        {
            var crm = answersData.getCrm(idSale, idCompany);

            if (crm.Count > 0)
            {
                throw new PresentationException("Atenção!", "Já existe um CRM cadastrado para este pedido!");
            }
        }

    }
}
