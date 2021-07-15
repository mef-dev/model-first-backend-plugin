using System;
using UCP.Common.Plugin;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public class EmptyEntityModel : BaseEntity, IModifiedTag
    {
        public EmptyEntityModel()
        {
            this.Format = null;
            this.Id = null;
            this.Lang = null;
            this.Name = null;
            this.ParentId = null;
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