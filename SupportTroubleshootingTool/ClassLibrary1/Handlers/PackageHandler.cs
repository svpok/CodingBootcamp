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
        public static void Packageing(String SourceFolder, String DestinationFolder)
        {
            try
            {
                ZipFile.CreateFromDirectory(SourceFolder, DestinationFolder);
            }
            catch (Exception e)
            {
                Utilities.Logger.WriteError(e);
            }
            Utilities.Logger.WriteInfo("the file Zipped to" + DestinationFolder);

        }
    }
}