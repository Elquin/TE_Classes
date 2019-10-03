using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNameTest
    {
        [TestMethod]
        public void AnimalGroupNameTests()
        {
            //        *GetHerd("giraffe") → "Tower"
            //    * GetHerd("")-> "unknown"
            //   * GetHerd("walrus")-> "unknown"
            //  * GetHerd("Rhino")-> "Crash"
            // * GetHerd("rhino")-> "Crash"
            //* GetHerd("elephants")-> "unknown"

            //Arrange
            //Create an instance of StringExercises
            AnimalGroupName animal = new AnimalGroupName();

            //Act
            string actualResult = animal.GetHerd("giraffe");

            //Assert
            Assert.AreEqual("Tower", actualResult);

        }
    }
}
