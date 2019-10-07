using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Tests
{
    [TestClass()]
    public class KataFizzBuzzTests
    {
     [DataTestMethod]
     [DataRow(3, "Fizz")]
     [DataRow(5, "Buzz")]
     public void FizzBuzzOne(int numberToTest, string expectedResult)
     {
         //Arrange
         // Create a new KataFizzBuzz Object
         KataFizzBuzz number = new KataFizzBuzz();

         //Act
         string actualResult = number.ToFizzBuzz(numberToTest);

         //Assert
         Assert.AreEqual(expectedResult, actualResult);

     }
            
        

    }
}
