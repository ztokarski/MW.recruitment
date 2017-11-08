using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    public class DateFormatException : Exception
    {
        public DateFormatException() : base($"Wrong date format. Your culture's date format is: {CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern} (e.g. {DateTime.Now.ToShortDateString()})")
        {
        }
    }

    public class ArgumentsNumberException : Exception
    {
        public ArgumentsNumberException() : base($"Please enter exactly 2 dates. Your current culture date format is: {CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern}")
        {
        }
    }

    public class ArgumentsOrderException : Exception
    {
        public ArgumentsOrderException() : base($"The First Date is greater than the Second Date")
        {
        }
    }
}
