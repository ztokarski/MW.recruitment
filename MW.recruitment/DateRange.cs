using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment
{
    public class DateRange
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public DateRange(DateTime startDate, DateTime endDate)
        {
            StartDate = startDate;
            EndDate = endDate;
        }

        public string DisplayRange(DateRange range)
        {
            if (range.StartDate > range.EndDate)
                return "Error. The StartDate is greater than the EndDate.";
            else if (range.StartDate == range.EndDate)
                return range.StartDate.ToShortDateString();
            else if (range.StartDate.Year == range.EndDate.Year && range.StartDate.Month == range.EndDate.Month)
                return string.Format("{0} - {1}.{2}.{3}", range.StartDate.Day, range.EndDate.Day, range.StartDate.Month, range.StartDate.Year);
            else if (range.StartDate.Year == range.EndDate.Year)
                return string.Format("{0}.{1} - {2}.{3}.{4}", range.StartDate.Day, range.StartDate.Month, range.EndDate.Day, range.EndDate.Month, range.EndDate.Year);
            else
                return string.Format("{0}.{1}.{2} - {3}.{4}.{5}", range.StartDate.Day, range.StartDate.Month, range.StartDate.Year, range.EndDate.Day, range.EndDate.Month, range.EndDate.Year);
        }

    }
}
