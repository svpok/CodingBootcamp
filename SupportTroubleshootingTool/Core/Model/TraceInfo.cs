using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class TraceInfo : ConfigItemInfo
    {
        public TraceInfo() : base()
        {

        }
        [XmlElement]
        public TraceModeInfo TraceMode{ get; set; }
        [XmlElement]
        public string TracesPath { get;  set; }
        [XmlElement]
        public string TraceFileName { get; set; }
        [XmlElement]
        public string IISApplicationPoolToRestart { get; set; }
    }
}
