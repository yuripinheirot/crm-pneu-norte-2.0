using System;

namespace project.models
{
    public class AnswerModel
    {
        public string id { get; set; }
        public string idQuestion { get; set; }
        public string idSale { get; set; }
        public string idClient { get; set; }
        public string status { get; set; }
        public string answer { get; set; }
        public string observation { get; set; }
        public string resolution { get; set; }
        public DateTime updatedAt { get; set; }
        public DateTime createdAt { get; set; }
        public string idCompany { get; set; }
    }
}
