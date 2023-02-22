using project.domain.model.entities;
using project.presentation.protocols;
using System.Collections.Generic;

namespace project.domain.interfaces.usecases
{
    public interface IGetAnswers
    {
        List<AnswerModel> getAnswers(AnswersFilters filters);
    }
}
