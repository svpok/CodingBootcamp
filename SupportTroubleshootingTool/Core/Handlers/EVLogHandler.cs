using SupportTroubleshootingTool.Core.Model;
using System;
using System.Windows.Forms;
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
                //evLog.LogName = "Application";
                if (!logsToCollect.ContainsKey(evLog.LogName))
                    logsToCollect.Add(evLog.LogName, new List<string>());

                if (evLog.Sources != null && evLog.Sources.Count > 0)
                {
                    foreach (var source in evLog.Sources)
                        if (!logsToCollect[evLog.LogName].Contains(source))
                            logsToCollect[evLog.LogName].Add(source);
                }
            }
            EventLogSession eventLogSession = new EventLogSession();
            foreach (var item in logsToCollect)
            {
                new Utilities.Logger().WriteInfo(" Started Collecting Event Logs");
                string sources = "";
                if (item.Value.Count > 0)
                {
                    sources = "*[System[Provider[";
                    int i = 1;
                    foreach (var src in item.Value)
                    {
                        sources += $"@Name='{src}'";
                        if (i != item.Value.Count)
                            sources += " or ";
                        i++;

                    }
                    sources += "]]] and ";
                }
                string path = $@"{_sessionInfo.SessionOtputFolderPath}\OutputData\{from}_{to}";
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string q = $@"{sources}*[System[TimeCreated[@SystemTime >= '{_sessionInfo.From.ToUniversalTime().ToString("o")}']]]  and *[System[TimeCreated[@SystemTime <= '{_sessionInfo.To.ToUniversalTime().ToString("o")}']]]";
                eventLogSession.ExportLog(item.Key, PathType.LogName, q, $@"{path}\{item.Key}.evtx");
                new Utilities.Logger().WriteInfo("Successfully Collected Event Logs");

            }
        }
    }
}
