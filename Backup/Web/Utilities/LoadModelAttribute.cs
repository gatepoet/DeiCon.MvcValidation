using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;

namespace MvcValidation.Web.Utilities
{
    public class LoadModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var modelType = filterContext.ActionParameters["model"].GetType();
            var model = ServiceLocator.Current.GetInstance(modelType);

            filterContext.SetParameter("model", model);        
        }
    }
}