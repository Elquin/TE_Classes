using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{

    [TestClass()]
    public class KataPotterTests
    {
        [DataTestMethod]
        [DataRow(2, 2, 2, 1, 1, 51.20)] //first condition to result in 51.20
        public void GetCostKata(int[] books, decimal expectedResult)
        {
            //Arrange
            // Create a new KataPotter Object
            KataPotter number = new KataPotter();

            //Act
            decimal actualResult = number.GetCost(books); //Generated method on KataPotter by creating method in test first.

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
