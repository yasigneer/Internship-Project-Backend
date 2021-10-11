using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Loggers.NLog
{
    public class NLogger : ILogger
    {
        private static NLogger instance;
        private Logger logger;
        public void Debug(string message, string arg = null)
        {
            throw new NotImplementedException();
        }

        public void Error(string message, string arg = null)
        {
            throw new NotImplementedException();
        }

        public void Info(string message, string arg = null)
        {
            throw new NotImplementedException();
        }

        public void Warning(string message, string arg = null)
        {
            throw new NotImplementedException();
        }
    }
}
