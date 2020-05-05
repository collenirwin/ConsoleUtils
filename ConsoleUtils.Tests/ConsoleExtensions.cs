using NUnit.Framework;

namespace ConsoleUtils.Tests
{
    public class ConsoleExtensions
    {
        [Test]
        public void Prompt_Basic_Functionality()
        {
            // arrange
            string message = "What's your favorite greeting? ";
            string output = null;
            string response = "Hello";
            Extensions.Write = text => output = text;
            Extensions.ReadLine = () => response;

            // act
            var actual = Extensions.Prompt(message);

            // assert
            Assert.IsNotNull(output);
            Assert.AreEqual(output, message);
            Assert.AreEqual(response, actual);
        }
    }
}
