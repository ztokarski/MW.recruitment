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
    public class InputValidatorTests
    {

        [TestMethod]
        [ExpectedException(typeof(ArgumentsNumberException),"Two arguments needed.")]
        public void CheckInputLength_OnlyOneParam_ThrowsException()
        {
            string[] args = { "01/01/2001" };
            InputValidator.CheckInputLength(args);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentsOrderException), "Wrong arguments order.")]
        public void CheckInputOrder_WrongParamOrder_ThrowsException()
        {
            string[] args = { "01/01/2001", "01/01/2000" };
            InputValidator.CheckInputOrder(args);
        }
    }
}

