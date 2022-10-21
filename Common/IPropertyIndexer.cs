using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public interface IPropertyIndexer
    {
        object this[string indexer]
        {
            get;
            set;
        }
    }
}
