using System;
using System.Collections.Generic;
using System.Text;

namespace SupportTroubleshootingTool.Core.Model
{
    public class TraceInfo
    {
        public string Name { get; private set; }
        public string Configfile { get; private set; }
        List<EVLogInfo> EVLogs { get; set; }
        List<FileLogInfo> FileLogs { get;  set; }
        List<TraceInfo> Traces { get;  set; }

    }
}
