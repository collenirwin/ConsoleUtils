﻿using System;

namespace ConsoleUtils
{
    /// <summary>
    /// Contains <see cref="IConsole"/> extension methods for typed input
    /// </summary>
    public static class TypedExtensions
    {
        /// <summary>
        /// Parses the result of <see cref="IConsole.ReadLine"/> as an <see cref="int"/>
        /// </summary>
        /// <param name="console">The <see cref="IConsole"/> instance to use</param>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="FormatException"/>
        /// <exception cref="OverflowException"/>
        /// <returns>The parsed input</returns>
        public static int ReadInt(this IConsole console)
        {
            console = console ?? throw new ArgumentNullException(nameof(console));
            return int.Parse(console.ReadLine());
        }

        /// <summary>
        /// Parses the result of <see cref="IConsole.ReadLine"/> as an <see cref="int"/>
        /// </summary>
        /// <param name="console">The <see cref="IConsole"/> instance to use</param>
        /// <param name="result">Will be assigned to the parsed input</param>
        /// <exception cref="ArgumentNullException"/>
        /// <returns>true if successful</returns>
        public static bool TryReadInt(this IConsole console, out int result)
        {
            console = console ?? throw new ArgumentNullException(nameof(console));
            return int.TryParse(console.ReadLine(), out result);
        }

        /// <summary>
        /// Parses the result of <see cref="IConsole.ReadLine"/> as a <see cref="double"/>
        /// </summary>
        /// <param name="console">The <see cref="IConsole"/> instance to use</param>
        /// <exception cref="ArgumentNullException"/>
        /// <exception cref="FormatException"/>
        /// <exception cref="OverflowException"/>
        /// <returns>The parsed input</returns>
        public static double ReadDouble(this IConsole console)
        {
            console = console ?? throw new ArgumentNullException(nameof(console));
            return double.Parse(console.ReadLine());
        }

        /// <summary>
        /// Parses the result of <see cref="IConsole.ReadLine"/> as a <see cref="double"/>
        /// </summary>
        /// <param name="console">The <see cref="IConsole"/> instance to use</param>
        /// <param name="result">Will be assigned to the parsed input</param>
        /// <exception cref="ArgumentNullException"/>
        /// <returns>true if successful</returns>
        public static bool TryReadDouble(this IConsole console, out double result)
        {
            console = console ?? throw new ArgumentNullException(nameof(console));
            return double.TryParse(console.ReadLine(), out result);
        }
    }
}
