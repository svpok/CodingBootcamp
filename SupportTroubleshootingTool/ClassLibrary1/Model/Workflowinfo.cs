using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using SupportTroubleshootingTool.Core.Contract;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class WorkflowInfo
    {
        public WorkflowInfo()
        {
            EVLogs = new List<EVLogInfo>();
            FileLogs = new List<FileLogInfo>();
            Traces = new List<TraceInfo>();
        }

        public string Name { get; set; }
        public string ConfigFile { get; set; }
        [XmlArrayItem]
        public List<EVLogInfo> EVLogs { get; set; }
        [XmlArrayItem]
        public List<FileLogInfo> FileLogs { get; set; }
        [XmlArrayItem]
        public List<TraceInfo> Traces { get; set; }

    }

}

