using MvcValidation.Web.Utilities.Bootstrapper;
using StructureMap.Configuration.DSL;

namespace MvcValidation.Web.Utilities.IoC
{
    public class BootstrapperRegistry : Registry
    {
        public BootstrapperRegistry()
        {
            Scan(s =>
                     {
                         s.TheCallingAssembly();
                         s.AddAllTypesOf<IBootstrapTask>();
                         s.LookForRegistries();
                     });
        }
    }
}