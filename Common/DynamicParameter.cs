using System;
using System.Data;
using UCP.Common.Plugin.Attributes;

namespace Natec.Entities
{
    [DocIgnore]
    public class DynamicParameter
    {
        private Func<object> _getter = null;
        private Action<object> _setter = null;
        public string Name { get; set; }
        public object Value
        {
            get
            {
                return _getter();
            }
            set
            {
                _setter(value);
            }
        }
        public DbType DBType { get;set; }
        public ParameterDirection Direction { get; set; }

        public DynamicParameter(Func<object> getter,
            Action<object> setter)
        {
            if (getter == null)
                throw new ArgumentNullException("getter");

            if (setter == null)
                throw new ArgumentNullException("setter");

            _getter = getter;
            _setter = setter;
        }
    }
}