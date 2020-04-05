using System;
using System.IO;
using Blizzard.IO.Core;
using System.Xml.Serialization;

namespace Blizzard.IO.Serialization.Xml
{
    public class XmlAbstractTypeDeserializer<TData> : IAbstractTypeDeserializer<TData>
    {
        public TData Deserialize(byte[] bytes, Type type)
        {
            var xmlSerializer = new XmlSerializer(type);
            using (var stream = new MemoryStream())
            {
                stream.Write(bytes, 0, bytes.Length);
                return (TData) xmlSerializer.Deserialize(stream);
            }
        }
    }
}
