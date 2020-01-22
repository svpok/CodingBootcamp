using System;
using System.Xml;
namespace ParsingXml
{
    class Program
    {
        static void Main(string[] args)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(@"XML.xml");//the path of file xml
            XmlNode root = xml.DocumentElement;
            XmlNodeList nod = root.SelectNodes("//Envelope/Cube/Cube/Cube[@rate>50 or @currency='USD']");//the xpath that you can changet for you need
            nod[0].Attributes["currency"].Value = "USD";//change value if attributes 
            xml.Save(@"XML.xml");// save xml file
            foreach(XmlNode x in nod)
            {
                Console.WriteLine(x.Attributes["currency"].Value + ":" + x.Attributes["rate"].Value);//print the content of xml file
            }
            Console.ReadKey();
        }
    }
}