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
            //given
            string[] args = { "01/01/01" };

            //when
            InputValidator.CheckInputLength(args);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentsNumberException), "Two arguments needed.")]
        public void CheckInputLength_MoreThan2Params_ThrowsException()
        {
            //given
            string[] args = { "01/01/01", "01/01/01", "01/01/01" };

            //when
            InputValidator.CheckInputLength(args);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentsNumberException), "Two arguments needed.")]
        public void CheckInputLength_WithoutParams_ThrowsException()
        {
            //given
            string[] args = { };

            //when
            InputValidator.CheckInputLength(args);
        }
    }
}

