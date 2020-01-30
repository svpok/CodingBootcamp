using System;
using System.Collections.Generic;
using System.IO;
using SupportTroubleshootingTool.Core.Contract;

namespace SupportTroubleshootingTool.Core.Model
{
    //Read about XML serialization and implement it for this class
    [Serializable]
    public class SessionInfo
    {
        public SessionInfo()
        {
            SessionID = Guid.NewGuid().ToString();
            SessionFolderPath = $"{DateTime.Now.ToString("yyyy-MM-dd-hh-mm")}_{SessionID}_open";
            SelectedEVLogs = new List<EVLogInfo>();
            SelectedFileLogs = new List<FileLogInfo>();
            SelectedTraces = new List<TraceInfo>();
            From = new DateTime();
            To = new DateTime();
            //SessionFolderPath = "";
            SessionOtputFolderPath = "";
        }

        public string SessionID { get;  set; }
        public TraceInfo Workflow { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public LogLevelEnum LogLevel { get; set; }
        List<EVLogInfo> SelectedEVLogs;
        List<FileLogInfo> SelectedFileLogs;
        List<TraceInfo> SelectedTraces;
        public string SessionFolderPath { get; set; }
        public string SessionOtputFolderPath { get; set; }

        void ResetToDefaults()
        {
            Workflow = null;
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
