using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Handlers
{
    class PackageHandler
    {
        private SessionInfo _currentSession;
        public PackageHandler(SessionInfo sessionInfo)
        {
            this._currentSession = sessionInfo;
        }
        public static void Packaging(string sourceFolder, string destinationPath) 
        {
            try
            {
                if (Directory.GetFiles(sourceFolder).Length > 0 || Directory.GetDirectories(sourceFolder).Length >0)
                {
                    ZipFile.CreateFromDirectory(sourceFolder, destinationPath);
                }
                else
                {
                    new Logger().WriteInfo("No Files Found to archive");
                    return;
                }
                new Logger().WriteInfo("the file Zipped to " + destinationPath);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        internal void Packaging()
        {
            try
            {
                string from = _currentSession.From.ToString("yyyy-MM-dd-hh-mm");
                string to = _currentSession.To.ToString("yyyy-MM-dd-hh-mm");
                string sourceFolder = $@"{_currentSession.SessionOtputFolderPath}\OutputData\{from}_{to}";
                string destinationPath = $@"{ _currentSession.SessionOtputFolderPath}\OutputData\{_currentSession.WorkflowName}_{from}_{to}.zip";
                Packaging(sourceFolder, destinationPath);
                new Logger().WriteInfo("the file Zipped seccessfully.");
            }
            catch(Exception ex)
            {
                new Logger().WriteError($"Faild to zipped file:{ex.Message}");
                throw ex;
            }
        }
    }
}