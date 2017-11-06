using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    class Program
    {
        static void Main(string[] args)
        {
            var date1 = "1998.10.03";
            var date2 = "1999.10.03";

            date1.TryParseToLocalDate(out DateTime startDate);
            date2.TryParseToLocalDate(out DateTime endDate);

            Console.WriteLine(startDate.ToShortDateString());
            Console.WriteLine(endDate.ToShortDateString());

            var range = new DateRange(startDate, endDate);
            Console.WriteLine(range.DisplayRange());
            
        }
    }


}
