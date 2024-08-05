using TwistedFizzBuzz;
using TwistedFizzBuzz.Implementations;
using TwistedFizzBuzz.Services;

Console.WriteLine("StandardFizzBuzz Console Application!");

var inputReader = new ConsoleInputReader();
var calculator = new FizzBuzzCalculator();

var fizzBuzzOutput = new FizzBuzzOutput(inputReader, calculator);

var rangeResult = fizzBuzzOutput.PrintOutput();

Console.WriteLine("FizzBuzz output for the given range:");

foreach (var item in rangeResult)
{
    Console.WriteLine(item);
}