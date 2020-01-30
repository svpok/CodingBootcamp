using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Model
{
    public abstract class ConfigItemInfo
    {
        public ConfigItemInfo()
        {
            ServicesToRestart = new List<string>();
        }

        public string Description { get; set; }
        public string ConfigFilePath { get; set; }
        public bool IsRequireIISRestart { get; set; }
        public List<string> ServicesToRestart { get; set; }
    }
}
