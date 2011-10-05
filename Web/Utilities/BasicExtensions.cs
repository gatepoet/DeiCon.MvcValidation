using System;

namespace MvcValidation.Web.Utilities
{
    public static class BasicExtensions
    {
        public static string GetKey(this Type type, string suffix)
        {
            return type.Name.RemoveLast(suffix);
        }
        public static string RemoveLast(this string input, string suffix)
        {
            var suffixIndex = input.LastIndexOf(suffix);
            return input.Remove(suffixIndex);
        }
        public static bool IsNull(this object value)
        {
            return value == null;
        }
        public static bool IsNotNull(this object value)
        {
            return value != null;
        }
        public static string FormatWith(this string text, params object[] args)
        {
            return string.Format(text, args);
        }
    }
}