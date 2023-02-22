using project.domain.interfaces.usecases;

namespace project.domain.interfaces.Struct
{
    public interface IAnswersData :
        IPostAnswers,
        IGetAnswers,
        IGetAnswersNotResolved,
        IGetAnswerDetails,
        IPutAnswer,
        IPostAnswerAlreadyExists
    { }
}
