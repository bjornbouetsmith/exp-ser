using System;

using ExpSer.Public;

namespace ExpSer.Core
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
