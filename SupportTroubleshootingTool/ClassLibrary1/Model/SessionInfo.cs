﻿using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Xml;

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
            From = new DateTime();
            To = new DateTime();
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

        void ResetToDefaults()
        {
            WorkflowName = ""; 
            SelectedEVLogs = new List<EVLogInfo>();
            SelectedFileLogs = new List<FileLogInfo>();
            SelectedTraces = new List<TraceInfo>();
            From = new DateTime();
            To = new DateTime();
            LogLevel = LogLevelEnum.All;
            SessionFolderPath = "";
            //TODO: complete
            SessionOtputFolderPath = "";
        }

       
    }
    
    public enum LogLevelEnum
    {
        Information,
        Warning,
        Error,
        All
    }
}
