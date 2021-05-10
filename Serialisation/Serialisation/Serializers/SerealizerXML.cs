using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serialisation
{
    public class SerealizerXML : ISerialize
    {
        public void SerialiseToFile<T>(string filePath, T item)
        {
            FileStream fileStream = File.Create(filePath);
            XmlSerializer writer = new XmlSerializer(item.GetType());
            writer.Serialize(fileStream, item);
            fileStream.Close();
        }

        public T DeserialiseFromFile<T>(string filePath)
        {
            FileStream fileStream = File.Create(filePath);
            XmlSerializer reader = new XmlSerializer(typeof(T));
            var deserialisedItem = (T)reader.Deserialize(fileStream);
            fileStream.Close();
            return deserialisedItem;
        }
    }
}
