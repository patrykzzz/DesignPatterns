using System;
using System.IO;
using System.Xml.Serialization;

namespace PrototypePattern.Implementation.Abstract
{
    [Serializable]
    public abstract class BasePrototype<T> where T : new()
    {
        public T Copy()
        {
            var serializer = new XmlSerializer(typeof(T));
            T result;

            using (var stream = new MemoryStream())
            {
                serializer.Serialize(stream, this);
                stream.Seek(0, SeekOrigin.Begin);
                result = (T)serializer.Deserialize(stream);
            }

            return result;
        }
    }
}