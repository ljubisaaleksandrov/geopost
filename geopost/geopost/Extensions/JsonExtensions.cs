using System;
using System.Reflection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Serialization;

namespace geopost.Extensions
{
    public static class JsonExtensionMethods
    {
        public static String ToJson(this object model, bool ignoreNull = false)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = (ignoreNull) ? NullValueHandling.Ignore : NullValueHandling.Include,
                ContractResolver = (ignoreNull) ? new CamelCasePropertyNamesContractResolver() : new SubstituteNullWithEmptyStringContractResolver(),
            };
            return JsonConvert.SerializeObject(model, Formatting.Indented, settings);
        }

        public static T FromJson<T>(this string model)
        {
            var settings = new JsonSerializerSettings
            {
                NullValueHandling = NullValueHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return JsonConvert.DeserializeObject<T>(model, settings);
        }

        public static T FromJson<T>(this JObject model)
        {
            var settings = new JsonSerializer
            {
                NullValueHandling = NullValueHandling.Ignore,
                MissingMemberHandling = MissingMemberHandling.Ignore,
                ContractResolver = new CamelCasePropertyNamesContractResolver()
            };
            return model.ToObject<T>(settings);
        }
    }

    public class SubstituteNullWithEmptyStringContractResolver : CamelCasePropertyNamesContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            JsonProperty property = base.CreateProperty(member, memberSerialization);

            if (property.PropertyType == typeof(string))
            {
                // Wrap value provider supplied by Json.NET.
                property.ValueProvider = new NullToEmptyStringValueProvider(property.ValueProvider);
            }

            return property;
        }

        sealed class NullToEmptyStringValueProvider : IValueProvider
        {
            private readonly IValueProvider _provider;

            public NullToEmptyStringValueProvider(IValueProvider provider)
            {
                if (provider == null) throw new ArgumentNullException("provider");

                _provider = provider;
            }

            public object GetValue(object target)
            {
                return _provider.GetValue(target) ?? "";
            }

            public void SetValue(object target, object value)
            {
                _provider.SetValue(target, value);
            }
        }
    }

}