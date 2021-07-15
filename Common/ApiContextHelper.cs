using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;
using UCP.Common.Plugin.Services;

namespace Natec.Entities
{
    [DocIgnore]
    public static class ApiContextHelper
    {
        public static IConfigurationRoot GetConfiguration(IApiContext apiContext, IBackendPlugin plugin)
        {
            IConfigurationRoot result = null;

            try
            {
                var sp = apiContext?.ServiceCollection.ToList();

                var cfgProvider = apiContext?.ServiceProvider().ConfigProvider();

                return cfgProvider.Get<IConfigurationRoot>(apiContext, plugin);
                /*
                var cfgProvider = apiContext?.СontextServiceProvider?.GetService(typeof(IPluginConfigProvider)) as IPluginConfigProvider;
                if (cfgProvider != null)
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
                    var cfgStr = cfgProvider.Get(apiContext, plugin);
                    if (!string.IsNullOrEmpty(cfgStr))
                    {
                        result = new ConfigurationBuilder()
                        .AddJsonStream(streamFunc(cfgStr))
                        .Build();
                    }
                }
                */
            }
            catch (Exception e)
            {
                Trace.TraceError($"Error while read config from apiContext : '{e.Message}'");
            }

            return result;
        }
    }
}