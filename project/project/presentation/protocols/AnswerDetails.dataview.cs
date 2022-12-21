using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.presentation.protocols
{
    internal class AnswerDetails
    {
        public string idCompany { get; set; }
        public string idSale { get; set; }
        public string client { get; set; }
        public string seller { get; set; }
        public string status { get; set; }
        public string descriptionQuestion { get; set; }
        public string answer { get; set; }
        public string observation { get; set; }
        public string resolution { get; set; }
    }
}
