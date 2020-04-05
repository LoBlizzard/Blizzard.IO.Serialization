using Blizzard.IO.Core;
using System.IO;
using System.Xml.Serialization;

namespace Blizzard.IO.Serialization.Xml
{
    public class XmlSerializer<TData> : ISerializer<TData>, IDeserializer<TData>
    {
        private readonly XmlSerializer _xmlSerilzier = new XmlSerializer(typeof(TData));
        
        public TData Deserialize(byte[] bytes)
        {
            using (var stream = new MemoryStream())
            {
                stream.Write(bytes, 0, bytes.Length);
                return (TData) _xmlSerilzier.Deserialize(stream);
            }
        }

        public byte[] Serialize(TData data)
        {
            using (var stream = new MemoryStream())
            {
                _xmlSerilzier.Serialize(stream, data);
                return stream.ToArray();
            }
        }
    }
}
