using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MvcValidation.Web.Models;

namespace MvcValidation.Web.Utilities
{
    public class LoadViewModelAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            LoadViewModelInto(filterContext);
            //ExecuteResult(filterContext.Controller);
        }

        private void ExecuteResult(ControllerBase controller)
        {
            var result = new ViewResult
                             {
                                 ViewData = controller.ViewData,
                                 TempData = controller.TempData
                             };
            result.ExecuteResult(controller.ControllerContext);
        }

        private static void LoadViewModelInto(ActionExecutingContext filterContext)
        {
            var modelKey = filterContext.ActionDescriptor.ActionName;
            var id = filterContext.RequestContext.RouteData.Values.Id();
            if (string.IsNullOrEmpty(id))
            {
                var model = ServiceLocator.Current.GetInstance<IModel>(modelKey);
                filterContext.Controller.ViewData.Model = model.GetViewModel();
            }
            else
            {
                var model = ServiceLocator.Current.GetInstance<IEditableModel>(modelKey);
                filterContext.Controller.ViewData.Model = model.GetViewModel(id);
            }
        }
    }
}