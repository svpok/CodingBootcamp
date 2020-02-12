using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

            //TODO: delete after tests
            //_xmlFilePath = @"C:\Users\Amal Saleh\Desktop\CodingBootcamp\XML.xml";

            try
            {
                _doc = new XmlDocument();
                _doc.Load(_xmlFilePath);
            }
            catch (Exception ex)
            {
                Utilities.Logger.WriteError(ex);
            }
        }

        public void Save()
        {
            //TODO: add try\catch
            try
            {
                _doc.Save(_xmlFilePath);
            }
            catch (Exception ex)
            {
                Logger.WriteError(ex);
                throw;
            }
        }

        public void Change(string xPath, string newValue)
        {
            //TODO: check if xPath ends with string \@* (Regexpression)
            //if yes then take the name of the attribute and change attribute
            //otherwise change inner text of the element 

            //string attrToChange = "currency";
            //"//Envelope/Cube/Cube/Cube" - element
            //"//Envelope/Cube/Cube/Cube[@rate>50 or @currency='USD']" - element
            //"//Envelope/Cube/Cube/Cube[@rate>50 or @currency='USD']/@currency" - attribute
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
                    string attrToChange = m.Value.Substring(2); //cut the first two characters
                    XmlNodeList nodes = _doc.SelectNodes(xPath);

                    foreach (XmlNode node in nodes)
                        // Set the new value
                        node.Value = newValue;
                      
                }
            }
        }
    }
 }
