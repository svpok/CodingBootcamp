using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
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
            Workflow = new WorkflowInfo();
            SelectedEVLogs = new List<EVLogInfo>();
            SelectedFileLogs = new List<FileLogInfo>();
            SelectedTraces = new List<TraceInfo>();
            From = new DateTime();
            To = new DateTime();
            SessionFolderPath = $"{DateTime.Now.ToString("yyyy-MM-dd-hh-mm")}_{SessionID}";
            SessionOtputFolderPath = "";
        }

        public string SessionID { get; set; }
        
        public WorkflowInfo Workflow { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
       
        public LogLevelEnum LogLevel { get; set; }
        [XmlArrayItem]
        public List<EVLogInfo> SelectedEVLogs { get; set; }
        [XmlArrayItem]
        public List<FileLogInfo> SelectedFileLogs { get; set; }
        [XmlArrayItem]
        public List<TraceInfo> SelectedTraces { get; set; }
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
        public void Save()
        {
            SessionProvider sessionProvider = new SessionProvider();
            XmlSerializer writer = new XmlSerializer(typeof(SessionInfo));
            //string path ="SessionInfo.xml";
            TextWriter s = new StreamWriter($"{sessionProvider.SessionRootFolderPath()}\\{this.SessionFolderPath}_open" + "\\SessionInfo.xml");

            //FileStream file = File.Create(path);
            writer.Serialize(s, this);
            s.Close();
        }
        public SessionInfo Load(string xmlPath)
        {
            SessionProvider sessionProvider = new SessionProvider();
            SessionInfo sessionInfo = null;
            string path = xmlPath;

            XmlSerializer serializer = new XmlSerializer(typeof(SessionInfo));

            StreamReader reader = new StreamReader(path);
            sessionInfo = (SessionInfo)serializer.Deserialize(reader);
            reader.Close();
            return sessionInfo;
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
