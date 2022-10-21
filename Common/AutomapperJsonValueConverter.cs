using AutoMapper;
using Newtonsoft.Json;

namespace Bss.Entities
{
    public class AutomapperJsonValueConverter : AutoMapper.IValueConverter<string, object>
    {
        public object Convert(string sourceMember, ResolutionContext context)
        {
            return JsonConvert.DeserializeObject(sourceMember);
        }
    }
}

