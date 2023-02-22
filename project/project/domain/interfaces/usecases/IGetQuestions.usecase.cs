using project.domain.model.entities;

namespace project.domain.interfaces.usecases
{
    public interface IGetQuestion
    {
        QuestionModel getQuestion(string idQuestion);
    }
}
