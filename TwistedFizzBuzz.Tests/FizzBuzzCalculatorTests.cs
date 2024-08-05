using TwistedFizzBuzz.Services;

namespace TwistedFizzBuzz.Tests
{
    public class FizzBuzzCalculatorTests
    {
        private readonly FizzBuzzCalculator _calculator = new FizzBuzzCalculator();

        [Theory]
        [InlineData(1, "1")]
        [InlineData(3, "Fizz")]
        [InlineData(5, "Buzz")]
        [InlineData(15, "FizzBuzz")]
        public void Calculate_ShouldReturnExpectedResult(int number, string expected)
        {
            var result = _calculator.CalculateFizzBuzz(number);
            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(10, new object[] { 5, "Fizz" }, "Fizz")]
        [InlineData(27, new object[] { 9, "Buzz", 27, "Bar" }, "BuzzBar")]
        [InlineData(18, new object[] { 9, "Buzz", 27, "Bar" }, "Buzz")]
        [InlineData(0, new object[] { 5, "Fizz", 9, "Buzz", 27, "Bar" }, "FizzBuzzBar")]

        public void CalculateCustomToken_ShouldReturnExpectedResult(int number, object[] tokensArray, string expected)
        {
            var tokens = new Dictionary<int, string>();

            for (int i = 0; i < tokensArray.Length; i += 2)
            {
                int divisor = (int)tokensArray[i];
                string token = (string)tokensArray[i + 1];
                tokens[divisor] = token;
            }

            var result = _calculator.CalculateCustomTokenResult(number, tokens);
            Assert.Equal(expected, result);
        }
    }
}