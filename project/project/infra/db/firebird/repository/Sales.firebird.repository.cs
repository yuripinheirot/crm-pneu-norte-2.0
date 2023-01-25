using FirebirdSql.Data.FirebirdClient;
using project.domain.model;
using project.domain.usecases;
using project.infra.db.firebird.config;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.firebird.repository
{
    public class SalesFirebirdRepository : IGetSales, IGetSale
    {
        static string saleQuery =
                 "select                                                                                        " +
                 "ped.empresa as idCompany,                                                                     " +
                 "ped.codigo as id,                                                                             " +
                 "ped.valorliquido as liquidValue,                                                              " +
                 "ped.dataefe as dateSale,                                                                      " +
                 "clg.codigo || '-' || clg.nome as client,                                                      " +
                 "clg.cpfcnpj as clientCpfCnpj,                                                                 " +
                 "                                                                                              " +
                 "(                                                                                             " +
                 "select                                                                                        " +
                 "iif(list(DISTINCT CASE c.TIPO                                                                 " +
                 "WHEN 'R' THEN 'VENDAS'                                                                        " +
                 "ELSE 'SERVIÇOS'                                                                               " +
                 "END) LIKE '%SERVIÇOS%', 'order', 'sale')                                                      " +
                 "from tvenproduto a                                                                            " +
                 "left outer join testproduto b on(a.empresa = b.empresa and a.produto = b.produto)             " +
                 "left outer join testgrupo c on(a.empresa = c.empresa and b.grupo = c.codigo)                  " +
                 "where                                                                                         " +
                 "a.pedido = ped.codigo                                                                         " +
                 "and a.empresa = ped.empresa                                                                   " +
                 ") as posSale,                                                                                 " +
                 "vdd.nome as seller                                                                            " +
                 "                                                                                              " +
                 "from tvenpedido ped                                                                           " +
                 "left outer join trecclientegeral clg on(ped.cliente = clg.codigo)                             " +
                 "left outer join tvenvendedor vdd on(ped.empresa = vdd.empresa and ped.vendedor = vdd.codigo)  ";
        public SaleModel getSale(string idCompany, string idSale)
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

                var sale = db.Database.SqlQuery<SaleModel>(saleQuery + whereClause).ToList().FirstOrDefault();
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

        public List<SaleModel> getSales(SalesFilters filters)
        {
            using (var db = new FbDbContext())
            {
                string buildMoreConditionalWhere()
                {
                    string _query = "";
                    if (!string.IsNullOrWhiteSpace(filters.idClient))
                    {
                        _query += $" and ped.cliente = '{filters.idClient}'";
                    };

                    return _query;
                };

                var whereClause =
                    $"                                                                                             " +
                    $"where                                                                                        " +
                    $"ped.dataefe between '{filters.initialDate:dd.MM.yyyy}' and '{filters.finalDate:dd.MM.yyyy}'  " +
                    $"and ped.empresa = '{filters.idCompany}'                                                      " +
                    $"and ped.tipopedido <> 'O'                                                                    " +
                    $"and ped.dataefe is not null                                                                  " +
                    $"{buildMoreConditionalWhere()}                                                                " +
                    $"order by                                                                                     " +
                    $"ped.codigo ASC                                                                               ";

                var command = new FbCommand(saleQuery + whereClause, db.Database.Connection as FbConnection);
                db.Database.Connection.Open();

                FbDataAdapter adapter = new FbDataAdapter();
                DataTable table = new DataTable();
                adapter.SelectCommand = command;
                adapter.Fill(table);

                return table.AsEnumerable()
                   .Select(row => new SaleModel
                   {
                       id = row.Field<string>("id"),
                       client = row.Field<string>("client"),
                       clientCpfCnpj = row.Field<string>("clientCpfCnpj"),
                       idCompany = row.Field<string>("idCompany"),
                       dateSale = row.Field<DateTime>("dateSale"),
                       liquidValue = row.Field<decimal>("liquidValue"),
                       posSale = row.Field<string>("posSale"),
                       seller = row.Field<string>("seller"),
                   }).ToList();
            }
        }
    }
}
