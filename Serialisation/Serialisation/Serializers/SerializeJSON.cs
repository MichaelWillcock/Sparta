using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Serialisation
{
    public class SerializeJSON : ISerialize
    {
        public void SerialiseToFile<T>(string filePath, T item)
        {
            //use newtonsoft.JSON to convert the item to a json string
            string jsonString = JsonConvert.SerializeObject(item);
            //then save to file
            File.WriteAllText(filePath, jsonString);
        }
        public T DeserialiseFromFile<T>(string filePath)
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<T>(jsonString);
        }
    }
}
