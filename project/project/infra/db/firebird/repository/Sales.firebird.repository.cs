using project.domain.model;
using project.domain.usecases;
using project.infra.db.firebird.config;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.firebird.repository
{
    public class SalesFirebirdRepository : IGetSales, IGetSale
    {
        public SaleModel getSale(string idCompany, string idSale)
        {
            using (var db = new FbDbContext())
            {
                var sale = db.tvenpedido.Where(ped => ped.EMPRESA == idCompany && ped.CODIGO == idSale).First();
                var client = db.trecclientegeral.Where(clt => clt.CODIGO == sale.CLIENTE).First();
                var seller = db.tvenvendedor.Where(sll => sll.CODIGO == sale.VENDEDOR && sll.EMPRESA == sale.EMPRESA).First();

                return new SaleModel()
                {
                    idCompany = sale.EMPRESA,
                    id = sale.CODIGO,
                    liquidValue = sale.VALORLIQUIDO,
                    posSale = "order",
                    seller = seller.NOME,
                    dateSale = sale.DATAEFE,
                    client = client.NOME,
                    clientCpfCnpj = client.CPFCNPJ,
                };
            }
        }

        public List<SaleModel> getSales(SalesFilters filters)
        {
            throw new NotImplementedException();
        }
    }
}
