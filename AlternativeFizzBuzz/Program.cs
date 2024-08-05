using TwistedFizzBuzz;
using TwistedFizzBuzz.Implementations;
using TwistedFizzBuzz.Services;

Console.WriteLine("Alternative FizzBuzz Console Application");

var inputReader = new ConsoleInputReader();
var calculator = new FizzBuzzCalculator();

var fizzBuzzOutput = new FizzBuzzOutput(inputReader, calculator);

var customTokens = new Dictionary<int, string>()
{
    { 5, "Fizz" },
    { 9, "Buzz" },
    { 27, "Bar" }
};

var result = fizzBuzzOutput.PrintOutputWithCustomTokens(customTokens, -20, 127);
Console.WriteLine("Custom FizzBuzz output for the range -20 to 127:");

foreach (var item in result)
{
    Console.WriteLine(item);
}
