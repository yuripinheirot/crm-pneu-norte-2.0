using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.presentation.protocols
{
    internal class SalesFilters
    {
        public string idCompany { get; set; }
        public string idClient { get; set; }
        public DateTime initialDate { get; set; }
        public DateTime finalDate { get; set; }
        public string posSale { get; set; }
    }
}
