using project.domain.interfaces.usecases;

namespace project.domain.interfaces.Struct
{
    public interface IAnswersRepository :
        IPostAnswersRepository,
        IGetAnswers,
        IGetAnswersNotResolved,
        IGetAnswerDetails,
        IPutAnswer,
        IPostAnswerAlreadyExists
    { }
}
