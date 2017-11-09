using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    public class DateRange
    {
        DateTime startDate;
        DateTime endDate;
        string separator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;


        public DateRange(DateTime startDate, DateTime endDate)
        {
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public static DateRange CreateInstance(string[] dates)
        {
            InputValidator.Validate(dates);
            dates[0].TryParseToLocalDate(out DateTime startDate);
            dates[1].TryParseToLocalDate(out DateTime endDate);
            return new DateRange(startDate, endDate);
        }

        override
        public string ToString()
        {
            if (YearsAreDifferent())
                return $"{startDate.ToShortDateString()} - {endDate.ToShortDateString()}";
            else if (MonthsAreDifferent())
                return $"{GetDay(startDate)}{separator}{GetMonth(startDate)} - {GetDay(endDate)}{separator}{GetMonth(endDate)}{separator}{endDate.Year}";
            else if (DaysAreDifferent())
                return $"{startDate.Day} - {endDate.Day}{separator}{startDate.Month}{separator}{startDate.Year}";
            else
                return startDate.ToShortDateString();
        }

        private bool YearsAreDifferent()
        {
            return startDate.Year != endDate.Year;
        }

        private bool DaysAreDifferent()
        {
            return startDate.Day != endDate.Day;
        }

        private bool MonthsAreDifferent()
        {
            return startDate.Month != endDate.Month;
        }

        

        public string GetDay(DateTime datetime)
        {
            return datetime.ToString("dd", CultureInfo.CurrentCulture);
        }

        public string GetMonth(DateTime datetime)
        {
            return datetime.ToString("MM", CultureInfo.CurrentCulture);
        }

       
    }
}
