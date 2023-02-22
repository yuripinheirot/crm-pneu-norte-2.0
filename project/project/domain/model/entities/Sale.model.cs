using project.domain.interfaces.entities;
using System;

namespace project.domain.model.entities
{
    public class SaleModel : ISaleEntity
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
