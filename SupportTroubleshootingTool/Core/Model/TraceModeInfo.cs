using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class TraceModeInfo
    {
        public string Xpath { get; set; }
        public bool ValueOn { get; set; }
        public bool ValueOff { get; set; }
}
}
