using System;
using MvcValidation.Web.Models;
using StructureMap.Attributes;
using StructureMap.Configuration.DSL;

namespace MvcValidation.Web.Utilities.IoC
{
    public class ModelRegistry : Registry
    {
        public ModelRegistry()
        {
            Scan(s =>
                     {
                         s.TheCallingAssembly();
                         s.AddAllTypesOf<IModel>()
                             .NameBy(FormatName);
                         s.AddAllTypesOf<IEditableModel>()
                             .NameBy(FormatName);
                     });
            ForRequestedType<IModel>().CacheBy(InstanceScope.HttpContext);
        }

        private static string FormatName(Type type)
        {
            return type.GetKey("Model");
        }
    }
}