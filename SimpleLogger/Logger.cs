using System;
using log4net;
using log4net.Core;

namespace SimpleLogger
{
    public class Logger : ILogger
    {
        public bool IsDebugEnabled { get; }

        public bool IsInfoEnabled { get; }

        public bool IsWarnEnabled { get; }

        public bool IsErrorEnabled { get; }

        public bool IsFatalEnabled { get; }

        private ILog _log;

        public Logger()
        {
            _log = LogManager.GetLogger("DefaultLog");
        }

        public ILog GetLogger(string name)
        {
            return LogManager.GetLogger(name);
        }

        public void Debug(object message)
        {
            _log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Error(object message)
        {
            throw new NotImplementedException();
        }

        public void Error(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message)
        {
            throw new NotImplementedException();
        }

        public void Fatal(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Info(object message)
        {
            throw new NotImplementedException();
        }

        public void Info(object message, Exception exception)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message)
        {
            throw new NotImplementedException();
        }

        public void Warn(object message, Exception exception)
        {
            throw new NotImplementedException();
        }
    }
}
