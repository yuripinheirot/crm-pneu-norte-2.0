using System;

namespace project.domain.model
{
    internal class Answer
    {
        public int id { get; set; }
        public int idQuestion { get; set; }
        public string idSale { get; set; }
        public string idClient { get; set; }
        public string status { get; set; }
        public string answer { get; set; }
        public string observation { get; set; }
        public string resolution { get; set; }
        public DateTime updatedAt { get; set; }
        public string idCompany { get; set; }
    }
}
