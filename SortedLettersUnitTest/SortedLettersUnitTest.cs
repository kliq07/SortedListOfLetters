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
        public void CheckIfStringIsNullorEmpty()
        {
            //Act
            string inputString = "Hey 007! How Are You On This Day 27 ?";
            string expected = "Hey 007! How Are You On This Day 27 ?";

            //Arrange

            string output = new StringHelper(inputString).IsNullOrEmptyString().ToString();

            //Assert
            Assert.AreEqual(expected, output);
        }


        [Test]
        public void SetInputStringToLowerCaseString()
        {
            //Act
            string inputString = "Hey 007! How Are You On This Day 27 ?";
            string expected = "hey 007! how are you on this day 27 ?";

            //Arrange

            string output = new StringHelper(inputString).ToLowerCaseString().ToString();

            //Assert
            Assert.AreEqual(expected, output);
        }


        [Test]
        public void RemoveSpacesAndSpecialCharactersFromInputString()
        {
            //Act
            string inputString = "hey 007! how are you on this day 27 ?";
            string expected = "hey007howareyouonthisday27";

            //Arrange

            string output = new StringHelper(inputString).RemoveSpacesAndSpecialChars().ToString();

            //Assert
            Assert.AreEqual(expected, output);
        }

        [Test]
        public void RemoveNumbersFromInputString()
        {
            //Act
            string inputString = "hey007howareyouonthisday27";
            string expected = "heyhowareyouonthisday";

            //Arrange

            string output = new StringHelper(inputString).RemoveNumbers().ToString();

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
