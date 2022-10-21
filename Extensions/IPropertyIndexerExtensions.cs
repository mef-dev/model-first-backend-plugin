using System;
using System.Diagnostics;

namespace Bss.Entities.Extensions
{
    public static class IPropertyIndexerExtensions
    {
        public static object SafeGet(this IPropertyIndexer propertyIndexer, string index)
        {
            try
            {
                return propertyIndexer[index];
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error '{e.Message}' while try property value for {propertyIndexer}/{index}");
                return null;
            }
        }

        public static T SafeGet<T>(this IPropertyIndexer propertyIndexer, string index) where T : struct
        {
            try
            {
                return (T)propertyIndexer[index];
            }
            catch (Exception e)
            {
                Debug.WriteLine($"Error '{e.Message}' while try property value for {propertyIndexer}/{index}");
                return default(T);
            }
        }
    }
}
