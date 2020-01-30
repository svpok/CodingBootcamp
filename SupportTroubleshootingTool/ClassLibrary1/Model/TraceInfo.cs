using System;
using System.Collections.Generic;
using System.Text;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class WorkflowInfo
    {
        public WorkflowInfo()
        {
            EVLogs = new List<EVLogInfo>();
            FileLogs = new List<FileLogInfo>();
            Traces = new List<TraceInfo>();
        }

        public string Name { get; set; }
        public string ConfigFile { get; set; }
        public List<EVLogInfo> EVLogs { get; set; }
        public List<FileLogInfo> FileLogs { get; set; }
        public List<TraceInfo> Traces { get; set; }

    }
}
