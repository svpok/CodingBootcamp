using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;

namespace SupportTroubleshootingTool.Core.Contract
{
    internal class FilesHandler
    {
        private SessionInfo _currentSession;

        public FilesHandler(SessionInfo currentSession)
        {
            _currentSession = currentSession;
            List<TraceInfo> traces = _currentSession.SelectedTraces;
            List<FileLogInfo> fileLogInfos = _currentSession.SelectedFileLogs;
            // Create folder for each trace by description 
            // Create folder for each filelog by description 

        }

        internal void CollectData()
        {
            //throw new NotImplementedException();
        }
    }
}