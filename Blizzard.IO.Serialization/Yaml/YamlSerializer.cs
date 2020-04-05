using Blizzard.IO.Core;
using System.Text;
using YamlDotNet.Serialization;

namespace Blizzard.IO.Serialization.Yaml
{
    public class YamlSerializer<TData> : ISerializer<TData>, IDeserializer<TData>
    {
        private readonly Serializer _yamlSerializer = new Serializer();
        private readonly Deserializer _yamlDeserializer = new Deserializer();

        public TData Deserialize(byte[] bytes)
        {
            return _yamlDeserializer.Deserialize<TData>(Encoding.UTF8.GetString(bytes));            
        }

        public byte[] Serialize(TData data)
        {
            return Encoding.UTF8.GetBytes(_yamlSerializer.Serialize(data));
        }
    }
}
