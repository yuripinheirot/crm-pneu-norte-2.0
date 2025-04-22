using FirebirdSql.Data.FirebirdClient;
using project.infra.db.firebird.config;
using project.models;
using project.presentation.protocols;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.sales
{
    internal class GetSales
    {
        string buildMoreConditionalWhere(SalesFilters filters)
        {
            string _query = "";

            if (!string.IsNullOrWhiteSpace(filters.idClient))
            {
                _query += $" and ped.cliente = '{filters.idClient}'";
            };
            if(!string.IsNullOrEmpty(filters.idCompany))
            {
                _query += $"and ped.empresa = '{filters.idCompany}' ";
            }

            return _query;
        }

        private List<SaleModel> getSales(SalesFilters filters)
        {
            using (var db = new FbDbContext())
            {


                var whereClause =
                    $"                                                                                             " +
                    $"where                                                                                        " +
                    $"ped.dataefe between '{filters.initialDate:dd.MM.yyyy}' and '{filters.finalDate:dd.MM.yyyy}'  " +
                    $"and ped.tipopedido <> 'O'                                                                    " +
                    $"and ped.dataefe is not null                                                                  " +
                    $"{buildMoreConditionalWhere(filters)}                                                         " +
                    $"order by                                                                                     " +
                    $"ped.codigo ASC                                                                               ";

                var command = new FbCommand(SaleQueryConstant.query() + whereClause, db.Database.Connection as FbConnection);
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

        public virtual List<SaleModel> execute(SalesFilters filters)
        {
            filters.initialDate = new DateTime(filters.initialDate.Year, filters.initialDate.Month, filters.initialDate.Day, 0, 0, 0);
            filters.finalDate = new DateTime(filters.finalDate.Year, filters.finalDate.Month, filters.finalDate.Day, 23, 59, 59);
            filters.posSale = string.IsNullOrWhiteSpace(filters.posSale) ? "" : TextUtils.translatePosSaleData(filters.posSale);

            return getSales(filters);
        }
    }
}
