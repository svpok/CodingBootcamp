using System;
using System.Collections.Generic;

namespace SupportTroubleshootingTool.Core
{
    
    public class SessionInfo : ISession
    {
        public string SessionID;
        Workflowinfo Workflow;
        DateTime From;
        DateTime To;
        LogLevelEnum LogLevel;
        List<EVLogInfo> SelectedEVLogs;
        List<FileLogInfo> SelectedFileLogs;
        List<TraceInfo> SelectedTraces;
        string SessionFolderPath;
        string SessionOtputFolderPath;
        void addEVLogs(EVLogInfo EVLogs)
        {
            this.SelectedEVLogs.Add(EVLogs);
        }
        void addFileLogs(FileLogInfo FileLogs)
        {
            this.SelectedFileLogs.Add(FileLogs);
        }
        void addTraces(TraceInfo Traces)
        {
            this.SelectedTraces.Add(Traces);
        }
        void addWorkflow(Workflowinfo workflow)
        {
            this.Workflow = workflow;
        }
        void addTimeFromTo(DateTime from,DateTime to)
        {
            this.From = from;
            this.To = to;
        }
        string ISession.SeesionRootFolderPath()
        {
            return SessionOtputFolderPath;
        }
        SessionInfo ISession.CurrentSession()
        {
            return this;
        }
        void ISession.StartSession(SessionInfo session)
        {


        }
        void ISession.StopSession(SessionInfo session)
        {

        }
        void ISession.CollectData(SessionInfo session)
        {

        }
        void reResetToDefaults()
        {

        }
    }
  


    enum LogLevelEnum
    {
        Information,
        Warning,
        Error,
        All
    }
}
