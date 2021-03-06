using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses.Classes;

namespace TestableClassesTest
{

    [TestClass]
    public class StringExercisesTests
    {


        [TestMethod]
        public void TestMakeAbba1()
        {
            //makeAbba("Hi", "Bye")  "HiByeByeHi"
            //makeAbba("Yo", "Alice")  "YoAliceAliceYo"
            //makeAbba("What", "Up")  "WhatUpUpWhat"

            //Arrange
            //Create an instance of StringExercises
            StringExercises ex = new StringExercises();

            //Act
            string actualResult = ex.MakeAbba("Hi", "Bye");

            //Assert
            Assert.AreEqual("HiByeByeHi", actualResult);

        }

        [TestMethod]
        public void TestMakeAbbaSpaceFirstString()
        {

            //Arrange
            StringExercises ex = new StringExercises();

            //Act
            string actualResult = ex.MakeAbba(" ", "Yeah");

            //Assert
            Assert.AreEqual(" YeahYeah ", actualResult);
        }

        [DataTestMethod]
        [DataRow("Hi", "Bye", "HiByeByeHi", DisplayName ="Hi-Bye")]
        [DataRow(" ", "Yeah", " YeahYeah ", DisplayName ="blank-Yeah")]
        [DataRow("", "", "", DisplayName ="Empty strings")]
        [DataRow(" ", " ", "    ", DisplayName ="Blank strings")]
        public void DataTestMakeAbba(string input1, string input2, string expectedResult)
        {
            //Arrange

            //Act
            string actualResult = ex.MakeAbba(input1, input2);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);
            
        }
    }
}
