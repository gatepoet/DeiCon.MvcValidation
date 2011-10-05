using System;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;

namespace MvcValidation.Web.Utilities.State
{
    public class ProcessAttribute : ActionFilterAttribute
    {
        public ProcessAttribute()
        {
            Order = 10;
        }

        private readonly Type _processType;
        private readonly IProcess _process;

        public ProcessAttribute(Type processType)
        {
            _processType = processType;
            _process = ServiceLocator.Current.GetInstance<IProcess>(processType.GetKey("Process"));
        }

        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            var step = _process.CurrentStep.Name;
            if (!_process.IsReadyFor(step))
            {
                filterContext.Result = RedirectTo(_process.CurrentStep);
                filterContext.Result.ExecuteResult(filterContext);
                filterContext.HttpContext.Response.End();
            }
            filterContext.SetParameter("step", _process.CurrentStep);        
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            if (filterContext.Result is EmptyResult)
                filterContext.Result = RedirectTo(_process.CurrentStep);

            if (_process.IsComplete())
                _process.Reset();
        }

        private ActionResult RedirectTo(IProcessStep step)
        {
            return new RedirectToRouteResult(step.RouteValues);
        }
    }
}