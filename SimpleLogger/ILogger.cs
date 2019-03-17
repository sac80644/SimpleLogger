using System;

namespace GallowayTech.SimpleLogger
{
    public interface ILogger
    {
        bool IsDebugEnabled { get; }
        bool IsInfoEnabled { get; }
        bool IsWarnEnabled { get; }
        bool IsErrorEnabled { get; }
        bool IsFatalEnabled { get; }

        void Debug(object message);
        void Debug(object message, Exception exception);
        void Error(object message);
        void Error(object message, Exception exception);
        void Fatal(object message);
        void Fatal(object message, Exception exception);
        void Info(object message);
        void Info(object message, Exception exception);
        void Warn(object message);
        void Warn(object message, Exception exception);
    }
}