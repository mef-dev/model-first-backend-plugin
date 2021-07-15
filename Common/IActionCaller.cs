using Microsoft.Extensions.Logging;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public interface IActionCaller
    {
        //BaseEntity NormalizeInputModel(BaseEntity entity);
        BaseEntity PostEntityAction(string connectionString, BaseEntity entity, int? postTimeOut, ILogger logger);
    }

    [DocIgnore]
    public interface IActionCaller<TIn, out TOut> where TIn : BaseEntity, IPropertyIndexer, new()
            where TOut : BaseEntity
    {
        //TIn NormalizeInputModel(TIn entity);
        TOut PostEntityAction(string connectionString, TIn entity, int? postTimeOut, ILogger logger);
    }
}