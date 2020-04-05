using System;
using System.Text;
using Blizzard.IO.Core;
using YamlDotNet.Serialization;

namespace Blizzard.IO.Serialization.Yaml
{
    public class YamlAbstractTypeDeserializer<TData> : IAbstractTypeDeserializer<TData>
    {
        private readonly Deserializer _yamlDeserializer = new Deserializer();

        public TData Deserialize(byte[] bytes, Type type)
        {
            return (TData) _yamlDeserializer.Deserialize(Encoding.UTF8.GetString(bytes), type);    
        }
    }
}
