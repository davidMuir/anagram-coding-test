using Xunit;

namespace AnagramSolver.Tests
{
    public class SolverTests
    {
        [Theory]
        [InlineData("rail safety", "fairy tales", true)]
        [InlineData("funeral", "real fun", true)]
        [InlineData("forty five", "over fifty", true)]
        [InlineData("I am Lord Voldemort", "Tom Marvolo Riddle", true)]
        [InlineData("Fish", "Bird", false)]
        [InlineData("I am an anagram", "I am not an anagram", false)]
        [InlineData("Little", "Lottle", false)]
        public void ChecksAnagramCorrectly(string phrase1, string phrase2, bool expected)
        {
            var solver = new Solver();

            var actual = solver.IsAnagram(phrase1, phrase2);

            Assert.Equal(expected, actual);
        }
    }
}
