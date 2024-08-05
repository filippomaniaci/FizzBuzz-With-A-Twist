namespace TwistedFizzBuzz.Services
{
    public class FizzBuzzCalculator
    {
        public static string CalculateFizzBuzz(int number)
        {
            if (number % 3 == 0 && number % 5 == 0)
            {
                return "FizzBuzz";
            }
            if (number % 3 == 0)
            {
                return "Fizz";
            }
            if (number % 5 == 0)
            {
                return "Buzz";
            }
            return number.ToString();
        }

        public static string CalculateCustomTokenResult(int number, Dictionary<int, string> tokens)
        {
            var result = "";

            foreach (var kvp in tokens)
            {
                if (number % kvp.Key == 0)
                {
                    result += kvp.Value;
                }
            }

            return string.IsNullOrEmpty(result) ? number.ToString() : result;
        }
    }
}
