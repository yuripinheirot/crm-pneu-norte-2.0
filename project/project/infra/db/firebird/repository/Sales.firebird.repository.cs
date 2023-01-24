using project.domain.model;
using project.domain.usecases;
using project.infra.db.firebird.config;
using project.presentation.protocols;
using project.presentation.utils;
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

                string posSaleQuery()
                {
                    string query =  
                           "select                                                                            " +
                           "iif(count(distinct c.tipo) > 1, 'VENDAS', 'SERVIÇOS')                             " +
                           "from tvenproduto a                                                                " +
                           "left outer join testproduto b on(a.empresa = b.empresa and a.produto = b.produto) " +
                           "left outer join testgrupo c on(a.empresa = c.empresa and b.grupo = c.codigo)      " +
                           "where                                                                             " +
                          $"a.pedido = '{idSale}'                                                             " +
                          $"and a.empresa = '{idCompany}'                                                     ";

                    var result = db.Database.SqlQuery<string>(query).Single();

                    return TextUtils.translatePosSaleData(result);
                }


                return new SaleModel()
                {
                    idCompany = sale.EMPRESA,
                    id = sale.CODIGO,
                    liquidValue = sale.VALORLIQUIDO,
                    posSale = posSaleQuery(),
                    seller = seller.NOME,
                    dateSale = sale.DATAEFE,
                    client = client.CODIGO + "-" + client.NOME,
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
