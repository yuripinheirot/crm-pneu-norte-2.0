using project.data.usecases.answers;
using project.models;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.usecases.sales
{
    internal class GetSalesWithoutCrm
    {
        GetSales getSales = new GetSales();
        GetAnswers getAnswers = new GetAnswers();

        private List<SaleModel> salesWithoutCrm(List<SaleModel> sales, List<AnswerModel> answers)
        {
            List<SaleModel> salesWithoutCrm = new List<SaleModel>();

            foreach (var sale in sales)
            {
                var hasCrm = answers.Any(a => a.idSale == sale.id);
                if (!hasCrm)
                {
                    salesWithoutCrm.Add(sale);
                }
            }

            return salesWithoutCrm.ToList();

        }

        public List<SaleModel> execute(SalesFilters filters)
        {
            var answersFilters = new AnswersFilters()
            {
                idCompany = filters.idCompany,
            };

            var allSales = getSales.execute(filters);
            var allAnswers = getAnswers.execute(answersFilters);

            return salesWithoutCrm(allSales, allAnswers);
        }
    }
}
