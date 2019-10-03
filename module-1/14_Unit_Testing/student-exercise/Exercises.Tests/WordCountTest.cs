using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void WordCountTest1()
        {
            //Arrange
            WordCount word = new WordCount();

            //Act
            Dictionary<string, int> actualResult = word.GetCount(new string[] { "ba", "ba", "black", "sheep" });

            //Assert
            //CollectionAssert.AreEqual(new string[] { "\"ba\" : 2", "\"black\": 1", "\"sheep\": 1" }, actualResult);
            Assert.AreEqual(new Dictionary<string, int>  { "ba" : 2, "black": 1, "sheep": 1 } , actualResult);

        }
    }
}
