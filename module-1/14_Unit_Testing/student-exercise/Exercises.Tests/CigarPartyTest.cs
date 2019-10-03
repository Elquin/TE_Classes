using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;


namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]
        public void SquirrelPartyWeekday()
        {
            

            //Arrange
            CigarParty party = new CigarParty();

            //Act
            bool actualResult = party.HaveParty(44, false);

            //Assert
            Assert.AreEqual(true, actualResult);

        }

        [TestMethod]
        public void SquirrelPartyWeekend()
        {


            //Arrange
            CigarParty party = new CigarParty();

            //Act
            bool actualResult = party.HaveParty(80, true);

            //Assert
            Assert.AreEqual(true, actualResult);

        }

        [TestMethod]
        public void SquirrelPartyWeekdayFalse()
        {


            //Arrange
            CigarParty party = new CigarParty();

            //Act
            bool actualResult = party.HaveParty(30, false);

            //Assert
            Assert.AreEqual(false, actualResult);

        }
    }
}
