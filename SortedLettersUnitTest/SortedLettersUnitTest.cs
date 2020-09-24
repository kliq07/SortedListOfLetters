using NUnit.Framework;
using SortedListOfLetters;
using System;

namespace SortedLettersUnitTest
{
    [TestFixture]
    public class TestSortedLetters
    {
        StringHelper strHelp;
        public TestSortedLetters()
        {

        }

        [Test]
        public void CheckIfStringIsNull()
        {
            string expected = "abc";
            string output = "abc";
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void RemoveNumbersFromInputString()
        {
            //Act
            string expected = "How are You on this day";
            string inputString = "How are You 0n th1s day 1229?";

            //Arrange
            strHelp = new StringHelper(inputString).RemoveNumbers();
            string output = strHelp.ToString();

            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void CheckIfStringIsSorted()
        {
            string expected = "abc";
            string output = "abc";
            Assert.AreEqual(expected, output);
        }


    }

}
