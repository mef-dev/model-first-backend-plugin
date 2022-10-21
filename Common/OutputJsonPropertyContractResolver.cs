using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;

namespace Bss.Entities
{
    public class OutputJsonPropertyContractResolver : CamelCasePropertyNamesContractResolver
    {
        protected override JsonProperty CreateProperty(MemberInfo member, MemberSerialization memberSerialization)
        {
            var property = base.CreateProperty(member, memberSerialization);
            var propAttribute = member.GetCustomAttribute<OutputJsonPropertyAttribute>();
            if (propAttribute != null)
            {
                property.PropertyName = propAttribute.PropertyName;
                property.ShouldSerialize = (o) => (propAttribute.NullValueHandling == NullValueHandling.Include || o != null);
            }
            return property;
        }
    }
}

