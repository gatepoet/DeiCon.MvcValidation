using Microsoft.Practices.ServiceLocation;
using MvcValidation.Web.Utilities.IoC;
using StructureMap;
using StructureMap.ServiceLocatorAdapter;

namespace MvcValidation.Web.Utilities.Bootstrapper
{
    public class Bootstrapper
    {
        static Bootstrapper()
        {
            ConfigureContainer();
        }

        public static void Run()
        {
            var tasks = ServiceLocator.Current.GetAllInstances<IBootstrapTask>();

            foreach (var task in tasks)
                task.Execute();
        }

        private static void ConfigureContainer()
        {
            var registry = new BootstrapperRegistry();
            var container = new Container(registry);
            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(container));
        }
    }
}