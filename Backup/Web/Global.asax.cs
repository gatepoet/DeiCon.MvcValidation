using System.Web;
using MvcValidation.Web.Utilities.Bootstrapper;

namespace MvcValidation.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.Run();
        }
    }
}