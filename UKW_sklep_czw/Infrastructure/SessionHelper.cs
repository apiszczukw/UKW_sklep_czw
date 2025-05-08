using Newtonsoft.Json;

namespace UKW_sklep_czw.Infrastructure
{
    public static class SessionHelper
    {
        public static void SetObjectAsJson(this ISession session, object value, string key)
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }

        public static T GetObjectFromJson<T>(this ISession session, string key)
        {
            var JsonValue = session.GetString(key);

            return JsonValue == null ? default(T) : JsonConvert.DeserializeObject<T>(JsonValue);

        }
    }
}
