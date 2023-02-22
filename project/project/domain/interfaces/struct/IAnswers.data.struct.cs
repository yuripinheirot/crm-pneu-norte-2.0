using project.domain.interfaces.usecases;
using project.domain.interfaces.usecases.reports;

namespace project.domain.interfaces.Struct
{
    public interface IAnswersData :
        IPostAnswers,
        IGetAnswers,
        IGetAnswersNotResolved,
        IGetAnswerDetails,
        IPutAnswer,
        IPostAnswerAlreadyExists,
        IPostQuestionnaireAnalysisReport
    { }
}
