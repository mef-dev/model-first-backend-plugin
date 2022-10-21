using Newtonsoft.Json;
using System;

namespace Bss.Entities
{
    public class FormattableModel : IFormattable
    {
        protected string _asString = string.Empty;
        public string AsString()
        {
            return _asString;
        }
        public string ToString(string format, IFormatProvider formatProvider)
        {
            IFormatProvider fp = formatProvider;

            if (formatProvider == null)
            {
                switch (format.ToUpperInvariant())
                {
                    case "JSON":
                        fp = new JsonFormatProvider();
                        break;
                    default:
                        //return this.ToString();
                        return null;
                }
            }

            return string.Format(fp, "{0}", this);
        }
    }
}
