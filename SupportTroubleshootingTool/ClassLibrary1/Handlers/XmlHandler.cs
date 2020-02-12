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

        internal static void LogLvl(SessionInfo session)
        {
            
        }

        internal static void TracesLvl(SessionInfo session)
        {
            
        }
    }
}
