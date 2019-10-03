using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class Lucky13Test
    {

        [TestMethod]
        public void GetLuckyTrue()
        {


            //Arrange
            Lucky13 number = new Lucky13();

            //Act
            bool actualResult = number.GetLucky(new int[] { 0, 2, 4 });

            //Assert
            Assert.AreEqual(true, actualResult);

        }
        [TestMethod]
        public void GetLuckyFalse()
        {


            //Arrange
            Lucky13 number = new Lucky13();

            //Act
            bool actualResult = number.GetLucky(new int[] { 1, 2, 4 });

            //Assert
            Assert.AreEqual(false, actualResult);

        }
    }
}
