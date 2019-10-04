using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        //    Return true if the given non-negative number is 1 or 2 less than a multiple of 20.So for example 38
        //and 39 return true, but 40 returns false.

        //(Hint: Think "mod".)
        // less20(18) → true
        // less20(19) → true
        // less20(20) → false

        [DataTestMethod]
        [DataRow(18, true)]
        [DataRow(19, true)]
        [DataRow(20, false)]
        [DataRow(39, true)]
        [DataRow(58, true)]
        [DataRow(60, false)]
        public void IsLessThanMultipleOf20(int a, bool expectedResult)
        {
            //Arrange
            Less20 number = new Less20();

            //Act
            bool actualResult = number.IsLessThanMultipleOf20(a);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
