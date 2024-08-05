using TwistedFizzBuzz;
using TwistedFizzBuzz.Implementations;
using TwistedFizzBuzz.Services;

Console.WriteLine("FizzBuzz Console Application");

var inputReader = new ConsoleInputReader();
var calculator = new FizzBuzzCalculator();

var fizzBuzzOutput = new FizzBuzzOutput(inputReader, calculator);

var rangeResult = fizzBuzzOutput.PrintOutput();
Console.WriteLine("FizzBuzz output for the range:");
foreach (var item in rangeResult)
{
    Console.WriteLine(item);
}

var listResult = fizzBuzzOutput.PrintOutputFromList();
Console.WriteLine("\nFizzBuzz output for the list of numbers:");
foreach (var item in listResult)
{
    Console.WriteLine(item);
}

var customResult = fizzBuzzOutput.PrintCustomOutput();
Console.WriteLine("\nCustom FizzBuzz output:");
foreach (var item in customResult)
{
    Console.WriteLine(item);
}

var apiTokens = new Dictionary<int, string>
{
    { 3, "Sea" },
    { 5, "Sky" },
    { 7, "Earth" }
};

var apiResult = fizzBuzzOutput.PrintOutputWithApiTokens(apiTokens);
Console.WriteLine("\nFizzBuzz output with API tokens:");

foreach (var item in apiResult)
{
    Console.WriteLine(item);
}