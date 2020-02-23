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
        private SessionInfo sessionInfo;

        public PackageHandler(SessionInfo sessionInfo)
        {
            this.sessionInfo = sessionInfo;
        }

        public static void Packaging(string sourceFolder, string destinationPath) 
        {
			// DestinationPath example : C:\folder\file.zip
            try
            {

                ZipFile.CreateFromDirectory(sourceFolder, destinationPath);
            }
            catch (Exception e)
            {
                new Utilities.Logger().WriteError(e);
                throw;
            }
            new Utilities.Logger().WriteInfo("the file Zipped to" + destinationPath);

        }
        internal void Packaging()
        {
            string destinationPath = $@"{ sessionInfo.SessionOtputFolderPath}\{sessionInfo.To.ToString("dd-MM-yyyy HH-mm")
                                        }-{sessionInfo.WorkflowName}.zip";
            string sourceFolder= $@"{ sessionInfo.SessionOtputFolderPath}\{ "OutputData"}";
            Packaging(sourceFolder,destinationPath);
        }
    }
}