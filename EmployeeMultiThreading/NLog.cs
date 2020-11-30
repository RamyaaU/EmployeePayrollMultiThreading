using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeMultiThreading
{
    public class NLog
    {
        /// <summary>
        /// The logger
        /// </summary>
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();

        /// <summary>
        /// Logs the debug.
        /// </summary>
        /// <param name="message">The message.</param>
        /// Method to log for the debug operation
        public void LogDebug(string message)
        {
            logger.Debug(message);
        }

        /// <summary>
        /// Logs the error.
        /// </summary>
        /// <param name="message">The message.</param>
        /// Method to log for the message at error level
        public void LogError(string message)
        {
            logger.Error(message);
        }

        /// <summary>
        /// Logs the information.
        /// </summary>
        /// <param name="message">The message.</param>
        /// Method to log for the message at information level
        public void LogInfo(string message)
        {
            logger.Info(message);
        }

        /// <summary>
        /// Logs the warn.
        /// </summary>
        /// <param name="message">The message.</param>
        /// Method to log for the message at warning level
        public void LogWarn(string message)
        {
            logger.Warn(message);
        }
    }
}
