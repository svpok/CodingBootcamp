using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using SupportTroubleshootingTool.Core.Contract;
namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class SessionInfo
    {
        public SessionInfo()
        {
            SessionID = Guid.NewGuid().ToString();
            WorkflowName = "";
            SelectedEVLogs = new List<EVLogInfo>();
            SelectedFileLogs = new List<FileLogInfo>();
            SelectedTraces = new List<TraceInfo>();
            string from = DateTime.Now.ToString();
            From = DateTime.Now.Add(new TimeSpan(-24, 0, 0));
            To = DateTime.Now;
            SessionFolderPath = $"{DateTime.Now.ToString("yyyy-MM-dd-hh-mm")}_{SessionID}";
            SessionOtputFolderPath = "";
        }
        [XmlElement]
        public string SessionID { get; set; }
        [XmlElement]
        public string WorkflowName { get; set; }
        [XmlElement]
        public DateTime From { get; set; }
        [XmlElement]
        public DateTime To { get; set; }
        [XmlElement]
        public LogLevelEnum LogLevel { get; set; }
        [XmlArray]
        [XmlArrayItem]
        public List<EVLogInfo> SelectedEVLogs { get; set; }
        [XmlArray]
        [XmlArrayItem]
        public List<FileLogInfo> SelectedFileLogs { get; set; }
        [XmlArray]
        [XmlArrayItem]
        public List<TraceInfo> SelectedTraces { get; set; }
        [XmlElement]
        public string SessionFolderPath { get; set; }
        [XmlElement]
        public string SessionOtputFolderPath { get; set; }
    }
}
    public enum LogLevelEnum
    {
        Current,
        Information,
        Warning,
        Error
    }