using Dapper;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
using static UCP.Common.Plugin.CommonPlatformException;

namespace Natec.Entities
{
    /// <summary>
    /// The class is designed to work with the database
    /// </summary>
    [DocIgnore]
    public class DB : IDisposable
    {
        #region [Fields]
        private static long _instanceCounter = 0;
        internal string _connectionString = "Server=d-dev9;Database=Unibill_bis_dev;User ID=sa;Password=Widecoup1;Trusted_Connection=No;MultipleActiveResultSets=true";
        //private Lazy<ProceduresCollection> proceduresHolder = new Lazy<ProceduresCollection>();
        private Lazy<TablesCollection> tablesHolder = new Lazy<TablesCollection>();
        private SqlConnection _sqlConnection = null;
        private ProceduresCollection _proceduresCollection = null;
        private string _preSqlCommand = string.Empty;
        private ILogger _logger;
        //private static TestsPlugin _testsPlugin = new TestsPlugin();
        #endregion

        #region [Properties]
        public string PreSqlCommand
        {
            get
            {
                return _preSqlCommand;
            }
            set
            {
                _preSqlCommand = value;
            }
        }

        public SqlExecParameters SqlExecParameters { get; set; }
        #endregion

        public class ProceduresCollection
        {
            #region [Properties]
            internal string ConnectionString { get; set; }
            internal string PreSqlCommand { get; set; }
            internal SqlExecParameters SqlExecParameters { get; set; }
            internal ILogger Logger { get; set; }

            #endregion

