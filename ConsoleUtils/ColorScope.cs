using System;

namespace ConsoleUtils
{
    /// <summary>
    /// Changes the <see cref="Console"/> colors, switching them back to their previous state when disposed
    /// </summary>
    public class ColorScope : IDisposable
    {
        private bool _disposed = false;
        private readonly ConsoleColor _originalForeColor = Console.ForegroundColor;
        private readonly ConsoleColor _originalBackColor = Console.BackgroundColor;

        /// <summary>
        /// This color scope's foreground color
        /// </summary>
        public ConsoleColor ForeColor { get; }

        /// <summary>
        /// This color scope's background color
        /// </summary>
        public ConsoleColor BackColor { get; }

        /// <summary>
        /// Initializes a <see cref="ColorScope"/> with background and foreground colors
        /// </summary>
        /// <param name="foreColor">Value for <see cref="Console.ForegroundColor"/></param>
        /// <param name="backColor">Value for <see cref="Console.BackgroundColor"/></param>
        public ColorScope(ConsoleColor foreColor, ConsoleColor backColor)
        {
            ForeColor = foreColor;
            BackColor = backColor;

            Console.ForegroundColor = ForeColor;
            Console.BackgroundColor = BackColor;
        }

        /// <summary>
        /// Sets the <see cref="Console"/> colors back to their state when this object was initialized
        /// </summary>
        public void Dispose()
        {
            Dispose(disposing: true);
        }

        /// <summary>
        /// Sets the <see cref="Console"/> colors back to their state when this object was initialized
        /// </summary>
        /// <param name="disposing">Should we be switching the colors back?</param>
        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Console.ForegroundColor = _originalForeColor;
                    Console.BackgroundColor = _originalBackColor;
                }

                _disposed = true;
            }
        }
    }
}
