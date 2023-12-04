using project.domain.model.entities;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces.usecases
{

    public interface IGetDobs
    {
        List<DobListModel> getDobs(string dobDayMonth, int year);
    }

}
