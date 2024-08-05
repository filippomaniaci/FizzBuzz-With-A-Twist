using Moq;
using TwistedFizzBuzz.Interfaces;
using TwistedFizzBuzz.Services;

namespace TwistedFizzBuzz.Tests
{
    public class FizzBuzzOutputTests
    {
        private readonly Mock<IInputReader> _mockInputReader = new Mock<IInputReader>();
        private readonly FizzBuzzCalculator _calculator = new FizzBuzzCalculator();
        private readonly FizzBuzzOutput _fizzBuzzOutput;

        public FizzBuzzOutputTests()
        {
            _fizzBuzzOutput = new FizzBuzzOutput(_mockInputReader.Object, _calculator);
        }

        [Fact]
        public void PrintOutput_ShouldReturnCorrectResults()
        {
            _mockInputReader.SetupSequence(m => m.ReadInt(It.IsAny<string>()))
                .Returns(1) // The initial range
                .Returns(15); // The final range

            var result = _fizzBuzzOutput.PrintOutput();

            Assert.Contains("1", result);
            Assert.Contains("Fizz", result);
            Assert.Contains("Buzz", result);
            Assert.Contains("FizzBuzz", result);
        }

        [Fact]
        public void PrintOutputFromList_ShouldReturnCorrectResults()
        {
            _mockInputReader.Setup(m => m.ReadString(It.IsAny<string>())).Returns("1, 3, 5, 15");
            var result = _fizzBuzzOutput.PrintOutputFromList();

            Assert.Contains("1", result);
            Assert.Contains("Fizz", result);
            Assert.Contains("Buzz", result);
            Assert.Contains("FizzBuzz", result);
        }

        [Fact]
        public void PrintCustomOutput_ShouldReturnCorrectResults()
        {
            _mockInputReader.SetupSequence(m => m.ReadInt(It.IsAny<string>()))
                .Returns(1)
                .Returns(15)
                .Returns(3)
                .Returns(5)
                .Returns(7);

            _mockInputReader.SetupSequence(m => m.ReadString(It.IsAny<string>()))
                .Returns("Fizz")
                .Returns("Buzz")
                .Returns("Bar");
            
            var result = _fizzBuzzOutput.PrintCustomOutput();

            Assert.Contains("Fizz", result);
            Assert.Contains("Buzz", result);
            Assert.Contains("Bar", result);
            Assert.Contains("FizzBuzz", result);
        }

        [Fact]
        public void PrintOutputWithApiTokens_ShouldReturnCorrectResults()
        {
            var apiTokens = new Dictionary<int, string>
            {
                { 3, "Sea" },
                { 5, "Sky" },
                { 7, "Earth" }
            };

            _mockInputReader.SetupSequence(m => m.ReadInt(It.IsAny<string>()))
                .Returns(1) // The initial range
                .Returns(15); // The final range

            var result = _fizzBuzzOutput.PrintOutputWithApiTokens(apiTokens);

            Assert.Contains("Sea", result);
            Assert.Contains("Sky", result);
            Assert.Contains("Earth", result);
            Assert.Contains("SeaSky", result);
        }
    }
}
