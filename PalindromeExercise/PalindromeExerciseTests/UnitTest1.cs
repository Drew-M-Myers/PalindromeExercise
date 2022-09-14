using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("car", false)]
        [InlineData("follow", false)]
        [InlineData("kayak", true)]
        [InlineData("radar", true)]
        [InlineData("", false)]
        public void IsAPalindrone(string palindrone, bool expected)
        {
            //Arrange
            var test = new WordSmith();
            //Act
            var actual = test.IsAPalindrome(palindrone);
            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
