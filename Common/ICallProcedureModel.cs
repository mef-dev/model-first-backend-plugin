using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public interface ICallProcedureModel<T> where T : class
    {
        IEnumerable<Expression<Func<T, object>>> Expressions();
        IEnumerable<DynamicParameter> DynamicParameters();
        string StoredProcedureName();
    }
}
