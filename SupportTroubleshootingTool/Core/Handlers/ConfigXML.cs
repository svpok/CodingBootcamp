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
               throw ex;
            }
        }
        public void Change(string xPath, string newValue)
        {
            try
            {
                MatchCollection mc = Regex.Matches(xPath, @"/@.*");
                if (mc.Count == 0)
                {
                    XmlNodeList nodeList = _doc.SelectNodes(xPath);
                    foreach (XmlNode i in nodeList)
                        i.InnerText = newValue;
                }
                else
                {
                    foreach (Match m in mc)
                    {
                        XmlNodeList nodes = _doc.SelectNodes(xPath);
                        foreach (XmlNode node in nodes)
                            node.Value = newValue;
                    }
                }
            }
            catch (Exception ex)
            {
                new Logger().WriteError(ex);
                throw ex;
            }
        }
    }
 }
