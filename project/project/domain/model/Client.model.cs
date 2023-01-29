using project.domain.interfaces.entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace project.domain.model
{
    public class ClientModel : IClientEntity
    {
        public string id { get; set; }
        public string name { get; set; }
        public string nameFantasy { get; set; }
        public string cpfCnpj { get; set; }
        public string phone { get; set; }

        public object acessByProp(string propertyName)
        {
            Type myType = typeof(ClientModel);
            PropertyInfo myPropInfo = myType.GetProperty(propertyName);

            return myPropInfo.GetValue(this, null);
        }
    }
}
