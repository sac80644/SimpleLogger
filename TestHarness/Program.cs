using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleLogger;

namespace TestHarness
{
    class Program
    {
        //private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            ILogger logF = new Logger(LoggerType.FileLogger);
            logF.Debug("debug", new Exception("custom exception"));
            logF.Warn("warn");
            logF.Error("error");
            logF.Fatal("fatal");
            logF.Info("info");

            ILogger logC = new Logger(LoggerType.ConsoleLogger);
            logC.Debug("debug", new Exception("custom exception"));
            logC.Warn("warn");
            logC.Error("error");
            logC.Fatal("fatal");
            logC.Info("info");
        }
    }
}
