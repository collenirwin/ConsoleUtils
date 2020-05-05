using System;

namespace ConsoleUtils
{
    /// <summary>
    /// Contains <see cref="IConsole"/> extension methods for prompting
    /// </summary>
    public static class PromptExtensions
    {
        /// <summary>
        /// Write a message, then read a response
        /// </summary>
        /// <param name="console">The <see cref="IConsole"/> instance to use</param>
        /// <param name="message">Message to write</param>
        /// <exception cref="ArgumentNullException"/>
        /// <returns>The <see cref="IConsole.ReadLine"/> response</returns>
        public static string Prompt(this IConsole console, string message)
        {
            console = console ?? throw new ArgumentNullException(nameof(console));
            message = message ?? throw new ArgumentNullException(nameof(message));

            console.Write(message);
            return console.ReadLine();
        }

        /// <summary>
        /// Write a message and newline, then read a response
        /// </summary>
        /// <param name="console">The <see cref="IConsole"/> instance to use</param>
        /// <param name="message">Message to write</param>
        /// <exception cref="ArgumentNullException"/>
        /// <returns>The <see cref="IConsole.ReadLine"/> response</returns>
        public static string PromptOnNewLine(this IConsole console, string message)
        {
            console = console ?? throw new ArgumentNullException(nameof(console));
            message = message ?? throw new ArgumentNullException(nameof(message));

            return console.Prompt(message + Environment.NewLine);
        }

        /// <summary>
        /// Prompts until a predicate is met
        /// </summary>
        /// <param name="console">The <see cref="IConsole"/> instance to use</param>
        /// <param name="message">Message to write</param>
        /// <param name="predicate">Predicate to evaluate using the user's input</param>
        /// <exception cref="ArgumentNullException"/>
        /// <returns>The <see cref="IConsole.ReadLine"/> response</returns>
        public static string PromptUntil(this IConsole console, string message, Predicate<string> predicate)
        {
            console = console ?? throw new ArgumentNullException(nameof(console));
            message = message ?? throw new ArgumentNullException(nameof(message));
            predicate = predicate ?? throw new ArgumentNullException(nameof(predicate));

            string response;

            do
            {
                response = console.Prompt(message);
            } while (!predicate(response));

            return response;
        }
    }
}
