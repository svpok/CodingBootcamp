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
        public string Name { get;  set; }
        [XmlElement]
        public string Configfile { get;  set; }
        public object Tracelnfo { get; set; }
    }
}
