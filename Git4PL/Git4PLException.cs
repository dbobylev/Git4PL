using System;

namespace Git4PL
{
    class Git4PLException : Exception
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public Git4PLException(string message) : base(message)
        {
            logger.Error(message);
        }
    }
}
