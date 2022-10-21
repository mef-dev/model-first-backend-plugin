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

namespace Bss.Entities
{
    /// <summary>
    /// The class is designed to work with the "Widecoup" database
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
        private Func<ProceduresCollection> _proceduresInitializer = null;
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

        /// <summary>
        /// Procedures collection
        /// </summary>
        public Bss.Entities.ProceduresCollection Procedures
        {
            get
            {
                /*
                var result = LazyInitializer.EnsureInitialized<Bss.Entities.ProceduresCollection> (ref _proceduresCollection, () => new ProceduresCollection());
                result.ConnectionString = _connectionString;
                result.PreSqlCommand = _preSqlCommand;
                result.SqlExecParameters = SqlExecParameters;
                result.Logger = this._logger;
                */
                var result = LazyInitializer.EnsureInitialized<Bss.Entities.ProceduresCollection>(ref _proceduresCollection, ProceduresInitializer);
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

        public Func<ProceduresCollection> ProceduresInitializer 
        {
            get
            {
                if (_proceduresInitializer == null)
                {
                    if (PackageEnvironment.Mode == PackageMode.Production)
                    {
                        _proceduresInitializer = () => new DBProceduresCollection()
                        {
                            ConnectionString = _connectionString,
                            PreSqlCommand = _preSqlCommand,
                            SqlExecParameters = SqlExecParameters,
                            Logger = this._logger
                        };
                    }
                    else if (PackageEnvironment.Mode == PackageMode.Development)
                    {
                        _proceduresInitializer = () => new DevelopmentProceduresCollection();
                    }
                    else
                    {
                        _proceduresInitializer = PackageEnvironment.ProceduresInitializer;
                    }
                }
                return _proceduresInitializer;
            }
            set
            {
                _proceduresInitializer = value;
            }
        }

        #endregion

        #region [Inner classes]
        public class DBProceduresCollection  :  Bss.Entities.ProceduresCollection
        {
            #region [Properties]
            internal string ConnectionString { get; set; }
            internal string PreSqlCommand { get; set; }
            internal SqlExecParameters SqlExecParameters { get; set; }
            internal ILogger Logger { get; set; }

            #endregion

            #region [Common]
            public override void CallProcedure<T>(T cpm, int? commandTimeOut = null)
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

            public override async Task CallProcedureAsync<T>(T cpm, int? commandTimeOut = null)
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

            public override void CallProcedure(string storedProcedureName, DynamicParameters parameter, int? timeOut = null)
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

            public override async Task CallProcedureAsync(string storedProcedureName, DynamicParameters parameter, int? timeOut = null)
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

            public override void CallRequest<T>(ref T cpm, int? timeOut = null)
            {
                DynamicParameters parameter = new DynamicParameters();

                if (!typeof(T).Equals(typeof(EmptyCallProcedureModel)))
                    parameter.AddProcedureParams(cpm);

                string procedureName = cpm.StoredProcedureName();

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        sqlConnection.Execute(SqlExecParameters, procedureName, parameter, null, timeOut, System.Data.CommandType.StoredProcedure, this.Logger);
                    });
                }

                parameter.FillProcedureResultParams(cpm, false, true, true);
            }

