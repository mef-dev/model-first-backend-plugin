using Microsoft.Extensions.Logging;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public class EntityActionCaller<TIn, TInCall, TOutCall, TOut> : IActionCaller,
            IActionCaller<TIn, TOut> where TIn : BaseEntity, IPropertyIndexer, new()
            where TOut : BaseEntity
            where TInCall : class, ICallProcedureModel<TInCall>
            where TOutCall : class, ICallProcedureModel<TOutCall>
    {


        public TIn NormalizeInputModel(TIn entity)
        {
            TIn rra = entity as TIn ??
                new TIn()
                {
                    Id = entity?.Id,
                    ParentId = entity?.ParentId,
                    Format = entity?.Format,
                    Lang = entity?.Lang,
                    Name = entity?.Name,
                };

            return rra;
        }

        public TOut PostEntityAction(string connectionString, TIn entity, int? postTimeOut, ILogger logger = null)
        {
            TIn inputModel = NormalizeInputModel(entity);
                //entity as TIn;

            if (inputModel == null)
                throw new CommonPlatformException("Input model is invalid")
                {
                    Source = "Entity Action Caller"
                };

            var caller = new CallSetModelCaller<TIn,
                TInCall,
                TOutCall,
                TOut>();

            TOut result = caller.CallSetViaWebModel(connectionString,
                entity as TIn,
                postTimeOut,
                logger);

            return result;
        }

        BaseEntity IActionCaller.PostEntityAction(string connectionString, BaseEntity entity, int? postTimeOut, ILogger logger = null)
        {
            return PostEntityAction(connectionString, entity as TIn, postTimeOut, logger);
        }
    }
}
