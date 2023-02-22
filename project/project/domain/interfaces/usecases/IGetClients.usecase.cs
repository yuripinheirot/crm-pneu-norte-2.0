using project.domain.model.entities;
using System.Collections.Generic;

namespace project.domain.interfaces.usecases
{
    public interface IGetClients
    {
        List<ClientModel> getClients(string fieldFilter, string valueFilter);
    }
}
