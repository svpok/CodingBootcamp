using System;
using System.Collections.Generic;

namespace SupportTroubleshootingTool.Core.Utilities
{
    public class Logger
    {
        private static readonly log4net.ILog mylogger = log4net.LogManager.GetLogger(typeof(Logger));
        public static void WriteInfo(string message)
        {
            mylogger.Info(message);
            // write to log file message text with information body
        }
        public static void WriteWarning(string message)
        {
            mylogger.Warn(message);
        }
        public static void WriteError(string message)
        {
            mylogger.Error(message);
        }
        public static void WriteError(Exception exeption)
        {
            mylogger.Error("Error with this exeption message ", exeption);
        }
    }

}
