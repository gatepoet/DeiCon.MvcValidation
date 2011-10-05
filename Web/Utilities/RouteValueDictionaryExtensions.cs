using System.Web.Routing;

namespace MvcValidation.Web.Utilities
{
    public static class RouteValueDictionaryExtensions
    {
        private static string AsString(this object input)
        {
            return input == null
                ? string.Empty
                : input.ToString();
        }

        public static object InputModel(this RouteData routeData)
        {
            return routeData.Values["inputModel"];
        }
        public static void InputModel(this RouteData routeData, object inputModel)
        {
            routeData.Values["inputModel"] = inputModel;
        }
        public static string Id(this RouteValueDictionary routeValues)
        {
            return routeValues["id"].AsString();
        }
        public static string Action(this RouteValueDictionary routeValues)
        {
            return routeValues["action"].AsString();
        }
        public static string Controller(this RouteValueDictionary routeValues)
        {
            return routeValues["controller"].AsString();
        }
    }
}