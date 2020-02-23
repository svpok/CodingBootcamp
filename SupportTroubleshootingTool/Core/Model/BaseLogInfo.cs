using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public abstract class BaseLogInfo : ConfigItemInfo
    {
        public BaseLogInfo() : base()
        {

        }
        [XmlElement]
        public List<string> LogLevelXPaths { get; set; }
    }
}
