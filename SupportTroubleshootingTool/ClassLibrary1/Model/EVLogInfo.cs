using System;
using System.Collections.Generic;
using System.Text;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class EVLogInfo : BaseLogInfo
    {
        public EVLogInfo() : base()
        {
            Sources = new List<string>();
        }

        public string LogName { get; set; }
        public List<string> Sources { get; set; }
    }
}
