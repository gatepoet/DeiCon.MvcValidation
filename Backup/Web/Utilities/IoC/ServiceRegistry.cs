using StructureMap.Configuration.DSL;

namespace MvcValidation.Web.Utilities
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            Scan(s =>
                     {
                         s.TheCallingAssembly();
                         s.WithDefaultConventions();
                     });
        }
    }
}