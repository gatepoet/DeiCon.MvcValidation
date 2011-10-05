using System;
using System.Web.Mvc;
using System.Web.Routing;
using MvcContrib.Routing;

namespace MvcValidation.Web.Utilities.Bootstrapper
{
    public class RegisterRoutes : IBootstrapTask
    {
        private readonly RouteCollection _routes;

        public RegisterRoutes() : this(RouteTable.Routes) { }
        private RegisterRoutes(RouteCollection routes)
        {
            _routes = routes;
        }

        public void Execute()
        {
            _routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
            _routes.IgnoreRoute("{*favicon}", new { favicon = @"(.*/)?favicon.ico(/.*)?" });
            _routes.MapRoute(
                "Default", // Route name
                "{controller}/{action}/{id}", // URL with parameters
                new { controller = "Home", action = "Index", id = ""} // Parameter defaults
                );
            //RouteDebugger.RewriteRoutesForTesting(_routes);
        }
    }
}