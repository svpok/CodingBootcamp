using System;
using System.Collections.Generic;
using System.Xml.Serialization;
namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public abstract class ConfigItemInfo
    {
        public ConfigItemInfo()
        {
            ServicesToRestart = new List<string>();
        }
        [XmlElement]
        public string Description { get; set; }
        [XmlElement]
        public string ConfigFilePath { get; set; }
        [XmlElement]
        public bool IsRequireIISRestart { get; set; }
        [XmlArray]
        [XmlArrayItem("ServiceName")]
        public List<string> ServicesToRestart { get; set; }
        internal abstract IEnumerable<ConfigurationPoint> GetConfigPoints(LogLevelEnum logLevel);
    }
}