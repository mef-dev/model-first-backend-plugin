using Newtonsoft.Json;
using System;

namespace Bss.Entities
{
    public class JsonFormatter : ICustomFormatter
    {
        private Lazy<JsonSerializerSettings> jssHolder = new Lazy<JsonSerializerSettings>(() =>
            new JsonSerializerSettings()
            {
                ContractResolver = new OutputJsonPropertyContractResolver()
            });
        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            string res = JsonConvert.SerializeObject(arg, jssHolder.Value);
            return $"{res}";
        }
    }
}
