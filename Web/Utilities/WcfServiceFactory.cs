using System;
using System.Collections.Generic;
using System.Diagnostics;
using MvcValidation.Web.Services;

namespace MvcValidation.Web.Utilities
{
    public class WcfServiceFactory : IDisposable
    {
        private Dictionary<Type, Object> _services = new Dictionary<Type, object>();

        public T Get<T>() where T : class
        {
            Debug.WriteLine("Starting service {0}.", typeof(T).Name);
            var service = new TestService() as T;
            _services.Add(typeof(T), service);
            return service;

        }
        public void Dispose()
        {
            Dispose(true);
        }

        private void Dispose(bool disposing)
        {
            if (disposing)
                GC.SuppressFinalize(this);

            foreach (var serviceKey in _services.Keys)
            {
                Debug.WriteLine("Closing service {0}.", serviceKey.Name);
                _services[serviceKey] = null;
            }
            _services.Clear();
        }
    }
}
