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
        DateTime StartDate;
        DateTime EndDate;
        string separator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;


        private DateRange(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
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
                return $"{StartDate.ToShortDateString()} - {EndDate.ToShortDateString()}";
            else if (MonthsAreDifferent())
                return $"{GetDay(StartDate)}{separator}{GetMonth(StartDate)} - {GetDay(EndDate)}{separator}{GetMonth(EndDate)}{separator}{EndDate.Year}";
            else if (DaysAreDifferent())
                return $"{StartDate.Day} - {EndDate.Day}{separator}{StartDate.Month}{separator}{StartDate.Year}";
            else
                return StartDate.ToShortDateString();
        }

        private bool YearsAreDifferent()
        {
            return StartDate.Year != EndDate.Year;
        }

        private bool DaysAreDifferent()
        {
            return StartDate.Day != EndDate.Day;
        }

        private bool MonthsAreDifferent()
        {
            return StartDate.Month != EndDate.Month;
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
