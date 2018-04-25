using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Extensions.Enum
{
    public static class Extensions
    {
        public static string GetStringValue<T>(this T source) where T : struct, IConvertible
        {
            if (!typeof(T).IsEnum) return null;

            Type attr = null;
            StringValue value = (StringValue)Attribute.GetCustomAttribute(attr, typeof(StringValue));
            if (value == null) return null;

            return value.Value;
        }
    }
}
