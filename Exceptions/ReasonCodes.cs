using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public enum ReasonCodes
    {
        ServiceAccessError = 0x1,
        UnderConstruction = 0x64,
        PreventiveStop = 0X65
    }
}