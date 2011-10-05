using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MvcValidation.Web.Models;


namespace MvcValidation.Web.Utilities
{
    public class ValidateViewModelAttribute : ActionFilterAttribute
    {
        private readonly LoadViewModelAttribute _loadViewModelAttribute = new LoadViewModelAttribute();
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if (filterContext.Controller.ViewData.ModelState.IsValid)
            {
                SetModelParameter(filterContext);
                return;
            }

            _loadViewModelAttribute.OnActionExecuting(filterContext);
        }

        private void SetModelParameter(ActionExecutingContext filterContext)
        {
            filterContext.SetParameter("model", GetModel(filterContext));
        }

        private object GetModel(ActionExecutingContext filterContext)
        {
            var modelKey = filterContext.RouteData.Values.Action();
            var id = filterContext.RequestContext.RouteData.Values.Id();
            return string.IsNullOrEmpty(id)
                       ? (object) ServiceLocator.Current.GetInstance<IModel>(modelKey)
                       : (object) ServiceLocator.Current.GetInstance<IEditableModel>(modelKey);
        }
    }
}