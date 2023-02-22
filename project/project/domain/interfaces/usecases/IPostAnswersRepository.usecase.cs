using project.domain.model.entities;
using System.Collections.Generic;

namespace project.domain.interfaces.usecases
{
    public interface IPostAnswersRepository
    {
        void addAnswersRepository(List<AnswerModel> answers);

    }
}
