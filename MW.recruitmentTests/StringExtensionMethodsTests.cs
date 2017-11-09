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
    public class StringExtensionMethodsTests
    {
        [TestMethod()]
        public void TryParseToLocalDate_CorrectParam_GetTrue()
        {
            var testString = "2001/01/01";
            Assert.IsTrue(testString.TryParseToLocalDate(out DateTime result));
        }

        [TestMethod()]
        public void TryParseToLocalDate_MonthNameParam_GetTrue()
        {
            var testString = "01/Jan/01";
            Assert.IsTrue(testString.TryParseToLocalDate(out DateTime result));
        }

        [TestMethod()]
        public void TryParseToLocalDate_ShortYearParam_GetTrue()
        {
            var testString = "01/01/01";
            Assert.IsTrue(testString.TryParseToLocalDate(out DateTime result));
        }

        [TestMethod()]
        public void TryParseToLocalDate_DifferentSeparatorsParam_GetTrue()
        {
            var testString = "01:01:01";
            Assert.IsTrue(testString.TryParseToLocalDate(out DateTime result));
        }

        [TestMethod]
        [ExpectedException(typeof(DateFormatException),"Wrong date format.")]
        public void TryParseToLocalDate_IncorrectParam_ThrowsDateFormatException()
        {
            var testString = "asdf";
            testString.TryParseToLocalDate(out DateTime result);
        }
    }
}