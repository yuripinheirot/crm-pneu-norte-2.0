using project.domain.model.reports.questionnaireAnalysis;
using System.Collections.Generic;

namespace project.domain.interfaces.usecases.reports
{
    public interface IPostQuestionnaireAnalysisReport
    {
        List<QuestionnaireAnalysisReportModel> postQuestionnaireAnalysisReport(QuestionnaireAnalysisFilters filters);
    }
}
