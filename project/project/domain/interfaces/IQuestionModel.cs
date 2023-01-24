using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces
{
    public interface IQuestionModel
    {
       string id { get; set; }
       string description { get; set; }
       string posSale { get; set; }
       bool active { get; set; }
       List<string> answers { get; set; }
       List<string> badAnswers { get; set; }
    }
}
