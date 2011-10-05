using System;
using System.Diagnostics;
using System.Web;
using MvcValidation.Web.Utilities.Bootstrapper;
using StructureMap;

namespace MvcValidation.Web
{
    public class MvcApplication : HttpApplication
    {
        protected void Application_Start()
        {
            Bootstrapper.Run();
        }

        protected void Application_EndRequest(object sender, EventArgs e)
        {
            Debug.Write("Request end (");
            ObjectFactory.ReleaseAndDisposeAllHttpScopedObjects();
            Debug.WriteLine(")");
        }

        protected void Application_Error(object sender, EventArgs e)
        {
            Exception objErr = Server.GetLastError().GetBaseException();
            string err = "Error Caught in Application_Error event\n" +
                    "Error in: " + Request.Url.ToString() +
                    "\nError Message:" + objErr.Message.ToString() +
                    "\nStack Trace:" + objErr.StackTrace.ToString();
            Debug.WriteLine(err);
            Server.ClearError();
            //additional actions...
        } 
    }
}