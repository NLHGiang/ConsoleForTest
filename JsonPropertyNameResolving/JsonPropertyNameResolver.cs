using Newtonsoft.Json.Serialization;

namespace JsonPropertyNameResolving
{
    public class JsonPropertyNameResolver : DefaultContractResolver
    {
        private readonly Dictionary<string, string> propertyMapping;

        public JsonPropertyNameResolver(Dictionary<string, string> propertyMapping)
        {
            this.propertyMapping = propertyMapping;
        }

        protected override string ResolvePropertyName(string propertyName)
        {
            if (propertyMapping.ContainsKey(propertyName))
            {
                return propertyMapping[propertyName];
            }

            return base.ResolvePropertyName(propertyName);
        }
    }
}