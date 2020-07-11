#if !NO_NEWTONSOFT_JSON
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace PusherClient
{
    internal class NewtonsoftJsonSerializer : IJsonSerializer
    {
        public T Deserialize<T>(string json)
        {
            return JsonConvert.DeserializeObject<T>(json);
        }

        public string Serialize<T>(T obj)
        {
            return JsonConvert.SerializeObject(obj);
        }

        public string GetJsonWithStringProperty(string json, string property)
        {
            var jObject = JObject.Parse(json);

            if (jObject[property] != null && jObject[property].Type != JTokenType.String)
                jObject[property] = jObject[property].ToString();

            return jObject.ToString(Formatting.None);
        }
    }
}
#endif