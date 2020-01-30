using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public abstract class BaseLogInfo : ConfigItemInfo
    {
        public BaseLogInfo() : base()
        {
        }

        public string LogLevelXPath { get; set; }
    }
}
