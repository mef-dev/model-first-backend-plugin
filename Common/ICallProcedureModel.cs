using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public interface ICallProcedureModel<T> where T : class
    {
        IEnumerable<Expression<Func<T, object>>> Expressions();
        IEnumerable<DynamicParameter> DynamicParameters();
        string StoredProcedureName();
    }
}