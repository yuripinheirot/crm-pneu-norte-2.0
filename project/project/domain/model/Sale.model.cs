using project.domain.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.model
{
    public class SaleModel : ISaleModel
    {
        public string id { get; set; }
        public string idCompany { get; set; }
        public decimal liquidValue { get; set; }
        public DateTime dateSale { get; set; }
        public string client { get; set; }
        public string clientCpfCnpj { get; set; }
        public string posSale { get; set; }
        public string seller { get; set; }
    }
}
