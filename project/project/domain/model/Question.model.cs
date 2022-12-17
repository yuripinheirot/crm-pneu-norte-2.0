using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.model
{
    internal class QuestionModel
    {
        public string id { get; set; }
        public string description { get; set; }
        public string posSale { get; set; }
        public bool active { get; set; } = true;
        public List<string> answers { get; set; }
    }
}
