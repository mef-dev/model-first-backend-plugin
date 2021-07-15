using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public static class Exceptions
    {
        #region [const]
        private const int DeadlockErrorNumber = 1205;
        private const int LockingErrorNumber = 1222;
        private const int UpdateConflictErrorNumber = 3960;
        //для ретрай - функционала
        private const int TimeoutExpiredErrorNumber = -2;
        private const int CouldNotOpenConnectionErrorNumber = 53;
        private const int TransportFailErrorNumber = 121;
        //вот тут не надо ретрай
        private const int HandledDeadlockErrorNumber = 50999;
        private const int SQLErrorNumber = 50000;

        public static IEnumerable<int> DeadLockFeatures
        {
            get
            {
                yield return DeadlockErrorNumber;
                yield return LockingErrorNumber;
                yield return UpdateConflictErrorNumber;
                yield break;
            }
        }

        public static IEnumerable<int> RetryNeededFeatures
        {
            get
            {
                yield return DeadlockErrorNumber;
                //yield return TimeoutExpiredErrorNumber;
                yield return CouldNotOpenConnectionErrorNumber;
                yield return TransportFailErrorNumber;
                yield break;
            }
        }

        #endregion
        public static void WrapAction(Action action, string  name = null)
        {
            string operationName = string.IsNullOrEmpty(name) ? "sql command" : name;
            Stopwatch sw = new Stopwatch();
            try
            {
                    sw.Start();
                    action();
            }
            catch (System.Data.SqlTypes.SqlTypeException sqlTypeException)
            {
                throw sqlTypeException.Handle();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                sw.Stop();
                throw sqlException.Handle(sw.ElapsedMilliseconds);
            }
            catch (Exception exception)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(exception.Message)
                {
                    Source = exception.Source
                };
            }
            finally
            {
                sw.Stop();
            }
        }

        public static async Task WrapActionAsync(Func<Task> action)
        {
            Stopwatch sw = new Stopwatch();
            try
            {
                sw.Start();
                await action();
            }
            catch (System.Data.SqlTypes.SqlTypeException sqlTypeException)
            {
                throw sqlTypeException.Handle();
            }
            catch (System.Data.SqlClient.SqlException sqlException)
            {
                sw.Stop();
                throw sqlException.Handle(sw.ElapsedMilliseconds);
            }
            catch (Exception exception)
            {
                throw new UCP.Common.Plugin.CommonPlatformException(exception.Message)
                {
                    Source = exception.Source
                };
            }
            finally
            {
                sw.Stop();
            }
        }

        public static UCP.Common.Plugin.CommonPlatformException Handle(this System.Data.SqlTypes.SqlTypeException sqlTypeException)
        {
            object dt = null;

            try
            {
                BaseSqlExceptionModel[] ar = JsonConvert.DeserializeObject<BaseSqlExceptionModel[]>(sqlTypeException.Message);
                RawSqlExceptionModel[] arr = ar.Select(a => new RawSqlExceptionModel(a)).ToArray();
                dt = arr;
            }
            catch (Exception) { }


            return new UCP.Common.Plugin.CommonPlatformException(sqlTypeException.Message, sqlTypeException)
            {
                Source = sqlTypeException.Source,
            };
        }

        public static UCP.Common.Plugin.CommonPlatformException Handle(this System.Data.SqlClient.SqlException sqlException, long? elapsedMilliseconds)
        {
            //object dt = null;
            BaseSqlExceptionModel baseSqlExceptionModel = null;
            int actualStatusCode = StatusCodes.Status500InternalServerError;

            #region [Deadlock]
            if (sqlException.IsRetryNeeded() || sqlException.IsDeadLockException())
            {
                Trace.TraceError($"SQL deadlock detected : {sqlException}");
            }


            if (sqlException.Number == Exceptions.HandledDeadlockErrorNumber)
            {
                return new UCP.Common.Plugin.ServiceUnavailableException($"Системная ошибка с кодом {sqlException.Number}: необходим повтор операции")
                {
                    LevelMessage = sqlException.Class,
                    Number = sqlException.Number,
                    Source = sqlException.Source,
                    State = sqlException.State,
                    StatusCode = StatusCodes.Status408RequestTimeout,
                    EstimatedDownTime = TimeSpan.FromMinutes(1),
                    ReasonCode = (int)ReasonCodes.ServiceAccessError
                };
            }

            #endregion

            try
            {
                #region [Examples]
                /*
        var str1 = @"[ {""LevelMessage"":17,""ErrNumber"":50227,""Message"":""Ошибка определения типа узла дерева(Abonents)"",""State"":1,""HelpLink"":null,""Xml"":null,
""Data"":[ {""LevelMessage"":17,""ErrNumber"":50227,""Message"":""Вложенная ошибка"",""State"":1,""HelpLink"":null,""Xml"":null,
""Data"":null,""ResolveUrl"":null}],""ResolveUrl"":null}]";
        */
                /*
                 [ {"LevelMessage":17,
                "ErrNumber":50201,
                "Message":"Ошибка добавления адреса абоненту: ",
                "State":1,
                "HelpLink":null,
                "Xml":null,
                "Data":[ {"LevelMessage":16,"ErrNumber":50213,"Message":"Не найден район (Districts): - по заданному ИД; Dstr_ID=81040Prov_ID=26,IsExternalID=1 ","State":1,"HelpLink":null,"Xml":null,"Data":null,"ResolveUrl":null}],
                "ResolveUrl":null}]
                 */
                /*
Cannot insert the value NULL into column 'PartitionCriteria', table 'Unibill_dev_etalon.dbo.SysLog'; column does not allow nulls. INSERT fails.
{"LevelMessage": "17","ErrNumber": "50268","Message": "Не найден узел дерева верхнего уровня: ","State": "1","HelpLink": "","Xml": "","Data":{},"ResolveUrl": ""}
The statement has been terminated.                  
              */
                /*
                  { "source":"Core .Net SqlClient Data Provider","number":50000,"class":17,"state":1,"message":"{\"LevelMessage\": \"17\",\"ErrNumber\": \"50243\",\"Message\": \"Ошибка изменения соглашения тарифного плана (Agreements): \",\"State\": \"1\",\"HelpLink\": \"\",\"Xml\": \"50243\",\"Data\":(@Agr_ID,@Grt_ID,@Rpr_ID,@DateStart,@Abn_ID)=(0,1559,-1,'2020-07-20 00:00:00.000',11132304 {\"LevelMessage\": \"17\",\"ErrNumber\": \"50249\",\"Message\": \"Ошибка определения внутреннего номера (Extentions): \",\"State\": \"1\",\"HelpLink\": \"\",\"Xml\": \"50249\",\"Data\":{},\"ResolveUrl\": \"\"},\"ResolveUrl\": \"\"}","status":0}

  */
                #endregion

                var sqlExceptionMessage = sqlException.Errors.Cast<SqlError>().Where(se => (se.Class > 0) &&
                    (se.Message.Trim().StartsWith("{")) &&
                    (se.Message.Trim().EndsWith("}"))).
                    Select(se => se.Message).
                    FirstOrDefault();

                baseSqlExceptionModel = JsonConvert.DeserializeObject<BaseSqlExceptionModel>(sqlExceptionMessage);
            }
            catch (Exception) { }

            if (baseSqlExceptionModel != null)
            {
                baseSqlExceptionModel.Number = sqlException.Number;
                if (baseSqlExceptionModel.ErrNumber == Exceptions.HandledDeadlockErrorNumber)
                {
                    actualStatusCode = StatusCodes.Status408RequestTimeout;
                }

                UCP.Common.Plugin.CommonPlatformException result = baseSqlExceptionModel.CreateCommonPlatformException(actualStatusCode);

                if (result != null)
                {
                    result.IsCompleted = true;
                    throw result;
                }
            }

            actualStatusCode = ResolveActualStatusCode(sqlException);

            if (actualStatusCode == StatusCodes.Status503ServiceUnavailable)
            {
                var result = new UCP.Common.Plugin.ServiceUnavailableException(sqlException.Message)
                {
                    LevelMessage = sqlException.Class,
                    Number = sqlException.Number,
                    Source = sqlException.Source,
                    State = sqlException.State,
                    StatusCode = actualStatusCode,
                    EstimatedDownTime = TimeSpan.FromMinutes(1),
                    ReasonCode = (int)ReasonCodes.ServiceAccessError
                };
                if (elapsedMilliseconds.HasValue)
                {
                    result.Data.Add("operationDuration", elapsedMilliseconds);
                }
                return result;
            }
            else
            {
                var result = new UCP.Common.Plugin.ServiceUnavailableException(sqlException.Message)
                {
                    LevelMessage = sqlException.Class,
                    Number = sqlException.Number,
                    Source = sqlException.Source,
                    State = sqlException.State,
                    StatusCode = actualStatusCode
                };
                if (elapsedMilliseconds.HasValue)
                {
                    result.Data.Add("operationDuration", elapsedMilliseconds);
                }
                return result;
            }
        }

        private static int ResolveActualStatusCode(SqlException sqlException)
        {
            int actualStatusCode = StatusCodes.Status500InternalServerError;
            //Ошибка 503 - TimeoutExpiredErrorNumber ИЛИ Количество ретраев исчерпано и НЕ DeadLockFeatures
            //Ошибка 408 - DeadLockFeatures И Количество ретраев исчерпано
            //пс. этот код в принципе будет выполняться только после исчерпания попыток
            //если дедлок
            if (sqlException.IsDeadLockException())
                return StatusCodes.Status408RequestTimeout;
            else
            if (sqlException.Number == TimeoutExpiredErrorNumber) // Истекло время ожидание 
                return StatusCodes.Status503ServiceUnavailable;
            else
            /*
            //если дедлок или таймаут
            if (sqlException.IsDeadLockException() || sqlException.IsRetryNeeded())
                return StatusCodes.Status408RequestTimeout;
            else
            if (sqlException.Number == -2) // Истекло время ожидание 
                return StatusCodes.Status503ServiceUnavailable;
            else
            */
            if (sqlException.Number == 50101 || sqlException.Number == 50100 || sqlException.Number == 50182)	// Значит, что произошла не фатальная ошибка.
            {
            }
            else
            if ((sqlException.Class >= 12 && sqlException.Class <= 14) || (sqlException.Class >= 18 && sqlException.Class <= 24))	// Значит, что произошла ошибка, из-за которой соединение разорвано. Ощибки с классом 17 - обработаннЫе нами
            {
                return StatusCodes.Status503ServiceUnavailable;
            }
            else
            if (sqlException.Class == 11 || sqlException.Class == 15 || sqlException.Class == 16)	// Значит, что произошла ошибка.
            {
                return StatusCodes.Status503ServiceUnavailable;
            }
            else
            if (sqlException.Number >= 0 && sqlException.Number <= 10)	// Значит, что произошла не фатальная ошибка.
            {
            }
            else
            if (sqlException.Number >= 0 && sqlException.Number <= 24)
            {
            }
            return actualStatusCode;
        }

        #region [IsDeadLock]
        public static bool IsDeadLockException(this SqlException exception)
        {
            if (exception == null)
                return false;
            else
                return DeadLockFeatures.Contains(exception.Number) ||
                    exception.Errors.IsDeadLockException();
        }

        public static bool IsDeadLockException(this SqlError error)
        {
            if (error == null)
                return false;
            else
                return DeadLockFeatures.Contains(error.Number);
        }

        public static bool IsDeadLockException(this SqlErrorCollection sqlErrorCollection)
        {
            if (sqlErrorCollection == null)
                return false;
            else
                return sqlErrorCollection.Cast<SqlError>().Any(error => error.IsDeadLockException());
        }
        #endregion

        #region [IsRetryNeeded]
        public static bool IsRetryNeeded(this SqlException exception)
        {
            if (exception == null)
                return false;
            else
                return RetryNeededFeatures.Contains(exception.Number) ||
                    exception.Errors.IsRetryNeeded();
        }

        public static bool IsRetryNeeded(this SqlError error)
        {
            if (error == null)
                return false;
            else
                return RetryNeededFeatures.Contains(error.Number);
        }

        public static bool IsRetryNeeded(this SqlErrorCollection sqlErrorCollection)
        {
            if (sqlErrorCollection == null)
                return false;
            else
                return sqlErrorCollection.Cast<SqlError>().Any(error => error.IsRetryNeeded());
        }
        #endregion
    }
}