using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mod1Assessment.Models;

namespace Mod1AssessmentTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow("5738586394958384", true, DisplayName = "5738586394958384")]
        [DataRow("6738586394958384", false, DisplayName = "6738586394958384")]
        [DataRow("4738586394958384", true, DisplayName = "4738586394958384")]
        [DataRow("4738586394958", true, DisplayName = "4738586394958")]
        [DataRow("3438586394958", true, DisplayName = "3438586394958")]
        [DataRow("3938586394958", false, DisplayName = "3938586394958")]
        [DataRow("3738586394958", true, DisplayName = "3738586394958")]
        public void CardValidTest(string cardNumber, bool expectedResult)
        {
            //Arrange
            TellerMachine newTellerMachine = new TellerMachine("Simons", 10.00M, 5.00M, cardNumber);



            //Act
            bool actualResult = newTellerMachine.CardValid(cardNumber);

            //Assert
            Assert.AreEqual(expectedResult, actualResult);

        }
    }
}
