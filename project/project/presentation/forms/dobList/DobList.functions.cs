using project.main.factories.business;
using project.presentation.utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project.presentation.protocols;

namespace project.presentation.forms.dobList
{
    public class DobListFunctions
    {
        static public void renderClientsOnGrid(DataGridView dgv,  string filterValue)
        {
            var clients = ClientFactory.handle.getClients("dob", filterValue);
            var dataSource = GridUtils.ToDataTable(clients);

            dgv.DataSource = dataSource;
        }

        static public void saveDob(DobListDTO dto)
        {

        }
    }
}
