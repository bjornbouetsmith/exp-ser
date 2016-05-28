using System;

namespace ExpSer.Public
{
    /// <summary>
    /// Interface for logging purposes within the ExpSer framework.
    /// Users of ExpSer can implement an instance of this if they want
    /// to see the emitted log messages of ExpSer.
    /// </summary>
    public interface ILogger
    {
        /// <summary>
        /// Logs a message at "Trace" level
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Trace(string message);

        /// <summary>
        /// Logs a message at "Info" level
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Info(string message);

        /// <summary>
        /// Logs a message at "Warn" level
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Warn(string message);

        /// <summary>
        /// Logs a message at "Error" level
        /// </summary>
        /// <param name="message">The message to log.</param>
        void Error(string message);

        /// <summary>
        /// Logs a message at "Error" level
        /// </summary>
        /// <param name="message">The message to log.</param>
        /// <param name="exception">The exception that happened.</param>
        void Error(string message, Exception exception);

    }
}
