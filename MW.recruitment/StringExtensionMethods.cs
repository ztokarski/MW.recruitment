using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    public static class StringExtensionMethods
    {
        public static bool TryParseToLocalDate(this string dateString, out DateTime result)
        {
            if (DateTime.TryParse(dateString, out result))
            {
                result = DateTime.Parse(dateString);
                return true;
            }
            throw new DateFormatException();
        }
    }
}
