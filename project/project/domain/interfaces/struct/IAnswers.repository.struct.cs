using project.domain.interfaces.usecases;
using project.domain.interfaces.usecases.reports;

namespace project.domain.interfaces.Struct
{
    public interface IAnswersRepository :
        IPostAnswersRepository,
        IGetAnswers,
        IGetAnswersNotResolved,
        IGetAnswerDetails,
        IPutAnswer,
        IPostAnswerAlreadyExists,
        IPostQuestionnaireAnalysisReport
    { }
}
