using PalindromeExercise;
using System;
using Xunit;

namespace PalindromeExerciseTests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData("racecar", true)]
        [InlineData("hello", false)]
        [InlineData("wow", true)]
        [InlineData("cowboy", false)]
        [InlineData("mom", true)]

        public void IsAPalindromeTest(string word, bool expected)
        {
            var wordSmith = new WordSmith();

            var actual = wordSmith.IsAPalindrome(word);

            Assert.Equal(expected, actual);
        }
    }
}
