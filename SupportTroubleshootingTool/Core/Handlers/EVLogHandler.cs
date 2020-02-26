using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;

namespace SupportTroubleshootingTool.Core.Handlers
{
    public class EVLogHandler
    {
        SessionInfo  _sessionInfo;
        List<EventLog> log = new List<EventLog>();

        public EVLogHandler(SessionInfo sessionInfo)
        {
            this._sessionInfo = sessionInfo;
        }



        public void CollectData()
        {
            var from = _sessionInfo.From.ToString("yyyy-MM-dd-hh-mm");
            var to = _sessionInfo.To.ToString("yyyy-MM-dd-hh-mm");
            var logsToCollect = new Dictionary<string, List<string>>();
            foreach (var evLog in _sessionInfo.SelectedEVLogs)
            {
                if (!logsToCollect.ContainsKey(evLog.LogName))
                    logsToCollect.Add(evLog.LogName, evLog.Sources);
                else
                    foreach (var source in evLog.Sources)
                        logsToCollect[evLog.LogName].Add(source);
            }
            EventLogSession eventLogSession = new EventLogSession();
            foreach (var item in logsToCollect)
            {
                string sources = "*[System[Provider[";
                foreach (var src in item.Value)
                {
                    sources += $"@Name='{src}'";

                }
                sources += "]]";
                eventLogSession.ExportLog(item.Key, PathType.LogName, $@"*[System[TimeCreated[@SystemTime >= '{_sessionInfo.From.ToUniversalTime().ToString("o")}']]]  and *[System[TimeCreated[@SystemTime <= '{_sessionInfo.To.ToUniversalTime().ToString("o")}']]]", $@"{_sessionInfo.SessionOtputFolderPath}\OutputData\{from}_{to}\EVLogs");
            }
        }
    }
}
