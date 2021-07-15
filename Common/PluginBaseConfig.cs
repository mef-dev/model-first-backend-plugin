using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public sealed class PluginBaseConfig
    {
        #region [Fields]
        private static PluginBaseConfig _instance;
        private static readonly int defaultPostTimeout = 0;
        private static readonly int defaultPutTimeout = 0;

        #endregion

        #region [Properties]
        public RuntimeState RuntimeState { get; private set; }
        public TimeSpan IdleTime { get; private set; } = TimeSpan.FromSeconds(5);
        public string RuntimeStateDescription { get; private set; } = "Unknown ...";
        public string PreSqlCommand { get; private set; }
        public SqlExecParameters SqlExecParameters { get; private set; }
        public int DefaultPostTimeout { get; private set; } = defaultPostTimeout;
        public int DefaultPutTimeout { get; private set; } = defaultPutTimeout;
        [Obsolete]
        //public string ConnectionString { get; private set; }
        public string ConfigName { get; private set; }
        public IDictionary<string, string> ConnectionStrings { get; private set; }

        #endregion

        private PluginBaseConfig(string configName)
        {
            this.ConfigName = configName;
            var configRoot = new ConfigurationBuilder()
                        .AddJsonFile(configName)
                        .Build();
            InitConfig(configRoot);
        }

        private PluginBaseConfig(IConfigurationRoot configRoot)
        {
            InitConfig(configRoot);
        }

        public static PluginBaseConfig Get(string configName)
        {
            PluginBaseConfig result = LazyInitializer.EnsureInitialized<PluginBaseConfig>(ref _instance, () => new PluginBaseConfig(configName));

            if (!string.Equals(configName, result.ConfigName, StringComparison.InvariantCultureIgnoreCase))
            {
                throw new InvalidOperationException($"Config is already initialized with other config name : '{result.ConfigName}'");
            }

            return result;
        }

        public static PluginBaseConfig Get(IConfigurationRoot configRoot)
        {
            PluginBaseConfig result = LazyInitializer.EnsureInitialized<PluginBaseConfig>(ref _instance, () => new PluginBaseConfig(configRoot));

            return result;
        }

        private void InitConfig(IConfigurationRoot configRoot)
        {
            var connectionStringsSections = configRoot.GetSection("ConnectionStrings");

            this.ConnectionStrings = connectionStringsSections.AsEnumerable()
                .ToDictionary((kvp) => kvp.Key.Split(":").Last(), (kvp) => kvp.Value);

            if (false == this.ConnectionStrings?.Any())
                throw new ArgumentNullException("Connection strings is empty")
                {
                    Source = "Plugin base config"
                };

            /*
            ConnectionString = configRoot.GetConnectionString("ConnectionString");

            if(string.IsNullOrEmpty(ConnectionString))
                ConnectionString = configRoot.GetValue<string>("ConnectionString");

            if (string.IsNullOrEmpty(ConnectionString))
                throw new ArgumentNullException("Connection string is empty")
                {
                    Source = "Plugin base config"
                };
            */

            this.RuntimeState = Enum.Parse<RuntimeState>(configRoot.GetValue<string>("RuntimeState", "Run"));
            string startTime = configRoot.GetValue<string>("StartTime", null);

            DateTime dt = DateTime.Now;
            if (DateTime.TryParse(startTime, out dt))
            {
                this.IdleTime = dt - DateTime.Now;
            }
            else
            {
                this.IdleTime = TimeSpan.FromSeconds(30);
            }

            this.RuntimeStateDescription = configRoot.GetValue<string>("RuntimeStateDescription", "Running");
            this.PreSqlCommand = configRoot.GetValue<string>("PreSqlCommand", null);
            this.DefaultPostTimeout = configRoot.GetValue<int>("DefaultPostTimeout", defaultPostTimeout);
            this.DefaultPutTimeout = configRoot.GetValue<int>("DefaultPutTimeout", defaultPutTimeout);
            this.SqlExecParameters = new SqlExecParameters()
            {
                DeadlockRetryCount = configRoot.GetValue<int>("DeadlockRetryCount", 3)
            };
        }
    }
}