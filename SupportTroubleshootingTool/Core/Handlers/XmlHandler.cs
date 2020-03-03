using SupportTroubleshootingTool.Core.Model;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;


namespace SupportTroubleshootingTool.Core.Handlers
{
    public class XmlHandler
    {
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
                    FillConfigsToChange(_sessionInfo.SelectedEVLogs);
                    //FillConfigsToChange(null);
                    FillConfigsToChange(_sessionInfo.SelectedFileLogs);
                }
                FillConfigsToChange(_sessionInfo.SelectedTraces);
                ChangeConfigs();
                new Utilities.Logger().WriteInfo("The files change configuration has been done!");
            }
            catch (Exception ex)
            {
                new Utilities.Logger().WriteError("Failed to change config for files") ;
                throw new Exception($"Failed to change config for files", ex);
            }
        }
        private void ChangeConfigs()
        {
            new Utilities.Logger().WriteInfo("Starting the change configuration");
            foreach (var configFilePath in _configsToChange)
            {
                ConfigXML configFileXml = new ConfigXML(configFilePath.Key);
                foreach (var configPoint in configFilePath.Value)
                {
                    try
                    {
                        configFileXml.Change(configPoint.XPath, configPoint.Value);
                        new Utilities.Logger().WriteInfo($"change in file {configFilePath} to New value {configPoint.Value} according to the Xpath {configPoint.XPath}");
                    }
                    catch (Exception ex)
                    {
                        new Utilities.Logger().WriteError($"Failed to change config for file {configFilePath.Key}, XPath:{configPoint.XPath}, Value:{configPoint.Value}.");
                        throw new Exception($"Failed to change config for file {configFilePath.Key}, XPath:{configPoint.XPath}, Value:{configPoint.Value}.", ex);
                    }
                }
                configFileXml.Save();
            }
        }
        private void FillConfigsToChange(IEnumerable<ConfigItemInfo> itemsList)
        {
            foreach (var item in itemsList)
            {
                if (!_configsToChange.ContainsKey(item.ConfigFilePath))
                    _configsToChange.Add(item.ConfigFilePath, new List<ConfigurationPoint>());

                foreach (var newPoint in item.GetConfigPoints(_sessionInfo.LogLevel))
                {
                    if (!_configsToChange[item.ConfigFilePath].Exists(existingPoint => existingPoint.XPath == newPoint.XPath))
                        _configsToChange[item.ConfigFilePath].Add(newPoint);
                }
            }
        }
    }
}
