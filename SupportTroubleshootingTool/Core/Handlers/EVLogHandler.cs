using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SupportTroubleshootingTool.Core.Handlers
{
    internal class EVLogHandler
    {
        private SessionInfo _sessionInfo;
        List<EventLog> log = new List<EventLog>();

        public EVLogHandler(SessionInfo sessionInfo)
        {
            this._sessionInfo = sessionInfo;
        }



        internal void CollectData()
        {
            var logsToCollect = new Dictionary<string, List<string>>();
            foreach (var evLog in _sessionInfo.SelectedEVLogs)
            {
                if (!logsToCollect.ContainsKey(evLog.LogName))
                    logsToCollect.Add(evLog.LogName, evLog.Sources);
            }


             //log.Log = evLog.LogName;
        }
    }
}