using Newtonsoft.Json;

namespace JsonPropertyNameResolving
{
    public static class JsonMapper
    {
        public static string MapObjectToJson(object obj, Dictionary<string, string> propertyMapping)
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new JsonPropertyNameResolver(propertyMapping),
                Formatting = Formatting.Indented // Optional: to format the JSON string
            };

            return JsonConvert.SerializeObject(obj, settings);
        }
    }
}
