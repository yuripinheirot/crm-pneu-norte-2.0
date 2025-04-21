using System.Collections.Generic;

namespace project.models
{
    public class QuestionModel 
    {
        public string id { get; set; }
        public string description { get; set; }
        public string posSale { get; set; }
        public bool active { get; set; } = true;
        public List<string> answers { get; set; }
        public List<string> badAnswers { get; set; }
    }
}
