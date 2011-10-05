using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using StructureMap.Configuration.DSL;
using StructureMap.Interceptors;

namespace MvcValidation.Web.Utilities
{
    public class ControllerFactoryRegistry : Registry
    {
        public ControllerFactoryRegistry()
        {
            ForRequestedType
                <IControllerFactory>()
                .TheDefault.Is.OfConcreteType
                <CommonServiceLocatorControllerFactory>();
        }
    }
}