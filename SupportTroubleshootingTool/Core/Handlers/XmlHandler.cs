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
        public static void XmlLoad(string xmlPath,string xPath, string value, string varToChange)
        {
            try
            {
                XmlDocument xm1 = new XmlDocument();
                xm1.Load(@"");//XMl path;
                Change(xm1, xPath,value, varToChange);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading 'Data.xml'. Exception: " + ex.Message);
            }
        }
        static void Change(XmlDocument xml,string xPath,string varToChange, string value)
        {
            // nodeList=Null --> necessary?
            /* in case of text
            XmlNodeList nodeList = xml.SelectNodes("/books/book/title"); // "/books/book" --> xPath
            foreach (XmlNode i in nodeList)
            {
                i.InnerText = value;
                
            }
            */
            //in case of attribute
            var nodes = xml.SelectNodes("//Envelope/Cube/Cube/Cube[@rate>50 or @currency='USD']"); // "/books/book" --> xPath
            foreach (XmlElement n in nodes)
            {
                n.SetAttribute(varToChange, value);
            }
            Save(xPath, xml);
        }
        static void Save(string xmlPath, XmlDocument xml)
        {
            xml.Save(@"C:\Users\Amal Saleh\Desktop\CodingBootcamp\XML.xml");         //xml.Save(xmlPath);
        }

        public XmlHandler(SessionInfo session)
        {
            _sessionInfo = session;
        }
        public  void ChangeConfig()
        {
            var ConfigstoChange = new Dictionary<string, List<string>>();
            foreach (var item in _sessionInfo.SelectedEVLogs)
            {
                if (ConfigstoChange.ContainsKey(item.ConfigFilePath))
                    foreach(var i in item.LogLevelXPaths)
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
            {

            }

        }

    }
}
