using System;
using System.Collections.Generic;
using System.Text;

namespace SupportTroubleshootingTool.Core.Utilities
{
    public class Logger
    {

        private static readonly log4net.ILog mylogger = log4net.LogManager.GetLogger(typeof(Logger));

        internal void WriteInfo(string message)
        {
            mylogger.Info(message);
        }
        internal void WriteWarning(string message)
        {
            mylogger.Warn(message);
        }
        internal void WriteDebug(string message)
        {
            mylogger.Debug(message);
        }
        internal void WriteError(string message)
        {
            mylogger.Error(message);
        }

        internal void WriteError(Exception exeption)
        {

            StringBuilder e = new StringBuilder();
            e.Append(exeption.Message);
            e.Append("\n");
            while (exeption.InnerException != null)
            {
                e.Append(exeption.InnerException.Message + "\n");
                exeption = exeption.InnerException;
            }
            mylogger.Error("Error with this exeption message " + e.ToString());
        }
    }

}
