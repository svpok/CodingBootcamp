using System;
using System.Collections.Generic;
using System.IO;
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
        public string @Xpath { get; set; }
        [XmlElement]
        public string ValueOn { get; set; }
        [XmlElement]
        public string ValueOff { get; set; }
    }
}
