using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.sales
{
    internal class SaleQueryConstant
    {
        public static string query()
        {
            return
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
        }
    }
}
