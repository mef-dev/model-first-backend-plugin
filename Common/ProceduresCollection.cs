using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bss.Entities
{
    public abstract class ProceduresCollection
    {
        public abstract void CallProcedure<T>(T cpm, int? commandTimeOut = null) where T : class, ICallProcedureModel<T>;

        public abstract Task CallProcedureAsync<T>(T cpm, int? commandTimeOut = null) where T : class, ICallProcedureModel<T>;

        public abstract void CallProcedure(string storedProcedureName, DynamicParameters parameter, int? timeOut = null);

        public abstract Task CallProcedureAsync(string storedProcedureName, DynamicParameters parameter, int? timeOut = null);

        public abstract void CallRequest<T>(ref T cpm, int? timeOut = null)
            where T : class, ICallProcedureModel<T>;

        public abstract TOut CallRequestResponse<T, TOut>(T cpm, int? timeOut = null, Func<T,TOut> mapFunc= null)
            where T : class, ICallProcedureModel<T>
            where TOut : class, ICallProcedureModel<TOut>;

        public abstract Task<TOut> CallRequestResponseAsync<T, TOut>(T cpm, int? timeOut = null)
            where T : class, ICallProcedureModel<T>
            where TOut : class;

        public abstract TOut CallRequestResponseModelTemplated<T, TOut>(T cpm, int? timeOut = null)
            where T : class, ICallProcedureModel<T>
            where TOut : class;

        public abstract Task<TOut> CallRequestResponseModelTemplatedAsync<T, TOut>(T cpm, int? timeOut = null)
            where T : class, ICallProcedureModel<T>
            where TOut : class;

        public abstract (TOutCallModel Result, IEnumerable<dynamic> ResultSet) CallRequestResponseQuery<TInCallModel, TOutCallModel>
            (TInCallModel inCallModel, int? timeOut = null)
            where TInCallModel : class, ICallProcedureModel<TInCallModel>
            where TOutCallModel : class;

        public abstract IEnumerable<TOut> CallRequestResponseQuery<T, TOut>(T cpm, Func<object, TOut> mapper, int? timeOut = null)
                        where T : class, ICallProcedureModel<T>;

        public abstract IEnumerable<TOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TOut>
            (TInCallModel inCallModel, out TOutCallModel outCallModel, Func<dynamic, TOut> mapper, int? timeOut = null)
            where TInCallModel : class, ICallProcedureModel<TInCallModel>
            where TOutCallModel : class
            where TOut : class;

        public abstract IEnumerable<TResOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TProcOut, TResOut>
            (TInCallModel inCallModel, out TOutCallModel outCallModel, Func<TProcOut, TResOut> mapper = null, int? timeOut = null)
            where TInCallModel : class, ICallProcedureModel<TInCallModel>
            where TOutCallModel : class
            where TProcOut : class
            where TResOut : class;

        public abstract IEnumerable<dynamic> CallRequestResponseQuery<TInCallModel, TOutCallModel>
            (TInCallModel inCallModel, out TOutCallModel outCallModel, int? timeOut = null)
            where TInCallModel : class, ICallProcedureModel<TInCallModel>
            where TOutCallModel : class;
    }
}

