using SupportTroubleshootingTool.Core.Model;
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
			// DestinationPath example : C:\folder\file.zip
            try
            {
                if (Directory.GetFiles(sourceFolder).Length > 0 || Directory.GetDirectories(sourceFolder).Length >0)
                {
                    ZipFile.CreateFromDirectory(sourceFolder, destinationPath);
                }
                else
                {
                    new Utilities.Logger().WriteInfo("No Files Found to archive");
                    return;
                }
            }
            catch (Exception e)
            {
                new Utilities.Logger().WriteError(e);
                return;
            }
            new Utilities.Logger().WriteInfo("the file Zipped to " + destinationPath);

        }
        internal void Packaging()
        {
            string destinationPath = $@"{ _currentSession.SessionOtputFolderPath}\OutputData\{_currentSession.WorkflowName}.zip";
            string from = _currentSession.From.ToString("yyyy-MM-dd-hh-mm");
            string to = _currentSession.To.ToString("yyyy-MM-dd-hh-mm");
            string sourceFolder= $@"{_currentSession.SessionOtputFolderPath}\OutputData\{from}_{to}";
            Packaging(sourceFolder,destinationPath);
        }
    }
}