            #region [Common]
            public void CallProcedure<T>(T cpm, int? commandTimeOut = null) where T : class, ICallProcedureModel<T>
            {
                DynamicParameters parameter = new DynamicParameters(cpm);


                foreach (var e in cpm.Expressions())
                {
                    parameter.Output(cpm, e);
                }

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        sqlConnection.Execute(SqlExecParameters, cpm.StoredProcedureName(), parameter, null, commandTimeOut, System.Data.CommandType.StoredProcedure, this.Logger);
                    });
                }
            }

            public async Task CallProcedureAsync<T>(T cpm, int? commandTimeOut = null) where T : class, ICallProcedureModel<T>
            {
                DynamicParameters parameter = new DynamicParameters(cpm);

                foreach (var e in cpm.Expressions())
                {
                    parameter.Output(cpm, e);
                }

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    await Exceptions.WrapActionAsync(async () =>
                    {
                        pre_Command_Exec(sqlConnection);
                        await sqlConnection.ExecuteAsync(SqlExecParameters, cpm.StoredProcedureName(), parameter, null, commandTimeOut, System.Data.CommandType.StoredProcedure);
                    }).ConfigureAwait(false);
                }
            }

            public void CallProcedure(string storedProcedureName, DynamicParameters parameter, int? timeOut = null)
            {
                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        sqlConnection.Execute(SqlExecParameters, storedProcedureName, parameter, null, timeOut, System.Data.CommandType.StoredProcedure, this.Logger);
                    });
                }
            }

            public async Task CallProcedureAsync(string storedProcedureName, DynamicParameters parameter, int? timeOut = null)
            {
                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    await Exceptions.WrapActionAsync(async () =>
                    {
                        pre_Command_Exec(sqlConnection);
                        await sqlConnection.ExecuteAsync(SqlExecParameters, storedProcedureName, parameter, null, timeOut, System.Data.CommandType.StoredProcedure);
                    }).ConfigureAwait(false);
                }
            }

            public TOut CallRequestResponse<T, TOut>(T cpm, int? timeOut = null)
                where T : class, ICallProcedureModel<T>
                where TOut : class, ICallProcedureModel<TOut>
            {
                DynamicParameters parameter = new DynamicParameters();

                if (!typeof(TOut).Equals(typeof(EmptyCallProcedureModel)))
                    parameter.AddProcedureParams(cpm);

                if (!typeof(TOut).Equals(typeof(EmptyCallProcedureModel)))
                    parameter.AddProcedureParams(Activator.CreateInstance<TOut>(), false, false, true);
                /*
                foreach (var v in cpm.DynamicParameters().Where(dp => dp.Value != null))
                {
                    parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in cpm.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    string paramValue = ((v.Value == null) && (v.DBType == System.Data.DbType.String)) ?
                        "" : null;
                    parameter.Add(v.Name, paramValue, v.DBType, v.Direction);
                }
                */

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        sqlConnection.Execute(SqlExecParameters, cpm.StoredProcedureName(), parameter, null, timeOut, System.Data.CommandType.StoredProcedure, this.Logger);
                        /*
                        foreach (var v in cpm.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                        {
                            v.Value = parameter.Get<dynamic>(v.Name);
                        }
                        */
                    });
                }

                parameter.FillProcedureResultParams(cpm, false, true, true);

                if (typeof(TOut).Equals(typeof(EmptyCallProcedureModel)) ||
                   typeof(TOut).Equals(typeof(EmptyModel)))
                    return null;
                else
                {
                    var result = (typeof(T).Equals(typeof(TOut)) ? cpm as TOut : MappingService.Map<TOut>(cpm));
                    parameter.FillProcedureResultParams(result, false, true, true);
                    return result;
                }
            }

            public async Task<TOut> CallRequestResponseAsync<T, TOut>(T cpm, int? timeOut = null)
                where T : class, ICallProcedureModel<T>
                where TOut : class
            {
                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in cpm.DynamicParameters().Where(dp => dp.Value != null))
                {
                    parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in cpm.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    string paramValue = ((v.Value == null) && (v.DBType == System.Data.DbType.String)) ?
                        "" : null;
                    parameter.Add(v.Name, paramValue, v.DBType, v.Direction);
                }

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {

                    await Exceptions.WrapActionAsync(async () =>
                    {
                        pre_Command_Exec(sqlConnection);
                        await sqlConnection.ExecuteAsync(SqlExecParameters, cpm.StoredProcedureName(), parameter, null, timeOut, System.Data.CommandType.StoredProcedure);
                        foreach (var v in cpm.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                        {
                            v.Value = parameter.Get<dynamic>(v.Name);
                        }
                    }).ConfigureAwait(false);
                }

                return (typeof(T).Equals(typeof(TOut)) ? cpm as TOut : MappingService.Map<TOut>(cpm));
            }

            public TOut CallRequestResponseModelTemplated<T, TOut>(T cpm, int? timeOut = null)
                where T : class, ICallProcedureModel<T>
                where TOut : class
            {
                //DapperProvider dapper = new DapperProvider(ConnectionString);
                DynamicParameters parameter = new DynamicParameters(cpm);

                foreach (var e in cpm.Expressions())
                {
                    parameter.Output(cpm, e);
                }

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        sqlConnection.Execute(SqlExecParameters, cpm.StoredProcedureName(), parameter, null, timeOut, System.Data.CommandType.StoredProcedure, this.Logger);
                    });

                    return MappingService.Map<TOut>(cpm);
                }
            }

            public async Task<TOut> CallRequestResponseModelTemplatedAsync<T, TOut>(T cpm, int? timeOut = null)
                where T : class, ICallProcedureModel<T>
                where TOut : class
            {
                //DapperProvider dapper = new DapperProvider(ConnectionString);
                DynamicParameters parameter = new DynamicParameters(cpm);

                foreach (var e in cpm.Expressions())
                {
                    parameter.Output(cpm, e);
                }

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {

                    await Exceptions.WrapActionAsync(async () =>
                    {
                        pre_Command_Exec(sqlConnection);
                        await sqlConnection.ExecuteAsync(SqlExecParameters, cpm.StoredProcedureName(), parameter, null, timeOut, System.Data.CommandType.StoredProcedure);

                    }).ConfigureAwait(false);

                    return MappingService.Map<TOut>(cpm);
                }
            }

            public (TOutCallModel Result, IEnumerable<dynamic> ResultSet) CallRequestResponseQuery<TInCallModel, TOutCallModel>
                (TInCallModel inCallModel, int? timeOut = null)
                where TInCallModel : class, ICallProcedureModel<TInCallModel>
                where TOutCallModel : class
            {
                /********************************************************************/
                IEnumerable<dynamic> resultSet = null;
                TOutCallModel result = null;

                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Value != null))
                {
                    parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction);
                    }
                    else
                    {
                        parameter.Add(v.Name, null, v.DBType, v.Direction);
                    }
                }

                int realTimeOut = timeOut.HasValue ? timeOut.Value : 0;

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        var res = sqlConnection.QueryMultiple(inCallModel.StoredProcedureName(), parameter, null, realTimeOut, System.Data.CommandType.StoredProcedure);

