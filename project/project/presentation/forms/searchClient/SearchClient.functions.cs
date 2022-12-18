using project.main.factories.business;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project.presentation.forms.searchClient
{
    internal class SearchClientFunctions
    {
        string convertClientSearchBy(string searchBy)
        {
            switch (searchBy)
            {
                case "RAZÃO":
                    return "name";
                case "FANTASIA":
                    return "nameFantasy";
                case "CPF/CNPJ":
                    return "cpfCnpj";
                case "FONE":
                    return "phone";
                default:
                    throw new Exception("Unexpected searchBy client");
            }
        }
        public void renderClientsOnGrid(DataGridView dgv, string fieldFilter, string filterValue)
        {
            var clients = ClientFactory.handle.getClients(convertClientSearchBy(fieldFilter), filterValue);
            var dataSource = GridUtils.ToDataTable(clients);

            dgv.DataSource = dataSource;
        }
    }
}
