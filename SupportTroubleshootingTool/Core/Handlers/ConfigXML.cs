using System;
using System.Text.RegularExpressions;
using System.Xml;
using SupportTroubleshootingTool.Core.Utilities;


namespace SupportTroubleshootingTool.Core.Handlers
{
    public class ConfigXML
    {
        string _xmlFilePath;
        XmlDocument _doc;
        public ConfigXML(string xmlFilePath)
        {
            _xmlFilePath = xmlFilePath;
            try
            {
                _doc = new XmlDocument();
                _doc.Load(_xmlFilePath);
            }
            catch (Exception ex)
            {
              new  Utilities.Logger().WriteError(ex);
            }
        }

        public void Save()
        {
            try
            {
                _doc.Save(_xmlFilePath);
            }
            catch (Exception ex)
            {
               new Logger().WriteError(ex);
                throw;
            }
        }

        public void Change(string xPath, string newValue)
        {
            MatchCollection mc = Regex.Matches(xPath, @"/@.*");
            if (mc.Count == 0)
            {
                //if mc.count==0 then we have innertext 
                //in case of text
                XmlNodeList nodeList = _doc.SelectNodes(xPath);
                foreach (XmlNode i in nodeList)
                    i.InnerText = newValue;
            }
            else
            {
                //in case of attribute
                //change according to the attribute
                foreach (Match m in mc)
                {
                    XmlNodeList nodes = _doc.SelectNodes(xPath);

                    foreach (XmlNode node in nodes)
                        // Set the new value
                        node.Value = newValue;    
                }
            }
        }
    }
 }
