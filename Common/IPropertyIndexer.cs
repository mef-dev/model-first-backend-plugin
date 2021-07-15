using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
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