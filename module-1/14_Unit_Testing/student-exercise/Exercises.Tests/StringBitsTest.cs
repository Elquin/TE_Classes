using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void StringBitsHlo()
        {
            //Arrange
            StringBits word = new StringBits();

            //Act
            string actualResult = word.GetBits("Hello");

            //Assert
            Assert.AreEqual("Hlo", actualResult);

        }
        [TestMethod]
        public void StringBitsH()
        {
            //Arrange
            StringBits word = new StringBits();

            //Act
            string actualResult = word.GetBits("Hi");

            //Assert
            Assert.AreEqual("H", actualResult);

        }
        [TestMethod]
        public void StringBitsHello()
        {
            //Arrange
            StringBits word = new StringBits();

            //Act
            string actualResult = word.GetBits("Heeololeo");

            //Assert
            Assert.AreEqual("Hello", actualResult);

        }
    }
}
