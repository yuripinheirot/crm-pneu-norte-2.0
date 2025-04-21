using project.infra.db.firebird.config;
using project.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.sales
{
    internal class GetSale
    {
        public virtual SaleModel execute(string idCompany, string idSale)
        {
            using (var db = new FbDbContext())
            {
                string whereClause =
                        $"where                                                                                         " +
                        $"ped.codigo = '{idSale}' and ped.empresa = '{idCompany}'                                       " +
                        $"and ped.tipopedido <> 'O'                                                                     " +
                        $"and ped.dataefe is not null                                                                   " +
                        $"order by                                                                                      " +
                        $"ped.codigo desc                                                                               ";

                var sale = db.Database.SqlQuery<SaleModel>(SaleQueryConstant.query() + whereClause).ToList().FirstOrDefault();

                if (sale == null)
                {
                    return null;
                }

                return new SaleModel()
                {
                    idCompany = sale.idCompany,
                    id = sale.id,
                    liquidValue = sale.liquidValue,
                    posSale = sale.posSale,
                    seller = sale.seller,
                    dateSale = sale.dateSale,
                    client = sale.client,
                    clientCpfCnpj = sale.clientCpfCnpj,
                };
            }
        }
    }
}
