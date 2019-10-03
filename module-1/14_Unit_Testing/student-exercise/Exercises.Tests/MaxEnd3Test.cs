using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {

        [TestMethod]
        public void MakeArray3()
        {


            //Arrange
            MaxEnd3 number = new MaxEnd3();

            //Act
            int[] actualResult = number.MakeArray(new int[] { 1, 2, 3 });

            //Assert
            CollectionAssert.AreEqual(new int[]{ 3, 3, 3}, actualResult);

        }
        [TestMethod]
        public void MakeArray11()
        {


            //Arrange
            MaxEnd3 number = new MaxEnd3();

            //Act
            int[] actualResult = number.MakeArray(new int[] { 11, 5, 9 });

            //Assert
            CollectionAssert.AreEqual(new int[] { 11, 11, 11 }, actualResult);

        }
    }
}
