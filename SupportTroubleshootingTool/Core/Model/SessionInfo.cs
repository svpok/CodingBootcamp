using System;
using System.Collections.Generic;
using SupportTroubleshootingTool.Core.Contract;

namespace SupportTroubleshootingTool.Core.Model
{
    
    public class SessionInfo : ISession
    {
        string SessionID;
        Workflowinfo Workflow;
        DateTime From;
        DateTime To;
        LogLevelEnum LogLevel;
        List<EVLogInfo> SelectedEVLogs;
        List<FileLogInfo> SelectedFileLogs;
        List<TraceInfo> SelectedTraces;
        string SessionFolderPath;
        string SessionOtputFolderPath;

        void addSessionID(string Sessionid)
        {
            this.SessionID = Sessionid;
        }
        void addLogLevel(LogLevelEnum LogLvl)
        {
            this.LogLevel = LogLvl;
        }
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
    public enum LogLevelEnum
    {
        Information,
        Warning,
        Error,
        All
    }
}
