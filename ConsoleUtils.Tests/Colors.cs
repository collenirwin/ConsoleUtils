using NUnit.Framework;
using System;
using System.Diagnostics;

namespace ConsoleUtils.Tests
{
    public class Colors
    {
        [Test]
        public void Colors_Stay_In_Scope()
        {
            // this test will only pass when debugging
            // which I believe has something to do with the impl of the Console.BackfroundColor getter
            // when there is no actual console window open
            // see https://docs.microsoft.com/en-us/dotnet/api/system.console.backgroundcolor?view=netcore-3.1#remarks
            // "A get operation for a Windows-based application, in which a console does not exist, returns ConsoleColor.Black."
            if (!Debugger.IsAttached)
            {
                Assert.Pass();
            }    

            // arrange
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;

            // act, assert
            using (var colorScope = new ColorScope(
                foreColor: ConsoleColor.Gray,
                backColor: ConsoleColor.Cyan))
            {
                Assert.AreEqual(ConsoleColor.Gray, Console.ForegroundColor);
                Assert.AreEqual(ConsoleColor.Cyan, Console.BackgroundColor);
            }

            Assert.AreEqual(ConsoleColor.White, Console.ForegroundColor);
            Assert.AreEqual(ConsoleColor.Black, Console.BackgroundColor);
        }
    }
}
