using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace specs.suport.helpers
{
    public class AssertObjectAreEqualHelper
    {
        public static void verify(object expected, object actual)
        {
            PropertyInfo[] properties = expected.GetType().GetProperties();
            foreach (var property in properties)
            {
                string propertyName = property.Name;
                object expectedValue = property.GetValue(expected);
                object actualValue = property.GetValue(actual);
                Assert.AreEqual(expectedValue, actualValue, $"\nProperty '{propertyName}' has different values. Expected: {expectedValue} but was: {actualValue}");
            }
        }
    }
}
