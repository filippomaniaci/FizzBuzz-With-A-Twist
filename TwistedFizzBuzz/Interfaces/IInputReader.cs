namespace TwistedFizzBuzz.Interfaces
{
    public interface IInputReader
    {
        int ReadInt(string prompt);
        string ReadString(string prompt);
    }
}
