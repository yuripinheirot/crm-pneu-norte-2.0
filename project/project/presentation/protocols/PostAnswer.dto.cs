using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.presentation.protocols
{
    internal class PostAnswerDTO
    {
        public string idQuestion { get; set; }
        public string idSale { get; set; }
        public string idClient { get; set; }
        public string status { get; set; }
        public string answer { get; set; }
        public string observation { get; set; }
        public DateTime? updatedAt { get; set; }
        public string idCompany { get; set; }
    }
}
