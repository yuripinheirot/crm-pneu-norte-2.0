using System;

namespace project.domain.model.reports.questionnaireAnalysis
{
    public class QuestionnaireAnalysisFilters
    {
        public DateTime? initialDate { get; set; }
        public DateTime? finalDate { get; set; }
        public string idQuestion { get; set; }
        public string idCompany { get; set; }
        public string answer { get; set; }
    }
}
