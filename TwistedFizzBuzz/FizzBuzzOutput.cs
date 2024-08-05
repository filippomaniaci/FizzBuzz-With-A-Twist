using TwistedFizzBuzz.Interfaces;
using TwistedFizzBuzz.Services;

namespace TwistedFizzBuzz
{
    public class FizzBuzzOutput
    {
        private readonly IInputReader _inputReader;
        private readonly FizzBuzzCalculator _calculator;

        public FizzBuzzOutput(IInputReader inputReader, FizzBuzzCalculator calculator)
        {
            _inputReader = inputReader;
            _calculator = calculator;
        }

        public List<string> PrintOutput()
        {

            int initialRange = _inputReader.ReadInt("Enter the initial range:");
            int finalRange = _inputReader.ReadInt("Enter the final range:");

            if (initialRange > finalRange)
            {
                var temp = initialRange;
                initialRange = finalRange;
                finalRange = temp;
            }

            var result = new List<string>();
            for (int i = initialRange; i <= finalRange; i++)
            {
                result.Add(_calculator.CalculateFizzBuzz(i));
            }
            return result;
        }

        public List<string> PrintOutputFromList()
        {
            string input = _inputReader.ReadString("Enter a comma-separated list of numbers:");
            var numbers = new List<int>();

            foreach (var str in input.Split(','))
            {
                if (int.TryParse(str.Trim(), out int num))
                {
                    numbers.Add(num);
                }
            }

            var result = new List<string>();
            foreach (var number in numbers)
            {
                result.Add(_calculator.CalculateFizzBuzz(number));
            }
            return result;
        }

        public List<string> PrintCustomOutput()
        {
            int initialRange = _inputReader.ReadInt("Enter the initial range:");
            int finalRange = _inputReader.ReadInt("Enter the final range:");
            int divisor1 = _inputReader.ReadInt("Enter the first divisor:");
            string token1 = _inputReader.ReadString("Enter the token for the first divisor:");
            int divisor2 = _inputReader.ReadInt("Enter the second divisor:");
            string token2 = _inputReader.ReadString("Enter the token for the second divisor:");
            int divisor3 = _inputReader.ReadInt("Enter the third divisor:");
            string token3 = _inputReader.ReadString("Enter the token for the third divisor:");

            var tokens = new Dictionary<int, string> { { divisor1, token1 }, { divisor2, token2 }, { divisor3, token3 } };
            var result = new List<string>();

            for (int i = initialRange; i <= finalRange; i++)
            {
                result.Add(_calculator.CalculateCustomTokenResult(i, tokens));
            }

            return result;
        }

        public List<string> PrintOutputWithApiTokens(Dictionary<int, string> tokens)
        {
            int initialRange = _inputReader.ReadInt("Enter the initial range:");
            int finalRange = _inputReader.ReadInt("Enter the final range:");

            var result = new List<string>();

            for (int i = initialRange; i <= finalRange; i++)
            {
                result.Add(_calculator.CalculateCustomTokenResult(i, tokens));
            }
            return result;
        }

        public List<string> PrintOutputWithCustomTokens(Dictionary<int, string> tokens, int initialRange, int finalRange)
        {
            var result = new List<string>();

            for (int i = initialRange; i <= finalRange; i++)
            {
                result.Add(_calculator.CalculateCustomTokenResult(i, tokens));
            }
            return result;
        }
    }
}
