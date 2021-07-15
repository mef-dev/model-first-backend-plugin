using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Logging;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public static class SqlConnectionExtensions
    {
        public static int Execute(this IDbConnection cnn,
            SqlExecParameters sqlExecParameters,
            string sql, 
            object param = null, 
            IDbTransaction transaction = null, 
            int? commandTimeout = null, 
            CommandType? commandType = null,
            ILogger logger = null)
        {
            var attemptNumber = 1;
            int realCommandTimeout = commandTimeout.HasValue ? commandTimeout.Value : 0;
            System.Guid execGuid = System.Guid.NewGuid();
            while (true)
            {
                try
                {
                    logger?.LogInformation($"[{execGuid}] Attempt {attemptNumber} Start executing {sql}");
                    return cnn.Execute(sql, param, transaction, realCommandTimeout, commandType);
                }
                catch (SqlException exception)
                {
                    if (exception.IsDeadLockException() || exception.IsRetryNeeded())
                    {
                        if (attemptNumber == sqlExecParameters.DeadlockRetryCount + 1)
                        {
                            throw;
                        }
                    }
                    else
                    {
                        throw;
                    }
                }
                finally
                {
                    logger?.LogInformation($"[{execGuid}] Attempt {attemptNumber} stop executing {sql}");
                }
                attemptNumber++;
                Thread.Sleep(300);
            }
        }

        public static async Task<int> ExecuteAsync(this IDbConnection cnn,
            SqlExecParameters sqlExecParameters,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null)
        {
            var attemptNumber = 1;
            int realCommandTimeout = commandTimeout.HasValue ? commandTimeout.Value : 0;
            while (true)
            {
                try
                {
                    return await cnn.ExecuteAsync(sql, param, transaction, realCommandTimeout, commandType).ConfigureAwait(false);
                }
                catch (SqlException exception)
                {
                    if (exception.IsDeadLockException() || exception.IsRetryNeeded())
                    {
                        if (attemptNumber == sqlExecParameters.DeadlockRetryCount + 1)
                        {
                            throw;
                        }
                    }
                    else
                    {
                        throw;
                    }
                }
                attemptNumber++;
                Thread.Sleep(300);
            }
        }
    }
}