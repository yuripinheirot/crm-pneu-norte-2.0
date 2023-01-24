using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.infra.db.postgres.utils
{
    public interface IValueConverter<T> { }
    public class ArrayConverter : IValueConverter<List<string>>
    {
        public List<string> ConvertFromProvider(object value)
        {
            if (value == null)
                return null;

            var array = (string[])value;
            return array.ToList();
        }

        public object ConvertToProvider(List<string> value)
        {
            if (value == null)
                return null;

            return value.ToArray();
        }

        public Type ProviderClrType => typeof(string[]);

        public Type ClrType => typeof(List<string>);
    }

}
