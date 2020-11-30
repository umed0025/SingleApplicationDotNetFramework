using System;

namespace SingleApplicationDotNetFramework
{
    internal class Program
    {
        private static readonly NLog.ILogger logger = NLog.LogManager.GetCurrentClassLogger();
        private static void Main(string[] args)
        {
            InitLog();
            logger.Info("Start");
            logger.Info("Hello World.");
            logger.Info("End");
#if DEBUG
            logger.Info("Press any key to continue...");
            Console.ReadKey();
#endif 
        }
        private static void InitLog()
        {
            var configuration = new NLog.Config.LoggingConfiguration();
            var layout = @"${longdate}|${level:uppercase=true}|${logger}|${message}${exception:format=tostring}";
            var logfile = new NLog.Targets.FileTarget("logfile")
            {
                FileName = "console.log",
                Layout = layout,
            };
            var asyncLogfile = new NLog.Targets.Wrappers.AsyncTargetWrapper(logfile, 5000, NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Discard);
            configuration.AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Fatal, asyncLogfile);
            var logconsole = new NLog.Targets.ConsoleTarget("logconsole")
            {
                Layout = layout,
            };
            configuration.AddRule(NLog.LogLevel.Trace, NLog.LogLevel.Fatal, logconsole);
            NLog.LogManager.Configuration = configuration;
        }
    }
}
