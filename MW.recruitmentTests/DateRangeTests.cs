using Microsoft.VisualStudio.TestTools.UnitTesting;
using MW.recruitment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW.recruitment.Tests
{
    [TestClass()]
    public class DateRangeTests
    {
        [TestMethod()]
        public void CreateInstance_TheSameDates()
        {
            string[] dates= { "2001/01/01", "2001/01/01" };
            var resultActual = DateRange.CreateInstance(dates).ToString();
            var resultExpected = new DateRange(new DateTime(2001,01,01), new DateTime(2001,01,01)).ToString();
            Assert.AreEqual(resultExpected, resultActual); 
        }

        [TestMethod()]
        public void CreateInstance_DifferentDates()
        {
            string[] dates = { "2001/01/01", "2002/01/01" };
            var resultActual = DateRange.CreateInstance(dates).ToString();
            var resultExpected = new DateRange(new DateTime(2001, 01, 01), new DateTime(2002, 01, 01)).ToString();
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod()]
        public void CreateInstance_EnglishMonthNamesInParams()
        {
            string[] dates = { "2001/Jan/01", "2002/01/Feb" };
            var resultActual = DateRange.CreateInstance(dates).ToString();
            var resultExpected = new DateRange(new DateTime(2001, 01, 01), new DateTime(2002, 02, 01)).ToString();
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod()]
        public void CreateInstance_ShortYearsInParams()
        {
            string[] dates = { "01/01/01", "01/01/01" };
            var resultActual = DateRange.CreateInstance(dates).ToString();
            var resultExpected = new DateRange(new DateTime(2001, 01, 01), new DateTime(2001, 01, 01)).ToString();
            Assert.AreEqual(resultExpected, resultActual);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentsNumberException), "Two arguments needed.")]
        public void CreateInstance_OnlyOneParam_ThrowsException()
        {
            string[] dates = { "2001/01/01" };
            DateRange.CreateInstance(dates).ToString();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentsOrderException), "Wrong arguments order.")]
        public void CreateInstance_WrongParamOrder_ThrowsException()
        {
            string[] dates = { "2001/01/01", "1999/01/01" };
            DateRange.CreateInstance(dates).ToString();
        }

        [TestMethod()]
        [ExpectedException(typeof(DateFormatException), "Wrong date format.")]
        public void CreateInstance_WrongFormatParam_ThrowsException()
        {
            string[] dates = { "2001/01/01", "asdf" };
            DateRange.CreateInstance(dates).ToString();
        }

        

    }
}