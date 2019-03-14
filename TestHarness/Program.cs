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
            ILogger log = new Logger("FileLogger");
            log.Debug("debug", new Exception("custom exception"));
            log.Warn("warn");
            log.Error("error");
            log.Fatal("fatal");
            log.Info("info");
            Console.Read();
        }
    }
}
