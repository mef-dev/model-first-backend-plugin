using System;

namespace Bss.Entities
{
    public enum PackageMode
    { 
        Production = 1,
        Development = 2,
        Debug = 3
    }

    public static class PackageEnvironment
    {
        public static PackageMode Mode { get; set; } = PackageMode.Production;
        public static Func<ProceduresCollection> ProceduresInitializer { get; set; } = null;
    }
}

