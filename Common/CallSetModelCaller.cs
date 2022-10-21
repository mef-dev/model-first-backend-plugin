using Microsoft.Extensions.Logging;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    internal class CallSetModelCaller<TRequestWebModel,
        TRequestCallModel, 
        TResponseCallModel,
        TResponseWebModel>
            where TRequestWebModel : BaseEntity
            where TRequestCallModel : class, ICallProcedureModel<TRequestCallModel>
            where TResponseCallModel : class, ICallProcedureModel<TResponseCallModel>
            where TResponseWebModel : BaseEntity
    {
        public TResponseWebModel CallSetViaWebModel(string connectionString, TRequestWebModel webModel, int? timeOut = null, ILogger logger = null)
        {
            TRequestCallModel callModel = MappingService.Map<TRequestCallModel>(webModel);
            TResponseCallModel resultCallModel = CallSetViaCallModel(connectionString, callModel, timeOut, logger);

            if (resultCallModel == null)
                return null;

            if ((resultCallModel is EmptyCallProcedureModel) &&
                (typeof(TResponseWebModel).Equals(typeof(EmptyEntityModel))))
                return new EmptyEntityModel() as TResponseWebModel;

            TResponseWebModel result = MappingService.MapWN<TResponseWebModel>(resultCallModel);
            result.Clean();
            return result;
        }

        public TResponseCallModel CallSetViaCallModel(string connectionString, TRequestCallModel callModel, int? timeOut = null, ILogger logger = null)
        {
            TResponseCallModel resultCallModel = null;
            using (var db = new DB(connectionString, logger))
            {
                resultCallModel = db.Procedures.CallRequestResponse<TRequestCallModel, TResponseCallModel>(callModel, timeOut);
            }

            if (resultCallModel == null)
            {
                if(typeof(TResponseCallModel).Equals(typeof(EmptyEntityModel)))
                {
                    return new EmptyEntityModel() as TResponseCallModel;
                }
                if (typeof(TResponseCallModel).Equals(typeof(EmptyCallProcedureModel)))
                {
                    return new EmptyCallProcedureModel() as TResponseCallModel;
                }
            }
            return resultCallModel;
        }
    }
}
