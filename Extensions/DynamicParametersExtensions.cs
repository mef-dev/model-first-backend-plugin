using Dapper;
using System.Linq;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public static class DynamicParametersExtensions
    {
        public static void AddProcedureParams<T>(this DynamicParameters parameter, T cpm,
            bool includeInput = true,
            bool includeInputOutput = true,
            bool includeOutput = false)
            where T : class, ICallProcedureModel<T>
        {
            if (parameter == null)
                return;

            foreach (var v in cpm.DynamicParameters())
            {
                if (
                (v.Direction == System.Data.ParameterDirection.Input && includeInput) ||
                (v.Direction == System.Data.ParameterDirection.InputOutput && includeInputOutput) ||
                (v.Direction == System.Data.ParameterDirection.Output && includeOutput)
                    )
                {
                    if (parameter.ParameterNames.Contains(v.Name))
                        continue;

                    if (v.Value != null)
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                    else
                    if (v.Direction == System.Data.ParameterDirection.InputOutput)
                    {
                        parameter.Add(v.Name, ((v.DBType == System.Data.DbType.String) ? "" : null), v.DBType, v.Direction);
                    }
                    else
                    if (v.Direction == System.Data.ParameterDirection.Output)
                    {
                        parameter.Add(v.Name, null, v.DBType, v.Direction);
                    }
                }
            }
        }

        public static void FillProcedureResultParams<T>(this DynamicParameters parameter, T cpm,
            bool includeInput = true,
            bool includeInputOutput = false,
            bool includeOutput = false)
            where T : class, ICallProcedureModel<T>
        {
            foreach (var v in cpm.DynamicParameters())
            {
                if (
                (v.Direction == System.Data.ParameterDirection.Input && includeInput) ||
                (v.Direction == System.Data.ParameterDirection.InputOutput && includeInputOutput) ||
                (v.Direction == System.Data.ParameterDirection.Output && includeOutput)
                    )
                    v.Value = parameter.Get<dynamic>(v.Name);
            }
        }
    }
}