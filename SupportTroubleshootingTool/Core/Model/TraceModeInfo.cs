using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class TraceModeInfo
    {
        [XmlElement]
        public string Xpath { get; set; }
        [XmlElement]
        public bool ValueOn { get; set; }
        [XmlElement]
        public bool ValueOff { get; set; }
    }
}
