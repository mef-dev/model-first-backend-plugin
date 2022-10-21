using System;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Bss.Entities
{
    [DocIgnore]
    public class EmptyEntityModel : BaseEntity, IModifiedTag, IPropertyIndexer
    {
        public EmptyEntityModel()
        {
            this.Format = null;
            this.Id = null;
            this.Lang = null;
            this.Name = null;
            this.ParentId = null;
        }

        public object this[string indexer] 
        {
            get
            {
                switch (indexer.ToUpper())
                {
                    case "FORMAT": return Format;
                    case "ID": return Id;
                    case "LANG": return Lang;
                    case "NAME":return Name;
                    case "PARENTID":return ParentId;
                    default: return null;
                }
            }
            set
            {
                switch (indexer.ToUpper())
                {
                    case "FORMAT": Format = (string)value;break;
                    case "ID": Id = (string)value; break;
                    case "LANG": Lang = (string)value; break;
                    case "NAME": Name = (string)value; break;
                    case "PARENTID": ParentId = (string)value; break;
                }
            }
        }

        public DateTime? IfModifiedSinceDate
        {
            get
            {
                return null;
            }
        }

        public DateTime? LastModified
        {
            get
            {
                return null;
            }
        }
    }
}
