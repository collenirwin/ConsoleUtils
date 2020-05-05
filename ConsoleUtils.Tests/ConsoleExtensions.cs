using NUnit.Framework;
using System.Linq;

namespace ConsoleUtils.Tests
{
    public class ConsoleExtensions
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
    }
}
