using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace SupportTroubleshootingTool.Core.Handlers
{
    public class EVLogHandler
    {
        SessionInfo  _sessionInfo=new SessionInfo();
        List<EventLog> log = new List<EventLog>();

        public EVLogHandler(SessionInfo sessionInfo)
        {
            this._sessionInfo = sessionInfo;
        }



        public void CollectData()
        {
            var logsToCollect = new Dictionary<string, List<string>>();
            foreach (var evLog in _sessionInfo.SelectedEVLogs)
            {
                if (!logsToCollect.ContainsKey(evLog.LogName))
                    logsToCollect.Add(evLog.LogName, evLog.Sources);
                else
                    foreach (var source in evLog.Sources)
                        logsToCollect[evLog.LogName].Add(source);
            }
            
        }
    }
}