            public override TOut CallRequestResponse<T, TOut>(T cpm, int? timeOut = null, Func<T, TOut> mapFunc = null)
            {
                DynamicParameters parameters = new DynamicParameters();

                if (!typeof(T).Equals(typeof(EmptyCallProcedureModel)))
                    parameters.AddProcedureParams(cpm);

                if (!typeof(TOut).Equals(typeof(EmptyCallProcedureModel)))
                    parameters.AddProcedureParams(Activator.CreateInstance<TOut>(), false, false, true);

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        pre_Command_Exec(sqlConnection);
                        sqlConnection.Execute(SqlExecParameters, cpm.StoredProcedureName(), parameters, null, timeOut, System.Data.CommandType.StoredProcedure, this.Logger);
                    });
                    //var stat = sqlConnection.RetrieveStatistics();
                }

                parameters.FillProcedureResultParams(cpm, false, true, true);

                if (typeof(TOut).Equals(typeof(EmptyCallProcedureModel)))
                {
                    return new EmptyCallProcedureModel() as TOut;
                }
                else if (typeof(TOut).Equals(typeof(EmptyEntityModel)))
                {
                    return new EmptyEntityModel() as TOut;
                }
                /*
                if (typeof(TOut).Equals(typeof(EmptyCallProcedureModel)) ||
                   typeof(TOut).Equals(typeof(EmptyModel)))
                    return null;
                */
                else
                {
                    TOut result = null;
                    if (typeof(T).Equals(typeof(TOut)))
                    {
                        result = cpm as TOut;
                    }
                    else
                    {
                        result = (mapFunc == null) ? MappingService.Map<TOut>(cpm) : mapFunc(cpm);
                    }

                    parameters.FillProcedureResultParams(result, false, true, true);
                    return result;
                }
            }

            public override async Task<TOut> CallRequestResponseAsync<T, TOut>(T cpm, int? timeOut = null)
            {
                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in cpm.DynamicParameters().Where(dp => dp.Value != null))
                {
                    if (v.DBType == System.Data.DbType.String)
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction, int.MaxValue);
                    else
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

            public override TOut CallRequestResponseModelTemplated<T, TOut>(T cpm, int? timeOut = null)
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

            public override async Task<TOut> CallRequestResponseModelTemplatedAsync<T, TOut>(T cpm, int? timeOut = null)
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

            //*************************************************************************************************************
            // Queries
            //*************************************************************************************************************

            public override (TOutCallModel Result, IEnumerable<dynamic> ResultSet) CallRequestResponseQuery<TInCallModel, TOutCallModel>
                (TInCallModel inCallModel, int? timeOut = null)
            {
                /********************************************************************/
                IEnumerable<dynamic> resultSet = null;
                TOutCallModel result = null;

                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Value != null))
                {
                    if (v.DBType == System.Data.DbType.String)
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction, int.MaxValue);
                    else
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction, int.MaxValue);
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
                        var res = sqlConnection.ExecuteQueryMultiple(SqlExecParameters, 
                            inCallModel.StoredProcedureName(), 
                            parameter, 
                            null, 
                            realTimeOut, 
                            System.Data.CommandType.StoredProcedure, 
                            this.Logger);

                        resultSet = res.Read().ToList();
                    });
                }
                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Direction == System.Data.ParameterDirection.InputOutput))
                {
                    v.Value = parameter.Get<dynamic>(v.Name);
                }

                result = MappingService.Map<TOutCallModel>(inCallModel);

                return (Result: result, ResultSet: resultSet);
            }

            public override IEnumerable<TOut> CallRequestResponseQuery<T, TOut>(T cpm, Func<object, TOut> mapper, int? timeOut = null)
            {
                IEnumerable<TOut> result = null;

                if (string.IsNullOrEmpty(cpm.StoredProcedureName()))
                    throw new ArgumentException($"Model {cpm?.GetType()?.Name} has empty procedure name");

                if (mapper == null)
                    throw new NullReferenceException("mapper");

                //DapperProvider dapper = new DapperProvider(ConnectionString);
                DynamicParameters parameter = new DynamicParameters();
                if (cpm is Dictionary<string, Tuple<object, DbType, ParameterDirection, int?>>)
                {
                    var dic = cpm as Dictionary<string, Tuple<object, DbType, ParameterDirection, int?>>;
                    foreach (var item in dic)
                    {
                        parameter.Add(item.Key, item.Value.Item1, item.Value.Item2, item.Value.Item3, item.Value.Item4);
                    }
                }
                else
                {
                    foreach (var v in cpm.DynamicParameters().Where(dp => dp.Value != null))
                    {
                        if (v.DBType == System.Data.DbType.String)
                            parameter.Add(v.Name, v.Value, v.DBType, v.Direction, int.MaxValue);
                        else
                            parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                    }
                }

                foreach (var e in cpm.Expressions())
                {
                    parameter.Output(cpm, e);
                }

                int realTimeOut = timeOut.HasValue ? timeOut.Value : 0;

                using (var sqlConnection = ConnectionManager.BuildSqlConnection(ConnectionString, PreSqlCommand))
                {
                    Exceptions.WrapAction(() =>
                    {
                        var res = sqlConnection.ExecuteQueryMultiple(SqlExecParameters, 
                            cpm.StoredProcedureName(), 
                            parameter, 
                            null, 
                            realTimeOut, 
                            System.Data.CommandType.StoredProcedure, 
                            this.Logger);

                        foreach (var pn in parameter.ParameterNames)
                        {
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

            public override IEnumerable<TOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TOut>
                (TInCallModel inCallModel, out TOutCallModel outCallModel, Func<dynamic, TOut> mapper, int? timeOut = null)
            {
                outCallModel = null;
                TOutCallModel outCallModelTmp = null;
                IEnumerable<TOut> result = null;

                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Value != null))
                {
                    if (v.DBType == System.Data.DbType.String)
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction, int.MaxValue);
                    else
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction, int.MaxValue);
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
                        var res = sqlConnection.ExecuteQueryMultiple(SqlExecParameters,
                            inCallModel.StoredProcedureName(),
                            parameter,
                            null,
                            realTimeOut,
                            System.Data.CommandType.StoredProcedure,
                            this.Logger);

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
                        /*
                         * +		readEx	{"{\"LevelMessage\": \"17\",\"ErrNumber\": \"50243\",\"Message\": \"������ ��������� ���������� ��������� ����� (Agreements): (@Agr_ID,@Grt_ID,@Rpr_ID,@DateStart,@Abn_ID)=(1918003,1663,-1,'2021-02-01 00:00:00.000',0: (������ ��������� ������������� ������� ��������� ����� (RepresentationTariffPlanBind): (������ �������� �������� �� ������: (���������� ������������ ��� �������� ��������: TemplateID = 5894 ServiceCode = 5001)))\",\"State\": \"1\",\"HelpLink\": \"\",\"errNumberReason\": \"51625\",\"Data\":{\"LevelMessage\": \"17\",\"ErrNumber\": \"50240\",\"Message\": \"������ ��������� ������������� ������� ��������� ����� (RepresentationTariffPlanBind): (������ �������� �������� �� ������: (���������� ������������ ��� �������� ��������: TemplateID = 5894 ServiceCode = 5001))\",\"State\": \"1\",\"HelpLink\": \"\",\"errNumberReason\": \"51625\",\"Data\":{\"LevelMessage\": \"17\",\"ErrNumber\": \"50271\",\"Message\": \"������ �������� �������� �� ������: (���������� ������������ ��� �������� ��������: TemplateID = 5894 ServiceCode = 5001)\",\"State\": \"1\",\"HelpLink\": \"\",\"errNumberReason\": \"51625\",\"Data\":{\"LevelMessage\": \"17\",\"ErrNumber\": \"51625\",\"Message\": \"���������� ������������ ��� �������� ��������: TemplateID = 5894 ServiceCode = 5001\",\"State\": \"1\",\"HelpLink\": \"\",\"errNumberReason\": \"51625\",\"ResolveUrl\": \"\"},\"ResolveUrl\": \"\"},\"ResolveUrl\": \"\"},\"ResolveUrl\": \"\"}"}	System.Exception {System.Data.SqlClient.SqlException}

                         */
                        catch (System.Data.SqlTypes.SqlTypeException sqlTypeException)
                        {
                            throw sqlTypeException;
                        }
                        catch (System.Data.SqlClient.SqlException sqlException)
                        {
                            throw sqlException;
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
                }
            }

            public override IEnumerable<TResOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TProcOut, TResOut>
                (TInCallModel inCallModel, out TOutCallModel outCallModel, Func<TProcOut, TResOut> mapper = null, int? timeOut = null)
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
                    if (v.DBType == System.Data.DbType.String)
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction, int.MaxValue);
                    else
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction, int.MaxValue);
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
                        var res = sqlConnection.ExecuteQueryMultiple(SqlExecParameters,
                            inCallModel.StoredProcedureName(),
                            parameter,
                            null,
                            realTimeOut,
                            System.Data.CommandType.StoredProcedure,
                            this.Logger);

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

            public override IEnumerable<dynamic> CallRequestResponseQuery<TInCallModel, TOutCallModel>
                (TInCallModel inCallModel, out TOutCallModel outCallModel, int? timeOut = null)
            {
                outCallModel = null;
                IEnumerable<dynamic> result = null;

                //DapperProvider dapper = new DapperProvider(ConnectionString);
                DynamicParameters parameter = new DynamicParameters();

                foreach (var v in inCallModel.DynamicParameters().Where(dp => dp.Value != null))
                {
                    if (v.DBType == System.Data.DbType.String)
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction, int.MaxValue);
                    else
                        parameter.Add(v.Name, v.Value, v.DBType, v.Direction);
                }

                foreach (var v in inCallModel.DynamicParameters().Where(dp => (dp.Value == null) && (dp.Direction == System.Data.ParameterDirection.InputOutput)))
                {
                    if ((v.Value == null) && (v.DBType == System.Data.DbType.String))
                    {
                        parameter.Add(v.Name, "", v.DBType, v.Direction, int.MaxValue);
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
                            result = sqlConnection.ExecuteQuery(SqlExecParameters, inCallModel.StoredProcedureName(), parameter, null, false, realTimeOut, System.Data.CommandType.StoredProcedure, this.Logger);
                            result = result?.ToList();
                        }
                        else
                        {

                            var res = sqlConnection.ExecuteQueryMultiple(SqlExecParameters, inCallModel.StoredProcedureName(), parameter, null, realTimeOut, System.Data.CommandType.StoredProcedure, this.Logger);
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

            internal DBProceduresCollection()
            { }
        }

        public class TablesCollection
        {
            internal string ConnectionString { get; set; }
        }
        #endregion

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

