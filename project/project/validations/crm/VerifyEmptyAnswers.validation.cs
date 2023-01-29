using project.domain.model;
using project.presentation.errors.exceptions;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.validations.crm
{
    public class VerifyEmptyAnswersValidation 
    {
        public void validate(List<PostAnswerDTO> answers)
        {
            foreach (PostAnswerDTO answer in answers)
            {
                if (string.IsNullOrEmpty(answer.answer))
                {
                    throw new PresentationException("Atenção!", "Todas as respostas devem ser preenchidas");
                }
            };
        }
    }
}
