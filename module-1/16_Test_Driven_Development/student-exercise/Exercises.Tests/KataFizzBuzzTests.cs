﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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
     [DataRow(3, "Fizz")] //first condition for divisible by 3
     [DataRow(5, "Buzz")] //2nd condition for divisible by 5
     [DataRow(15, "FizzBuzz")] //3rd condition for divisible by 3 AND 5
     [DataRow(22, "22")] //4th step. Testing for NOT divisible by 3 or 5 between 1-100.
     [DataRow(0, "")] //5th step. Added condition that is outside of the range 1-100.
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
