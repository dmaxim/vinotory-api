using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace MxInfo.Library.Serialization;

public static class JsonExtensions
{
    public static string ToJson<T>(this T obj, bool includeNull = true)
    {
        return JsonConvert.SerializeObject(obj, GetSerializerSettings(includeNull));
    }

    public static T? DeserializeJson<T>(this string jsonString, bool includeNull = true) where T : class
    {
        if (string.IsNullOrWhiteSpace(jsonString) ||
            jsonString.Equals("null", StringComparison.InvariantCultureIgnoreCase))
        {
            return default(T);
        }

        return JsonConvert.DeserializeObject<T>(jsonString, GetSerializerSettings(includeNull));
    }

    private static JsonSerializerSettings GetSerializerSettings(bool includeNull)
    {
        return new JsonSerializerSettings
        {
            ContractResolver = new CamelCasePropertyNamesContractResolver(),
            Converters = new JsonConverter[] { new StringEnumConverter() },
            NullValueHandling = includeNull ? NullValueHandling.Include : NullValueHandling.Ignore,
            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
        };

    }

}