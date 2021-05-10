using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialisation
{
    interface ISerialize
    {
        void SerialiseToFile<T>(string filePath, T item);
        T DeserialiseFromFile<T>(string filePath);
    }
}
