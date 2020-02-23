using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using SupportTroubleshootingTool.Core.Contract;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace SupportTroubleshootingTool.Core.Model
{
    //Read about XML serialization and implement it for this class
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
            From = DateTime.Parse(DateTime.Now.Add(new TimeSpan(-24, 0, 0)).ToString("MM/dd/yyyy HH:mmm"));
            To = DateTime.Parse(DateTime.Now.ToString("MM/dd/yyyy HH:mmm"));
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
