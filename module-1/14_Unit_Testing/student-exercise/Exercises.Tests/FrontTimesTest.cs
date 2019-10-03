using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [DataTestMethod]
        [DataRow("Chocolate", 2, "ChoCho")]
        [DataRow("Chocolate", 3, "ChoChoCho")]
        [DataRow("Abc", 3, "AbcAbcAbc")]
        [DataRow("Xy", 4, "XyXyXyXy")]
        public void GenerateString(string a, int b, string expectedResult)
        {
            //Arrange
            FrontTimes words = new FrontTimes();

            //Act
            string actualResult = words.GenerateString(a, b);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
        }
    }
}
