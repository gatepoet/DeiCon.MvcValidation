using System;
using System.Web.Mvc;
using System.Web.Routing;
using Microsoft.Practices.ServiceLocation;

namespace MvcValidation.Web.Utilities
{
    public class CommonServiceLocatorControllerFactory : DefaultControllerFactory
    {
        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return (controllerType == null)
                       ? base.GetControllerInstance(requestContext, controllerType)
                       : ServiceLocator.Current.GetInstance(controllerType) as IController;
        }
    }
}