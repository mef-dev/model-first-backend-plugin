using UCP.Common.Plugin;
using Newtonsoft.Json;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public static class ConvertService
    {
        public static T Convert<T>(string src)
            where T : BaseEntity
        {
            return JsonConvert.DeserializeObject<T>(src);
        }
    }
}