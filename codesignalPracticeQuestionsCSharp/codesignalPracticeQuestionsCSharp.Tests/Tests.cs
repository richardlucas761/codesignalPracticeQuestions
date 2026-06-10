using FluentAssertions;

namespace codesignalPracticeQuestionsCSharp.Tests
{
    [TestClass]
    public sealed class Tests
    {
        [TestMethod]
        [DataRow(29, 11)]
        [DataRow(48, 12)]
        [DataRow(10, 1)]
        [DataRow(25, 7)]
        [DataRow(52, 7)]
        [DataRow(99, 18)]
        [DataRow(44, 8)]
        [DataRow(50, 5)]
        [DataRow(39, 12)]
        [DataRow(26, 8)]
        public void AddTwoDigitsTest(int value, int expected)
        {
            // Arrange

            // Act
            var result = Program.AddTwoDigits(value);

            // Assert
            result.Should().Be(expected);
        }
    }
}
