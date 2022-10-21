using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public class SqlExecParameters
    {
        public int DeadlockRetryCount { get; set; }

        public static SqlExecParameters Default()
        {
            return new SqlExecParameters()
            {
                DeadlockRetryCount = 3
            };
        }
    }
}
