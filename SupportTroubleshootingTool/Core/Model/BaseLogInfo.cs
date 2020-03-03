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
            LogLevelXPaths = new List<string>(); 
        }
        [XmlArray]
        [XmlArrayItem("XPath")]
        public List<string> LogLevelXPaths { get; set; }
        internal override IEnumerable<ConfigurationPoint> GetConfigPoints(LogLevelEnum logLevel)
        {
            return LogLevelXPaths.Select(item => CreateConfigurationPoint(item, logLevel));
        }
        private ConfigurationPoint CreateConfigurationPoint(string xPath, LogLevelEnum value)
        {
            return new ConfigurationPoint()
            {
                XPath = xPath,
                Value = ConvertLogLevelToValue(xPath, value)
            };
        }
        internal string ConvertLogLevelToValue(string xPath, LogLevelEnum logLevel)
        {
            var isLog4net = xPath.Contains("log4net");
            switch (logLevel)
            {
                case LogLevelEnum.Information:
                    return isLog4net ? "ALL" : "All";
                case LogLevelEnum.Warning:
                    return isLog4net ? "WARN" : "Warning";
                case LogLevelEnum.Error:
                    return isLog4net ? "ERROR" : "Error";
                default:
                    return null;
            }
        }
    }
}