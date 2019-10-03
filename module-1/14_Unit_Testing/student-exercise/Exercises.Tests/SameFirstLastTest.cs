using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {

        [TestMethod]
        public void IsItTheSameTestFalse()
        {


            //Arrange
            SameFirstLast number = new SameFirstLast();

            //Act
            bool actualResult = number.IsItTheSame(new int[] { 1, 2, 3 });

            //Assert
            Assert.AreEqual(false, actualResult);

        }
        [TestMethod]
        public void IsItTheSameTestTrue()
        {


            //Arrange
            SameFirstLast number = new SameFirstLast();

            //Act
            bool actualResult = number.IsItTheSame(new int[] { 1, 2, 3, 1 });

            //Assert
            Assert.AreEqual(true, actualResult);

        }
    }
}
