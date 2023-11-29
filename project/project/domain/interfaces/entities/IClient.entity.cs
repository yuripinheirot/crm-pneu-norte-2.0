using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.interfaces.entities
{
    public interface IClientEntity
    {
        string id { get; set; }
        string name { get; set; }
        string nameFantasy { get; set; }
        string cpfCnpj { get; set; }
        string phone { get; set; }
        DateTime? dob { get; set; }
        object acessByProp(string propertyName);
    }
}
