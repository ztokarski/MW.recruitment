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

        public string DisplayRange()
        {
            if (this.StartDate > this.EndDate)
                return "Error. The StartDate is greater than the EndDate.";
            else if (this.StartDate == this.EndDate)
                return this.StartDate.ToShortDateString();
            else if (this.StartDate.Year == this.EndDate.Year && this.StartDate.Month == this.EndDate.Month)
                return string.Format("{0} - {1}.{2}.{3}", this.StartDate.Day, this.EndDate.Day, this.StartDate.Month, this.StartDate.Year);
            else if (this.StartDate.Year == this.EndDate.Year)
                return string.Format("{0}.{1} - {2}.{3}.{4}", this.StartDate.Day, this.StartDate.Month, this.EndDate.Day, this.EndDate.Month, this.EndDate.Year);
            else
                return string.Format("{0}.{1}.{2} - {3}.{4}.{5}", this.StartDate.Day, this.StartDate.Month, this.StartDate.Year, this.EndDate.Day, this.EndDate.Month, this.EndDate.Year);
        }

    }
}
