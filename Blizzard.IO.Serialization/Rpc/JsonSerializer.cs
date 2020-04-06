using Newtonsoft.Json;
using Blizzard.IO.Core.Rpc;
using System;
using System.Text;

namespace Blizzard.IO.Serialization.Rpc
{
    public class JsonSerializer : ISerializer
    {
        public byte[] Serialize(object data)
        {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
        }

        public object Deserialize(byte[] data, Type type)
        {
            return JsonConvert.DeserializeObject(Encoding.UTF8.GetString(data), type);
        }
    }
}
