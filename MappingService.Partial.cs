using AutoMapper.Configuration;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using UCP.Common.Plugin;

namespace Bss.Entities
{
    public static partial class MappingService
    {
        public static void ExtendConfiguration(MapperConfigurationExpression cfg)
        {
            Trace.WriteLine("====>ExtendConfiguration");
        }
        public static void ExtendConfigurationWN(MapperConfigurationExpression cfg)
        {
            Trace.WriteLine("====>ExtendConfigurationWN");
        }
    }
}
