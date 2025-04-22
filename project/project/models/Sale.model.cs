using System;

namespace project.models
{
    public class SaleModel
    {
        public SaleModel() { }

        public SaleModel(SaleModel sale)
        {
            id = sale.id;
            idCompany = sale.idCompany;
            liquidValue = sale.liquidValue;
            dateSale = sale.dateSale;
            client = sale.client;
            clientCpfCnpj = sale.clientCpfCnpj;
            posSale = sale.posSale;
            seller = sale.seller;
        }

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
