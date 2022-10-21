using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public class EmptyCallProcedureModel : ICallProcedureModel<EmptyCallProcedureModel>
    {
        public IEnumerable<DynamicParameter> DynamicParameters()
        {
            throw new NotImplementedException("EmptyCallProcedureModel:DynamicParameters");
        }

        public IEnumerable<Expression<Func<EmptyCallProcedureModel, object>>> Expressions()
        {
            throw new NotImplementedException("EmptyCallProcedureModel:Expressions");
        }

        public string StoredProcedureName()
        {
            throw new NotImplementedException("EmptyCallProcedureModel:StoredProcedureName");
        }
    }
}
