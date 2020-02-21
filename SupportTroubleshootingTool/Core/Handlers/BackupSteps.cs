using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Handlers
{
    [Serializable]
    public class BackupSteps
    {
        [XmlArray]
        [XmlArrayItem]
        public List<string> FilePath { set; get; }
        [XmlArray]
        [XmlArrayItem]
        public List<string> FileName { set; get; }

        public  BackupSteps()
        {
            FilePath = new List<string>();
            FileName = new List<string>();
        }
    }
}