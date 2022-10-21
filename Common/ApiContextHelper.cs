using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
using UCP.Common.Plugin.Models.Config;
using UCP.Common.Plugin.Services;

namespace Bss.Entities
{
    [DocIgnore]
    public static class ApiContextHelper
    {
        public static IConfigurationRoot GetConfiguration(IApiContext apiContext, IBackendPlugin plugin)
        {
            if (apiContext == null)
                return null;

            IConfigurationRoot result = null;

            try
            {
                var svcProvider = apiContext?.ServiceProvider();
                if (svcProvider == null)
                {
                    return ReadFromDatabag(apiContext);
                }

                var cfgGlobalProvider = svcProvider?.GetService<IPluginOrganizationConfigProvider>();

                if (cfgGlobalProvider != null)
                {
                    try
                    {
                        var temp = cfgGlobalProvider.GetOrganizationConfiguration(apiContext);
                        var cfgStr = JsonConvert.DeserializeObject<Dictionary<string, List<PluginConfigSetting>>>(temp);
                        if (cfgStr != null)
                        {
                            result = StringToConfigurationRoot((string)cfgStr["connection"][0].Value);
                        }
                    }
                    catch (Exception)
                    { }
                }

                if (result != null)
                    return result;

                var cfgProvider = apiContext?.ServiceProvider().ConfigProvider();
                result = cfgProvider?.Get<IConfigurationRoot>(apiContext, plugin);

                return result??ReadFromDatabag(apiContext);
            }
            catch (Exception e)
            {
                Trace.TraceError($"Error while read config from apiContext : '{e.Message}'");
            }

            return result;
        }

        public static IConfigurationRoot StringToConfigurationRoot(string cfgStr)
        {
            Func<string, Stream> streamFunc = (string s) =>
            {
                var stream = new MemoryStream();
                var writer = new StreamWriter(stream);

                writer.Write(s);
                writer.Flush();

                stream.Position = 0;
                return stream;
            };

            if (!string.IsNullOrEmpty(cfgStr))
            {
                return new ConfigurationBuilder()
                    .AddJsonStream(streamFunc(cfgStr))
                    .Build();
            }
            else
                return null;
        }

        private static IConfigurationRoot ReadFromDatabag(IApiContext apiContext)
        {
            return apiContext.DataBag.Configuration as IConfigurationRoot;
        }
    }
}
