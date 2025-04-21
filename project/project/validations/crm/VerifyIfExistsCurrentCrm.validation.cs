using project.data.usecases.answers;
using project.models;
using project.presentation.errors.exceptions;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.validations.crm
{
    public delegate void clearScreen();

    public class VerifyIfExistsCurrentCrmValidation
    {
        GetAnswers getAnswers;

        public VerifyIfExistsCurrentCrmValidation(GetAnswers getAnswers)
        {
            this.getAnswers = getAnswers;
        }


        public void validate(AnswersFilters filters, clearScreen clear)
        {
            var crm = getAnswers.execute(filters);

            if (crm.Count > 0)
            {
                clear();
                throw new PresentationException("Atenção!", "Já existe um CRM cadastrado para este pedido!");
            }
        }

    }
}
