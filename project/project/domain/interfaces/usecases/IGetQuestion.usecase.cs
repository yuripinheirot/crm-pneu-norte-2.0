using project.domain.model.entities;
using System.Collections.Generic;

namespace project.domain.interfaces.usecases
{

    public interface IGetQuestions
    {
        List<QuestionModel> getQuestions();
    }
}
