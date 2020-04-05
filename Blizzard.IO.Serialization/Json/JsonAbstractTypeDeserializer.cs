using Blizzard.IO.Core;
using Newtonsoft.Json;
using System;
using System.Text;

namespace Blizzard.IO.Serialization.Json
{
    public class JsonAbstractTypeDeserializer<TData> : IAbstractTypeDeserializer<TData>
    {
        public TData Deserialize(byte[] bytes, Type type)
        {
            return (TData) JsonConvert.DeserializeObject(Encoding.UTF8.GetString(bytes), type);
        }
    }
}
