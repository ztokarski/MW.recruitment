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
            //given
            string[] dates= { "2001/01/01", "2001/01/01" };
            var expectedStartDate = new DateTime(2001, 01, 01);
            var expectedEndDate = new DateTime(2001, 01, 01);

            //when
            var resultActual = DateRange.CreateInstance(dates);

            //then
            Assert.AreEqual(expectedStartDate, resultActual.StartDate);
            Assert.AreEqual(expectedEndDate, resultActual.EndDate);
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
            Assert.AreEqual(expectedStartDate, resultActual.StartDate);
            Assert.AreEqual(expectedEndDate, resultActual.EndDate);
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
            Assert.AreEqual(expectedStartDate, resultActual.StartDate);
            Assert.AreEqual(expectedEndDate, resultActual.EndDate);
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
            Assert.AreEqual(expectedStartDate, resultActual.StartDate);
            Assert.AreEqual(expectedEndDate, resultActual.EndDate);
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



        //[TestMethod()]
        //public void CreateInstance_EnglishMonthNamesInParams()
        //{
        //    string[] dates = { "2001/Jan/01", "2002/01/Feb" };
        //    var resultActual = DateRange.CreateInstance(dates).ToString();
        //    var resultExpected = new DateRange(new DateTime(2001, 01, 01), new DateTime(2002, 02, 01)).ToString();
        //    Assert.AreEqual(resultExpected, resultActual);
        //}

        

    }
}