using System;
using System.Collections.Generic;

namespace SupportTroubleshootingTool.Core.Contracts
{
    interface ISession
    {
        string SeesionRootFolderPath();
        SessionInfo CurrentSession();
        void StartSession(SessionInfo session);
        void StopSession(SessionInfo session);
        void CollectData(SessionInfo session);

    }
    class SessionInfo : ISession
    {


        string SessionID;
        WorkflowInfo Workflow;
        DateTime From;
        DateTime To;
        LogLevelEnum LogLevel;
        List<string> SelectedEVLogs;
        List<string> SelectedFileLogs;
        List<string> SelectedTraces;
        string SessionFolderPath;
        string SessionOtputFolderPath;
        void addEVLogs(string EVLogs)
        {
            this.SelectedEVLogs.Add(EVLogs);
        }
        void addFileLogs(string FileLogs)
        {
            this.SelectedFileLogs.Add(FileLogs);
        }
        void addTraces(string Traces)
        {
            this.SelectedTraces.Add(Traces);
        }
        void addWorkflow(WorkflowInfo workflow)
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

        private class WorkflowInfo
        {

        }
    }
    interface IWorkflow
    {
        List<Workflowinfo> Workflowslist { get; }
    }
    class Workflowinfo : IWorkflow
    {
        List<Workflowinfo> IWorkflow.Workflowslist { get; }
        string Name;
        string Configfile;
        List<EVLogInfo> EVLogs;
        List<FileLogInfo> FileLogs;
        List<TraceInfo> Traces;


    }
    class EVLogInfo
    {

    }
    class FileLogInfo
    {

    }
    class TraceInfo
    {

    }


    enum LogLevelEnum
    {
        Information,
        Warning,
        Error,
        All
    }
}
