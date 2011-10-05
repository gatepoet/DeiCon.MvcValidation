using System;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Services.Description;
using Microsoft.Practices.ServiceLocation;
using StructureMap;

namespace MvcValidation.Web.Utilities
{
    public class ServiceProxy<T> : IDisposable where T : class
    {
        public ServiceProxy()
        {
            Service = ServiceLocator.Current.GetInstance<T>();
            Debug.WriteLine("Starting service {0}.".FormatWith(typeof(T).Name));
        }

        public T Service { get; private set; }
        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
                GC.SuppressFinalize(this);

            Debug.WriteLine("Closing service {0}.".FormatWith(typeof(T).Name));
            Service = null;
        }


    }
}