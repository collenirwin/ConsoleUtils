using System;

namespace ConsoleUtils
{
    public class Extensions
    {
        internal static Func<string> ReadLine = Console.ReadLine;
        internal static Action<string> Write = Console.Write;

        public static string Prompt(string message)
        {
            Write(message);
            return ReadLine();
        }

        public static string PromptOnNewLine(string message)
        {
            return Prompt(message + Environment.NewLine);
        }

        public static string PromptUntil(string message, Predicate<string> predicate)
        {
            string response;

            do
            {
                response = Prompt(message);
            } while (!predicate(response));

            return response;
        }
    }
}
