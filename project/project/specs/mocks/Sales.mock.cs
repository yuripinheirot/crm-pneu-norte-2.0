using project.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.specs.mocks
{
    internal class SalesMock
    {
        public static List<SaleModel> sales = new List<SaleModel>()
        {
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000300",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,1),
                client = "00013-JOHN",
                clientCpfCnpj = "123.123.123-12",
                posSale = "order"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000301",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,1),
                client = "00014-KATE",
                clientCpfCnpj = "123.123.123-12",
                posSale = "order"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000302",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,2),
                client = "00015-SAWYER",
                clientCpfCnpj = "123.123.123-12",
                posSale = "order"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000303",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,2),
                client = "00016-JENIFER",
                clientCpfCnpj = "123.123.123-12",
                posSale = "order"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000304",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,3),
                client = "00017-BOB",
                clientCpfCnpj = "123.123.123-12",
                posSale = "sale"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000305",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,5),
                client = "00018-FRED",
                clientCpfCnpj = "123.123.123-12",
                posSale = "sale"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000306",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,6),
                client = "00019-MAI",
                clientCpfCnpj = "123.123.123-12",
                posSale = "sale"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000307",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,11,1),
                client = "00020-KURT",
                clientCpfCnpj = "123.123.123-12",
                posSale = "sale"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000308",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,9),
                client = "00021-JAMES",
                clientCpfCnpj = "123.123.123-12",
                posSale = "sale"
            },
            new SaleModel()
            {
                idCompany = "02",
                idSale = "0000309",
                liquidValue = Convert.ToDecimal(302.43),
                dateSale = new DateTime(2022,12,8),
                client = "00022-AMY",
                clientCpfCnpj = "123.123.123-12",
                posSale = "sale"
            },
        };
    }
}
