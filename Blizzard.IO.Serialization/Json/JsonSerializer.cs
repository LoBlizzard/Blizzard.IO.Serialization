using Blizzard.IO.Core;
using Newtonsoft.Json;
using System.Text;

namespace Blizzard.IO.Serialization.Json
{
    public class JsonSerializer<TData> : ISerializer<TData>, IDeserializer<TData>
    {
        public TData Deserialize(byte[] bytes)
        {
            return JsonConvert.DeserializeObject<TData>(Encoding.UTF8.GetString(bytes));
        }

        public byte[] Serialize(TData data)
        {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data));
        }
    }
}
