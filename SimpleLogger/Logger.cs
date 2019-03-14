using System;
using log4net;
using log4net.Core;

namespace SimpleLogger
{
    public enum LoggerType
    {
        ConsoleLogger,
        FileLogger
    }

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

        public Logger(string name)
        {
            _log = LogManager.GetLogger(name);
        }

        public Logger(LoggerType loggerType)
        {
            var type = loggerType.ToString();
            _log = LogManager.GetLogger(loggerType.ToString());
        }

        public void Debug(object message)
        {
            _log.Debug(message);
        }

        public void Debug(object message, Exception exception)
        {
            _log.Debug(message, exception);
        }

        public void Info(object message)
        {
            _log.Info(message);
        }

        public void Info(object message, Exception exception)
        {
            _log.Info(message, exception);
        }

        public void Warn(object message)
        {
            _log.Warn(message);
        }

        public void Warn(object message, Exception exception)
        {
            _log.Warn(message, exception);
        }

        public void Error(object message)
        {
            _log.Error(message);
        }

        public void Error(object message, Exception exception)
        {
            _log.Error(message, exception);
        }

        public void Fatal(object message)
        {
            _log.Fatal(message);
        }

        public void Fatal(object message, Exception exception)
        {
            _log.Fatal(message, exception);
        }
    }
}
