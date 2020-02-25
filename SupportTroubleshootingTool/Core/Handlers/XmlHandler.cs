using SupportTroubleshootingTool.Core.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace SupportTroubleshootingTool.Core.Handlers
{
    public class XmlHandler
    {
        private SessionInfo _sessionInfo;
        public XmlHandler(SessionInfo session)
        {
            _sessionInfo = session;
        }
        public  void ChangeConfig()
        {
            if (_sessionInfo.LogLevel != LogLevelEnum.Current)
            {

                var ConfigstoChange = new Dictionary<string, List<string>>();
                foreach (var item in _sessionInfo.SelectedEVLogs)
                {
                    if (ConfigstoChange.ContainsKey(item.ConfigFilePath))
                        foreach (var i in item.LogLevelXPaths)
                            ConfigstoChange[item.ConfigFilePath].Add(i);
                    else
                        ConfigstoChange.Add(item.ConfigFilePath, item.LogLevelXPaths);
                }
                foreach (var item in _sessionInfo.SelectedFileLogs)
                {
                    if (ConfigstoChange.ContainsKey(item.ConfigFilePath))
                        foreach (var i in item.LogLevelXPaths)
                            ConfigstoChange[item.ConfigFilePath].Add(i);
                    else
                        ConfigstoChange.Add(item.ConfigFilePath, item.LogLevelXPaths);
                }
                //TODO traces dict
                var ConfigstoChangeTraces = new Dictionary<string, List<TraceModeInfo>>();
                foreach (var item in _sessionInfo.SelectedTraces)
                {
                    if (ConfigstoChangeTraces.ContainsKey(item.ConfigFilePath))
                        ConfigstoChangeTraces[item.ConfigFilePath].Add(item.TraceMode);
                    else //test
                        ConfigstoChangeTraces.Add(item.ConfigFilePath, new List<TraceModeInfo> { item.TraceMode });
                }
                foreach (var i in ConfigstoChange)
                {
                    ConfigXML obj = new ConfigXML(i.Key);
                    foreach (var j in i.Value)
                    {
                            try
                            {
                                obj.Change(j, Enum.GetName(typeof(LogLevelEnum), _sessionInfo.LogLevel));
                            }
                            catch
                            {
                                MessageBox.Show("Null ConfigtoChange");
                            }
                        obj.Save();
                    }
                    
                }
                foreach (var i in ConfigstoChangeTraces.Keys)
                {
                    ConfigXML obj = new ConfigXML(i);
                    foreach (var j in ConfigstoChangeTraces.Values)
                    {
                        foreach (var k in j)
                            try
                            {
                                obj.Change(k.Xpath, k.ValueOn.ToString());
                            }
                            catch
                            {
                                MessageBox.Show("Null ConfigToChangeTraces");
                            }

                    }
                    obj.Save();
                }
            }

        }

    }
}
