using TwistedFizzBuzz.Interfaces;

namespace TwistedFizzBuzz.Implementations
{
    public class ConsoleInputReader : IInputReader
    {
        public int ReadInt(string prompt)
        {
            Console.WriteLine(prompt);
            return int.Parse(Console.ReadLine()!);
        }

        public string ReadString(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine()!;
        }
    }
}
