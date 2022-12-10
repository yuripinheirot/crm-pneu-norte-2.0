using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.model
{
    internal class Sale
    {
        public string idCompany { get; set; }
        public string idSale { get; set; }
        public decimal liquidValue { get; set; }
        public DateTime dateSale { get; set; }
        public string client { get; set; }
        public string clientCpfCnpj { get; set; }
        public string posSale { get; set; }
    }
}
