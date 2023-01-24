using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces
{
    public interface IAnswerModel
    {
        string id { get; set; }
        string idQuestion { get; set; }
        string idSale { get; set; }
        string idClient { get; set; }
        string status { get; set; }
        string answer { get; set; }
        string observation { get; set; }
        string resolution { get; set; }
        DateTime updatedAt { get; set; }
        DateTime createdAt { get; set; }
        string idCompany { get; set; }
    }
}
