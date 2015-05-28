using System;

namespace WinMailParser.Logging
{
    /// <summary>
    /// Class used for handling the instance creation of the default ILog logging interface
    /// </summary>
    /// <remarks>If the application wishes to override the default logger used by the system, then a factory
    /// delegate is passed to the class using the <see cref="LoggerFactory"/> method.
    /// This class, by default, returns an instance of a <see cref="DiagnosticsLogger"/> object.</remarks>
    public static class DefaultLogger
    {
        /// <summary>
        /// Delegate used to create a logger
        /// </summary>
        /// <returns>A new Logger to use for logging</returns>
        public delegate ILogger DefaultLoggerFactory();

        /// <summary>
        /// The factory object to use to create the default logger for the system
        /// </summary>
        public static DefaultLoggerFactory LoggerFactory = () => new DiagnosticsLogger();

        /// <summary>
        /// Creates an instance object of the default logging interface
        /// </summary>
        /// <returns>An <see cref="ILogger"/> interface object</returns>
        public static ILogger Create()
        {
            return LoggerFactory();
        }
    }
}