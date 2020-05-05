using NUnit.Framework;
using System;
using System.Linq;

namespace ConsoleUtils.Tests
{
    public class Prompt
    {
        [Test]
        public void Prompt_Basic_Functionality()
        {
            // arrange
            string message = "Enter your name: ";
            string response = "Collen";
            var console = new TestConsole();
            console.Input.Push(response);

            // act
            var actual = console.Prompt(message);

            // assert
            Assert.AreEqual(1, console.Output.Count);
            Assert.AreEqual(message, console.Output.First());

            Assert.AreEqual(response, actual);
        }

        [Test]
        public void PromptOnNewLine_Basic_Functionality()
        {
            // arrange
            string message = "Enter your name:";
            string response = "Collen";
            var console = new TestConsole();
            console.Input.Push(response);

            // act
            var actual = console.PromptOnNewLine(message);

            // assert
            Assert.AreEqual(1, console.Output.Count);
            Assert.AreEqual(message + Environment.NewLine, console.Output.First());

            Assert.AreEqual(response, actual);
        }

        [Test]
        public void PromptUntil_Basic_Functionality()
        {
            // arrange
            string message = "Enter my name: ";
            string response = "Collen";
            var console = new TestConsole();
            console.Input.Push(response);
            console.Input.Push("Ethan");
            console.Input.Push("Larry");

            // act
            var actual = console.PromptUntil(message, response => response == "Collen");

            // assert
            Assert.AreEqual(3, console.Output.Count);
            Assert.IsTrue(console.Output.All(output => output == message));

            Assert.AreEqual(response, actual);
        }
    }
}
