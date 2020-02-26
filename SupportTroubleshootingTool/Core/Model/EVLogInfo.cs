using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class EVLogInfo : BaseLogInfo
    {
        public EVLogInfo() : base()
        {
            Sources = new List<string>();   
        }
        [XmlElement]
        public string LogName { get; set; }
        [XmlArray]
        [XmlArrayItem("Source")]
        public List<string> Sources { get; set; }

        public override string ConvertLogLevelToValue(LogLevelEnum logLevel)
        {
            switch(logLevel)
            {
                case LogLevelEnum.Information:
                    return "All";
                case LogLevelEnum.Warning:
                    return "Warning";
                case LogLevelEnum.Error:
                    return "Error";
                default:
                    return null;
            }
        }
    }
}
