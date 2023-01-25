using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces
{
    public interface ISaleModel
    {
        string id { get; set; }
        string idCompany { get; set; }
        decimal liquidValue { get; set; }
        DateTime dateSale { get; set; }
        string client { get; set; }
        string clientCpfCnpj { get; set; }
        string posSale { get; set; }
        string seller { get; set; }
    }
}
