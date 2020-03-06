using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class TraceInfo : ConfigItemInfo
    {
        public TraceInfo() : base()
        {
            TraceMode = new TraceModeInfo();
        }
        [XmlElement]
        public TraceModeInfo TraceMode { get; set; }
        [XmlElement]
        public string TracesPath { get;  set; }
        [XmlElement]
        public string TraceFileName { get; set; }
        [XmlElement]
        public string IISApplicationPoolToRestart { get; set; }
        internal override IEnumerable<ConfigurationPoint> GetConfigPoints(LogLevelEnum logLevel)
        {
            return new List<ConfigurationPoint>()
            {
                new ConfigurationPoint()
                {
                    XPath = TraceMode.Xpath,
                    Value = TraceMode.ValueOn
                }
            };
        }
    }
}
