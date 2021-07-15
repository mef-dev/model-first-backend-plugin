using System.Linq;
using System.Collections.Generic;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public static class IDictionaryExtensions
    {
        public static string WriteConnection(this IDictionary<string, string> connectionStrings)
        {
            string result = null;
            connectionStrings?.TryGetValue("WriteConnection", out result);
            return result;
        }

        public static string ReadConnection(this IDictionary<string, string> connectionStrings)
        {
            string result = null;
            connectionStrings.TryGetValue("ReadConnection", out result);
            return result;

        }

        public static string WriteOrDefaultConnection(this IDictionary<string, string> connectionStrings)
        {
            string result = connectionStrings.WriteConnection();

            if (result == null)
                connectionStrings.TryGetValue("ConnectionString", out result);
            return result;

        }

        public static string ReadOrDefaultConnection(this IDictionary<string, string> connectionStrings)
        {
            string result = connectionStrings.ReadConnection();
            if (result == null)
                connectionStrings.TryGetValue("ConnectionString", out result);
            return result;

        }

        public static string GetConnection(this IDictionary<string, string> connectionStrings)
        {
            string result = null;
            if (connectionStrings.TryGetValue("ConnectionString", out result))
                return result;
            else
            if (connectionStrings.TryGetValue("Default", out result))
                return result;
            else
            if (connectionStrings.Count > 0)
            {
                return connectionStrings[connectionStrings.Keys.FirstOrDefault()];
            }
            else
                return null;
        }
    }
}