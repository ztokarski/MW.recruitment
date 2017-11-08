using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    public class Application
    {
        string[] dates;

        public Application(string[] dates)
        {
            this.dates = dates;
        }


        public void Run()
        {
            try
            {
                var range = DateRange.CreateInstance(dates);
                Console.WriteLine(range.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}

