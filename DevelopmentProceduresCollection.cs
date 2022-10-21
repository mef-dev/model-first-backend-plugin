using Dapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Bss.Entities
{
    public class DevelopmentProceduresCollection : ProceduresCollection
    {
        public override void CallProcedure<T>(T cpm, int? commandTimeOut = null)
        {
            throw new NotImplementedException();
        }

        public override void CallProcedure(string storedProcedureName, DynamicParameters parameter, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override Task CallProcedureAsync<T>(T cpm, int? commandTimeOut = null)
        {
            throw new NotImplementedException();
        }

        public override Task CallProcedureAsync(string storedProcedureName, DynamicParameters parameter, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override void CallRequest<T>(ref T cpm, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override TOut CallRequestResponse<T, TOut>(T cpm, int? timeOut = null, Func<T, TOut> mapFunc = null)
        {
            throw new NotImplementedException();
        }

        public async override Task<TOut> CallRequestResponseAsync<T, TOut>(T cpm, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override TOut CallRequestResponseModelTemplated<T, TOut>(T cpm, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override Task<TOut> CallRequestResponseModelTemplatedAsync<T, TOut>(T cpm, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override (TOutCallModel Result, IEnumerable<dynamic> ResultSet) CallRequestResponseQuery<TInCallModel, TOutCallModel>(TInCallModel inCallModel, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        #region [CallRequestResponseQuery]
        public override IEnumerable<TOut> CallRequestResponseQuery<T, TOut>(T cpm, Func<object, TOut> mapper, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TOut>(TInCallModel inCallModel, out TOutCallModel outCallModel, Func<dynamic, TOut> mapper, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<TResOut> CallRequestResponseQuery<TInCallModel, TOutCallModel, TProcOut, TResOut>(TInCallModel inCallModel, out TOutCallModel outCallModel, Func<TProcOut, TResOut> mapper = null, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        public override IEnumerable<dynamic> CallRequestResponseQuery<TInCallModel, TOutCallModel>(TInCallModel inCallModel, out TOutCallModel outCallModel, int? timeOut = null)
        {
            throw new NotImplementedException();
        }

        #endregion    
    }
}
