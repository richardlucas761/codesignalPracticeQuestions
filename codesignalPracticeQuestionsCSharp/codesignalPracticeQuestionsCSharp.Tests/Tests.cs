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

        [TestMethod]
        public void ProcessQueriesTest1()
        {
            // Arrange
            string[][] queries =
                [["ADD","1"],
                 ["ADD","2"],
                 ["ADD","5"],
                 ["ADD","2"],
                 ["EXISTS","2"],
                 ["EXISTS","5"],
                 ["EXISTS","1"],
                 ["EXISTS","4"],
                 ["EXISTS","3"],
                 ["EXISTS","0"]];

            // Act
            var result = Program.ProcessQueries(queries);

            string[] expected = ["", "", "", "",
                "true", "true", "true", "false", "false", "false"];

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void ProcessQueriesTest2()
        {
            // Arrange
            string[][] queries =
                [["EXISTS","0"],
                 ["EXISTS","10"],
                 ["ADD","2"],
                 ["ADD","3"],
                 ["ADD","9"],
                 ["EXISTS","3"],
                 ["EXISTS","4"],
                 ["EXISTS","9"],
                 ["EXISTS","10"],
                 ["ADD","10"],
                 ["ADD","0"],
                 ["EXISTS","0"],
                 ["EXISTS","1"],
                 ["EXISTS","2"],
                 ["EXISTS","3"],
                 ["EXISTS","4"],
                 ["EXISTS","9"],
                 ["EXISTS","10"],
                 ["EXISTS","11"]];

            // Act
            var result = Program.ProcessQueries(queries);

            string[] expected =
                ["false",
                 "false",
                 "",
                 "",
                 "",
                 "true",
                 "false",
                 "true",
                 "false",
                 "",
                 "",
                 "true",
                 "false",
                 "true",
                 "true",
                 "false",
                 "true",
                 "true",
                 "false"];

            // Assert
            result.Should().BeEquivalentTo(expected);
        }

        [TestMethod]
        public void ProcessQueriesTest3()
        {
            // Arrange
            string[][] queries =
                [["ADD","0"],
                 ["ADD","1"],
                 ["ADD","2"],
                 ["ADD","0"],
                 ["EXISTS","-1"],
                 ["EXISTS","0"],
                 ["EXISTS","1"],
                 ["EXISTS","2"],
                 ["EXISTS","3"]];

            // Act
            var result = Program.ProcessQueries(queries);

            string[] expected =
                ["", "", "", "",
                "false", "true", "true", "true", "false"];

            // Assert
            result.Should().BeEquivalentTo(expected);
        }
    }
}
