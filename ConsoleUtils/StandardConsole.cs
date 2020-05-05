using System;

namespace ConsoleUtils
{
    /// <summary>
    /// Basic <see cref="IConsole"/> implementation, wrapping <see cref="Console"/> methods
    /// </summary>
    public class StandardConsole : IConsole
    {
        /// <summary>
        /// Reads a line of standard input (wraps <see cref="Console.ReadLine"/>)
        /// </summary>
        /// <returns>The user-input line</returns>
        public string ReadLine()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// Writes to standard output (wraps <see cref="Console.Write"/>)
        /// </summary>
        /// <param name="message">Text to write</param>
        public void Write(string message)
        {
            Console.Write(message);
        }

        /// <summary>
        /// Writes to standard output (wraps <see cref="Console.WriteLine"/>)
        /// </summary>
        /// <param name="message">Text to write</param>
        public void WriteLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
