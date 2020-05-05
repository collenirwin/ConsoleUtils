namespace ConsoleUtils
{
    /// <summary>
    /// Barebones console that can read and write text
    /// </summary>
    public interface IConsole
    {
        void Write(string message);
        void WriteLine(string message);
        string ReadLine();
    }
}
