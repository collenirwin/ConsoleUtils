using NUnit.Framework;

namespace ConsoleUtils.Tests
{
    public class Typed
    {
        [Test]
        public void ReadInt_Basic_Functionality()
        {
            // arrange
            var console = new TestConsole();
            console.Input.Push("5");

            // act
            int actual = console.ReadInt();

            // assert
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void ReadDouble_Basic_Functionality()
        {
            // arrange
            var console = new TestConsole();
            console.Input.Push("5.872");

            // act
            double actual = console.ReadDouble();

            // assert
            Assert.AreEqual(5.872, actual);
        }

        [Test]
        public void TryReadInt_Good_Input()
        {
            // arrange
            var console = new TestConsole();
            console.Input.Push("5");

            // act
            bool successful = console.TryReadInt(out int actual);

            // assert
            Assert.IsTrue(successful);
            Assert.AreEqual(5, actual);
        }

        [Test]
        public void TryReadInt_Bad_Input()
        {
            // arrange
            var console = new TestConsole();
            console.Input.Push("5!");

            // act
            bool successful = console.TryReadInt(out int actual);

            // assert
            Assert.IsFalse(successful);
            Assert.AreEqual(default(int), actual);
        }

        [Test]
        public void ReadMapped_Basic_Functionality()
        {
            // arrange
            var console = new TestConsole();
            console.Input.Push("5");

            // act
            string actual = console.ReadMapped(input => int.Parse(input).ToString("c2"));

            // assert
            Assert.AreEqual("$5.00", actual);
        }
    }
}
