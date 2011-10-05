

using System.Diagnostics;
using MvcValidation.Web.Services;
using StructureMap.Configuration.DSL;

namespace MvcValidation.Web.Utilities
{
    public class ServiceRegistry : Registry
    {
        public ServiceRegistry()
        {
            Scan(
                s =>
                    {
                        s.TheCallingAssembly();
                        s.ExcludeType<ITestService>();
                        s.WithDefaultConventions();
                    });
            For(typeof(ServiceProxy<>)).HttpContextScoped().Use(typeof(ServiceProxy<>));
            For<ITestService>().Use(c =>
                                        {
                                            Debug.WriteLine("Getting service");
                                            return c.GetInstance<ServiceProxy<TestService>>().Service;
                                        });

        }
    }
}