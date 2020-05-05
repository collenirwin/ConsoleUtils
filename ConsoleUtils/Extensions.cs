using System;

namespace ConsoleUtils
{
    public static class Extensions
    {
        public static string Prompt(this IConsole console, string message)
        {
            console.Write(message);
            return console.ReadLine();
        }

        public static string PromptOnNewLine(this IConsole console, string message)
        {
            return console.Prompt(message + Environment.NewLine);
        }

        public static string PromptUntil(this IConsole console, string message, Predicate<string> predicate)
        {
            string response;

            do
            {
                response = console.Prompt(message);
            } while (!predicate(response));

            return response;
        }
    }
}
