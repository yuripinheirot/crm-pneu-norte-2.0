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
    delegate void clearScreen();
    internal class VerifyIfExistsCurrentCrmValidation
    {
        AnswersData answersData;
        public VerifyIfExistsCurrentCrmValidation(AnswersData answersData)
        {
            this.answersData = answersData;
        }


        public void validate(AnswersFilters filters, clearScreen clear)
        {
            var crm = answersData.getAnswers(filters);

            if (crm.Count > 0)
            {
                clear();
                throw new PresentationException("Atenção!", "Já existe um CRM cadastrado para este pedido!");
            }
        }

    }
}
