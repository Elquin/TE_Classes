using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class DateFashionTest
    {
        [TestMethod]
        public void GetTableYes()
        {
            //Arrange
            //Create an instance of StringExercises
            DateFashion getTable = new DateFashion();

            //Act
            int actualResult = getTable.GetATable(9,8);

            //Assert
            Assert.AreEqual(2, actualResult);
        }
        [TestMethod]
        public void GetTableMaybe()
        {
            //Arrange
            DateFashion getTable = new DateFashion();

            //Act
            int actualResult = getTable.GetATable(3, 5);

            //Assert
            Assert.AreEqual(1, actualResult);
        }
        [DataTestMethod]
        [DataRow(2, 5, 0)]
        [DataRow(1, 7, 0)]
        [DataRow(0, 2, 0)]
        public void GetTableNo(int a, int b, int actualResult)
        {
            //Arrange
            DateFashion getTable = new DateFashion();

            //Act
            //int actualResult = getTable.GetATable(2, 6);

            //Assert
            Assert.AreEqual(0, actualResult);
        }
    }
}
