using Microsoft.VisualStudio.TestTools.UnitTesting;
using MW.recruitment;
using System;
using System.Collections.Generic;
using System.Globalization;
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
            //given
            string[] dates= { "2001/01/01", "2001/01/01" };
            var expectedStartDate = new DateTime(2001, 01, 01);
            var expectedEndDate = new DateTime(2001, 01, 01);

            //when
            var resultActual = DateRange.CreateInstance(dates);

            //then
            Assert.AreEqual(expectedStartDate.ToString(), resultActual.StartDate.ToString());
            Assert.AreEqual(expectedEndDate.ToString(), resultActual.EndDate.ToString());
        }
        
        [TestMethod()]
        public void CreateInstance_DifferentDates()
        {
            //given
            string[] dates = { "2001/01/01", "2002/01/01" };
            var expectedStartDate = new DateTime(2001, 01, 01);
            var expectedEndDate = new DateTime(2002, 01, 01);

            //when
            var resultActual = DateRange.CreateInstance(dates);

            //then
            Assert.AreEqual(expectedStartDate.ToString(), resultActual.StartDate.ToString());
            Assert.AreEqual(expectedEndDate.ToString(), resultActual.EndDate.ToString());
        }

        [TestMethod()]
        public void CreateInstance_EnglishMonthNamesInParams()
        {
            //given
            string[] dates = { "2001/Jan/01", "2002/01/Feb" };
            var expectedStartDate = new DateTime(2001, 01, 01);
            var expectedEndDate = new DateTime(2002, 02, 01);

            //when
            var resultActual = DateRange.CreateInstance(dates);

            //then
            Assert.AreEqual(expectedStartDate.ToString(), resultActual.StartDate.ToString());
            Assert.AreEqual(expectedEndDate.ToString(), resultActual.EndDate.ToString());
        }

        [TestMethod()]
        public void CreateInstance_ShortYearsInParams()
        {
            //given
            string[] dates = { "01/01/01", "01/01/01" };
            var expectedStartDate = new DateTime(2001, 01, 01);
            var expectedEndDate = new DateTime(2001, 01, 01);

            //when
            var resultActual = DateRange.CreateInstance(dates);

            //then
            Assert.AreEqual(expectedStartDate.ToString(), resultActual.StartDate.ToString());
            Assert.AreEqual(expectedEndDate.ToString(), resultActual.EndDate.ToString());
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentsNumberException), "Two arguments needed.")]
        public void CreateInstance_OnlyOneParam_ThrowsException()
        {
            //given
            string[] dates = { "2001/01/01" };

            //when
            DateRange.CreateInstance(dates).ToString();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentsOrderException), "Wrong arguments order.")]
        public void CreateInstance_WrongParamOrder_ThrowsException()
        {
            //given
            string[] dates = { "2001/01/01", "1999/01/01" };

            //when
            DateRange.CreateInstance(dates).ToString();
        }

        [TestMethod()]
        [ExpectedException(typeof(DateFormatException), "Wrong date format.")]
        public void CreateInstance_WrongFormatParam_ThrowsException()
        {
            //given
            string[] dates = { "2001/01/01", "asdf" };

            //when
            DateRange.CreateInstance(dates).ToString();
        }
    }
}