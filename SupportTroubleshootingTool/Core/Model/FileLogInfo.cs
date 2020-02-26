using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Model
{
    [Serializable]
    public class FileLogInfo : BaseLogInfo
    {
        public FileLogInfo() : base()
        {

        }
        [XmlElement]
        public string LogsPath { get; set; }
        [XmlElement]
        public string LogFileName { get; set; }

        public override string ConvertLogLevelToValue(LogLevelEnum logLevel)
        {
            switch (logLevel)
            {
                case LogLevelEnum.Information:
                    return "ALL";
                case LogLevelEnum.Warning:
                    return "WARN";
                case LogLevelEnum.Error:
                    return "ERROR";
                default:
                    return null;
            }
        }
    }
}
