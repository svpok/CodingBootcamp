using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
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
        [XmlElement]
        public string Name { get; set; }
        [XmlElement]
        public string ConfigFile { get; set; }
        [XmlArray]
        [XmlArrayItem]
        public List<EVLogInfo> EVLogs { get; set; }
        [XmlArray]
        [XmlArrayItem]
        public List<FileLogInfo> FileLogs { get; set; }
        [XmlArray("Traces")]
        [XmlArrayItem("TraceInfo")]
        public List<TraceInfo> Traces { get; set; }
    }
}