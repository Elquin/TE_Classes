using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        //Given 2 strings, return their concatenation, except omit the first char of each.The strings will
        // be at least length 1.
        // GetPartialString("Hello", "There") → "ellohere"
        // GetPartialString("java", "code") → "avaode"	
        // GetPartialString("shotl", "java") → "hotlava"

        [TestMethod]
        public void NonStartTestWord1()
        {


            //Arrange
            NonStart word = new NonStart();

            //Act
            string actualResult = word.GetPartialString("Hello", "There");

            //Assert
            Assert.AreEqual("ellohere", actualResult);

        }
        [TestMethod]
        public void NonStartTestWord2()
        {


            //Arrange
            NonStart word = new NonStart();

            //Act
            string actualResult = word.GetPartialString("shotl", "java");

            //Assert
            Assert.AreEqual("hotlava", actualResult);

        }
    }
}
