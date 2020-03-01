
using System;
using System.IO;
using System.Xml.Serialization;

namespace SupportTroubleshootingTool.Core.Utilities
{
    class SerialtionHelper<T>
    {
        public static void Serialize(T value , string path)
        {
            try
            {
                XmlSerializer writer = new XmlSerializer(typeof(T));
                using (TextWriter s = new StreamWriter(path, false))
                {
                    writer.Serialize(s, value);
                    s.Close();
                }
                new Logger().WriteInfo($"Serializing {path} seccessfully.");
            }catch(Exception ex)
            {
                new Logger().WriteError($"Faild to serializing:{ex}");
                throw ex;
            }
            
        }
        public static T Deserialize(string Xmlpath)
        {
            try
            {
                T serializedData;
                XmlSerializer serializer = new XmlSerializer(typeof(T));

                using (StreamReader reader = new StreamReader(Xmlpath))
                {
                    serializedData = (T)serializer.Deserialize(reader);
                    reader.Close();
                }
                new Logger().WriteInfo($"Deserializing {Xmlpath} seccessfully.");
                return serializedData;
            }
            catch (Exception ex)
            {
                new Logger().WriteError($"faild to Deserializing:{ex}");
                throw ex;
            }
        }
    }
}
