using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mod1Assessment.Models;

namespace Mod1AssessmentTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void LateFee()
        {
            //Arrange
            string title = "Frozen";
            string format = "DVD";
            bool isPremium = false;
            decimal expected = (decimal)1.99;
            decimal actual;
            MovieRental newMovieRental = new MovieRental(title, format, isPremium);


            //Act
            actual = newMovieRental.LateFee(1);

            //Assert
            Assert.AreEqual(expected, actual);


        }

        [TestMethod]
        public void RentalPrice()
        {
            //Arrange
            string title = "Into the Deep";
            string format = "VHS";
            bool isPremium = false;
            decimal expected = (decimal)0.99;
            decimal actual;
            MovieRental newMovieRental = new MovieRental(title, format, isPremium);


            //Act
            actual = newMovieRental.RentalPrice;

            //Assert
            Assert.AreEqual(expected, actual);


        }

    }
}
