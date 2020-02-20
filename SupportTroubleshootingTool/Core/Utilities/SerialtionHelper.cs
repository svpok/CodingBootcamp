
using System.IO;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Utilities
{
    class SerialtionHelper<T>
    {
        public static void Serialize(T value , string path)
        {
            XmlSerializer writer = new XmlSerializer(typeof(T));
            using (TextWriter s = new StreamWriter(path,false))
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
