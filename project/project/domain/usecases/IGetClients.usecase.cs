using project.domain.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.usecases
{
    internal interface IGetClients
    {
        List<ClientModel> getClients(string fieldFilter, string valueFilter);
    }
}
