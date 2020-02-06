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
        public static void XmlLoad(string xmlPath,string xPath, string value)
        {
            try
            {
                XmlDocument xm1 = new XmlDocument();
                xm1.Load(@"C:\Users\Amal Saleh\Desktop\xmlExample.xml");
                Change(xm1, xPath,value);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading 'Data.xml'. Exception: " + ex.Message);
            }
        }
        static void Change(XmlDocument xml,string xPath,string value)
        {
            // nodeList=Null --> necessary?
            XmlNodeList nodeList = xml.SelectNodes("/books/book/title"); // "/books/book" --> xPath
            foreach (XmlNode i in nodeList)
            {
                i.InnerText = value;
            }
            Save(xPath, xml);
        }
        static void Save(string xmlPath, XmlDocument xml)
        {
            xml.Save(@"C:\Users\Amal Saleh\Desktop\xmlExample.xml");         //xml.Save(xmlPath);
        }
    }
}
