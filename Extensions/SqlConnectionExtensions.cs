using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading;
using System.Threading.Tasks;
using Dapper;
using Microsoft.Extensions.Logging;
using UCP.Common.Plugin.Attributes;
using static Dapper.SqlMapper;

namespace Bss.Entities
{
    [DocIgnore]
    public static class SqlConnectionExtensions
    {
        private static T GenExec<T>(Func<string, object, IDbTransaction, int?,  CommandType?, T> func,
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
                    var dParams = param as DynamicParameters;
                    if (dParams != null)
                    {
                        logger?.LogInformation($"[{execGuid}] Attempt {attemptNumber} Start executing {sql} with parameters {dParams.AsLoggerString()}");
                    }
                    else
                        logger?.LogInformation($"[{execGuid}] Attempt {attemptNumber} Start executing {sql} with parameter {param}");

                    //return cnn.Execute(sql, param, transaction, realCommandTimeout, commandType);
                    var res = func(sql, param, transaction, commandTimeout, commandType);
                    return res;
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

        public static int Execute(this IDbConnection cnn,
            SqlExecParameters sqlExecParameters,
            string sql, 
            object param = null, 
            IDbTransaction transaction = null, 
            int? commandTimeout = null, 
            CommandType? commandType = null,
            ILogger logger = null)
        {
            return GenExec<int>((s, o, dbT, tmOut, cmdType) => cnn.Execute(s, o, dbT, tmOut, cmdType),
                sqlExecParameters,
                sql,
                param,
                transaction,
                commandTimeout,
                commandType,
                logger);
            /*
            var attemptNumber = 1;
            int realCommandTimeout = commandTimeout.HasValue ? commandTimeout.Value : 0;
            System.Guid execGuid = System.Guid.NewGuid();
            while (true)
            {
                try
                {
                    var dParams = param as DynamicParameters;
                    if (dParams != null)
                    {
                        logger?.LogInformation($"[{execGuid}] Attempt {attemptNumber} Start executing {sql} with parameters {dParams.AsLoggerString()}");
                    }
                    else
                        logger?.LogInformation($"[{execGuid}] Attempt {attemptNumber} Start executing {sql} with parameter {param}");

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
            */
        }

        public static async Task<int> ExecuteAsync(this IDbConnection cnn,
            SqlExecParameters sqlExecParameters,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null,
            ILogger loger = null)
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
                    /*
                    if (!exception.IsDeadLockException())
                    {
                        throw;
                    }
                    else if (attemptNumber == sqlExecParameters.DeadlockRetryCount + 1)
                    {
                        throw;
                    }
                    */
                }
                attemptNumber++;
                Thread.Sleep(300);
            }
        }

        public static IEnumerable<dynamic> ExecuteQuery(this IDbConnection cnn,
            SqlExecParameters sqlExecParameters,
            string sql, 
            object param = null, 
            IDbTransaction transaction = null, 
            bool buffered = true, 
            int? commandTimeout = null, 
            CommandType? commandType = null,
            ILogger logger = null)
        {
            return GenExec<IEnumerable<dynamic>>((s, o, dbT, tmOut, cmdType) => cnn.Query(s, o, dbT, buffered, tmOut, cmdType),
                sqlExecParameters,
                sql,
                param,
                transaction,
                commandTimeout,
                commandType,
                logger);

            /*
            var res = cnn.Query(sql,
                param,
                transaction,
                buffered,
                commandTimeout,
                commandType);
            return res;
            */
        }

        public static GridReader ExecuteQueryMultiple(this IDbConnection cnn,
            SqlExecParameters sqlExecParameters,
            string sql,
            object param = null,
            IDbTransaction transaction = null,
            int? commandTimeout = null,
            CommandType? commandType = null,
            ILogger logger = null)
        {
            return GenExec<GridReader>((s, o, dbT, tmOut, cmdType) => cnn.QueryMultiple(s, o, dbT, tmOut, cmdType),
                sqlExecParameters,
                sql,
                param,
                transaction,
                commandTimeout,
                commandType,
                logger);
        }
    }
}
