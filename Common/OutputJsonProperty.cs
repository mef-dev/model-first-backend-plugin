using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;

namespace Bss.Entities
{
    [AttributeUsage(AttributeTargets.Property,AllowMultiple =false)]
    public class OutputJsonPropertyAttribute  : Attribute
    {
        public string PropertyName { get; set; }
        public NullValueHandling NullValueHandling { get; set; } = NullValueHandling.Ignore;
        public OutputJsonPropertyAttribute(string propertyName)
        {
            PropertyName = propertyName;
        }
    }
}

