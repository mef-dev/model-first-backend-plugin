using System.Collections.Generic;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    internal class CallGetModelBinder<TRequestWebModel,
        TRequestCallModel, 
        TResponseCallModel,
        TResponseWebModel,
        TResultSetCallModel,
        TResultSetWebModel>
            where TRequestWebModel : BaseEntity
            where TRequestCallModel : class, ICallProcedureModel<TRequestCallModel>
            where TResponseCallModel : class
            where TResponseWebModel : BaseEntity
            where TResultSetCallModel : class
            where TResultSetWebModel : BaseEntity

    {
        public IEnumerable<TResultSetWebModel> GetViaWebModel(string connectionString, 
            TRequestWebModel webModelInput, 
            out TResponseWebModel webModelOutput)
        {
            TRequestCallModel callModelInput = MappingService.Map<TRequestCallModel>(webModelInput);
            TResponseCallModel callModelOutput = null;

            IEnumerable<TResultSetWebModel> result = null;
            //IEnumerable<TResultSetCallModel> callProcResult = null;

            using (var db = new DB(connectionString))
            {
                result =
                    db.Procedures.CallRequestResponseQuery<TRequestCallModel, TResponseCallModel, TResultSetCallModel, TResultSetWebModel>(callModelInput, out callModelOutput);
                /*, (d) =>
                    MappingService.Map<TResultSetCallModel>(d));
                    */
            }
            webModelOutput = MappingService.MapWN<TResponseWebModel>(callModelOutput);
            webModelOutput.Clean();
            /*
            webModelOutput = MappingService.MapWN<TResponseWebModel>(callModelOutput);
            

            result = callProcResult.Select(cpr =>
            {
                var res = MappingService.MapWN<TResultSetWebModel>(cpr);
                res.Clean();
                return res;
            });
            */
            return result;
        }

        public IEnumerable<TResultSetCallModel> GetViaCallModel(string connectionString,
            TRequestCallModel callModelInput,
            out TResponseCallModel callModelOutput)
        {
            IEnumerable<TResultSetCallModel> callProcResult = null;

            using (var db = new DB(connectionString))
            {
                callProcResult =
                    db.Procedures.CallRequestResponseQuery<TRequestCallModel, TResponseCallModel, TResultSetCallModel>(callModelInput,
                    out callModelOutput, 
                    (o) =>
                    {
                        if (o == null)
                            return o;
                        TResultSetCallModel procRes = MappingService.Map<TResultSetCallModel>(o);
                        return procRes;
                    }
                   );
            }
            return callProcResult;
        }
    }
}
