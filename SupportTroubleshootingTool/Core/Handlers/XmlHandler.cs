using SupportTroubleshootingTool.Core.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SupportTroubleshootingTool.Core.Handlers
{
    public class XmlHandler
    {
        struct ConfigurationPoint
        {
            internal string XPath { get; set; }
            internal string Value { get; set; }
        }

        private SessionInfo _sessionInfo;
        private Dictionary<string, List<ConfigurationPoint>> _configsToChange;

        public XmlHandler(SessionInfo session)
        {
            _sessionInfo = session;
            _configsToChange = new Dictionary<string, List<ConfigurationPoint>>();
        }

        public void ChangeConfig()
        {
            try
            {
                if (_sessionInfo.LogLevel != LogLevelEnum.Current)
                {
                    AddConfigPoints(_sessionInfo.SelectedEVLogs);
                    AddConfigPoints(_sessionInfo.SelectedFileLogs);
                }
                AddConfigPoints(_sessionInfo.SelectedTraces);

                ChangeConfigs();
            }
            catch (Exception ex)
            {
                new Utilities.Logger().WriteError(ex);
                throw;
            }
        }

        private void ChangeConfigs()
        {
            foreach (var configFilePath in _configsToChange)
            {
                ConfigXML configFileXml = new ConfigXML(configFilePath.Key);
                foreach (var configPoint in configFilePath.Value)
                {
                    try
                    {
                        configFileXml.Change(configPoint.XPath, configPoint.Value);
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Failed to change config for file {configFilePath.Key}, XPath:{configPoint.XPath}, Value:{configPoint.Value}.", ex);
                    }
                }
                configFileXml.Save();
            }
        }

        private void AddConfigPoints(IEnumerable<BaseLogInfo> logsList)
        {
            foreach (var logItem in logsList)
            {
                if (!_configsToChange.ContainsKey(logItem.ConfigFilePath))
                    _configsToChange.Add(logItem.ConfigFilePath, new List<ConfigurationPoint>());

                foreach (var i in logItem.LogLevelXPaths)
                    _configsToChange[logItem.ConfigFilePath].Add(
                        new ConfigurationPoint() { XPath = i, Value = logItem.ConvertLogLevelToValue(_sessionInfo.LogLevel) });
            }
        }

        private void AddConfigPoints(IEnumerable<TraceInfo> tracesList)
        {
            foreach (var logItem in tracesList)
            {
                if (!_configsToChange.ContainsKey(logItem.ConfigFilePath))
                    _configsToChange.Add(logItem.ConfigFilePath, new List<ConfigurationPoint>());

                _configsToChange[logItem.ConfigFilePath].Add(
                        new ConfigurationPoint() {
                            XPath = logItem.TraceMode.Xpath,
                            Value = logItem.TraceMode.ValueOn });
            }
        }
    }
}
