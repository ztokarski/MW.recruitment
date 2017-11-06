using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    public static class StringExtensionMethods
    {
        public static bool TryParseToLocalDate(this string dateString)
        {
            try
            {
                DateTime.Parse(dateString);
                return true;
            }
            catch (FormatException)
            {
                Console.WriteLine("{0} - This is wrong date format. Your System date format is: {1}", dateString, DateTime.Now.ToShortDateString());
            }
            return false;
        }
    }
}
