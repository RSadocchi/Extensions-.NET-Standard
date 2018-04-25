using System;

namespace Extensions.Enum
{
    [AttributeUsage(AttributeTargets.Enum, AllowMultiple = false, Inherited = false)]
    public class StringValue : Attribute
    {
        public string Value { get; private set; }
        public StringValue(string value)
        {
            Value = value;
        }
    }
}