#if DEBUG
                        resultSet = res.Read().ToList();

#else
                        //result = res.Read();
                        resultSet = res.Read().ToList();
#endif
                    });
                }
                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                {
                    v.Value = parameter.Get<dynamic>(v.Name);
                }

                result = MappingService.Map<TOutCallModel>(inCallModel);

                return (Result: result, ResultSet: resultSet);
            }

            public IEnumerable<TOut> CallRequestResponseQuery<T, TOut>(T cpm, Func<object, TOut> mapper, int? timeOut = null)
                            where T : class, ICallProcedureModel<T>
            {
                IEnumerable<TOut> result = null;

                if (string.IsNullOrEmpty(cpm.StoredProcedureName()))
                    throw new ArgumentException($"Model {cpm?.GetType()?.Name} has empty procedure name");

                if (mapper == null)
                    throw new NullReferenceException("mapper");

                //DapperProvider dapper = new DapperProvider(ConnectionString);
                DynamicParameters parameter = new DynamicParameters(cpm);


                foreach (var e in cpm.Expressions())
                {
                    parameter.Output(cpm, e);
                }

                int realTimeOut = timeOut.HasValue ? timeOut.Value : 0;

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {

                        var res = sqlConnection.QueryMultiple(cpm.StoredProcedureName(), parameter, null, realTimeOut, System.Data.CommandType.StoredProcedure);

                        foreach (var pn in parameter.ParameterNames)
                        {
                            //var prm = parameter[pn];
                            var val = parameter.Get<dynamic>(pn);
                            var valObj = parameter.Get<object>(pn);
                        }

                        try
                        {
                            result = res.Read()
                                .Select((d) => mapper(d))
                                .Cast<TOut>();
                        }
                        catch (InvalidOperationException e)
                        {
                            if ((e.Source.Equals("Dapper")) && (e.Message.Equals("No columns were selected")))
                                result = null;
                            else
                                throw e;

                        }
                    });
                }

                return result;
            }

            public IEnumerable<TOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TOut>
                (TInCallModel inCallModel, out TOutCallModel outCallModel, Func<dynamic, TOut> mapper, int? timeOut = null)
                where TInCallModel : class, ICallProcedureModel<TInCallModel>
                where TOutCallModel : class
                where TOut : class
            {
                outCallModel = null;
                TOutCallModel outCallModelTmp = null;
                IEnumerable<TOut> result = null;

                //Func<dynamic, TOut> mapperFunc = mapper ?? (o => MappingService.Map<TOut>(o));

                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Value != null))
                {
                    parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction);
                    }
                    else
                    {
                        parameter.Add(v.Name, null, v.DBType, v.Direction);
                    }
                }

                int realTimeOut = timeOut.HasValue ? timeOut.Value : 0;

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        var res = sqlConnection.QueryMultiple(inCallModel.StoredProcedureName(), parameter, null, realTimeOut, System.Data.CommandType.StoredProcedure);

                        try
                        {
#if DEBUG
                            result = res.Read()
                                .Select((d) => mapper(d))
                                .Cast<TOut>()
                                .ToList();

#else
                            //result = res.Read()
                            //    .Select((d) => mapperFunc(d))
                            //    .Cast<TOut>();
                            result = res.Read()
                                   .Select((d) => mapper(d))
                                   .Cast<TOut>()
                                   .ToList();
#endif
                        }
                        catch (Exception readEx)
                        {
                            Trace.TraceError($"Error while reading dataset : {readEx}");
                            result = new List<TOut>();
                        }

                        foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                        {
                            v.Value = parameter.Get<dynamic>(v.Name);
                        }

                        outCallModelTmp = MappingService.Map<TOutCallModel>(inCallModel);
                    });

                    outCallModel = outCallModelTmp;
                    return result;
                    /*
                    try
                    {
                        pre_Command_Exec(sqlConnection);
                        var res = sqlConnection.QueryMultiple(inCallModel.StoredProcedureName(), parameter, null, realTimeOut, System.Data.CommandType.StoredProcedure);

                        try
                        {
#if DEBUG
                            result = res.Read()
                                .Select((d) => mapper(d))
                                .Cast<TOut>()
                                .ToList();

#else
                        result = res.Read()
                            .Select((d) => mapperFunc(d))
                            .Cast<TOut>();
#endif
                        }
                        catch (Exception readEx)
                        {
                            Trace.TraceError($"Error while reading dataset : {readEx}");
                            result = new List<TOut>();
                        }

                        foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                        {
                            v.Value = parameter.Get<dynamic>(v.Name);
                        }

                        outCallModel = MappingService.Map<TOutCallModel>(inCallModel);

                        return result;
                    }
                    catch (System.Data.SqlTypes.SqlTypeException sqlTypeException)
                    {
                        throw sqlTypeException.Handle();
                    }
                    catch (System.Data.SqlClient.SqlException sqlException)
                    {
                        throw sqlException.Handle();
                    }
                    catch (Exception exception)
                    {
                        throw new UCP.Common.Plugin.CommonPlatformException(exception.Message)
                        {
                            Source = exception.Source
                        };
                    }

                    */
                }
            }

            public IEnumerable<TResOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TProcOut, TResOut>
                (TInCallModel inCallModel, out TOutCallModel outCallModel, Func<TProcOut, TResOut> mapper = null, int? timeOut = null)
                where TInCallModel : class, ICallProcedureModel<TInCallModel>
                where TOutCallModel : class
                where TProcOut : class
                where TResOut : class
            {
                outCallModel = null;
                IEnumerable<TResOut> result = null;

                Func<dynamic, TResOut> mapperFunc = o =>
                {
                    var procRes = MappingService.Map<TProcOut>(o);
                    if (mapper == null)
                    {
                        var res = MappingService.Map<TResOut>(procRes);
                        res.Clean();
                        return res;
                    }
                    else
                        return mapper(procRes);
                };

                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Value != null))
                {
                    parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction);
                    }
                    else
                    {
                        parameter.Add(v.Name, null, v.DBType, v.Direction);
                    }
                }

                int realTimeOut = timeOut.HasValue ? timeOut.Value : 0;

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        var res = sqlConnection.QueryMultiple(inCallModel.StoredProcedureName(), parameter, null, realTimeOut, System.Data.CommandType.StoredProcedure);

