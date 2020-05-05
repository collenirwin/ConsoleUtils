using System;

namespace ConsoleUtils.Example
{
    class Program
    {
        static readonly IConsole _console = new StandardConsole();

        static void Main()
        {
            Console.WriteLine("Welcome to the example!");

            using (var colorScope = new ColorScope(
                foreColor: ConsoleColor.DarkGray,
                backColor: ConsoleColor.White))
            {
                string name = _console.Prompt("Enter your name: ");
                Console.WriteLine($"Hi {name}!");
            }

            Console.WriteLine("Have a great day.");
            Console.ReadLine();
        }
    }
}
