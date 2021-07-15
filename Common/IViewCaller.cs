using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
using UCP.Common.Plugin.Services;

namespace Natec.Entities
{
    [DocIgnore]
    public interface IViewCaller
    {
        IPagedList<IModifiedTag, BaseEntity> Get(Filter filter,
            string viewName,
            IApiContext context);
    }
}