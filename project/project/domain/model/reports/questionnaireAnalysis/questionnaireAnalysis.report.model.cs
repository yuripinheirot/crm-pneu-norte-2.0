namespace project.domain.model.reports.questionnaireAnalysis
{
    public class QuestionnaireAnalysisReportModel
    {
        public string idClient { get; set; }
        public string clientName { get; set; }
        public string clientFantasy { get; set; }
        public string answer { get; set; }
        public string answerStatus { get; set; }
        public string idQuestion { get; set; }
        public string descriptionQuestion { get; set; }
        public string posSaleTypeQuestion { get; set; }
        public string idSale { get; set; }
    }
}
