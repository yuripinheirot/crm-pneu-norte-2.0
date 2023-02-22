using project.domain.interfaces.usecases;

namespace project.domain.interfaces.Struct
{
    public interface IAnswersBusiness :
        IPostAnswers,
        IGetAnswers,
        IGetAnswersNotResolved,
        IGetAnswerDetails,
        IPutAnswer,
        IPostAnswerAlreadyExists
    {
    }
}
