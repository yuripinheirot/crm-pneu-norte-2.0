using project.domain.interfaces.usecases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces.Struct
{
    public interface ISalesRepository : IGetSales, IGetSale
    {
    }
}
