using System;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;

namespace MvcValidation.Web.Utilities.State
{
    public static class ProcessExtensions
    {
        public static bool Matches(this IProcessStep step, Type currentStep)
        {
            return step.GetType().Equals(currentStep);
        }
        public static IProcess GetProcess(this ControllerContext controllerContext, string processName)
        {
            var process = controllerContext.HttpContext.Session[processName] as IProcess;
            if (process.IsNull())
                process = controllerContext.CreateProcess(processName);
            return process;
        }
        private static IProcess CreateProcess(this ControllerContext controllerContext, string name)
        {
            var process = ServiceLocator.Current.GetInstance<IProcess>(name);
            controllerContext.HttpContext.Session[name] = process;
            return process;
        }
    }
}