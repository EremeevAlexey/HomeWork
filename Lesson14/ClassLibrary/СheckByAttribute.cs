using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class СheckByAttribute
    {
        public void Сheck(object objectToCheck)
        {
            Type type = objectToCheck.GetType();

            PropertyInfo[] propertysInfo = type.GetProperties();

            foreach (var propertyInfo in propertysInfo)
            {
                var attributes = propertyInfo.GetCustomAttributes<RegexMatchAttribute>();
                foreach (var attribute in attributes)
                {
                    if (propertyInfo.PropertyType == typeof(string))
                    {
                        var propertyValue = (string)propertyInfo.GetValue(objectToCheck);
                        if (Regex.IsMatch(propertyValue, attribute.Pattern))
                        {
                            Console.WriteLine($"{propertyInfo.Name}: {propertyValue} соответствует шаблону {attribute.Pattern}");
                        }
                        else
                            Console.WriteLine($"{propertyInfo.Name}: {propertyValue} не соответствует шаблону {attribute.Pattern}");
                    }
                }
            }
        }
    }
}
