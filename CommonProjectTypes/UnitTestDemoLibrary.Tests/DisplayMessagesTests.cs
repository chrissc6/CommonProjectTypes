using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

// Arrange, Act, Assert
// Expected and Actual 

// Red, Green, Refactor

namespace UnitTestDemoLibrary.Tests
{
    public class DisplayMessagesTests
    {
        [Fact]
        public void GreetingShouldReturnGoodMorningMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good morning Chris";
            string expected2 = "Good morning Chris";

            //Act
            string actual = messages.Greeting("Chris", 5);
            string actual2 = messages.Greeting("Chris", 11);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void GreetingShouldReturnGoodAfternoonMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good afternoon Chris";
            string expected2 = "Good afternoon Chris";

            //Act
            string actual = messages.Greeting("Chris", 12);
            string actual2 = messages.Greeting("Chris", 17);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Fact]
        public void GreetingShouldReturnGoodEveningMessage()
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();
            string expected = "Good evening Chris";
            string expected2 = "Good evening Chris";

            //Act
            string actual = messages.Greeting("Chris", 18);
            string actual2 = messages.Greeting("Chris", 23);

            //Assert
            Assert.Equal(expected, actual);
            Assert.Equal(expected2, actual2);
        }

        [Theory]
        [InlineData("Chris", 0, "Sleep is good Chris")]
        [InlineData("Chris", 1, "Sleep is good Chris")]
        [InlineData("Chris", 2, "Sleep is good Chris")]
        [InlineData("Chris", 3, "Sleep is good Chris")]
        [InlineData("Chris", 4, "Sleep is good Chris")]
        [InlineData("Chris", 5, "Good morning Chris")]
        [InlineData("Chris", 6, "Good morning Chris")]
        [InlineData("Chris", 7, "Good morning Chris")]
        [InlineData("Chris", 8, "Good morning Chris")]
        [InlineData("Chris", 9, "Good morning Chris")]
        [InlineData("Chris", 10, "Good morning Chris")]
        [InlineData("Chris", 11, "Good morning Chris")]
        [InlineData("Chris", 12, "Good afternoon Chris")]
        [InlineData("Chris", 13, "Good afternoon Chris")]
        [InlineData("Chris", 14, "Good afternoon Chris")]
        [InlineData("Chris", 15, "Good afternoon Chris")]
        [InlineData("Chris", 16, "Good afternoon Chris")]
        [InlineData("Chris", 17, "Good afternoon Chris")]
        [InlineData("Chris", 18, "Good evening Chris")]
        [InlineData("Chris", 19, "Good evening Chris")]
        [InlineData("Chris", 20, "Good evening Chris")]
        [InlineData("Chris", 21, "Good evening Chris")]
        [InlineData("Chris", 22, "Good evening Chris")]
        [InlineData("Chris", 23, "Good evening Chris")]
        public void GreetingShouldReturnExpectedValue(
            string firstName,
            int hourOfTheDay,
            string expected)
        {
            //Arrange
            DisplayMessages messages = new DisplayMessages();

            //Act
            string actual = messages.Greeting(firstName, hourOfTheDay);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
