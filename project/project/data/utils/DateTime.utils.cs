using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project.data.utils
{
    public class DateTimeUtils
    {
        public static DateTime convertToInitial (DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 0, 0, 0);
        }        
        public static DateTime convertToFinal (DateTime value)
        {
            return new DateTime(value.Year, value.Month, value.Day, 23, 59, 59);
        }
    }
}