#if DEBUG
                        result = res.Read()
                            .Select((d) => mapperFunc(d))
                            .Cast<TResOut>()
                            .ToList();

#else
                        result = res.Read()
                            .Select((d) => mapperFunc(d))
                            .Cast<TResOut>();
#endif
                    });
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                {
                    v.Value = parameter.Get<dynamic>(v.Name);
                }

                outCallModel = MappingService.Map<TOutCallModel>(inCallModel);

                return result;
            }

            public IEnumerable<dynamic> CallRequestResponseQuery<TInCallModel, TOutCallModel>
                (TInCallModel inCallModel, out TOutCallModel outCallModel, int? timeOut = null)
                where TInCallModel : class, ICallProcedureModel<TInCallModel>
                where TOutCallModel : class
            {
                outCallModel = null;
                IEnumerable<dynamic> result = null;

                //DapperProvider dapper = new DapperProvider(ConnectionString);
                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Value != null))
                {
                    parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction);
                    }
                    else
                    {
                        parameter.Add(v.Name, null, v.DBType, v.Direction);
                    }
                }
                TOutCallModel tmpOutCallModel = null;

                int realTimeOut = timeOut.HasValue ? timeOut.Value : 0;

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);

                        if (typeof(TOutCallModel).Equals(typeof(EmptyModel)))
                        {
                            result = sqlConnection.Query(inCallModel.StoredProcedureName(), parameter, null, false, realTimeOut, System.Data.CommandType.StoredProcedure);
                            result = result?.ToList();
                        }
                        else
                        {

                            var res = sqlConnection.QueryMultiple(inCallModel.StoredProcedureName(), parameter, null, realTimeOut, System.Data.CommandType.StoredProcedure);
                            result = res.Read();

                            foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                            {
                                v.Value = parameter.Get<dynamic>(v.Name);
                            }
                            tmpOutCallModel = MappingService.Map<TOutCallModel>(inCallModel);
                        }
                    });
                }

                outCallModel = tmpOutCallModel;
                return result;
            }

            #endregion
            /*
                        #region [Special calls]
                        /// <summary>
                        /// Обертка для вызова p_get_Tasks
                        /// </summary>
                        /// <param name="callModel"></param>
                        /// <param name="timeOut"></param>
                        /// <returns></returns>
                        public IEnumerable<p_get_Tasks_ResultModel> p_get_Tasks(p_get_Tasks_CallModel callModel, int? timeOut = null)
                        {
                            var result = CallRequestResponseQuery<p_get_Tasks_CallModel, p_get_Tasks_ResultModel>(callModel, (o) =>
                            {
                                IDictionary<string, object> dic = o as IDictionary<string, object>;
                                p_get_Tasks_ResultModel dest = null;

                                if (dic != null)
                                {
                                    dest = new p_get_Tasks_ResultModel();
                                    dest.ID_GroupATS = (int)dic["ID_GroupATS"];
                                    dest.lig_ID = (long?)dic["lig_ID"];
                                    dest.tsk_DateStart = (DateTime?)dic["tsk_DateStart"];
                                    dest.tsk_ID = (long?)dic["tsk_ID"];
                                    dest.tsk_PeriodBegin = (DateTime?)dic["tsk_PeriodBegin"];
                                    dest.tsk_PeriodEnd = (DateTime?)dic["tsk_PeriodEnd"];
                                    dest.tsk_ProcessName = (string)dic["tsk_ProcessName"];
                                    dest.tsk_State = (string)dic["tsk_State"];
                                    dest.tsk_StateMessage = (string)dic["tsk_StateMessage"];
                                }
                                return dest;
                            }, timeOut);
                            return result;
                        }

                        public IEnumerable<long?> p_get_ListID(long? lig_Id, int? timeOut = null)
                        {
                            var result = CallRequestResponseQuery<p_get_ListID_CallModel, long?>(new p_get_ListID_CallModel("p_get_ListID", lig_Id), (o) =>
                           {
                               long? convertRes = null;
                               IDictionary<string, object> dic = o as IDictionary<string, object>;
                               if (dic != null)
                               {
                                   convertRes = (long?)dic["ID"];
                               };
                               return convertRes;

                           }, timeOut);
                            return result;
                        }

                        public IEnumerable<long?> p_srh_get_ListID(int? lig_Id, int? tspl_NoListIDRead, int? timeOut = null)
                        {
                            var result = CallRequestResponseQuery<p_srh_get_ListID_CallModel, long?>(new p_srh_get_ListID_CallModel(lig_Id, tspl_NoListIDRead), (o) =>
                            {
                                long? convertRes = null;
                                IDictionary<string, object> dic = o as IDictionary<string, object>;
                                if (dic != null)
                                {
                                    convertRes = (long?)dic["ID"];
                                };
                                return convertRes;

                            }, timeOut);
                            return result;
                        }

                        public SET_p_ucp_set_ServiceTask_Response p_ucp_set_ServiceTask(int taskId,
                            TaskStateCode stateCode,
                            string stateMessage,
                            DateTime dateStart,
                            int groupATSId,
                            int? timeOut = null)
                        {
                            SET_p_ucp_set_ServiceTask_Request cm = new SET_p_ucp_set_ServiceTask_Request()
                            {
                                Tsk_ID = taskId,
                                Tsst_ID = (int)stateCode,
                                Tsk_StateMessage = stateMessage,
                                ID_GroupATS = groupATSId
                                //"Задача поставлена в очередь выполнения"
                            };

                            if (!DateTime.MinValue.Equals(dateStart))
                            {
                                cm.Tsk_DateStart = dateStart;
                            }

                            return CallRequestResponse<SET_p_ucp_set_ServiceTask_Request, SET_p_ucp_set_ServiceTask_Response>(cm, timeOut);
                        }

                        public IEnumerable<p_get_ServiceTaskData_ResultModel> p_get_ServiceTaskData(p_get_ServiceTaskData_CallModel callModel, int? timeOut = null)
                        {
                            var result = CallRequestResponseQuery<p_get_ServiceTaskData_CallModel, p_get_ServiceTaskData_ResultModel>(callModel, (o) =>
                            {
                                return MappingService.Map<p_get_ServiceTaskData_ResultModel>(o);
                            }, timeOut);
                            return result;
                        }

                        public IEnumerable<p_ucp_get_TaskProcessList_ResultModel> p_ucp_get_TaskProcessList(int? timeOut = null)
                        {
                            p_ucp_get_TaskProcessList_CallModel callModel = new p_ucp_get_TaskProcessList_CallModel();
                            var result = CallRequestResponseQuery<p_ucp_get_TaskProcessList_CallModel, p_ucp_get_TaskProcessList_ResultModel>(callModel, (o) =>
                            {
                                return MappingService.Map<p_ucp_get_TaskProcessList_ResultModel>(o);
                            }, timeOut);
                            return result;
                        }

                        public void sp_StatusMonitor(int numberATS, int? timeOut = null)
                        {
                            DynamicParameters dp = new DynamicParameters();
                            dp.Add("@NumberATS", numberATS, System.Data.DbType.Int32, System.Data.ParameterDirection.Input);

                            this.CallProcedure("[dbo].[sp_StatusMonitor]", dp, timeOut);
                        }

                        #endregion
            */
            private void pre_Command_Exec(SqlConnection sqlConnection)
            {
                //stub
                return;
                if (string.IsNullOrEmpty(PreSqlCommand))
                    return;
                try
                {
                    using (SqlCommand _Command = sqlConnection.CreateCommand())
                    {
                        _Command.CommandType = CommandType.Text;
                        _Command.CommandText = PreSqlCommand;
                        _Command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Trace.TraceError($"Error while executing connection pre-command : {e.Message}");
                }
            }

            internal ProceduresCollection()
            { }
        }

        public class TablesCollection
        {
            internal string ConnectionString { get; set; }

        }

        /// <summary>
        /// Procedures collection
        /// </summary>
        public ProceduresCollection Procedures
        {
            get
            {
                var result = LazyInitializer.EnsureInitialized<ProceduresCollection>(ref _proceduresCollection, () => new ProceduresCollection());
                //var result = proceduresHolder.Value;
                result.ConnectionString = _connectionString;
                result.PreSqlCommand = _preSqlCommand;
                result.SqlExecParameters = SqlExecParameters;
                result.Logger = this._logger;
                //return proceduresHolder.Value;
                return result;
            }
        }

        internal TablesCollection Tables
        {
            get
            {
                var result = tablesHolder.Value;
                result.ConnectionString = _connectionString;
                return tablesHolder.Value;
            }
        }

        public DB(string connectionString, ILogger logger = null)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("connectionString");
            }
            _logger = logger;
            _connectionString = connectionString;
            _instanceCounter = Interlocked.Increment(ref _instanceCounter);
            this.SqlExecParameters = new SqlExecParameters()
            {
                DeadlockRetryCount = 3
            };
            Trace.TraceInformation($"Plugins.DB:: Current instances count : {_instanceCounter}");
            InitializeMaps(_instanceCounter);
        }

        public DB(IApiContext apiContext, ILogger logger = null)
        {
            ApiContextManager.Instance.ValidateContext(apiContext, StubPlugin.StubInstance);
            string connectionString = ResolveConnectionString(apiContext);
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentNullException("connectionString");
            }
            _logger = logger;
            _connectionString = connectionString;
            _instanceCounter = Interlocked.Increment(ref _instanceCounter);
            this.SqlExecParameters = new SqlExecParameters()
            {
                DeadlockRetryCount = 3
            };
            Trace.TraceInformation($"Plugins.DB:: Current instances count : {_instanceCounter}");
            InitializeMaps(_instanceCounter);
        }

        internal DB(string connectionString, SqlExecParameters execParameters) : this(connectionString)
        {
            if (execParameters != null)
                this.SqlExecParameters = execParameters;
        }

        public IEnumerable<T> Query<T>(string queryString, object param = null) where T : class
        {
            /*
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                return sqlConnection.Query<T>(queryString, param);
            }
            */
            IEnumerable<T> result = null;
            using (var sqlConnection = ConnectionManager.BuildSqlConnection(_connectionString, PreSqlCommand))
            {
                Exceptions.WrapAction(() =>
                {
                    result = sqlConnection.Query<T>(queryString, param);
                });
            }
            return result;
        }

        public IEnumerable<dynamic> Query(string queryString, object param = null)
        {
            /*
            using (SqlConnection sqlConnection = new SqlConnection(_connectionString))
            {
                return sqlConnection.Query(queryString, param);
            }
            */
            IEnumerable<dynamic> result = null;
            using (var sqlConnection = ConnectionManager.BuildSqlConnection(_connectionString, PreSqlCommand))
            {
                Exceptions.WrapAction(() =>
                {
                    result = sqlConnection.Query(queryString, param);
                });
            }
            return result;

        }

        private void InitializeMaps(long instanceCounter = 0)
        {
            if (instanceCounter > 0)
                return;

            //MappingService.ResetConfiguration(0);
            //MappingService.ResetConfiguration(1);
        }

        #region IDisposable Support
        private bool disposedValue = false; // To detect redundant calls

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects).
                    //_sqlConnection.Close();
                    //_sqlConnection.Dispose();
                }

                // TODO: free unmanaged resources (unmanaged objects) and override a finalizer below.
                // TODO: set large fields to null.

                disposedValue = true;
            }
        }

        // TODO: override a finalizer only if Dispose(bool disposing) above has code to free unmanaged resources.
        ~DB()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            var instanceCounter = Interlocked.Decrement(ref _instanceCounter);
            Trace.TraceInformation($"Plugins.DB::Finalize: #{instanceCounter}");

            Dispose(false);
        }

        // This code added to correctly implement the disposable pattern.
        public void Dispose()
        {
            // Do not change this code. Put cleanup code in Dispose(bool disposing) above.
            Dispose(true);
            // TODO: uncomment the following line if the finalizer is overridden above.
            // GC.SuppressFinalize(this);
        }

        private string ResolveConnectionString(IApiContext context)
        {
            string result = null;
            try
            {
                PluginBaseConfig cfg = null;
                IConfigurationRoot cfgRoot = ApiContextHelper.GetConfiguration(context, StubPlugin.StubInstance) ??
                    context.DataBag.Configuration as IConfigurationRoot;
                if (cfgRoot != null)
                {
                    cfg = PluginBaseConfig.Get(cfgRoot);
                    if (cfg != null)
                    {
                        return cfg.ConnectionStrings.GetConnection();
                    }
                    else
                        throw new NullReferenceException("Config");
                }
                else
                    throw new NullReferenceException("Config root");

                /*
                if (cfgRoot != null)
                {
                    var cfg = PluginBaseConfig.Get(cfgRoot);
                    if (cfg != null)
                    {
                        return cfg.ConnectionString;
                    }
                }

                cfgRoot = context.DataBag.Configuration as IConfigurationRoot;
                result = cfgRoot.GetConnectionString("ConnectionString");

                if (string.IsNullOrEmpty(result))
                    result = cfgRoot.GetValue<string>("ConnectionString");
                */
            }
            catch (Exception e)
            {
                //throw CommonPlatformException.ErrorOccurredInsidePlugin(this.GetType().Assembly.GetName().Name, "DB");
                var pluginName = this.GetType().Assembly.GetName().Name;
                throw new CommonPlatformException($"Error occurred inside the '{pluginName}' plugin : '{e.Message}'", e)
                {
                    ErrNumber = ErrNumbers.InternalPluginCommonError,
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Source = "DB",
                };
            }

            return result;
        }
        #endregion
    }
}