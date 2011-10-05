using System;
using MvcValidation.Web.Utilities.State;
using StructureMap;
using StructureMap.Attributes;
using StructureMap.Configuration.DSL;
using StructureMap.Pipeline;

namespace MvcValidation.Web.Utilities.IoC
{
    public class ProcessRegistry : Registry
    {
        public ProcessRegistry()
        {
            Scan(s =>
                     {
                         s.TheCallingAssembly();
                         s.AddAllTypesOf<IProcess>()
                             .NameBy(FormatProcessName);
                         s.AddAllTypesOf<IProcessStep>()
                             .NameBy(FormatStepName);
                     });
            For<IProcess>().LifecycleIs(new HybridSessionLifecycle());
        }

        private static string FormatProcessName(Type type)
        {
            return type.GetKey("Process");
        }

        private static string FormatStepName(Type type)
        {
            return type.GetKey("Step");
        }
    }
}