using SupportTroubleshootingTool.Core.Model;
using SupportTroubleshootingTool.Core.Utilities;
using SupportTroubleshootingTool.Core.Contract;
using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupportTroubleshootingTool.Core.Utilities
{
    class SerialtionHelper<T>
    {
        public static void Serialize(T value , string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(T));
            //var sessionFolder = path;//$@"{SessionRootFolderPath}\{SessionFolderPath}_open\SessionInfo.xml";
            using (TextWriter s = new StreamWriter(path))
            {
                writer.Serialize(s, value);
                s.Close();
            }
        }
        public static T Deserialize(string Xmlpath)
        {
            T serializedData;
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using (StreamReader reader = new StreamReader(Xmlpath))
            {
                serializedData = (T)serializer.Deserialize(reader);
                reader.Close();
            }
            return serializedData;



        }
    }
}
