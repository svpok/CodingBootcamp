using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
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

        public static void Packageing(String SourceFolder, String DestinationPath) 
        {
			// DestinationPath example : C:\folder\file.zip
            try
            {
                ZipFile.CreateFromDirectory(SourceFolder, DestinationPath);
            }
            catch (Exception e)
            {
                new Utilities.Logger().WriteError(e);
            }
            new Utilities.Logger().WriteInfo("the file Zipped to" + DestinationPath);

        }
        internal void Packageing()
        {
            
        }
    }
}