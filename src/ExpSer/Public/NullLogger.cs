using System;

namespace ExpSer.Public
{
    internal class NullLogger : ILogger
    {
        public void Trace(string message)
        {
        }

        public void Info(string message)
        {
        }

        public void Warn(string message)
        {
        }

        public void Error(string message)
        {
        }

        public void Error(string message, Exception exception)
        {
        }
    }
}
