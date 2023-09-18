using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("madam", true)]
        [InlineData("hello", false)]
        [InlineData("noon", true)]
        [InlineData("power", false)]
        
        public void PalindromeTest(string input, bool expected)
        {
            var instance = new WordSmith();

            var actual = instance.IsAPalindrome(input);

            Assert.Equal(expected, actual);
        }
        
    }
}
