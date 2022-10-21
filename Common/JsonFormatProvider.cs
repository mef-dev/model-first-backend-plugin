using System;

namespace Bss.Entities
{
    public class JsonFormatProvider : IFormatProvider
    {
        public object GetFormat(Type formatType)
        {
            if (formatType == typeof(ICustomFormatter))
            {
                return new JsonFormatter();
            }
            return null;
        }
    }
}
