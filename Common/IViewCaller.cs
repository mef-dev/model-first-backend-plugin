using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
using UCP.Common.Plugin.Services;

namespace Bss.Entities
{
    [DocIgnore]
    public interface IViewCaller
    {
        IPagedList<IModifiedTag, BaseEntity> Get(Filter filter,
            string viewName,
            IApiContext context);
    }
}

