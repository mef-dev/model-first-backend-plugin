using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Composition;
using System.Linq;
using System.Reflection;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    /// <summary>
    /// Implements only config - related base operations
    /// </summary>
    [DocIgnore]
    public class BasePlugin
    {
        #region [Properties]
        private const int defaultPostTimeout = 0;
        private const int defaultPutTimeout = 0;
        protected RuntimeState RuntimeState { get; set; }
        protected TimeSpan IdleTime { get; set; } = TimeSpan.FromSeconds(5);
        protected string RuntimeStateDescription { get; set; } = "Unknown ...";
        protected string PreSqlCommand { get; set; }
        protected SqlExecParameters SqlExecParameters { get; set; }
        protected int DefaultPostTimeout { get; set; } = defaultPostTimeout;
        protected int DefaultPutTimeout { get; set; } = defaultPutTimeout;
        protected IDictionary<string, string> ConnectionStrings { get; set; }

        #endregion

        protected virtual void ReadConfig(string cfgFileName)
        {
            ReadConfig(PluginBaseConfig.Get(cfgFileName));
        }

        protected virtual void ReadConfig(IConfigurationRoot cfg)
        {
            ReadConfig(PluginBaseConfig.Get(cfg));
        }

        protected virtual void ReadConfig(PluginBaseConfig pbCfg)
        {
            this.ConnectionStrings = pbCfg.ConnectionStrings.ToDictionary(kvp => kvp.Key, kvp => kvp.Value);
            this.RuntimeState = pbCfg.RuntimeState;
            this.IdleTime = pbCfg.IdleTime;
            this.RuntimeStateDescription = pbCfg.RuntimeStateDescription;
            this.PreSqlCommand = pbCfg.PreSqlCommand;
            this.DefaultPostTimeout = pbCfg.DefaultPostTimeout;
            this.DefaultPutTimeout = pbCfg.DefaultPutTimeout;
            this.SqlExecParameters = new SqlExecParameters()
            {
                DeadlockRetryCount = pbCfg.SqlExecParameters.DeadlockRetryCount
            };
        }

        internal class ConnectionStringCollection
        {
            public string WriteConnection
            {
                get
                {
                    string result;
                    if (ConnectionStrings == null)
                        result = null;
                    else
                        ConnectionStrings.TryGetValue("WriteConnection", out result);
                    return result;
                }
            }

            public string ReadConnection
            {
                get
                {
                    string result;
                    if (ConnectionStrings == null)
                        result = null;
                    else
                        ConnectionStrings.TryGetValue("ReadConnection", out result);
                    return result;
                }
            }

            public IDictionary<string, string> ConnectionStrings { get; set; } = null;

            internal ConnectionStringCollection(IDictionary<string, string> connectionStrings)
            {
                ConnectionStrings = connectionStrings;
            }
        }

        internal static void CorrectWebModelBase(BaseEntity webModel,
            IApiContext apiContext,
            string entityName = null,
            string parent = null)
        {
            if (webModel == null)
                return;

            if (string.IsNullOrEmpty(webModel.Id))
            {
                webModel.Id = "0";
            }
            if (string.IsNullOrEmpty(webModel.ParentId))
            {
                webModel.ParentId = "0";
            }

            if (string.IsNullOrEmpty(webModel.Format))
            {
                webModel.Format = "json";
            }


            IPropertyIndexer pi = webModel as IPropertyIndexer;

            //IDictionary<string, object> dataBagDic = this._apiContext.DataBag as IDictionary<string, object>;
            IDictionary<string, object> dataBagDic = apiContext?.DataBag as IDictionary<string, object>;
            var hi = apiContext?.HeadersInfo;



            if (pi != null)
            {
                object ho = null;

                if (string.Equals(pi["EntityName"], BaseEntity.emptyId))
                {
                    pi["EntityName"] = null;
                }

                if (string.IsNullOrEmpty((string)pi["EntityName"]) && !string.IsNullOrEmpty(entityName))
                {
                    pi["EntityName"] = entityName;
                }

                #region [CacheControlDate]
                if ((true == dataBagDic?.TryGetValue("cache-control-date", out ho)) ||
                    (true == hi?.TryGetValue("cache-control-date", out ho)))
                {
                    pi["CacheControlDate"] = apiContext?.DataBag.CacheControlDate;
                }
                #endregion

                #region [IfModifiedSince]
                if ((true == dataBagDic?.TryGetValue("if-modified-since", out ho)) ||
                    (true == hi?.TryGetValue("if-modified-since", out ho)))
                {
                    pi["IfModifiedSince"] = DateTime.Parse((string)ho);
                    pi["IfModifiedSinceDate"] = DateTime.Parse((string)ho);
                    pi["CacheControlDate"] = DateTime.Parse((string)ho);
                }
                #endregion

                #region [ExternalSystemCode/system]
                if ((true == dataBagDic?.TryGetValue("system", out ho)) ||
                    (true == hi?.TryGetValue("system", out ho)))
                {
                    pi["ExternalSystemCode"] = ho;
                    pi["system"] = ho;
                }

                #endregion

                #region [global_unique_id]
                if (true == hi?.TryGetValue("global_unique_id", out ho))
                {
                    pi["global_unique_id"] = ho;
                }
                #endregion

                #region [cacheStatus]
                if (true == dataBagDic?.TryGetValue("cacheStatus", out ho))
                {
                    pi["cacheStatus"] = ho;
                }
                #endregion

                var modValue = pi["ModBy"] ?? pi["ModifiedBy"];

                if (modValue == null)
                {
                    pi["ModBy"] = apiContext?.User?.Identity?.Name;
                    pi["ModifiedBy"] = apiContext?.User?.Identity?.Name;
                }

                modValue = pi["ModFrom"] ?? pi["ModifiedFrom"];

                if (modValue == null)
                {
                    pi["ModFrom"] = apiContext?.User?.Identity?.Name;
                    pi["ModifiedFrom"] = apiContext?.User?.Identity?.Name;
                }

                if (!string.IsNullOrEmpty(parent))
                    pi["EntityName"] = parent;
            }
        }
    }
}