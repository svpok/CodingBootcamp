using System;
using System.Collections.Generic;
using System.Text;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class FileLogInfo : BaseLogInfo
    {
        public FileLogInfo() : base()
        {

        }

        public string LogsPath { get; set; }
        public string LogFileName { get; set; }

    }
}
