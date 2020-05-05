using System;
using System.Collections.Generic;

namespace ConsoleUtils.Tests
{
    internal class TestConsole : IConsole
    {
        public Stack<string> Input { get; } = new Stack<string>();
        public List<string> Output { get; } = new List<string>();

        public string ReadLine()
        {
            return Input.Pop();
        }

        public void Write(string message)
        {
            Output.Add(message);
        }

        public void WriteLine(string message)
        {
            Output.Add(message + Environment.NewLine);
        }
    }
}
