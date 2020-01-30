using System;
using System.Collections.Generic;
using System.Text;

namespace SupportTroubleshootingTool.Core.Model
{
    public class TraceInfo : ConfigItemInfo
    {
        public TraceInfo() : base()
        {

        }
        public string Name { get;  set; }
        public string Configfile { get;  set; }

    }
}
