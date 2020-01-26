using System;
using log4net;
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
        string ISession.SeesionRootFolderPath()
        {
            return SessionOtputFolderPath;
        }
        SessionInfo ISession.CurrentSession()
        {
            SessionInfo a =new SessionInfo();
            return a;
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

    internal class TraceInfo
    {

    }

    internal class FileLogInfo
    {

    }

    internal class EVLogInfo
    {

    }

    enum LogLevelEnum
    {
        Information,
        Warning,
        Error,
        All
    }

    internal class WorkflowInfo
    {

    }
}
