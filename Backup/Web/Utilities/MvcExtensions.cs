using System.Web.Mvc;

namespace MvcValidation.Web.Utilities
{
    public static class MvcExtensions
    {
        public static void SetParameter(this ActionExecutingContext filterContext, string key, object value)
        {
            if (!filterContext.ActionParameters.ContainsKey(key))
                return;

            filterContext.ActionParameters[key] = value;
        }

        public static T As<T>(this object value) where T : class
        {
            return value as T;
        }
    }
}