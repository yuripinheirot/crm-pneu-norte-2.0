using project.data.usecases.doblist;
using project.domain.interfaces.Struct;
using project.domain.model.entities;
using project.presentation.protocols;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.business.usecases.doblist
{
    public class DoblistBusiness : IDobListBusiness
    {
        DobListData doblistData;

        public DoblistBusiness(DobListData doblistData)
        {
            this.doblistData = doblistData;
        }

        public List<DobListModel> getDobs(string dobDayMonth, int year)
        {
            return doblistData.getDobs(dobDayMonth, year);
        }

        public void insertDob(DobListDTO dto)
        {
            doblistData.insertDob(dto);
        }
    }
}
