using project.data.usecases.doblist;
using project.domain.interfaces.Struct;
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

        public void insertDob(DobListDTO dto)
        {
            doblistData.insertDob(dto);
        }
    }
}
