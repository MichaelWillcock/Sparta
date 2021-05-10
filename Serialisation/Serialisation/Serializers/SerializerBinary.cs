using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialisation
{
    class SerializerBinary
    {
        public void SerializeToFile<T>(string filePath, T item)
        {
            //Create a binary formatter object and use it to serialize the item to file
            FileStream fileStream = File.Create(filePath);
            BinaryFormatter writer = new BinaryFormatter();
            writer.Serialize(fileStream, item);
            fileStream.Close();
        }
        public T DeserializeFromFile<T>(string filePath)
        {
            //create a new object from reading
            Stream fileStream = File.OpenRead(filePath);
            //create bianry formatter and use it to read the file
            BinaryFormatter reader = new BinaryFormatter();
            var deserialisedItem = (T)reader.Deserialize(fileStream);
            return deserialisedItem;
        }
    }
}
